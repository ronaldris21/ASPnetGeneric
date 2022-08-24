# Fundamentos de Entity Framework

Se utilizara ADO.NET que es un conjunto de librerías para acceder a datos y servicios de datos.

##Setup inicial
Get the latest version of Omnisharp VS Code Settings.json file.
~~~json
"omnisharp.path": "latest"
~~~

**Windows** %APPDATA%\Code\User\settings.json
**macOS** $HOME/Library/Application\ Support/Code/User/settings.json
**Linux** $HOME/.config/Code/User/settings.json
Reset all settings#

## Conexión a base de datos

* ODBC
* OLEDB
* SQL server
* Conexion Azure SQL

ADO.NET

ADO.NET es un conjunto de componentes del software que pueden ser usados por los programadores para acceder a datos y a servicios de datos. Es parte de la biblioteca de clases base que están incluidas en el Microsoft .NET Framework. Es comúnmente usado por los programadores para acceder y para modificar los datos almacenados en un sistema gestor de bases de datos relacionales, aunque también puede ser usado para acceder a datos en fuentes no relacionales.

**Instalar Entity Framework Core:**

Para instalar EF Core, instale el paquete para los proveedores de bases de datos de EF Core a los que desea dirigirse. Este tutorial usa SQLite porque se ejecuta en todas las plataformas compatibles con .NET Core. Para obtener una lista de proveedores disponibles, consulte Proveedores de bases.

### Comandos necesarios para entity framework

> dotnet new web
> dotnet new gitignore

**ver la version de dotnet:**
> dotnet --version
> dotnet --version-runtimes

**installar la herramienta entity framework en dotnet:**
> dotnet tool install --global dotnet-ef

**installar el paquete de entity framework:**
> dotnet add package Microsoft EntityFrameworkCore.Design

**crear una migracion con entity framework:**
> dotnet ef migrations add InitialCreate

**hacer una actualización de la base de datos con entity framework:**
> dotnet ef database update


**Instalación de EF**
> dotnet add package Microsoft.EntityFrameworkCore --version 6.0.8

**Instalación para crear una base de datos en memoria**
> dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 6.0.8

**Instalación para conectarnos con el motor SQL Server**
> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.8

**Instalación para conectarnos con PostgreSQL**
> dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0.6

**Certificados**
> dotnet dev-certs https --clean
> dotnet dev-certs https --trust

## ¿Qué es un ORM?

ORM es la sigla para Object Relational Mapping. Se apoya en objetos y clases para realizar la representación del concepto a utilizar.

Que es ORM: es una herramienta que realiza un mapeo que nos permite transformar los objetos de la base de datos como tablas y esquemas a clases con atributos en código de programación para poder manipular la información de una forma más fácil sin requerir de SQL.

Contribución creada con aportes de: Cristhofer Alexander Moya Contreras y Marcos Avila Rodriguez.

## Creación de modelos

Crearemos una carpeta con Models y dentro los archivos:

* Categoria.cs
* Tarea.cs

**Las paquetes y el namespace seras:**

~~~csharp
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models;
~~~

**Codigo dentro de la clase Categoria:**

~~~csharp
public class Categoria
{
    public Guid CategoriaId {get;set;}
    public string? Nombre {get;set;}
    public string? Descripcion {get;set;}
    public int Peso {get;set;}
    
    public virtual ICollection<Tarea>? Tareas {get;set;}
}
~~~

**Codigo dentro de la clase Tarea:**

~~~csharp
public class Tarea 
{
    public Guid TareaId { get; set; }
    public string? Titulo { get; set; }
    public string? Descripcion { get; set; }
    public Guid CategoriaId { get; set; }
    public Prioridad PrioridadTarea { get; set; }
    public DateTime FechaCreacion { get; set; }
	[JsonIgnore]
    public virtual Categoria Categoria { get; set; }

    public string? Resumen { get; set; }
    public string? Estado { get; set; }
}
~~~


## Configuración de Entity Framework

* Contexto: Es donde van a ir todas las relaciones de los modelos que nosotros tenemos para poder transformarlo en colecciones que van a representarse dentro de la base de datos.

Más información e en el siguiente enlace : <https://docs.microsoft.com/es-es/ef/ef6/fundamentals/working-with-dbcontext#defining-a-dbcontext-derived-class>

