# CRUD VB.NET WinForms with Entity Framework (OOP)

A simple CRUD desktop application built using:

* VB.NET (Windows Forms)
* .NET Framework 4.0
* Entity Framework 6 (ORM)
* SQL Server
* Clean Architecture (OOP: Repository + Service Layer)

---

## 📦 Repository

Source code available at:
https://gitlab.com/PoetralesanA/crudentitiyframework-oop

---

## 🚀 How to Run

### 1. Clone Repository

```bash
git clone https://gitlab.com/PoetralesanA/crudentitiyframework-oop.git
```

---

### 2. Setup Database

Open SQL Server and execute this script:

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

Open:

```
App.config
```

Update this section according to your SQL Server:

```xml
<connectionStrings>
  <add name="DbConnection"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=DbCrudApp;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

💡 If `SQLEXPRESS` doesn't work, try:

```
(localdb)\MSSQLLocalDB
```

---

### 4. Restore NuGet Packages

In Visual Studio:

* Right click Solution
* Click **Restore NuGet Packages**

---

### 5. Run Application

Press:

```
F5
```

---

## ✨ Features

* Create, Read, Update, Delete (CRUD)
* Search by product name
* Input validation
* Clean OOP structure
* Entity Framework integration

---

## 🏗️ Architecture

This project uses a simple layered architecture:

* **Models** → Entity classes
* **Data** → DbContext
* **Repositories** → Data access abstraction
* **Services** → Business logic
* **Forms** → UI layer

---

## ⚠️ Notes

* Built using Visual Studio 2015
* Uses Entity Framework 6.x
* SQL Server required (Express is enough)

---

## 👨‍💻 Author

**PoetralesanA**

---

## 📄 License

This project is open-source and free to use.
