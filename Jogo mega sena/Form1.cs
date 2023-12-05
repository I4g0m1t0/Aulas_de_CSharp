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
        public partial class Form1 : Form
        {
            private Blaze jogo;

            public Form1()
            {
                InitializeComponent();
                InicializarJogo();
                Load += Form1_Load; // Adicionando o manipulador de eventos diretamente
            }

            private void InicializarJogo()
            {
                jogo = new JogoBingo(flowLayoutPanelNumeros, lblResultadoSorteio);
                jogo.InicializarNumeros();
            }

            private void btn_sortear_Click(object sender, EventArgs e)
            {
                jogo.SortearENotificar();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                // Lógica a ser executada no carregamento do formulário
            }
        }
    }