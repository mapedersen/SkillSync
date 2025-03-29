This is the **React 19 + Vite** frontend for SkillSync — a skill tracking and personal development platform.
It is built with a modern, scalable architecture and best practices for DX, styling, and state management.

---

## 🧠 Description

The WebUI allows users to:

- Sign up and log in
- Create and view learning goals
- Log skill sessions under each goal
- View logs as a timeline or list
- Get a fast, responsive, modern UI using Tailwind and shadcn

This frontend is tightly integrated with a .NET 9 backend via a typed API layer and uses TanStack Query for server state.

---

## 🏗️ Folder Structure

```
WebUI/
├── public/                  # Static files
├── src/
│   ├── app/                # App root, providers, router
│   ├── features/           # Goal and log feature folders
│   ├── shared/             # Shared UI components, hooks, types, utils
│   ├── main.tsx            # Vite entry
│   └── index.css           # Tailwind base
├── .eslintrc.cjs
├── .prettierrc
├── .editorconfig
├── tailwind.config.ts
├── tsconfig.json
└── vite.config.ts

```

---

## 📦 Installed Packages & Tooling

### 🖥️ Core

- `react@19`
- `react-dom@19`
- `typescript`
- `vite`

### 🧪 State & Data

- `@tanstack/react-query` – For async data/state management
- `@tanstack/react-router` – For routing with file-based feel
- `zod` – Schema validation
- `react-hook-form` – Forms with validation

### 🎨 Styling

- `tailwindcss` – Utility-first CSS
- `shadcn/ui` – Headless + Tailwind components
- `clsx` – Conditional className merging

### ⚙️ Developer Experience

- `eslint` + `eslint-config-airbnb-typescript`
- `prettier`
- `.editorconfig`
- `husky` – Git hooks
- `lint-staged` – Pre-commit lint/format
- `@types/*` – Type definitions for all libs

### 📊 (Optional/Future)

- `recharts` or `chart.js` – For visualizing activity
- `react-hot-toast` – Toast messages
- `framer-motion` – Animations

---

## 🔧 Scripts

```bash
pnpm dev       # Start dev server (Vite)
pnpm build     # Production build
pnpm preview   # Preview prod build
pnpm lint      # Run eslint
pnpm format    # Run prettier

```

---

## 🛡️ Git & Formatting Setup

- Pre-commit formatting via `husky` + `lint-staged`
- Auto-lints + prettifies files on commit
- Enforced code style in team environments

---

## ✅ Features Checklist (MVP Phase)

- [ ] Login form with auth logic
- [ ] Create goal form + validation
- [ ] List goals with click-to-view
- [ ] Log session form (modal)
- [ ] View logs for a selected goal
- [ ] Handle loading/error states

---

## 🧩 Integration Notes

- API base URL is configured per environment
- Uses Axios or fetch + typed response handling (WIP)
- Shared types will later be generated from .NET DTOs

---

## 🧪 Testing Ideas

- `vitest` for unit tests
- `cypress` or `playwright` for E2E

---
