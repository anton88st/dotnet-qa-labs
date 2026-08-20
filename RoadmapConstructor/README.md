# Roadmap Constructor

Interactive roadmap + slide decks.

A single-page roadmap of phases (Installation, Models, Tokens, MCP, …). Every phase can host a slide deck rendered from a real `.pptx`. The page renders from `storage/content.md`, so editing the markdown *or* using the in-browser editor both update the same source of truth.

---

## Requirements

What you need depends on what you want to do:

| Role | Python 3 | LibreOffice + poppler | Git Bash (Windows only) |
|---|---|---|---|
| **View** the roadmap | ✓ | — | — |
| **Edit** text (phases, cards, bullets) | ✓ | — | — |
| **Add / replace / remove decks** (`.pptx`) | ✓ | ✓ | ✓ (for `rebuild.sh`) |

### macOS

```bash
# Python comes preinstalled. If you don't have it: brew install python
brew install --cask libreoffice      # ~700 MB — only needed for deck rendering
brew install poppler                 # gives you pdftoppm
```

### Windows

Using **winget** (built into Windows 10/11):

```cmd
winget install Python.Python.3.12
winget install TheDocumentFoundation.LibreOffice
winget install Git.Git
```

The last one is for **Git Bash**, which gives you the bash shell needed to run `backend/rebuild.sh`. Without it, PowerShell/cmd can't execute the script.

For **poppler** (the `pdftoppm` tool), use Scoop or Chocolatey:

```cmd
:: Scoop (recommended — no admin needed)
scoop install poppler

:: OR Chocolatey (needs admin)
choco install poppler
```

If you don't have Scoop yet, install it once:
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
irm get.scoop.sh | iex
```

After installing, open **Git Bash** (right-click in the repo folder → "Open Git Bash here") to run scripts like `./backend/rebuild.sh`. Python and the dev server (`backend/server.py`) work in plain PowerShell or cmd too.

### Linux

```bash
sudo apt install python3 libreoffice poppler-utils    # Debian / Ubuntu
sudo dnf install python3 libreoffice poppler-utils    # Fedora
```

### Already installed somewhere unusual?

Set `SOFFICE` to the path of your `soffice` binary before running `rebuild.sh`:

```bash
SOFFICE="C:/Apps/LibreOffice/program/soffice.exe" ./backend/rebuild.sh
```

`rebuild.sh` auto-probes the standard install locations on all three OSes, so you usually won't need this.

---

## Quick start (just want to view it)

**macOS / Linux:**
```bash
cd RoadmapConstructor
python3 backend/server.py
# then open http://localhost:8765/
```

**Windows (cmd or PowerShell):**
```cmd
cd RoadmapConstructor
python backend\server.py
:: then open http://localhost:8765/
```

No build needed for viewing — slide PNGs are committed.

If you have **Claude Code** installed and open this repo there, even simpler — type `/open-roadmap` and it does the above for you (cross-platform; works on Mac, Windows, Linux):

```
/open-roadmap     ← starts the server and opens the URL
/close-roadmap    ← stops it and frees the port
```

---

## Editing the roadmap (phases, cards, bullets)

Two equivalent ways. Both write `storage/content.md`.

### A. In the browser (point-and-click)

1. Click **Edit** in the top-right corner.
2. The page switches to edit mode:
   - Click any phase title, card title, or bullet → type to change it.
   - **+ Add card** at the bottom of each phase → appends a new card.
   - **+ Add phase** at the end of the timeline → appends a new phase.
   - **×** on a phase or card → removes it (no confirm dialog).
   - **⋮⋮** on a card (top-left) → drag to reorder within its phase.
   - Drag a phase by its connector icon (the round emoji on the left) → reorder phases.
3. Click **Save** in the top-right → server rewrites `storage/content.md` → page returns to view mode.

Phase numbers (`Phase 1`, `Phase 2`, …) renumber automatically after any add/remove/reorder.

### B. In your text editor (Markdown)

Open `storage/content.md`. The format is:

```markdown
# 🤖 Page title

## 🚀 Phase 1: Phase Title
### 📄 Card Title
- Bullet
- Another bullet

