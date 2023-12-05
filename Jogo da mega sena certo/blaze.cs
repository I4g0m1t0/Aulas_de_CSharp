using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Jogo_da_mega_sena_certo
{
    public class Blaze
    {
        private readonly List<Button> numerosSelecionados = new List<Button>();
        private readonly FlowLayoutPanel flowLayoutPanelNumeros;
        private readonly Label lblResultadoSorteio;
        private readonly ComboBox comboBoxQuantidadeNumeros;
        private readonly Random random = new Random();

        public Blaze(FlowLayoutPanel flowLayoutPanelNumeros, Label lblResultadoSorteio, ComboBox comboBoxQuantidadeNumeros)
        {
            this.flowLayoutPanelNumeros = flowLayoutPanelNumeros;
            this.lblResultadoSorteio = lblResultadoSorteio;
            this.comboBoxQuantidadeNumeros = comboBoxQuantidadeNumeros;
        }
        
        public void InicializarNumeros()
        {
            for (int i = 1; i <= 60; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Width = 40;
                button.Height = 40;
                button.Click + Numero_Click;
                flowLayoutPanelNumeros.Controls.Add(button);
            }
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            Button numero = (Button)sender;

            if (numerosSelecionados.Contains(numero))
            {
                numerosSelecionados.Remove(numero);
                numero.BackColor = Color.GreenYellow;
            }
            else
            {
                int quantidadeMaxima = Convert.ToInt32(comboBoxQuantidadeNumeros.SelectedItem);
                if (numerosSelecionados.Count < quantidadeMaxima)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = Color.Yellow;
                }
                else
                {
                    MessageBox.Show($"Você pode selecionar no máximo {quantidadeMaxima} números.", "Aviso");
                }
            }
        }

        public void ConfirmarAposta()
        {
            int quantidadeNumerosSelecionados = numerosSelecionados.Count;
            double valorAposta = CalcularValorAposta(quantidadeNumerosSelecionados);

            if (quantidadeNumerosSelecionados >= 6 && quantidadeNumerosSelecionados <= 20)
            {
                string mensagemConfirmacao = $"Você confirma a aposta com {quantidadeNumerosSelecionados} números?\nValor da aposta: R$ {valorAposta:F2}";
                DialogResult resultado = MessageBox.Show(mensagemConfirmacao, "Confirmação", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    List<int> numerosSorteados = SortearNumeros(6);
                    lblResultadoSorteio.Text = $"Números sorteados: {string.Join(", ", numerosSorteados)}";
                    ExibirResultado(numerosSorteados);
                }
            }
            else
            {
                MessageBox.Show("A quantidade de números selecionados deve estar entre 6 e 20.", "Aviso");
            }
        }

        public void LimparAposta()
        {
            foreach (Button numero in numerosSelecionados)
            {
                numero.BackColor = Color.GreenYellow;
            }

            numerosSelecionados.Clear();

            comboBoxQuantidadeNumeros.SelectedItem = null;

            lblResultadoSorteio.Text = string.Empty;

            comboBoxQuantidadeNumeros.Enabled = true;
        }

        private void ExibirResultado(List<int> numerosSorteados)
        {            
            int acertos = numerosSelecionados.Count(numero => numerosSorteados.Contains(int.Parse(numero.Text)));
            MessageBox.Show($"Você acertou {acertos} números dos 6 sorteados.", "Resultado");
        }

        private double CalcularValorAposta(int quantidadeNumerosSelecionados)
        {
            switch (quantidadeNumerosSelecionados)
            {
                case 6: return 5.00;
                case 7: return 35.00;
                case 8: return 140.00;
                case 9: return 420.00;
                case 10: return 1050.00;
                case 11: return 2310.00;
                case 12: return 4620.00;
                case 13: return 8580.00;
                case 14: return 15015.00;
                case 15: return 25025.00;
                case 16: return 40040.00;
                case 17: return 61880.00;
                case 18: return 92820.00;
                case 19: return 135660.00;
                case 20: return 193800.00;
                default: return 0.00;
            }
        }

        private List<int> SortearNumeros(int quantidade)
        {
            List<int> numerosDisponiveis = Enumerable.Range(1, 60).ToList();
            List<int> numerosSorteados = new List<int>();

            for (int i = 0; i < quantidade; i++)
            {
                int indiceSorteado = random.Next(0, numerosDisponiveis.Count);
                int numeroSorteado = numerosDisponiveis[indiceSorteado];
                numerosDisponiveis.RemoveAt(indiceSorteado);
                numerosSorteados.Add(numeroSorteado);
            }

            numerosSorteados.Sort();

            return numerosSorteados;
        }
    }
}
