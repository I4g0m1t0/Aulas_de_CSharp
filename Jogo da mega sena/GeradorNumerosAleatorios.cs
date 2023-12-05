using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_mega_sena
{
    public class GeradorNumerosAleatorios
    {
        private int[] numerosGerados;

        public int[] NumerosGerados
        {
            get { return numerosGerados; }
            private set { numerosGerados = value; }
        }

        public void GerarNumeros()
        {
            int[] numeros = new int[6];
            Random random = new Random();
            int aleatorio;

            for (int i = 0; i < 6; i++)
            {
                aleatorio = random.Next(1, 61);
                while (numeros.Contains(aleatorio))
                {
                    aleatorio = random.Next(1, 61);
                }
                numeros[i] = aleatorio;
            }

            NumerosGerados = numeros;
        }
    }
}
