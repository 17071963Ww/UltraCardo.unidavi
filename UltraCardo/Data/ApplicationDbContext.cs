using Microsoft.EntityFrameworkCore;
using UltraCardo.API.Models;

namespace UltraCardo.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos => Set<Produto>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Frete> Fretes => Set<Frete>();
        public DbSet<Pedido> Pedidos => Set<Pedido>();
    }
}
