using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorForum.Data;

public class Postagem
{
    public long Id { get; set; }
    
    public long AutorId { get; set; }
    
    [ForeignKey("AutorId")]  
    public Usuario Autor { get; set; }
    
    public string Texto { get; set; }
    
    public string Titulo { get; set; }
}
