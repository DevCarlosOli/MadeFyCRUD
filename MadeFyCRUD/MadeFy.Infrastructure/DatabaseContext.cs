using MadeFy.Domain.Entities;
using System.Data.Entity;

namespace MadeFy.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=MyConnectionString") // Coloque o nome da sua connection string aqui
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
