# 🎬 MovieNest

**MovieNest** is a simple **ASP.NET Core MVC** web application that allows users to manage movie details — including name, release date, producer, director, and casting.
This project demonstrates **CRUD operations (Create, Read, Delete)** using **Entity Framework Core** and **SQL Server** as the database.
It’s an excellent example of connecting a .NET Core MVC application with a real database and managing records through a clean UI.

---

## 🧩 Key Features

* 🎥 Add, edit, view, and delete movies
* 🗄️ SQL Server database integration
* ⚙️ Entity Framework Core
* 🧰 Dependency Injection for services
* 🧑‍💻 Simple UI with MVC architecture
* 🔄 Supports CRUD operations with clean separation of concerns

---

## 🚀 Project Setup Guide

### ✅ Prerequisites

Before running the project, ensure the following are installed:

* [.NET 8 SDK or later](https://dotnet.microsoft.com/download)
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
* [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
* [Visual Studio 2022](https://visualstudio.microsoft.com/)

---

## ⚙️ Step 1: Clone the Repository

Open **Git Bash** or **Command Prompt**, then run:

```bash
git clone https://github.com/<your-username>/MovieNest.git
cd MovieNest
```

---

## ⚙️ Step 2: Database Setup

1. Open **SQL Server Management Studio (SSMS)**.
2. Connect to your **SQL Server instance**.
3. Click **File → Open → File…** and select the database script given below.
4. Press **Execute (F5)** to run the script.

This will create the `MovieNest` database and `Movies` table.

---

### 🗄️ Database Script

```sql
CREATE DATABASE [MovieNest]

USE [MovieNest]

GO
 
/****** Object:  Table [dbo].[Movies] ******/

SET ANSI_NULLS ON

GO
 
SET QUOTED_IDENTIFIER ON

GO
 
CREATE TABLE [dbo].[Movies](

	[Id] [uniqueidentifier] NOT NULL,

	[Name] [nvarchar](50) NULL,

	[ReleaseDate] [datetime] NULL,

	[Producer] [nvarchar](50) NULL,

	[Director] [nvarchar](50) NULL,

	[Casting] [nvarchar](50) NULL,

CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 

(

	[Id] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

) ON [PRIMARY]

GO
 
 
 
```

---

## ⚙️ Step 3: Connecting Database

Open the **`appsettings.json`** file and update the connection string:

```json
"ConnectionStrings": {
  "MovieNest": "Data Source=<your SQL Server instance name>;Initial Catalog=MovieNest;Integrated Security=True;TrustServerCertificate=True"
}
```

