using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo_certo
{
    public class Nozes : Bolo
    {
        public int qtdeNozes { get; set; }
        
        public override void calcularPreco()
        {
            this.preco = this.preco * 1.40 ;
        }
    }
}