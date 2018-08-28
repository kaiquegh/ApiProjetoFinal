using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProjetoFinal.Models
{
    public class Comercio
    {
        
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Informacao { get; set; }
        public string Nome { get; set; }
        public DateTime Aberto { get; set; }
        public DateTime Fechado { get; set; }
        public string Tipo { get; set; }

    }
}
