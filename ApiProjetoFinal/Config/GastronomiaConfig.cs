using ApiProjetoFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjetoFinal.Config
{
    public class GastronomiaConfig : IEntityTypeConfiguration<Gastronomia>
    {
        public void Configure(EntityTypeBuilder<Gastronomia> builder)
        {

        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Tipo).HasMaxLength(20).IsRequired();
        builder.Property(x => x.Endereco).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Informacao).IsRequired();
        builder.Property(x => x.Aberto).IsRequired();
        builder.Property(x => x.Fechado).IsRequired();

        }
    }
}
