using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo_certo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnBoloBasico_Click(object sender, EventArgs e)
        {
            Bolo novoBolo = new Bolo();
            novoBolo.calcularPreco();
            novoBolo.foto = pictureBox1.Image;
            txtPrecoFinal.Text = novoBolo.preco.ToString("c");

            pictureBox2.Image = novoBolo.foto;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nozes nozes = new Nozes();
            nozes.calcularPreco();
            txtPrecoFinal.Text = nozes.preco.ToString("c");

        }

        private void btn_sensacao_Click(object sender, EventArgs e)
        {
            Sensação sensação = new Sensação();
            sensação.calcularPreco();
            txtPrecoFinal.Text = sensação.preco.ToString("c");
        }

        private void btn_negra_Click(object sender, EventArgs e)
        {
            FlorestaNegra negra = new FlorestaNegra();
            negra.calcularPreco();
            txtPrecoFinal.Text = negra.preco.ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(fileDialog.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
