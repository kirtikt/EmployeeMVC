# EmployeeMVC

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![oaicite:7](https://img.shields.io/badge/license-MIT-green)](LICENSE)

EmployeeMVC is a full-featured ASP.NET Core MVC web application for managing employee records. It supports complete CRUD operations, utilizes a layered architecture with the Repository Pattern and Dependency Injection, and leverages Entity Framework Core for database interactions. The UI is built with Razor views and styled using Bootstrap for responsive design.

---

## 🧰 Technologies Used

* **Framework**: ASP.NET Core MVC (.NET 8)
* **Language**: C#
* **Architecture**: MVC (Model-View-Controller)
* **ORM**: Entity Framework Core
* **Dependency Injection**: Built-in ASP.NET Core DI
* **Frontend**: Razor Views, Bootstrap
* **Configuration**: appsettings.json
* **Static Files**: Served via wwwroot

---

## 📁 Project Structure

```
EmployeeMVC/
├── Controllers/       // Handles HTTP requests and routing
├── Models/            // Domain models/entities (e.g., Employee)
├── Views/             // Razor (.cshtml) files for UI
├── Migrations/        // Database schema changes via EF Core
├── Repository/        // Data access logic implementing Repository Pattern
├── Service/           // Business logic layer
├── wwwroot/           // Static files (CSS, JS, images)
├── appsettings.json   // Application configuration
├── Program.cs         // Application startup and service configuration
└── EmpMVC.csproj      // Project configuration and dependencies
```



---

## 🚀 Features

* **CRUD Operations**: Create, Read, Update, and Delete employee records.
* **Layered Architecture**: Separation of concerns with Controllers, Services, and Repositories.
* **Entity Framework Core**: Efficient database access and management.
* **Dependency Injection**: Promotes modularity and testability.
* **Form Validation**: Client-side and server-side validation for data integrity.
* **Error Handling**: Robust mechanisms to handle exceptions gracefully.
* **Responsive Design**: Bootstrap integration for mobile-friendly UI.

---

## 🛠️ Getting Started

### Prerequisites

* .NET 8 SDK
* SQL Server (or any compatible database)

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/kirtikt/EmployeeMVC.git
   cd EmployeeMVC
   ```

2. **Configure the database**:

   * Update the `appsettings.json` file with your database connection string.

3. **Apply migrations and update the database**:

   ```bash
   dotnet ef database update
   ```

4. **Run the application**:

   ```bash
   dotnet run
   ```

5. **Access the application**:

   * Navigate to `https://localhost:5001` in your web browser.

---

## 🤝 Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

---

## 🙋‍♂️ Author

* **Name**: Kirtik Tiwari
* **GitHub**: [@kirtikt](https://github.com/kirtikt)

---
