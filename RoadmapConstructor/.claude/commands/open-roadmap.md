---
description: Start the roadmap dev server and open it in the browser. Works on macOS, Linux, and Windows.
---

Start the roadmap dev server on port 8765 and open it in the user's default browser.

## Detect platform first

Determine the OS once at the start:
- macOS / Linux: shell built-ins like `lsof`, `pkill`, `nohup`, `open` (Mac) or `xdg-open` (Linux) are available.
- Windows (Git Bash / WSL / cmd): use `netstat` + `taskkill` for ports/processes and `start ""` (cmd) or `Start-Process` (PowerShell) to open URLs.

Pick the commands below appropriate for the detected platform.

## Steps

1. **Free port 8765 if it's already in use.**
   - macOS / Linux: `lsof -ti:8765 | xargs kill -9 2>/dev/null; true`
   - Windows: find PID via `netstat -ano | findstr :8765` and kill with `taskkill /F /PID <pid>` (skip silently if nothing found).

2. **Start the server in the background.** Use the absolute path to `backend/server.py` in the repo root. Redirect output to a log file in the OS temp dir.
   - macOS / Linux: `nohup python3 backend/server.py 8765 > /tmp/roadmap-server.log 2>&1 & disown`
   - Windows: `start /B python backend\server.py 8765 > %TEMP%\roadmap-server.log 2>&1` (cmd) or `Start-Process python -ArgumentList "backend/server.py","8765" -WindowStyle Hidden -RedirectStandardOutput "$env:TEMP/roadmap-server.log"` (PowerShell).

3. **Verify it responds** (wait briefly, then curl `http://localhost:8765/` and check for HTTP 200). If it doesn't, print the contents of the log file and stop.

4. **Open the URL in the default browser.**
   - macOS: `open http://localhost:8765/`
   - Linux: `xdg-open http://localhost:8765/`
   - Windows: `start "" http://localhost:8765/` (cmd) or `Start-Process http://localhost:8765/` (PowerShell).

5. **Print exactly this** (substitute the platform-appropriate log path):
   ```
   ✓ Roadmap running at http://localhost:8765/
     Stop with: /close-roadmap
     Server log: <log-path>
   ```

Do not investigate the repo. Do not run any other commands. Do not modify any files.
