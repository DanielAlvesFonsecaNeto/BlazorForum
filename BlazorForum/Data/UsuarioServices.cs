namespace BlazorForum.Data;

public class UsuarioServices(ForumDbContext context)
{
    public async Task<Usuario?> GetUsuarioById(long id)
    {
        return await context.Usuarios.FindAsync(id);
    }
}