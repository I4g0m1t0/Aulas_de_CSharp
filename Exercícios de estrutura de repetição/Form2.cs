using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_de_estrutura_de_repetição
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txb_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorbase = int.Parse(txb_base.Text);
            int expoente = int.Parse(txb_exp.Text);
            int resultado = 1;

            for (int i = 0; i < expoente; i++)
            {
                resultado *= valorbase;
            }
            txb_resultado.Text = resultado.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_base.Clear();
            txb_exp.Clear();
            txb_resultado.Clear();
        }
    }
}
