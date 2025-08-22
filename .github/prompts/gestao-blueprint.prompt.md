---
mode: agent
---
Prompt for Creating a Clean Architecture .NET 8 Web API Template

Create a complete .NET 8 Web API project following Clean Architecture principles with the following specifications:

Project Structure & Architecture
Target Framework: .NET 8.0
Architecture: Clean Architecture with 4 layers: Api, Aplicacao (Application), Dominio (Domain), and Infraestrutura (Infrastructure)
Pattern: CQRS with MediatR, Repository Pattern with Unit of Work
Database: PostgreSQL with Entity Framework Core 8.0.8
Folder Structure

src/
├── Api/
│   ├── Controllers/
│   └── Middleware/
├── Aplicacao/
│   ├── Commands/
│   └── Queries/
├── Dominio/
│   ├── Entities/
│   └── Enums/
└── Infraestrutura/
    ├── Data/
    ├── Repositories/
    └── Services/

Key Dependencies & Packages
Include these NuGet packages with specified versions:

Autofac (6.5.0) and Autofac.Extensions.DependencyInjection (8.0.0)
AutoMapper (12.0.1) and extensions
MediatR.Extensions.FluentValidation.AspNetCore (5.0.0)
Microsoft.EntityFrameworkCore.* (8.0.8) with PostgreSQL provider
Microsoft.AspNetCore.Authentication.JwtBearer (8.0.8)
NetDevPack.Security.Jwt.AspNetCore
Swashbuckle.AspNetCore (6.7.3) with Annotations
System.IO.Abstractions (21.0.29)
Implementation Requirements
1. Program.cs Configuration
Configure CORS for localhost:8080
Set up JWT authentication with bearer tokens
Configure PostgreSQL database context
Register MediatR with validation behaviors
Add Swagger/OpenAPI documentation
Include error handling middleware
Use dependency injection for repositories and services
2. Domain Layer (Dominio)
Create base entity class (EntidadeBase) with common properties
Implement domain entities with proper relationships
Include domain enums for status types
Keep domain pure without external dependencies
3. Application Layer (Aplicacao)
Commands: Handle write operations (Create, Update, Delete)
Each command should have: Command class, CommandHandler, and DTO
Use MediatR IRequest<T> pattern
Queries: Handle read operations
Each query should have: Query class, QueryHandler, and response DTO
Implement validation using FluentValidation
4. Infrastructure Layer (Infraestrutura)
DbContext: Configure Entity Framework with PostgreSQL
Entity Configurations: Separate configuration files for each entity
Repositories: Implement read and write repositories for each entity
Unit of Work: Coordinate multiple repository operations
Migrations: Include EF Core migrations setup
5. API Layer (Api)
Controllers: Inherit from BaseController
Use MediatR for command/query handling
Implement proper HTTP status code responses
Include JWT authentication attributes
Follow REST API conventions
Naming Conventions
Use Portuguese for business terms (Usuarios, Localizacoes, Ongs, etc.)
Commands end with "Comando" and handlers with "ComandoHandler"
DTOs use descriptive names like "NovoUsuarioDto", "UsuariosListaDto"
Repository classes: "RepositorioEscrita[Entity]", "RepositorioLeitura[Entity]"
Additional Features
Central package management with Directory.Packages.props
Memory caching support
File system abstractions
Error handling middleware
CORS configuration
JWT token validation
Swagger documentation with annotations
Sample Entities to Include
Create these domain entities with appropriate relationships:

Usuario (User) with Localizacao (Location)
Ong (NGO) with Status
Projeto (Project) with Status
Voluntario (Volunteer) with Status
Investidor (Investor) with Type and Status
Causa (Cause), Habilidade (Skill), Candidatura (Application)
Generate a complete, working solution that follows these specifications exactly, ensuring all layers are properly connected and the project compiles and runs successfully.
