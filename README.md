SkillSync is a fullstack learning tracker and personal growth app built with modern tech, clean architecture, and a focus on habit + knowledge development. This project uses:

- 🟦 .NET 9 Minimal API
- ⚛️ React 19 with Vite + TypeScript
- 🎨 TailwindCSS + shadcn/ui
- 🔍 TanStack Router + Query
- 🐘 PostgreSQL
- 🐳 Docker + Docker Compose
- 🌍 Deployed to DigitalOcean

---

## 📁 Project Structure

```
skillsync/
├── api/                # .NET 9 backend
│   ├── MyApp.Api/
│   │   ├── Program.cs
│   │   ├── Services/
│   │   ├── Models/
│   │   └── Controllers/
│   └── MyApp.sln
│
├── WebUI/              # React 19 frontend
│   ├── public/
│   ├── src/
│   │   ├── app/       # Root layout, router, providers
│   │   ├── features/  # Goal & log features
│   │   ├── shared/    # Reusable UI, types, hooks
│   │   └── main.tsx
│   └── vite.config.ts
│
├── docker-compose.yml
├── README.md
└── .gitignore

```

---

## ⚙️ Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Node.js](https://nodejs.org/) + [pnpm](https://pnpm.io/)
- [Docker](https://www.docker.com/)
- PostgreSQL

---

## 🛠 Step-by-Step Setup

### 1. 🧱 Clone the repo

```bash
git clone https://github.com/your-username/skillsync.git
cd skillsync

```

### 2. ⚙️ Backend Setup

```bash
cd api
cp appsettings.Development.json.example appsettings.Development.json
dotnet build
dotnet ef database update  # if using EF Core

```

### 3. 🖥️ Frontend Setup

```bash
cd WebUI
pnpm install  # or bun install
pnpm dev      # starts Vite dev server

```

### 4. 🐘 Docker (Dev Mode)

Make sure Docker is running, then:

```bash
docker-compose up --build

```

This will spin up:

- api (.NET)
- WebUI (React)
- db (PostgreSQL)

### 5. 🌍 Visit the App

Frontend: [http://localhost:5173](http://localhost:5173/)

Backend: http://localhost:5000/swagger

---

## ✍️ Scripts Summary

### Backend

```bash
dotnet build
dotnet run

```

### Frontend

```bash
pnpm dev       # Run dev server
pnpm build     # Build frontend
pnpm preview   # Preview production build
pnpm lint      # Lint code
pnpm format    # Format code

```

---

## 🧪 Testing & Linting

- ESLint + Prettier setup in frontend
- Husky with `lint-staged` for pre-commit hooks
- Add unit/integration tests using your preferred tool (xUnit, Vitest, etc.)

---

## 🚢 Deploy to DigitalOcean

1. Create a Droplet (Ubuntu + Docker)
2. Copy `docker-compose.yml` to server
3. Add `.env` and secrets for prod
4. Run:

```bash
docker-compose up -d --build

```

1. (Optional) Set up Caddy or Nginx for HTTPS

---

## 🌱 Environment Variables (suggested)

```
POSTGRES_USER=skillsync
POSTGRES_PASSWORD=supersecure
POSTGRES_DB=skillsync_db
JWT_SECRET=your-secret-key

```

Add these in your `docker-compose.yml` or `.env` file.

---

## ✅ To Do Next

- [ ] Add Swagger docs for all endpoints
- [ ] Polish forms & validations using zod + react-hook-form
- [ ] Build goal timeline view
- [ ] Add category/tag filtering UI
- [ ] Add chart support (e.g., Recharts or Chart.js)

---

## 🤝 Contributing

PRs welcome once it's public! Until then, personal playground and portfolio piece.

---

For more details, check the roadmap in `/docs` or the Notion doc.

Let's build something beautiful. 💡
