using ApiProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjetoFinal.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Atracoes> Atracoes { get; set; }
        public DbSet<Comercio> Comercios { get; set; }
        public DbSet<Gastronomia> Gastronomia { get; set; }
        public DbSet<Hospedagem> Hospedagens { get; set; }
    }
}
