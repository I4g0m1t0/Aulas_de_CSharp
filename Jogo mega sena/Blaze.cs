using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mega_sena_chatgpt
{
    public class Blaze
    {
        private readonly List<Button> numerosSelecionados = new List<Button>();
        private readonly FlowLayoutPanel flowLayoutPanelNumeros;
        private readonly Label lblResultadoSorteio;

        public Blaze(FlowLayoutPanel flowLayoutPanelNumeros, Label lblResultadoSorteio) 
        { 
            this.flowLayoutPanelNumeros = flowLayoutPanelNumeros;
            this.lblResultadoSorteio = lblResultadoSorteio;
        }

        public void InicializarNumeros()
        {
            for (int i = 1; i <= 60; i++) 
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Width = 40;
                button.Height = 40;
                button.Click += Numero_Click;
                flowLayoutPanelNumeros.Controls.Add(button);
            }
        }

        private void Numero_click (object sender, EventArgs e)
        {
            Button numero = (Button)sender;

            if (numerosSelecionados.Contains(numero))
            {
                numerosSelecionados.Add(numero);
                numero.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                if (numerosSelecionados.Count == 6)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 6 números.\nValor da aposta: R$ 5,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 7)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 7 números.\nValor da aposta: R$ 35,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 8)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 8 números.\nValor da aposta: R$ 140,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 9)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 9 números.\nValor da aposta: R$ 420,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 10)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 10 números.\nValor da aposta: R$ 1.050,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 11)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 11 números.\nValor da aposta: R$ 2.310,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 12)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 12 números.\nValor da aposta: R$ 4.620,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 13)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 13 números.\nValor da aposta: R$ 8.580,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 14)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 14 números.\nValor da aposta: R$ 15.015,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 15)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 15 números.\nValor da aposta: R$ 25.025,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 16)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 16 números.\nValor da aposta: R$ 40.040,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 17)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 17 números.\nValor da aposta: R$ 61.880,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 18)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 18 números.\nValor da aposta: R$ 92.820,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 19)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 19 números.\nValor da aposta: R$ 135.660,00", "Aviso");
                }
                else if (numerosSelecionados.Count == 20)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Você selecionou 20 números.\nValor da aposta: R$ 193.800,00", "Aviso");
                }
                else if (numerosSelecionados.Count < 6)
                {
                    MessageBox.Show("Você precisa selecionar no mínimo 6 números.", "Aviso");
                }
                else if (numerosSelecionados.Count > 20)
                {
                    MessageBox.Show("Você pode selecionar no máximo 20 números.", "Aviso");
                }
            }
        }

        public void SortearENotificar()
        {
            List<int> numerosSorteados = SortearNumeros(6);
            lblResultadoSorteio.Text = $"Números sorteados: {string.Join(",", numerosSorteados)}";
        }

        private void VerificarAcertos (List<int> numeros )
        {

        }
    }
}
