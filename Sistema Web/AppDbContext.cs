using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
{
}
// DbSets personalizados, se quiser adicionar depois
public DbSet<Usuario> Usuarios { get; set; }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}