## ⚙️ Phase 2: Another Phase
### 🧰 Card title
- bullet
```

- `## …` = phase (the emoji is optional; the order in the file controls the order on the page).
- `### …` = card inside the previous phase.
- `- …` = bullet inside the previous card.

Save the file → reload your browser tab → done.

---

## Managing presentations (`.pptx` decks)

Each phase can have a slide deck. It lives at `storage/presentations/<slug>/`, where `<slug>` is the phase title slugified — for example:

| Phase title | Slug |
|---|---|
| `Installation & Setup` | `installation-setup` |
| `MCP — Connecting Claude to Your Stack` | `mcp-connecting-claude-to-your-stack` |
| `CI/CD Integration` | `ci-cd-integration` |

A phase folder contains:
```
storage/presentations/<slug>/
├── <slug>.pptx         # source — gitignored (too big for GitHub)
├── slide-01.png … slide-NN.png    # rendered — committed
└── manifest.json       # { "slides": N }
```

### Three ways to add (or replace) a deck

Pick whichever fits the moment — they all end at the same files on disk.

#### 1. In the browser (Upload button)

1. Click **Edit**.
2. On the target phase, click the green **📎 Upload** button.
3. Pick the `.pptx`. Server saves it, runs LibreOffice + `pdftoppm`, returns ~10-30 s later with rendered PNGs.
4. The inline viewer refreshes.

#### 2. In Claude Code (drop file in chat)

Open a session in the repo. Drag the `.pptx` into the chat and say something like:

> "add this to Phase 4"
> "use this for the CI/CD phase"

…or invoke the command explicitly: `/add-presentation`. Claude follows the spec in `.claude/commands/add-presentation.md` — figures out the slug from `content.md`, copies the file, runs `./backend/rebuild.sh <slug>`, reports the slide count.

#### 3. Manually in a terminal

```bash
SLUG=<phase-title-slug>
mkdir -p "storage/presentations/$SLUG"
cp /path/to/your.pptx "storage/presentations/$SLUG/$SLUG.pptx"
./backend/rebuild.sh "$SLUG"
```

### Removing a deck

- **In the browser:** Edit mode → click the red **🗑️ Remove deck** on the phase.
- **Manually:** `rm -rf storage/presentations/<slug>/`. The page handles this gracefully — clicking Presentation just shows "Slides not built yet".

### Replacing a deck

Just upload a new `.pptx` to the same phase — it overwrites the existing one and re-renders.

### What needs to be installed for deck rendering

