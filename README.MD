# CRUD VB.NET WinForms with Entity Framework (OOP)

A simple desktop CRUD application built with **VB.NET WinForms** using **Entity Framework 6** and structured with clean **Object-Oriented Programming (OOP)** principles.

---

## 🔗 Repository

👉 GitHub: https://github.com/BrokeCoderZ/CRUD-Entitiy-Framework-OOP

---

## 🧰 Tech Stack

* VB.NET (Windows Forms)
* .NET Framework 4.0
* Entity Framework 6 (ORM)
* SQL Server
* OOP (Repository Pattern + Service Layer)

---

## 🚀 Getting Started

### 1. Clone Repository

```bash
git clone https://github.com/BrokeCoderZ/CRUD-Entitiy-Framework-OOP.git
cd CRUD-Entitiy-Framework-OOP
```

---

### 2. Setup Database

Run the following SQL script in SQL Server:

```sql
CREATE DATABASE DbCrudApp;
GO

USE DbCrudApp;
GO

CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Stock INT NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
```

---

### 3. Configure Connection String

Open file:

```
App.config
```

Update:

```xml
<connectionStrings>
  <add name="DbConnection"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=DbCrudApp;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

💡 Alternative for LocalDB:

```
(localdb)\MSSQLLocalDB
```

---

### 4. Restore NuGet Packages

In Visual Studio:

* Right-click Solution
* Click **Restore NuGet Packages**

---

### 5. Run Application

Press:

```
F5
```

---

## ✨ Features

* CRUD (Create, Read, Update, Delete)
* Search products by name
* Input validation
* Clean and maintainable OOP structure
* Entity Framework integration

---

## 🏗️ Architecture Overview

This project follows a layered architecture:

* **Models** → Entity definitions
* **Data** → DbContext configuration
* **Repositories** → Data access layer (DAL)
* **Services** → Business logic layer (BLL)
* **Forms** → Presentation/UI layer

---

## 📌 Notes

* Developed using Visual Studio 2015
* Uses Entity Framework 6.x
* Requires SQL Server (Express edition is sufficient)

---

## 👨‍💻 Author

**PoetralesanA**

---

## 📄 License

This project is open-source and free to use.
