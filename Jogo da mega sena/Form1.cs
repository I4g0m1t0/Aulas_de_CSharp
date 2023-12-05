using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_mega_sena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_sorteio_Click(object sender, EventArgs e)
        {
            lbl_numeros.Text = string.Empty;

            // Cria uma instância da classe GeradorNumerosAleatorios
            GeradorNumerosAleatorios gerador = new GeradorNumerosAleatorios();

            // Chama o método para gerar os números aleatórios
            gerador.GerarNumeros();

            // Acesse os números gerados usando a propriedade NumerosGerados
            int[] numerosGerados = gerador.NumerosGerados;

            // Atualiza o texto do rótulo com os números gerados
            lbl_numeros.Text = string.Join(" ", numerosGerados.Select(num => num.ToString()));
        }
        //lbl_numeros.Text = string.Empty;

        //int[] numeros = new int[6];
        //Random random = new Random();
        //int aleatorio;

        //for (int i = 0; i < 6; i++)
        //{
        //    aleatorio = random.Next(1, 61);
        //    while (numeros.Contains(aleatorio))
        //    {
        //        aleatorio = random.Next(1, 61);
        //    }
        //    numeros[i] = aleatorio;
        //    lbl_numeros.Text += numeros[i].ToString() + " ";
        //}
    }
}