Methods 1 and 2 run `rebuild.sh` under the hood, which needs **LibreOffice** + **poppler** (`pdftoppm`). See the [Requirements](#requirements) section above for install commands on macOS, Windows, and Linux.

LibreOffice runs headless — no app icon, no menu bar entry, no UI window. Just a binary the build script invokes. If you're only **viewing** the roadmap (not adding decks), you don't need it.

### Why `.pptx` files aren't in git

`storage/presentations/**/*.pptx` is `.gitignore`'d. **GitHub rejects any file over 100 MB** in regular git, and presentation files routinely cross that line because of embedded screenshots / images / video.

What's committed: the rendered **PNGs + `manifest.json`** for every deck. That's all the page needs to *display* a presentation — teammates can clone and view without ever touching a `.pptx`.

If you actually need to share the source `.pptx` with other maintainers, you have three options:

| Option | When it fits | Cost |
|---|---|---|
| **Git LFS** | Multiple maintainers will edit the same deck; you want full version history. | One-time setup (`brew install git-lfs` then `git lfs track "*.pptx"`). Teammates need `git-lfs` installed too. Free tier: 1 GB storage + 1 GB bandwidth / month. |
| **Compress the .pptx first** | Source images are oversized retina screenshots and shrinking them to ~1600 px is acceptable. | A short Python script (Pillow) downsamples images and re-zips — typically drops a 100 MB deck to 10-15 MB with no visible loss at display size. |
| **Shared drive** (Google Drive / OneDrive / SharePoint) | You just want one place to hand the file off — no version history needed. | Zero setup; out of band from git. |

Default for this repo is **option 3** — share the `.pptx` out of band, commit only the PNGs. Swap in LFS later if the editorial workload grows.

---

## Claude Code: commands and skills

The repo ships three slash commands in `.claude/commands/`. They auto-load whenever you open Claude Code rooted in this project.

| Command | What it does | When to use |
|---|---|---|
| `/open-roadmap` | Starts `backend/server.py`, opens `http://localhost:8765/` in your default browser. | Start of a session. |
| `/close-roadmap` | Stops the server, frees port 8765. | End of a session. |
| `/add-presentation` | Copies a `.pptx` into the right slot + renders slides. | Quickest way to add a deck without leaving the editor. |

You don't have to type the slash command literally — Claude Code reads each command's description and will route a natural-language request to the right one. For example:

> "open the roadmap" → triggers `/open-roadmap`
> "add this deck for the security phase" → triggers `/add-presentation`

Typing the slash version is faster and more explicit; describing the intent is more conversational. Both work.

These only load if Claude Code is opened from inside the repo (project-level slash commands are scoped to the project's working directory). If you start Claude Code somewhere else, the commands won't appear in `/` autocomplete.

---

## Repo layout

```
.
├── frontend/
│   └── index.html              # the whole page — HTML/CSS/JS in a single file
├── backend/
│   ├── server.py               # localhost-only dev server + API endpoints
│   └── rebuild.sh              # pptx → PDF → per-slide PNGs (LibreOffice + poppler)
├── storage/
│   ├── content.md              # phases / cards / bullets (source of truth)
│   └── presentations/          # one folder per deck, keyed by phase-title slug
│       └── <slug>/
│           ├── <slug>.pptx           # gitignored
│           ├── slide-01.png … slide-NN.png  # committed
│           └── manifest.json
├── .claude/
│   └── commands/               # slash commands shipped with the repo
├── README.md
└── .gitignore
```

## Server endpoints (reference)

`backend/server.py` binds to `127.0.0.1` only — safe on coffee-shop WiFi. The endpoints are:

| Method | Path | Body | Effect |
|---|---|---|---|
| GET | `/` | — | serves `frontend/index.html` |
| GET | `/<path>` | — | static asset under `frontend/` |
| GET | `/storage/<path>` | — | static asset under `storage/` (slides, `content.md`) |
| POST | `/_save-content` | markdown | overwrites `storage/content.md` |
| POST | `/_upload-pptx?key=<slug>` | `.pptx` bytes | saves file + invokes `rebuild.sh <slug>` |
| POST | `/_delete-pptx?key=<slug>` | — | removes `storage/presentations/<slug>/` (idempotent) |

## Failure modes that don't crash

- **Folder deleted manually** (`rm -rf storage/presentations/<slug>/`) → page shows "Slides not built yet" when you click Presentation. No errors.
- **Single PNG missing** → other slides render normally; the missing one shows an inline ⚠️ "Slide N is missing on disk" message.
- **Calling delete on a missing folder** → 200, `{ok:true, removed:false}`. Idempotent.
- **Two browser tabs open during an edit** → last Save wins; there's no merge.
- **`server.py` not running** → in-browser Save shows "Save endpoint missing — run python3 backend/server.py". Open the page via `file://` similarly fails with a clear message instead of a blank screen.

## Implementation notes (curious only)

- **Single source of truth: `storage/content.md`.** The frontend fetches it on load, parses with a small inline parser (no external markdown library), and renders the timeline from the parsed data. The in-browser editor serializes the DOM back to markdown when you Save.
- **Slide viewer**: per-phase inline viewer (no popup). Slides are pre-rendered PNGs from LibreOffice → not PPTXjs, so fidelity matches PowerPoint exactly. Fullscreen via the **F** key.
- **Drag & drop**: SortableJS via CDN, only active in edit mode. Disabled in view mode so cards stay clickable.
- **localStorage**: in-progress edits are mirrored to `localStorage` so closing the tab mid-edit doesn't lose work. Cleared on every successful Save.
- **Phase numbering**: auto-managed (`Phase 1`, `Phase 2`, …). Don't try to edit the number itself — edit the title.
- **Phase slug → deck folder**: derived from the title every page load. If you rename a phase, either rename the folder to match, or upload again via 📎 (which writes to the current slug).
