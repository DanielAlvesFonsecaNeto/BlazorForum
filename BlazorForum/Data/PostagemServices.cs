using Microsoft.EntityFrameworkCore;

namespace BlazorForum.Data;

public class PostagemServices(ForumDbContext context)
{
    public async Task<List<Postagem>> RetornaPostagens()
    {
        return await context.Postagens.Include(p => p.Autor).ToListAsync();
    }
    
    public async Task<List<Postagem>> RetornaPostagensDoUsuario(long usuarioId)
    {
        return await context.Postagens.ToListAsync();
    }
}