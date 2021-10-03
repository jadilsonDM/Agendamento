using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence
{
    public class AgendamentoDbContext : DbContext
    {
        public AgendamentoDbContext(DbContextOptions<AgendamentoDbContext> options) : base(options)
        {

        }

        public DbSet<Exame>  Exames { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<TipoDeExame> TipoDeExames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<TipoDeExame>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<TipoDeExame>()
                .Property(e => e.NomeDoTipo)
                .HasMaxLength(100);
            modelBuilder.Entity<TipoDeExame>()
                .Property(e => e.Descricao)
                .HasMaxLength(256);

            modelBuilder.Entity<Paciente>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Paciente>()
                .Property(e => e.Nome)
                .HasMaxLength(100);                 
                
        }

    }
}
