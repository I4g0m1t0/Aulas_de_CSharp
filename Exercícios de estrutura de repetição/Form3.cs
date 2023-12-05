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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txb_1.Text);
            int par = int.Parse(txb_par.Text);
            int impar = int.Parse(txb_impar.Text);


            if (num1 % 2 == 0)
            {
                par += 1;
                txb_par.Text = par.ToString();

            }
            else
            {
                impar += 1;
                txb_impar.Text = impar.ToString();
            }


        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_1.Clear();
            txb_par.Text = "0";
            txb_impar.Text = "0";
        }
    }
}
