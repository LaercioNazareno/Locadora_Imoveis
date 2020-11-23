
using Microsoft.EntityFrameworkCore;
using locadora.Models;

namespace locadora.Data
{
    public class LocadoraContext: DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
        {
        }
        public DbSet<Locador> Locador { get; set; }
        public DbSet<Locatario> Locatario { get; set; }
        public DbSet<Cobranca> Cobranca { get; set; }
        public DbSet<Imovel> Imovel { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locador>().ToTable("Locador");
            modelBuilder.Entity<Locatario>().ToTable("Locatario");
            modelBuilder.Entity<Cobranca>().ToTable("Cobranca");
            modelBuilder.Entity<Imovel>().ToTable("Imovel");
            modelBuilder.Entity<Contrato>().ToTable("Contrato");
        }
    }
}