using System.Security.AccessControl;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace proyectoEF.Models;

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

public enum Prioridad
{
    Baja,
    Media,
    Alta
}