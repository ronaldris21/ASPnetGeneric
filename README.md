# ASPnetGeneric
Learning from zero to hero - here we go again!

#Download DOTNET SDK
https://dotnet.microsoft.com/en-us/download/dotnet


#Habilitar https, confiando en los certificados -- POWER SHELL
dotnet dev-certs https --trust

#Si no funciona
Primero Instala dotnet-sdk de la pagina https://dotnet.microsoft.com/download
Luego
En PowerShell ejecutas
dotnet tool install --global dotnet-dev-certs
dotnet dev-certs https --trust

Razor Page 										page
MVC ViewImports 								viewimports
MVC ViewStart 									viewstart
ASP.NET Core Empty 								web
ASP.NET Core Web App (Model-View-Controller) 	mvc
ASP.NET Core Web App 							razor
ASP.NET Core with Angular 						angular
ASP.NET Core with React.js 						react
ASP.NET Core with React.js and Redux 			reactredux
Razor Class 									Library
razorclasslib
ASP.NET Core Web API 							webapi


#Agregar paquetes!		
dotnet add package Newtonsoft.Json


#Comandos de CONSOLA:  
dotnet run
dotnet restore
dotnet new console -o ProjectName
code . 
dotnet new mvc -au none -o projectName
dotnet watch run


#Useful Link for EntityFramework   https://www.learnentityframeworkcore.com/

##Providers Actuales para EF Core


|NuGet Package| Supported database engines|
|Microsoft.EntityFrameworkCore.SqlServer |SQL Server 2008 onwards|
|Microsoft.EntityFrameworkCore.Sqlite |SQLite 3.7 onwards|
|Microsoft.EntityFrameworkCore.InMemory |EF Core in-memory database|
|Npgsql.EntityFrameworkCore.PostgreSQL |PostgreSQL|
|Pomelo.EntityFrameworkCore.MySql |MySQL, MariaDB|
|Pomelo.EntityFrameworkCore.MyCat |MyCAT Server|
|EntityFrameworkCore.SqlServerCompact40 |SQL Server Compact 4.0|
|EntityFrameworkCore.SqlServerCompact35 |SQL Server Compact 3.5|
|MySql.Data.EntityFrameworkCore |MySQL|
|FirebirdSql.EntityFrameworkCore.Firebird |Firebird 2.5 and 3.x|
|EntityFrameworkCore.FirebirdSql |Firebird 2.5 and 3.x|
|IBM.EntityFrameworkCore |Db2, Informix|
|IBM.EntityFrameworkCore-lnx |Db2, Informix|
|IBM.EntityFrameworkCore-osx |Db2, Informix|
|Devart.Data.Oracle.EFCore |Oracle 9.2.0.4 onwards|
|Devart.Data.PostgreSql.EFCore |PostgreSQL 8.0 onwards|
|Devart.Data.SQLite.EFCore |SQLite 3 onwards|
|Devart.Data.MySql.EFCore |MySQL 5 onwards|
|EntityFrameworkCore.Jet |Microsoft Access files|