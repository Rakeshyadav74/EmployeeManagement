# Employee Management System – ASP.NET Core Web API

A RESTful Employee Management API developed using ASP.NET Core Web API (.NET 10), C#, Entity Framework Core, and Microsoft SQL Server.

This project demonstrates a layered architecture with Repository Pattern, Service Layer, DTOs, dependency injection, CRUD operations, and data validation.

## Project Overview

The Employee Management System provides REST API endpoints to create, retrieve, update, and delete employee records.

It is being developed as a practical .NET backend development project, following structured coding practices and incremental learning.

## Technology Stack

| Technology            | Purpose                 |
| --------------------- | ----------------------- |
| C#                    | Programming Language    |
| ASP.NET Core Web API  | REST API Framework      |
| .NET 10               | Runtime and SDK         |
| Entity Framework Core | ORM                     |
| SQL Server Express    | Database                |
| LINQ                  | Data Queries            |
| Postman               | API Testing             |
| Git & GitHub          | Version Control         |
| Visual Studio 2026    | Development Environment |

## Features

* Employee CRUD operations
* RESTful API endpoints
* Entity Framework Core Code First
* SQL Server database integration
* Repository Pattern
* Service Layer
* Dependency Injection
* Data Transfer Objects (DTOs)
* Data validation using Data Annotations
* HTTP status code handling
* Asynchronous database operations
* Postman API testing

## Project Architecture

```text
EmployeeManagement
│
├── Controllers
│   └── EmployeeController.cs
│
├── Data
│   └── EmployeeDbContext.cs
│
├── DTOs
│   ├── CreateEmployeeDto.cs
│   ├── UpdateEmployeeDto.cs
│   └── EmployeeResponseDto.cs
│
├── Interfaces
│   ├── IEmployeeRepository.cs
│   └── IEmployeeService.cs
│
├── Models
│   └── Employee.cs
│
├── Repositories
│   └── EmployeeRepository.cs
│
├── Services
│   └── EmployeeService.cs
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── EmployeeManagement.csproj
```

## API Endpoints

Base URL:

```text
/api/Employee
```

| Method | Endpoint           | Description        |
| ------ | ------------------ | ------------------ |
| GET    | /api/Employee      | Get all employees  |
| GET    | /api/Employee/{id} | Get employee by ID |
| POST   | /api/Employee      | Create employee    |
| PUT    | /api/Employee/{id} | Update employee    |
| DELETE | /api/Employee/{id} | Delete employee    |

## Sample Request

### Create Employee

```json
{
  "name": "Rahul Kumar",
  "department": "IT",
  "salary": 45000.50,
  "email": "rahul@gmail.com"
}
```

## HTTP Status Codes

| Status Code | Meaning               |
| ----------- | --------------------- |
| 200         | OK                    |
| 201         | Created               |
| 204         | No Content            |
| 400         | Bad Request           |
| 404         | Not Found             |
| 500         | Internal Server Error |

## Getting Started

### Prerequisites

* Visual Studio 2026
* .NET 10 SDK
* SQL Server Express
* SQL Server Management Studio
* Postman

### Clone Repository

```bash
git clone https://github.com/Rakeshyadav74/EmployeeManagement.git
```

### Configure Database

Update the `DefaultConnection` connection string in `appsettings.json` according to your local SQL Server instance.

Do not commit database passwords, API keys, or other secrets.

### Apply Migrations

Open Visual Studio Package Manager Console:

```powershell
Update-Database
```

### Run Application

Open the solution in Visual Studio and press:

```text
Ctrl + F5
```

Use the actual localhost port displayed by Visual Studio.

## Learning Roadmap

* [x] ASP.NET Core Web API Setup
* [x] SQL Server and Entity Framework Core
* [x] Code First Migrations
* [x] Repository Pattern
* [x] Service Layer
* [x] CRUD API
* [x] DTOs and Validation
* [ ] Global Exception Handling
* [ ] Logging and Middleware
* [ ] Pagination, Filtering, and Sorting
* [ ] JWT Authentication
* [ ] Role-Based Authorization
* [ ] Unit Testing
* [ ] Docker
* [ ] Deployment

## Author

**Rakesh Kumar Yadav**

Aspiring .NET Developer | Software Developer | Cloud & DevOps Learner

GitHub: [@Rakeshyadav74](https://github.com/Rakeshyadav74)

## Project Status

In Development – Lesson 08 completed.

More features and improvements will be added as development progresses.

---

If you find this project useful, feel free to explore the repository and follow the development journey.
