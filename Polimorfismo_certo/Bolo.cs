using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Polimorfismo_certo
{
    public class Bolo
    {
        public string nome { get; set; }

        public double preco { get; set; }

        public Image foto { get; set; }
        
        public Bolo()
        {
            this.preco = 100;
            this.nome = "";
            
        }


        public virtual void calcularPreco()
        {
            this.preco = 100;
        }
    }
}