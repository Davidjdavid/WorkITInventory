[WorkITInventory-README.md](https://github.com/user-attachments/files/30318315/WorkITInventory-README.md)
# WorkITInventory

A desktop inventory management application built in C# (WinForms) for tracking IT equipment stored in "OSR", the equipment storage room for a student IT job at Kansas State University Residential Networking.

## What it does

- Provides a GUI (`formInv.cs` / `formInv.Designer.cs`) for checking equipment in and out of storage
- Uses Entity Framework (`Model1.cs`, `Model1.Context.cs`, and their `.tt` templates) to read and write inventory records to a database
- Runs as a standard .NET WinForms app via `Program.cs`

## Project structure

| File/Folder | Purpose |
|---|---|
| `Program.cs` | Application entry point |
| `formInv.cs` / `formInv.Designer.cs` / `formInv.resx` | Main inventory GUI form |
| `Model1.cs` / `Model1.Context.cs` | Entity Framework data model and DB context |
| `Model1.tt` / `Model1.Context.tt` | EF T4 templates used to generate the model/context code |
| `App.config` | Application configuration (including DB connection string) |
| `OSR Inventory.sln` / `OSR Inventory.csproj` | Visual Studio solution and project files |
| `packages.config` / `packages/` | NuGet package references (includes Entity Framework) |

## Requirements

- Windows with .NET Framework (WinForms) support
- Visual Studio (recommended for building/running)
- A SQL database matching the Entity Framework model, connection string configured in `App.config`

## Setup

1. Clone the repo and open `OSR Inventory.sln` in Visual Studio.
2. Restore NuGet packages (Entity Framework, etc. — see `packages.config`).
3. Update the connection string in `App.config` to point to your database.
4. Build and run.

## Notes

- "OSR" refers to the physical room where the IT equipment is stored — the app's checkout/check-in workflow is built around that inventory.
- Built as an internal tool for a specific job; database schema and connection details aren't included and will need to be set up separately.
