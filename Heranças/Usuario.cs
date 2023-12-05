using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    internal class Usuario
    {
        public string nome { get; set; }
        public int matricula { get; set; }
        public string endereco { get; set; }
        public DateTime dt_nasc { get; set; }

        public Usuario()
        {
            this.nome = string.Empty;
            this.matricula = 0;
            this.endereco = string.Empty;
            this.dt_nasc = DateTime.Today;
        }
    }
}
