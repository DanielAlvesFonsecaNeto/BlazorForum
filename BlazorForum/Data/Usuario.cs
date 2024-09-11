namespace BlazorForum.Data;


public class Usuario
{
    public long Id { get; set; }
    public string Nome { get; set; }
    
    public ICollection<Postagem> Postagens { get; set; }
}