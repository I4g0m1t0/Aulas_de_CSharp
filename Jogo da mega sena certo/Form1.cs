using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_mega_sena_certo
{
    public partial class Form1 : Form
    {
        private Blaze blaze;

        public Form1()
        {
            InitializeComponent();
            InicializarJogo();
        }

        private void InicializarJogo()
        {
            blaze = new Blaze(flowLayoutPanelNumeros, lblResultadoSorteio, comboBoxQuantidadeNumeros);
            blaze.InicializarNumeros();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            blaze.ConfirmarAposta();
        }

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            blaze.LimparAposta();
        }

        private void flowLayoutPanelNumeros_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
