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

<table >
    <thead >
        <tr>
            <th scope="col">NuGet Package</th>
            <th scope="col">Supported database engines</th>
        </tr>
    </thead>
    <tbody>
		<tr>
			<td>Microsoft.EntityFrameworkCore.SqlServer /td>
			<td>SQL Server 2008 onwards </td>
		</tr>
		<tr>
			<td>Microsoft.EntityFrameworkCore.Sqlite  </td>
			<td>SQLite 3.7 onwards </td>
		</tr>
		<tr>
			<td>Microsoft.EntityFrameworkCore.InMemory  </td>
			<td>EF Core in-memory database  </td>
		</tr>
		<tr>
			<td>Npgsql.EntityFrameworkCore.PostgreSQL  </td>
			<td>PostgreSQL  </td>
		</tr>
		<tr>
			<td>Pomelo.EntityFrameworkCore.MySql  </td>
			<td>MySQL, MariaDB  </td>
		</tr>
		<tr>
			<td>Pomelo.EntityFrameworkCore.MyCat  </td>
			<td>MyCAT Server  </td>
		</tr>
		<tr>
			<td>EntityFrameworkCore.SqlServerCompact40  </td>
			<td>SQL Server Compact 4.0  </td>
		</tr>
		<tr>
			<td>EntityFrameworkCore.SqlServerCompact35   </td>
			<td>SQL Server Compact 3.5  </td>
		</tr>
		<tr>
			<td>MySql.Data.EntityFrameworkCore  </td>
			<td>MySQL  </td>
		</tr>
		<tr>
			<td>FirebirdSql.EntityFrameworkCore.Firebird  </td>
			<td>Firebird 2.5 and 3.x  </td>
		</tr>
		<tr>
			<td>EntityFrameworkCore.FirebirdSql  </td>
			<td>Firebird 2.5 and 3.x  </td>
		</tr>
		<tr>
			<td>IBM.EntityFrameworkCore  </td>
			<td>Db2, Informix  </td>
		</tr>
		<tr>
			<td>IBM.EntityFrameworkCore-lnx   </td>
			<td>Db2, Informix  </td>
		</tr>
		<tr>
			<td>IBM.EntityFrameworkCore-osx  </td>
			<td>Db2, Informix  </td>
		</tr>
		<tr>
			<td>Devart.Data.Oracle.EFCore  </td>
			<td>Oracle 9.2.0.4 onwards  </td>
		</tr>
		<tr>
			<td>Devart.Data.PostgreSql.EFCore  </td>
			<td>PostgreSQL 8.0 onwards  </td>
		</tr>
		<tr>
			<td>Devart.Data.SQLite.EFCore  </td>
			<td>SQLite 3 onwards  </td>
		</tr>
		<tr>
			<td>Devart.Data.MySql.EFCore  </td>
			<td>MySQL 5 onwards  </td>
		</tr>
		<tr>
			<td>EntityFrameworkCore.Jet  </td>
			<td>Microsoft Access files </td>
		</tr>
    </tbody>
</table>