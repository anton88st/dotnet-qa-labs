#!/bin/bash
# Render every .pptx in storage/presentations/<key>/<key>.pptx into per-slide
# PNGs alongside the source file, plus a manifest.json with the slide count.
#
# Conventions:
#   storage/presentations/<key>/<key>.pptx
#     → storage/presentations/<key>/slide-01.png … slide-NN.png
#     → storage/presentations/<key>/manifest.json
#
# Usage (paths are resolved relative to this script's repo root):
#   ./backend/rebuild.sh                 # rebuild every deck
#   ./backend/rebuild.sh jira-github     # rebuild one deck by key

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"
cd "$REPO_ROOT"

DPI="${DPI:-150}"
PRESENTATIONS_DIR="storage/presentations"

# Locate LibreOffice. Honour $SOFFICE if set, otherwise probe known install
# locations on macOS, Linux, and Windows (Git Bash / WSL).
find_soffice() {
  if [[ -n "${SOFFICE:-}" && -x "$SOFFICE" ]]; then echo "$SOFFICE"; return; fi
  local candidates=(
    "/Applications/LibreOffice.app/Contents/MacOS/soffice"   # macOS
    "/usr/bin/soffice"                                        # Linux
    "/usr/bin/libreoffice"
    "/c/Program Files/LibreOffice/program/soffice.exe"        # Git Bash on Windows
    "/c/Program Files/LibreOffice/program/soffice.com"
    "/mnt/c/Program Files/LibreOffice/program/soffice.exe"    # WSL
  )
  for c in "${candidates[@]}"; do
    if [[ -x "$c" ]]; then echo "$c"; return; fi
  done
  if command -v soffice >/dev/null 2>&1; then command -v soffice; return; fi
  if command -v libreoffice >/dev/null 2>&1; then command -v libreoffice; return; fi
  echo ""
}

SOFFICE="$(find_soffice)"
if [[ -z "$SOFFICE" ]]; then
  echo "LibreOffice not found. Install it:" >&2
  echo "  macOS:    brew install --cask libreoffice" >&2
  echo "  Windows:  winget install TheDocumentFoundation.LibreOffice" >&2
  echo "  Linux:    sudo apt install libreoffice  (or your distro's equivalent)" >&2
  echo "Or set the SOFFICE environment variable to the soffice binary path." >&2
  exit 1
fi
if ! command -v pdftoppm >/dev/null 2>&1; then
  echo "pdftoppm not found (part of poppler). Install it:" >&2
  echo "  macOS:    brew install poppler" >&2
  echo "  Windows:  scoop install poppler   OR   choco install poppler" >&2
  echo "  Linux:    sudo apt install poppler-utils" >&2
  exit 1
fi

build_one() {
  local key="$1"
  local dir="$PRESENTATIONS_DIR/$key"
  local pptx="$dir/$key.pptx"
  local tmp
  tmp="$(mktemp -d)"

  if [[ ! -f "$pptx" ]]; then
    echo "✗ $pptx not found, skipping" >&2
    return 1
  fi

  echo "▶ Building $key …"
  "$SOFFICE" --headless --convert-to pdf --outdir "$tmp" "$pptx" >/dev/null
  local pdf="$tmp/$key.pdf"

  # Wipe old slide-*.png but keep the .pptx
  find "$dir" -maxdepth 1 -name 'slide-*.png' -delete 2>/dev/null || true
  pdftoppm -r "$DPI" -png "$pdf" "$dir/slide" >/dev/null

  # pdftoppm uses no zero-padding for <10 slides — normalize to slide-NN.png
  local count=0
  for f in "$dir"/slide-*.png; do
    count=$((count+1))
  done
  if (( count > 0 )); then
    local first
    first="$(ls "$dir"/slide-*.png | head -1)"
    local digits
    digits="$(basename "$first" .png | sed 's/slide-//' | awk '{print length($0)}')"
    if (( digits == 1 )); then
      for f in "$dir"/slide-*.png; do
        local n
        n="$(basename "$f" .png | sed 's/slide-//')"
        printf -v padded "%02d" "$n"
        mv "$f" "$dir/slide-$padded.png"
      done
    fi
  fi

  printf '{"slides": %d}\n' "$count" > "$dir/manifest.json"
  rm -rf "$tmp"
  echo "  ✓ $count slides → $dir/"
}

if [[ $# -gt 0 ]]; then
  for key in "$@"; do
    build_one "$key"
  done
else
  shopt -s nullglob
  any=0
  for dir in "$PRESENTATIONS_DIR"/*/; do
    key="$(basename "$dir")"
    if [[ -f "$dir$key.pptx" ]]; then
      any=1
      build_one "$key"
    fi
  done
  if (( any == 0 )); then
    echo "No .pptx files found under $PRESENTATIONS_DIR/*/" >&2
    exit 1
  fi
fi

echo "Done."
