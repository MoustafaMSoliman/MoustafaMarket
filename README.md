# 🛒 E-commerce Domain-Driven Design Project

A scalable, maintainable e-commerce platform built with **.NET 8**, following **Domain-Driven Design (DDD)**, **CQRS**, and **Event-Driven Architecture**.

---

## 📜 Project Overview

### **🚀 Key Features**
✅ **DDD-Based Architecture**  
✅ **CQRS Pattern** for separation of read/write operations  
✅ **Event-Driven Communication** (MediatR)  
✅ **JWT Authentication & Role-Based Access Control (RBAC)**    
✅ **Unit & Integration Testing** with xUnit  

### **🛠 Technology Stack**
| **Component**  | **Technology** |
|----------------|--------------|
| Backend        | .NET 8 (ASP.NET Core) |
| Database       | SQL Server |
| ORM            | Entity Framework Core |
| Caching       | Redis |
| Authentication | JWT / IdentityServer |
| Logging       | Serilog |
| Testing       | xUnit, Moq |

---

## 📂 Project Structure

```bash
/EcommerceDDD
  ├── /Ecommerce.Domain        # Domain Layer (Entities, Aggregates, Events)
  ├── /Ecommerce.Application   # Application Layer (CQRS, Use Cases)
  ├── /Ecommerce.Infrastructure # Infrastructure Layer (Persistence, Messaging)
  ├── /Ecommerce.API           # API Layer (Controllers, Authentication)
  ├── /Ecommerce.Tests         # Testing Layer (Unit & Integration Tests)
