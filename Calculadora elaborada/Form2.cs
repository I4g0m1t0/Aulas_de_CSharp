using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_elaborada
{
    public partial class Form2 : Form
    {
        private double valor1 = 0;
        private double resultado = 0;
        private string operacao = "";
        private bool operadorPressionado = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void verificaLabel()
        {
            if (operacao != "" && txtVisor.Text == null)
            {
                // Se o botão de operação foi clicado e o texto do txtVisor é nulo (vazio).
            
                MessageBox.Show("Você deve inserir valores antes fazer contas");
            }
        }
        private void btn_igual_Click(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            if (operadorPressionado)
            {
                txtVisor.Text = btn.Text;
                operadorPressionado = false;
            }
            else
            {
                txtVisor.Text += btn.Text;
            }
        }

        private void btnOperacao_Click(object sender, MouseEventArgs e)
        {

            if (!operadorPressionado && txtVisor.Text != "")
            {
                Button btn = (Button)sender;

                if (valor1 == 0)
                {
                    valor1 = double.Parse(txtVisor.Text);
                }
                else
                {
                    CalcularResultado();
                }

                operacao = btn.Text;
                lbl_operacao.Text = operacao;
                operadorPressionado = true;
            }
        }

        private void CalcularResultado()
        {
            double valor2 = double.Parse(txtVisor.Text);

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "÷":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("Erro: Divisão por zero!");
                        LimparCalculadora();
                        return;
                    }
                    break;
                case "x²":
                    resultado = Math.Pow(valor1, valor2);
                    break;
                case "%":
                    resultado = valor1 * (valor2 / 100);
                    break;
            }

            txtVisor.Text = resultado.ToString();
            valor1 = resultado;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!operadorPressionado)
            {
                CalcularResultado();
                lbl_operacao.Text = "";
                operadorPressionado = true;
            }
            
        }

        private void LimparCalculadora()
        {
            valor1 = 0;
            resultado = 0;
            operacao = "";
            lbl_operacao.Text = "";
            txtVisor.Clear();
            operadorPressionado = false;
        }

        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtVisor.Text);
            txtVisor.Text = Math.Sqrt(valor).ToString();
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtVisor.Text);
            // double numeroEmRadianos = valor * Math.PI / 180; convrte em graus
            txtVisor.Text = Math.Sin(valor).ToString();
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtVisor.Text);
            txtVisor.Text = Math.Cos(valor).ToString();
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtVisor.Text);
            txtVisor.Text = Math.Tan(valor).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtVisor.Text);
            txtVisor.Text = Math.Log10(valor).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            operacao = "";
            valor1 = 0;
            lbl_operacao.Text = operacao;

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_operacao_Click(object sender, EventArgs e)
        {
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "+";
        }

        private void btn_subtrai_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "-";
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "x";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "÷";
        }

        private void btn_aoquadrado_Click(object sender, EventArgs e)
        {
            lbl_operacao.Text = "^";
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + ",";
        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            operacao = "%";
            valor1 = double.Parse(txtVisor.Text);
            txtVisor.Clear();
            lbl_operacao.Text = operacao;
        }

        private void btn_parentese_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text.Length > 0)
            {
                double valorAtual = double.Parse(txtVisor.Text);
                valorAtual = -valorAtual; // Inverte o sinal do número
                txtVisor.Text = valorAtual.ToString();
            }
        }
    }
}
