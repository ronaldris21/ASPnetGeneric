using Microsoft.EntityFrameworkCore;
using proyectoEF.Models;


namespace proyectoEF;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarea> Tareas { get; set; }
    public TareasContext(DbContextOptions<TareasContext> options) : base(options){}

    ///Fluent API
    ///Ahora comento los data notations en los modelos-- Se hace de una u de otra forma. No ambas
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Datos Semilla
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
            ///Puedo especificar un nombre para la columna en la base de datos
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
            // indica que es una tabla
            tarea.ToTable("tarea");
            // indica que es la clave primaria
            tarea.HasKey(t => t.TareaId);            
            // indica que una tarea tiene una categoria y una categoria tiene muchas tareas
            tarea.HasOne(t => t.Categoria).WithMany(c => c.Tareas).HasForeignKey(t => t.CategoriaId); 
            // indica que es un campo obligatorio y su tamaño máximo es 200
            tarea.Property(t => t.Titulo).IsRequired().HasMaxLength(200); 
            // indica que es un campo opcional
            tarea.Property(t => t.Descripcion).IsRequired(false);      
            // indica que es un campo con una conversión de tipo enumerado COMO STRING
            tarea.Property(t => t.PrioridadTarea).IsRequired().HasConversion(  
                v => v.ToString(),
                v => (Prioridad)Enum.Parse(typeof(Prioridad), v)).HasMaxLength(10);
            
            // ignora la propiedad en la base de datos
            tarea.Ignore(t=>t.Resumen);
            // Valor por defecto
            tarea.Property(t=>t.FechaCreacion).HasDefaultValue(DateTime.Now);

            tarea.HasData(tareasInit);
        });
    }

}