* DBSet: Es un set o una asignación de datos del modelo que nosotros hemos creado previamente, básicamente esto va a representar lo que sería una tabla dentro del contexto de entity framework.

    Un DbSet representa la colección de todas las entidades en el contexto, o que se puede consultar desde la base de datos, de un tipo determinado.

    Los objetos DbSet se crean a partir de DbContext mediante el método DbContext. set. Microsoft nos ofrece más información sobre esta clase en el siguiente enlace: <https://docs.microsoft.com/es-es/dotnet/api/system.data.entity.dbset-1?view=entity-framework-6.2.0>

## Mapeo de modelos usando atributos

Se usa Data Anotation para especificar el tipo de dato que tendremos en nuestra base de datos

Usar el siguiente link para buscar mas información: <https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations>

### Data Annotations

![data-annotation](./imgs/data-annotation.png)

![data-annotation](./imgs/data-annotation-2.png)

**Codigo dentro de la clase Categoria:**

~~~csharp
public class Categoria
{
    //[Key]
    public Guid CategoriaId { get; set; }
    // [Required]
    // [MaxLength(150)] 
    public string Nombre { get; set; } 
    public string Descripcion { get; set; }
    public int Peso { get; set; }
    // [ForeignKey("CategoriaId")]
    public virtual ICollection<Tarea> Tareas {get;set;}

}
~~~

**Codigo dentro de la clase Tarea:**

~~~csharp
public class Tarea 
{
     // [Key]
    public Guid TareaId { get; set; }
    // [ForeignKey("CategoriaId")]
    public Guid CategoriaId { get; set; }
    // [Required]
    // [MaxLength(200)]
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    // [Required]
    public Prioridad PrioridadTarea { get; set; }
    public DateTime FechaCreacion { get; set; }
    [JsonIgnore]
    public virtual Categoria Categoria {get;set;}
    // [NotMapped]
    public string Resumen {get;set;}
}
~~~

**Especificar el nombre de la tabla en la base de datos tienen que usar la anotación “Table”.**
~~~csharp
using System.ComponentModel.DataAnnotations.Schema;

[Table("Task")]
public class Tareas
{
...
}
~~~
## Utilizando base de datos en memoria

ayuda a verificar si toda la implementacion esta funcionando correctamente creando asi las tablas.

Entonces se realizara las siguientes modificaciones en el archivo program.cs

~~~csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoef;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbConexion", ([FromServices] TareasContext dbContext)=>{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria creada con exito: "+ dbContext.Database.IsInMemory()+
                        "  ---  SQL Server Db Created: " + dbContext.Database.IsSqlServer());
});

app.Run();
~~~



## Conectado a base de datos SQL server

Ejemplo de cadena de conexión para SQL server:

~~~csharp
"Data Source=server;Initial Catalog=db;user id=sa; password=pass";
~~~

### Con seguridad de windows
~~~Json
"Data Source=(local); Initial Catalog= TareasDb;Trusted_Connection=True; Integrated Security=True"
~~~

### Configuración para PostgreSQL:

**Enlace de descarga:**
<https://www.postgresql.org/download/>

**Paquete nuget:**
<https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/>

**Comando para instalar el paquete nuget:**
> dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

**Configuración de PostgreSQL en la clase Program.cs:**

~~~csharp
services.AddDbContext<HotelContextDB>(options => options.UseNpgsql(“Server=postgreServer;Database=DbName;Port=5432;User Id=user;Password=password;”));
~~~

**Ejemplo de con cadena de conexión de PostgreSQL:**

~~~csharp
Server=postgreServer;Database=DbName;Port=5432;User Id=user;Password=password;
~~~

### Para mysql seria:
builder.Services.AddDbContext<TareasContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString(“SERVER”)));


## Agregando conexión al archivo appsettings

abrir el archivo appsettings.json y hacer la siguiente configurarión

~~~json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "cnTareas": "Data Source=server;Initial Catalog=db;user id=sa; password=pass"
  }
}
~~~
**Server en local seria:
>  (local)\\SQLEXPRESS

Hacer las siguientes configuracion en programa.cs

~~~csharp
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));
~~~

## Introducción a Fluent API

**Fluent API:**

Forma avanzada de configuración sin utilizar atributos o data-annotations, usando funciones de extensión anidadas en objetos de tabla, columnas durante el mapeo de los datos.

![fluent-api](./imgs/Fluent-API.png)

## Creando modelo de tarea con Fluent API

~~~csharp
using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;
~~~


