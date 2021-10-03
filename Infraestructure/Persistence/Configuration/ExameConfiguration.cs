using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence.Configuration
{
    class ExameConfiguration : IEntityTypeConfiguration<Exame>
    {
        public void Configure(EntityTypeBuilder<Exame> builder)
        {
            builder
                  .HasKey(e => e.Id);
            builder
                  .Property(e => e.NomeDoExame)
                .HasMaxLength(100);
            builder
                 .Property(e => e.Observacao)
                .HasMaxLength(100);

            builder
                .HasOne(e => e.TipoDeExame)
                .WithMany(t => t.Exames);
        }
    }
}
