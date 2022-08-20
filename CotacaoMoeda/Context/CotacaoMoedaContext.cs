using CotacaoMoeda.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Context
{
    public class CotacaoMoedaContext : DbContext
    {
        public CotacaoMoedaContext(DbContextOptions<CotacaoMoedaContext> moeda) : base(moeda) { }

        public DbSet<Cotacao> Cotacao { get; set; }
        public DbSet<Moeda> Moeda { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai2;User Id=postgres;Password=admin;");
        }
    }
}
