using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranças
{
    internal class Ingles : Professor
    {
        public string ingles { get; set; }

        public Ingles() 
        { 
            this.ingles = string.Empty;
        }
    }
}
