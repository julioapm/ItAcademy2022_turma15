using Microsoft.EntityFrameworkCore;
namespace DemoEFCoreWebApi.Models;

public class LojinhaContext: DbContext
{
    public LojinhaContext()
    {
    }

    public LojinhaContext(DbContextOptions<LojinhaContext> options)
    : base(options)
    {
    }
    public DbSet<Produto> Produtos {get;set;} = null!;
    public DbSet<Cliente> Clientes {get;set;} = null!;
    public DbSet<Pedido> Pedidos {get;set;} = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>(entityBuilder => {
            entityBuilder.Property(e => e.Nome)
                .HasMaxLength(30);
            entityBuilder.Property(e => e.Descricao)
                .HasMaxLength(200);
        });
        modelBuilder.Entity<Cliente>(entityBuilder => {
            entityBuilder.Property(e => e.Nome)
                .HasMaxLength(30);
            entityBuilder.Property(e => e.Email)
                .HasMaxLength(50);
        });
        modelBuilder.Entity<Pedido>()
                .HasMany(e => e.Produtos)
                .WithMany(e => e.Pedidos)
                .UsingEntity<Item>();
    }
}