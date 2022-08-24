using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoEF;
using proyectoEF.Models;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TareasContext>(p=> p.UseInMemoryDatabase("TareasDb"));
// builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("TareasConnection"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("TareasConnectionfluentAPI"));

var app = builder.Build();

app.MapGet("/", () => "Hello xD!");
app.MapGet("/Hi", () => "Hello Ronald Ris!");
app.MapGet("/HiKai", () => "Hello Kai!");

app.MapGet("/dbInMemoryConexion",  ([Microsoft.AspNetCore.Mvc.FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();

    return Results.Ok("Base de datos en memoria creada con exito: "+ dbContext.Database.IsInMemory());
});

app.MapGet("/dbConexion", ([FromServices] TareasContext dbContext)=>{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria creada con exito: "+ dbContext.Database.IsInMemory()+
                        "  ---  SQL Server Db Created: " + dbContext.Database.IsSqlServer());
});


//GETS
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


///POSTS
app.MapPost("/api/tareas", async([FromBody] Tarea tarea, [FromServices] TareasContext dbContext) => {
    tarea.TareaId =  new Guid();
    tarea.FechaCreacion = DateTime.Now;

    await dbContext.Tareas.AddAsync(tarea);
    await dbContext.SaveChangesAsync();

    return Results.Ok("Guardado");
});

///PUT
app.MapPut("/api/tareas/{id}", async ([FromBody] Tarea tarea, [FromServices] TareasContext dbContext, [FromRoute] Guid id) => {

    var tareaActual = dbContext.Tareas.Find(id);
    if(tareaActual ==null)
        return Results.NotFound();

    tareaActual.CategoriaId = tarea.CategoriaId;
    tareaActual.Descripcion = tarea.Descripcion;
    tareaActual.PrioridadTarea = tarea.PrioridadTarea;
    tareaActual.Titulo = tarea.Titulo;

    await dbContext.SaveChangesAsync();

    return Results.Ok("Actualizado");
});


app.MapDelete("/api/tareas/{id}", async ([FromServices] TareasContext dbContext, [FromRoute] Guid id)=>{
    var tareaActual = dbContext.Tareas.Find(id);
    if(tareaActual == null)
        return Results.NotFound("No se encontro la tarea a eliminar");

    dbContext.Tareas.Remove(tareaActual);
    await dbContext.SaveChangesAsync();

    return Results.Ok("Tarea eliminada: "+id.ToString());
});


app.Run();
