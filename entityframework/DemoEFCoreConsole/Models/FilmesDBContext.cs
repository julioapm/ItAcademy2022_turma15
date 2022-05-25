using Microsoft.EntityFrameworkCore;

namespace DemoEFCoreConsole.Models;

public class FilmesDBContext : DbContext
{
    public DbSet<Filme> Filmes {get;set;} = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Filme>(
            entity =>
            {
                entity.Property(e => e.Titulo)
                    .HasMaxLength(50);
            }
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=itat15bdfilmes;Integrated Security=True");
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }
}