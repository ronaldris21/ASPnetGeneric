using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace proyectoEF.Models;
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
    public virtual ICollection<Tarea>? Tareas {get;set;}

}

