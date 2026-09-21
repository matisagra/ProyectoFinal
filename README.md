# Sistema Compra-Stock

Guia para configurar el entorno de desarrollo y levantar el backend del proyecto.

## Tecnologias del Proyecto
- Backend: .NET Core / ASP.NET Core (C#) Web API
- Base de Datos: PostgreSQL
- ORM: Entity Framework Core
- Control de Versiones: Git y GitHub

## Pasos para configurar el proyecto

### 1. Clonar el repositorio
Abre la terminal y ejecuta:
git clone https://github.com/matisagra/ProyectoFinal.git
cd ProyectoFinal

### 2. Configurar la Base de Datos
Crea una base de datos con el nombre: ProyectoFinal
Subi el backup de la carpeta bd

### 3. Configurar la cadena de conexion
Edita el archivo appsettings.json.
Actualiza los datos de usuario y contraseña de tu servidor PostgreSQL:
"ConnectionStrings": {
  "ConexionPostgres": "Server=localhost;Port=5432;Database=compra-stock;User Id=postgres;Password=TU_CONTRASEÑA;"
}

### 4. Ejecutar el proyecto
Ejecuta los siguientes comandos en la terminal dentro de la carpeta del proyecto:
dotnet restore
dotnet run
