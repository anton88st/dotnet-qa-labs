#!/usr/bin/env python3
"""
Dev server for the AQA roadmap.

Project layout (relative to repo root):

    frontend/        — static page assets (index.html lives here)
    backend/         — this server + rebuild script
    storage/         — content + per-presentation folders (slides, manifests, .pptx)

The server:
    GET  /                                         → frontend/index.html
    GET  /<path>                                   → frontend/<path>     (CSS, JS, images)
    GET  /storage/<path>                           → storage/<path>      (slides, content.md)
    POST /_save-content   body = markdown          → overwrites storage/content.md
    POST /_upload-pptx?key=<key>  body = .pptx     → saves + runs backend/rebuild.sh <key>
    POST /_delete-pptx?key=<key>                   → removes storage/presentations/<key>/

Only accepts connections from localhost so it's safe to leave running on a
laptop, even on a coffee-shop wifi.

Usage:
    python3 backend/server.py            # listens on 8765
    python3 backend/server.py 9000       # custom port
"""

from __future__ import annotations

import json
import re
import shutil
import subprocess
import sys
from http.server import HTTPServer, SimpleHTTPRequestHandler
from pathlib import Path
from socketserver import ThreadingMixIn
from urllib.parse import urlsplit, unquote, parse_qs

REPO = Path(__file__).resolve().parent.parent
FRONTEND = REPO / "frontend"
STORAGE = REPO / "storage"
INDEX = FRONTEND / "index.html"
CONTENT_MD = STORAGE / "content.md"


class Handler(SimpleHTTPRequestHandler):
    # Quieter default logging
    def log_message(self, fmt, *args):
        sys.stderr.write("%s - %s\n" % (self.address_string(), fmt % args))

    def end_headers(self):
        # Dev server — disable cache so every reload is fresh
        self.send_header("Cache-Control", "no-store")
        super().end_headers()

    def translate_path(self, path: str) -> str:
        # Strip query / fragment, decode percent-escapes
        parsed = urlsplit(path)
        clean = unquote(parsed.path)
        # Block parent-directory escapes
        if ".." in clean.split("/"):
            return str(FRONTEND)
        if clean.startswith("/storage/"):
            return str(STORAGE / clean[len("/storage/"):].lstrip("/"))
        if clean in ("", "/"):
            return str(INDEX)
        return str(FRONTEND / clean.lstrip("/"))

    def do_POST(self):
        parsed = urlsplit(self.path)
        if parsed.path == "/_save-content":
            self._write_body(CONTENT_MD)
            return
        if parsed.path == "/_upload-pptx":
            self._handle_upload_pptx(parsed.query)
            return
        if parsed.path == "/_delete-pptx":
            self._handle_delete_pptx(parsed.query)
            return
        self.send_error(404, "Unknown endpoint")

    def _handle_upload_pptx(self, query: str):
        qs = parse_qs(query)
        key = (qs.get("key", [""])[0] or "").strip().lower()
        if not key or not re.match(r"^[a-z0-9][a-z0-9_-]*$", key):
            self.send_error(400, "Missing or invalid ?key= (lowercase alphanumeric / hyphens / underscores)")
            return
        length = int(self.headers.get("Content-Length") or 0)
        if length <= 0:
            self.send_error(400, "Empty body")
            return
        # Stream the upload directly to disk so we don't load 100MB into RAM.
        target_dir = STORAGE / "presentations" / key
        target_dir.mkdir(parents=True, exist_ok=True)
        target_pptx = target_dir / f"{key}.pptx"
        tmp = target_pptx.with_suffix(".pptx.tmp")
        with tmp.open("wb") as f:
            remaining = length
            while remaining > 0:
                chunk = self.rfile.read(min(1 << 16, remaining))
                if not chunk:
                    break
                f.write(chunk)
                remaining -= len(chunk)
        tmp.replace(target_pptx)

        # Run the build script for this key. Blocks until LibreOffice + pdftoppm finish.
        script = REPO / "backend" / "rebuild.sh"
        try:
            proc = subprocess.run(
                [str(script), key],
                cwd=str(REPO),
                capture_output=True,
                text=True,
                timeout=300,
            )
        except subprocess.TimeoutExpired:
            self._json_error(504, "Rebuild timed out after 5 min")
            return
        if proc.returncode != 0:
            err = (proc.stderr or proc.stdout or "rebuild failed").strip().splitlines()
            self._json_error(500, "Rebuild failed: " + (err[-1] if err else "unknown"))
            return

        # Read slide count from manifest
        slides = 0
        try:
            manifest = json.loads((target_dir / "manifest.json").read_text())
            slides = int(manifest.get("slides", 0))
        except Exception:
            pass

        payload = json.dumps({"ok": True, "key": key, "slides": slides}).encode()
        self.send_response(200)
        self.send_header("Content-Type", "application/json")
        self.send_header("Content-Length", str(len(payload)))
        self.end_headers()
        self.wfile.write(payload)

    def _handle_delete_pptx(self, query: str):
        qs = parse_qs(query)
        key = (qs.get("key", [""])[0] or "").strip().lower()
        if not key or not re.match(r"^[a-z0-9][a-z0-9_-]*$", key):
            self._json_error(400, "Missing or invalid ?key=")
            return
        target_dir = STORAGE / "presentations" / key
        existed = target_dir.exists()
        if existed:
            try:
                shutil.rmtree(target_dir)
            except OSError as e:
                self._json_error(500, f"Could not remove: {e}")
                return
        payload = json.dumps({"ok": True, "key": key, "removed": existed}).encode()
        self.send_response(200)
        self.send_header("Content-Type", "application/json")
        self.send_header("Content-Length", str(len(payload)))
        self.end_headers()
        self.wfile.write(payload)

    def _json_error(self, code: int, msg: str):
        payload = json.dumps({"ok": False, "error": msg}).encode()
        self.send_response(code)
        self.send_header("Content-Type", "application/json")
        self.send_header("Content-Length", str(len(payload)))
        self.end_headers()
        self.wfile.write(payload)

    def _write_body(self, target: Path):
        length = int(self.headers.get("Content-Length") or 0)
        if length <= 0:
            self.send_error(400, "Empty body")
            return
        try:
            body = self.rfile.read(length).decode("utf-8")
        except UnicodeDecodeError:
            self.send_error(400, "Body must be UTF-8")
            return
        target.parent.mkdir(parents=True, exist_ok=True)
        tmp = target.with_suffix(target.suffix + ".tmp")
        tmp.write_text(body, encoding="utf-8")
        tmp.replace(target)
        self.send_response(200)
        self.send_header("Content-Type", "application/json")
        self.end_headers()
        self.wfile.write(b'{"ok":true}')


class LocalOnlyServer(ThreadingMixIn, HTTPServer):
    daemon_threads = True
    allow_reuse_address = True

    def verify_request(self, request, client_address):
        return client_address[0] in ("127.0.0.1", "::1")


def main() -> int:
    port = int(sys.argv[1]) if len(sys.argv) > 1 else 8765
    addr = ("127.0.0.1", port)
    print(f"Repo:     {REPO}")
    print(f"Frontend: {FRONTEND}  →  served at /")
    print(f"Storage:  {STORAGE}   →  served at /storage")
    print(f"Listening on http://localhost:{port}  (Ctrl-C to stop)")
    try:
        LocalOnlyServer(addr, Handler).serve_forever()
    except KeyboardInterrupt:
        print("\nStopped.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
