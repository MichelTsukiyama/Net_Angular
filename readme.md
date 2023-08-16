# Curso Full Stack em .Net 5 + Angular 12
<br>

Curso criando uma API com .Net 5 e Angular 12;

Requisitos:
- SDK .Net 5;
- SDK Node versão 14 +;
- Angular CLI 12;
- IDE ou editor de código (VS Code, Visual Studio...);
- Git;
- GitHub;
- Dotnet Entity Framework 5 ;

------

## Instalar Dotnet Entity Framework
<br>

Instala a versão 5 do Entity Framework 5

        dotnet tool install dotnet-ef --global --version 5.0.4

para utilizar os comandos do entity framework:

        dotnet-ef <command>

Instalar também via Nuget:

- Microsoft.EntityFrameworkCore;
- Microsoft.EntityFrameworkCore.Design;
- Microsoft.EntityFrameworkCore.Sqlite;
- Microsoft.EntityFrameworkCore.Tools;

Verifique o arquivo .csproj

1. Exemplo adicionar Migration:

        dotnet ef migrations add Initial -o Data/Migrations

2. Exemplo atualizar DB:

        dotnet ef database update

---------

