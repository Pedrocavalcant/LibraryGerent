using LibraryGerent.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryGerent.Infraestructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Livro> Livros { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Movimento> Movimentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações Fluent API (opcional)
    }
}
