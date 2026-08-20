---
description: Add a .pptx presentation to a roadmap phase. Use this when the user attaches a .pptx in chat (or gives a file path) and asks to attach it to a phase — e.g. "add this deck to Phase 4", "use this for CI/CD".
---

# Add a presentation to a roadmap phase

Follow these steps in order. Do not improvise.

## 1. Identify the two inputs

You need both:

**a. The source `.pptx` file path.** Look for it in this priority order:
1. The user attached a file in the current message → use that path verbatim.
2. The user pasted a path in their message → use it.
3. Otherwise → ask the user: "Drop the .pptx in chat or paste its path."

If the path doesn't end in `.pptx` (case-insensitive), stop and tell the user it must be a `.pptx`.

**b. The target phase.** Look for it in the same message. Match by:
- Exact phase number ("Phase 4", "phase 5")
- A substring of the phase title (case-insensitive — e.g. "CI/CD", "MCP", "tokens")

If unclear, run:
```bash
grep -n '^## ' storage/content.md
```
…show the result to the user, and ask which phase.

## 2. Compute the phase slug

Read `storage/content.md` and find the matching phase heading. Phase headings look like:

```
## ⚙️ Phase N: Phase Title
```

Compute the slug from `Phase Title` (NOT including the "Phase N:" prefix or the emoji):
- Lowercase
- Replace any run of non-`[a-z0-9]` characters with a single `-`
- Trim leading/trailing `-`

Examples:
- "MCP — Connecting Claude to Your Stack" → `mcp-connecting-claude-to-your-stack`
- "CI/CD Integration" → `ci-cd-integration`
- "Tokens & Cost Awareness" → `tokens-cost-awareness`

Verify by checking the page's `data-pptx-key` for that phase if you're unsure — the slug must match exactly what the frontend expects.

## 3. Copy the file into the right folder

```bash
SLUG="<slug-from-step-2>"
mkdir -p "storage/presentations/$SLUG"
cp "<source-pptx-path>" "storage/presentations/$SLUG/$SLUG.pptx"
```

These commands work in bash on macOS / Linux and in **Git Bash on Windows**. If you're on Windows and `bash` isn't available, use the PowerShell equivalent (`New-Item -ItemType Directory -Force` then `Copy-Item`).

## 4. Render slides

```bash
./backend/rebuild.sh "$SLUG"
```

This takes 10-30 seconds for typical decks. Use a longer timeout (180+ seconds) when running it.

On Windows, run this from **Git Bash** (the `.sh` script needs a bash shell). It auto-detects LibreOffice on macOS / Linux / Windows / WSL — no SOFFICE env var needed in typical installs.

If the script fails (e.g. LibreOffice not installed), surface the error and stop. Don't try to install dependencies yourself; point the user at the Requirements section of the README.

## 5. Confirm and report

Read the slide count:
```bash
cat "storage/presentations/$SLUG/manifest.json"
```

Then print exactly:

```
✓ Added presentation to <Phase N>: <Phase Title>
  Slides: <N> rendered to storage/presentations/<slug>/
  Reload the browser to see it.
```

## Constraints

- Do NOT modify `frontend/index.html` or `storage/content.md`. The frontend already auto-wires every phase to a slug-derived key.
- Do NOT commit anything. The user will commit when they're ready.
- Do NOT investigate the rest of the repo. Stay focused on this task.
- If anything outside steps 1-5 is needed, stop and ask the user.
