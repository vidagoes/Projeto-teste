using Microsoft.EntityFrameworkCore;
using Projeto_teste.Models; // Namespace onde estão os modelos

namespace Projeto_teste.Data
{
    public class Projeto_testeContext : DbContext
    {
        public Projeto_testeContext(DbContextOptions<Projeto_testeContext> options)
            : base(options)
        {
        }

        // Adicione os DbSets para os modelos
        public DbSet<Produtos> Produtos { get; set; }
    }
}
