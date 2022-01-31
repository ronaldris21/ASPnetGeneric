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