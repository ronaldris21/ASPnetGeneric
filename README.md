
<h1>ASPnetGeneric</h1>
Learning from zero to hero - here we go again!

<h3>Download DOTNET SDK</h3>
https://dotnet.microsoft.com/en-us/download/dotnet


<h3>Habilitar https, confiando en los certificados -- POWER SHELL</h3>
dotnet dev-certs https --trust

#Si no funciona
Primero Instala dotnet-sdk de la pagina https://dotnet.microsoft.com/download
Luego
En PowerShell ejecutas
dotnet dev-certs https --trust  <br>
dotnet tool install --global dotnet-dev-certs

<table>
    <thead>
        <tr>
            <th>Razor Page </th>
            <th>page</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>MVC ViewImports </td>
            <td>viewimports</td>
        </tr>
        <tr>
            <td>MVC ViewStart </td>
            <td>viewstart</td>
        </tr>
        <tr>
            <td>ASP.NET Core Empty </td>
            <td>web</td>
        </tr>
        <tr>
            <td>ASP.NET Core Web App (Model-View-Controller)</td>
            <td>mvc</td>
        </tr>
        <tr>
            <td>ASP.NET Core Web App</td>
            <td>razor</td>
        </tr>
        <tr>
            <td>ASP.NET Core with Angular </td>
            <td>angular</td>
        </tr>
        <tr>
            <td>ASP.NET Core with React.js 	</td>
            <td>react</td>
        </tr>
        <tr>
            <td>ASP.NET Core with React.js and Redux </td>
            <td>reactredux</td>
        </tr>
        <tr>
            <td>Razor Class Library</td>
            <td>razorclasslib</td>
        </tr>
        <tr>
            <td>ASP.NET Core Web API </td>
            <td>webapi</td>
        </tr>
    </tbody>
</table>					
								
									
								
 	
 							
						
					
			


<h2>#Comandos de CONSOLA:  </h2>

<ul>
    <li>dotnet run</li>
    <li>dotnet restore</li>
    <li>dotnet add package Newtonsoft.Json    </li>
    <li>dotnet new console -o ProjectName</li>
    <li>code . </li>
    <li>dotnet watch run</li>
    <li>dotnet new mvc -au none -o projectName</li>
    <li>dotnet dev-certs https --trust</li>
    <li>dotnet tool install --global dotnet-dev-certs</li>
</ul>




<h2>#Useful Links</h2>
 <ul>
     <li>https://www.learnentityframeworkcore.com/</li>
 </ul>


<h2>##Providers Actuales para EF Core</h2>

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