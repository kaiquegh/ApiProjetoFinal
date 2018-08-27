using ApiProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjetoFinal.Config
{
    public class ComercioConfig: EntityTypeConfiguration<Comercio>
    {
        public void Configure(EntityTypeBuilder<Comercio> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Tipo).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Endereco).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Informacao).IsRequired();
            builder.Property(x => x.Horario).IsRequired();

        }
    }
}
