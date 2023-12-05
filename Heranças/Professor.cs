using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    internal class Professor:Usuario
    {
        public string carga_horaria { get; set; }

        public Professor()
        {
            this.carga_horaria = string.Empty;
        }
    }
}
