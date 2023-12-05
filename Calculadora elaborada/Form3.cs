using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_elaborada
{
    public partial class Form3 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + "9";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = txt_resultado.Text + ".";
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {

                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture); //converte o texto para valor1
                txt_resultado.Text = "";
                operacao = "Soma";
                lbl_operacao.Text = "+";

            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "Soma")
            {
                txt_resultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Subtrai")
            {
                txt_resultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "Multiplica")
            {
                txt_resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "Divide")
            {
                txt_resultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "Potencia")
            {
                txt_resultado.Text = Convert.ToString(valor1 * valor1);
            }

            lbl_operacao.Text = string.Empty;

        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture); //converte o texto para valor1
                txt_resultado.Text = "";
                operacao = "Subtrai";
                lbl_operacao.Text = "-";

            }
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {

                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture); //converte o texto para valor1
                txt_resultado.Text = "";
                operacao = "Multiplica";
                lbl_operacao.Text = "x";

            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            {

                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture); //converte o texto para valor1
                txt_resultado.Text = "";
                operacao = "Divide";
                lbl_operacao.Text = "÷";

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            lbl_operacao.Text = "";
            valor1 = 0;
            valor2 = 0;

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }

        private void btn_aoquadrado_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
            txt_resultado.Text = "";
            operacao = "Potencia";
            lbl_operacao.Text = "²";
        }

        private void btn_parentese_Click(object sender, EventArgs e)
        {

        }
    }
}
