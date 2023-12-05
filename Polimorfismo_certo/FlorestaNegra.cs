using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo_certo
{
    public class FlorestaNegra : Bolo
    {
        public int qtdeCerejas { get; set; }
        public override void calcularPreco()
        {
            this.preco = preco * 1.20;
        }
    }
}