~~~csharp
public class TareasContext: DbContext
{
    public DbSet<Categoria>? Categorias {get;set;}
    public DbSet<Tarea>? Tareas {get;set;}

    public TareasContext(DbContextOptions<TareasContext> options) :base(options) { }
    
	///Fluent API
    ///Ahora comento los data notations en los modelos-- Se hace de una u de otra forma. No ambas
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(categoria=>{
            categoria.ToTable("Categoria");
            categoria.HasKey(p=>p.CategoriaId);
            categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150);
            ///Puedo especificar un nombre para la columna en la base de datos
            categoria.Property(p=>p.Descripcion).HasColumnName("Description");
        });

        modelBuilder.Entity<Tarea>(tarea =>
        {
            // indica que es una tabla
            tarea.ToTable("tarea");
            // indica que es la clave primaria
            tarea.HasKey(t => t.TareaId);            
            // indica que una tarea tiene una categoria y una categoria tiene muchas tareas
            tarea.HasOne(t => t.Categoria).WithMany(c => c.Tareas).HasForeignKey(t => t.CategoriaId); 
            // indica que es un campo obligatorio y su tamaño máximo es 200
            tarea.Property(t => t.Titulo).IsRequired().HasMaxLength(200); 
            // indica que es un campo opcional
            tarea.Property(t => t.Descripcion);      
            // indica que es un campo con una conversión de tipo enumerado
            tarea.Property(t => t.PrioridadTarea).IsRequired().HasConversion(  
                v => v.ToString(),
                v => (Prioridad)Enum.Parse(typeof(Prioridad), v));
            // ignora la propiedad en la base de datos
            tarea.Ignore(t=>t.Resumen);
        });
}

~~~

**mas informacion sobre Fluent API:** 

* <https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key>

* <https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key>

* <https://www.tutorialspoint.com/entity_framework/entity_framework_fluent_api.htm#:~:text=Fluent%20API%20is%20an%20advanced,not%20possible%20with%20data%20annotations>

# ¿Qué son las migraciones?

![migraciones](./imgs/migraciones.png)

![comandos](./imgs/migraciones-comandos.png)

## Inicializar las migraciones
<https://docs.microsoft.com/en-us/ef/core/cli/dotnet>

**Comando para instalar la herramienta de EF:**

> dotnet tool install --global dotnet-ef

**Comando para instalar EF Design:**

dotnet add package Microsoft.EntityFrameworkCore.Design

**Cada migración debe de tener un nombre descriptivo:**

> dotnet ef migrations add InitialCreate

**Actualizacion de la base de datos:**
Si queremos utilizar migrations en producción debemos hacerlo una vez que se haya terminado el esquema, o sea mientras no hayan datos.

Cada vez que agreguemos una migración debemos usar el comando:

> dotnet ef database update

**IMPORTANTE -- PostgreSQL**
Usarlo justo despues de los using en el archivo de DbContext
> AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


## Agregando datos semilla

Crear objetos y agregar datos a las propiedades de la clase Categoria y tarea en la clase TareasContext.cs

~~~csharp
using Microsoft.EntityFrameworkCore;
using proyectoEF.Models;


