using Microsoft.EntityFrameworkCore;

namespace BlazorForum.Data;

public class ForumDbContext(DbContextOptions<ForumDbContext> options) : DbContext(options)
{
    public DbSet<Usuario> Usuarios { get; init; }
    public DbSet<Postagem> Postagens { get; init; }
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        
        modelBuilder.Entity<Usuario>().HasData(RetornaPessoas());
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Postagem>()
            .HasOne(p => p.Autor)
            .WithMany(a => a.Postagens)
            .HasForeignKey(p => p.AutorId);
        
        modelBuilder.Entity<Postagem>()
            .HasData(RetornaPostagem());
    }
    
    private List<Usuario> RetornaPessoas() {
        return new List<Usuario>{
            new Usuario { Id = 1001, Nome = "Daniel"},
            new Usuario { Id = 1002, Nome = "Emerson"},
            new Usuario { Id = 1003, Nome = "Rafael"},
        };
    }
    
    private List<Postagem> RetornaPostagem(){
        return new List<Postagem>{
            new Postagem { Id = 1001, AutorId = 1001, Titulo = "Laptop", Texto ="Excelente notebook"},
            new Postagem { Id = 1002, AutorId = 1001, Titulo = "Microsoft Office", Texto ="Um MS Office"},
            new Postagem { Id = 1003, AutorId = 1002, Titulo = "Mouse", Texto ="Um mouse que funciona"},
            new Postagem { Id = 1004, AutorId = 1003, Titulo = "HD USB", Texto = "Armazene incríveis 256GB de dados"}
        };
    }
}