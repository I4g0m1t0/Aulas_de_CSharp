using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mega_sena_chatgpt
{
    public partial class Form1 : Form
    {

        private List<Button> numerosSelecionados = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            InicializarNumeros();
        }

        private void InicializarNumeros()
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

        private void Numero_Click(object sender, EventArgs e)
        {
            Button numero = (Button)sender;

            if (numerosSelecionados.Contains(numero))
            {
                numerosSelecionados.Remove(numero);
                numero.BackColor = DefaultBackColor;
            }
            else
            {
                // Verifica se o limite de 6 números já foi atingido
                if (numerosSelecionados.Count < 6)
                {
                    numerosSelecionados.Add(numero);
                    numero.BackColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    // Se o limite foi atingido, informa ao usuário que não pode selecionar mais números
                    MessageBox.Show("Você pode selecionar no máximo 6 números.", "Aviso");
                }
            }
        }

        private void btn_sortear_Click(object sender, EventArgs e)
        {
            List<int> numerosSorteados = SortearNumeros(6);

            // Exibir os números sorteados em um rótulo ou caixa de texto
            lblResultadoSorteio.Text = $"Números sorteados: {string.Join(", ", numerosSorteados)}";

            // Verificar se o usuário acertou os números
            VerificarAcertos(numerosSorteados);
        }

        private void VerificarAcertos(List<int> numerosSorteados)
        {
            int acertos = numerosSelecionados.Count(numero => numerosSorteados.Contains(int.Parse(numero.Text)));

            MessageBox.Show($"Você acertou {acertos} números!", "Resultado");
        }

        private List<int> SortearNumeros(int quantidade)
        {
            List<int> numerosDisponiveis = Enumerable.Range(1, 60).ToList();
            List<int> numerosSorteados = new List<int>();
            Random random = new Random();

            for (int i = 0; i < quantidade; i++)
            {
                int indiceSorteado = random.Next(0, numerosDisponiveis.Count);
                int numeroSorteado = numerosDisponiveis[indiceSorteado];
                numerosDisponiveis.RemoveAt(indiceSorteado);
                numerosSorteados.Add(numeroSorteado);
            }

            return numerosSorteados;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnLimparSelecao_Click(object sender, EventArgs e)
        //{
        //    // Limpar a seleção dos números escolhidos
        //    foreach (Button numero in numerosSelecionados)
        //    {
        //        numero.BackColor = DefaultBackColor;
        //    }
        //    numerosSelecionados.Clear();
        //}
    }
}