namespace proyectoEF;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>(){
            new Categoria()
            {
                CategoriaId = Guid.Parse("2d143e08-b275-425a-b3b0-a3a747ca9834"),
                Nombre = "Actividades pendientes",
                Peso=20
            },
            new Categoria()
            {
                CategoriaId = Guid.Parse("df94fd47-243b-4a8b-a438-41734bae8e2d"),
                Nombre = "Actividades Personales",
                Peso=50
            },
        };

        modelBuilder.Entity<Categoria>(categoria=>{
            categoria.ToTable("Categoria");
            categoria.HasKey(p=>p.CategoriaId);
            categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p=>p.Descripcion).HasColumnName("Description").IsRequired(false);
            categoria.Property(p=> p.Peso);

            categoria.HasData(categoriasInit);
        });

        List<Tarea> tareasInit = new List<Tarea>(){
            new Tarea(){
                TareaId = Guid.Parse("f2777a32-663c-4b32-b20c-24170523b98a"),
                CategoriaId = Guid.Parse("2d143e08-b275-425a-b3b0-a3a747ca9834"),
                Titulo = "Comprar leche y huevos",
                PrioridadTarea = Prioridad.Media
            },
            new Tarea(){
                TareaId = Guid.Parse("f2777a32-663c-4b32-b20c-24170523b98b"),
                CategoriaId = Guid.Parse("2d143e08-b275-425a-b3b0-a3a747ca9834"),
                Titulo = "Pedir una Micro SD en Amazon",
                PrioridadTarea = Prioridad.Media
            },

            new Tarea(){
                TareaId = Guid.Parse("f2777a32-663c-4b32-b20c-24170523b98c"),
                CategoriaId = Guid.Parse("df94fd47-243b-4a8b-a438-41734bae8e2d"),
                Titulo = "Revisar Compra de laptop, llega mañana",
                PrioridadTarea = Prioridad.Alta
            },
            new Tarea(){
                TareaId = Guid.Parse("f2777a32-663c-4b32-b20c-24170523b98d"),
                CategoriaId = Guid.Parse("df94fd47-243b-4a8b-a438-41734bae8e2d"),
                Titulo = "Terminar Curso de ASP Net",
                PrioridadTarea = Prioridad.Alta
            },

        };

        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("tarea");
            tarea.HasKey(t => t.TareaId);            
            tarea.HasOne(t => t.Categoria).WithMany(c => c.Tareas).HasForeignKey(t => t.CategoriaId); 
            tarea.Property(t => t.Titulo).IsRequired().HasMaxLength(200); 
            tarea.Property(t => t.Descripcion).IsRequired(false);      
            tarea.Property(t => t.PrioridadTarea).IsRequired().HasConversion(  
                v => v.ToString(),
                v => (Prioridad)Enum.Parse(typeof(Prioridad), v)).HasMaxLength(10);
            
            tarea.Ignore(t=>t.Resumen);
            tarea.Property(t=>t.FechaCreacion).HasDefaultValue(DateTime.Now);
            tarea.HasData(tareasInit);
        });
    }
}
~~~

## Obteniendo datos con Entity Framework
https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio

**Cuidado si necesitas un [JsonIgnore]*

Creando el end point Get

**GET**
~~~csharp
app.MapGet("/api/tareas", async ([FromServices] TareasContext dbContext) =>
{
    return Results.Ok(dbContext.Tareas.OrderBy(t=>t.PrioridadTarea).Include(t=>t.Categoria));
});

app.MapGet("/api/categorias", ([FromServices] TareasContext dbContext)=>{
    return Results.Ok(dbContext.Categorias);
});

app.MapGet("/api/categorias2", ([FromServices] TareasContext dbContext)=>{
    return Results.Ok(dbContext.Categorias.Include(c=>c.Tareas));
});

~~~

## Guardando datos con Entity framework

Creando el end point Post:
**POST**
~~~csharp
app.MapPost(
    "/api/tareas", 
    async ([FromServices] TareasContext dbContext, 
    [FromBody] Tarea tarea) =>
{
    tarea.TareaId = Guid.NewGuid();
    tarea.FechaCreacion = DateTime.Now;
    await dbContext.AddAsync(tarea);
    //await dbContext.Tareas.AddAsync(tarea);

    await dbContext.SaveChangesAsync();

    return Results.Ok();
});
~~~

## Actualizando datos con Entity framework

Creando el end point Put:
**PUT**
~~~csharp
app.MapPut(
    "/api/tareas/{id}", 
    async ([FromServices] TareasContext dbContext, 
    [FromBody] Tarea tarea,
    [FromRoute] Guid id) =>
{
    var tareaActual = dbContext?.Tareas?.Find(id);
    if (tareaActual != null)
    {
        tareaActual.CategoriaId = tarea.CategoriaId;
        tareaActual.Titulo = tarea.Titulo;
        tareaActual.PrioridadTarea = tarea.PrioridadTarea;
        tareaActual.Descripcion = tarea.Descripcion;
        
        await dbContext.SaveChangesAsync();

        return Results.Ok();
    }

    return Results.NotFound();
});
~~~

## Eliminando datos con Entity framework

Creando el end point Delete:

~~~csharp
app.MapDelete(
    "/api/tareas/{id}", 
    async ([FromServices] TareasContext dbContext, 
    [FromRoute] Guid id) =>
{
    var tareaActual = dbContext?.Tareas?.Find(id);

    if(tareaActual == null)
    {
        return Results.NotFound("Task not found.");
    }
        
    dbContext?.Tareas?.Remove(tareaActual);
    await dbContext.SaveChangesAsync();

    return Results.Ok();
});
~~~

---