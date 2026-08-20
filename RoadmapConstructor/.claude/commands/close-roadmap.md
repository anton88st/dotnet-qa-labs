---
description: Stop the roadmap dev server and free port 8765. Works on macOS, Linux, and Windows.
---

Stop the roadmap dev server and free port 8765.

## Detect platform first

- macOS / Linux: use `pkill` + `lsof`.
- Windows: use `tasklist` + `taskkill` + `netstat`.

## Steps

1. **Kill any `backend/server.py` process.**
   - macOS / Linux: `pkill -f 'backend/server.py' 2>/dev/null; true`
   - Windows (cmd): `for /f "tokens=2" %p in ('tasklist /v /fi "imagename eq python.exe" /fo csv ^| findstr server.py') do taskkill /F /PID %p` — or use PowerShell: `Get-CimInstance Win32_Process -Filter "name='python.exe'" | Where-Object { $_.CommandLine -like '*server.py*' } | ForEach-Object { Stop-Process -Id $_.ProcessId -Force }`.

2. **Belt-and-suspenders: kill anything still bound to port 8765.**
   - macOS / Linux: `lsof -ti:8765 | xargs kill -9 2>/dev/null; true`
   - Windows: find PID via `netstat -ano | findstr :8765` then `taskkill /F /PID <pid>`.

3. **Wait briefly, then confirm the port is free.**

4. **Print exactly one of these:**
   - If port free: `✓ Roadmap stopped — port 8765 free.`
   - If still busy: `⚠️ Port 8765 still busy. Investigate manually.`

Do not investigate the repo. Do not run any other commands. Do not modify any files.
