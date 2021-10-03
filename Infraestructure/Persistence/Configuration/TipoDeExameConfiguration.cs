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
    class TipoDeExameConfiguration : IEntityTypeConfiguration<TipoDeExame>
    {
        public void Configure(EntityTypeBuilder<TipoDeExame> builder)
        {
            builder
                .HasKey(e => e.Id);
            builder
                 .Property(e => e.NomeDoTipo)
                .HasMaxLength(100);
            builder
                 .Property(e => e.Descricao)
                .HasMaxLength(256);
        }
    }
}
