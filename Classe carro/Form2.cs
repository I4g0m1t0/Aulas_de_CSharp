using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_carro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Criar objeto carro
        Carro objCarro = new Carro(); //chamada do construtor

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // atribuir valr aos atributos com os set's
                objCarro.setPlaca(txb_placa.Text);
                objCarro.setMarca(txb_marca.Text);
                objCarro.setModelo(txb_modelo.Text);
                objCarro.setCor(cmb_cor.Text);
                objCarro.setCombustivel(txb_combustivel.Text);
                objCarro.setPreco(Convert.ToDouble(txb_preco.Text));
                objCarro.setdataCompra(dateTimePicker1.Value);
                objCarro.setnumBatidas(Convert.ToInt16(txb_batidas.Text));
                objCarro.settempoUso(Convert.ToInt16(txb_tempodeUso.Text));

                // acessando os métodos get's
                label11.Text = ("Placa: " + objCarro.getPlaca());
                label11.Text += ("\nMarca: " + objCarro.getMarca());
                label11.Text += ("\nModelo: " + objCarro.getModelo());
                label11.Text += ("\nCor: " + objCarro.getCor());
                label11.Text += ("\nCombustível :" + objCarro.getCombustivel());
                label11.Text += ("\nPreço: " + objCarro.getPreco());
                label11.Text += ("\nNúmero de batidas: " + objCarro.getnumBatidas());
                label11.Text += ("\nTempo de uso: " + objCarro.gettempoUso() + " anos");
                label11.Text += ("\nData da compra: " + objCarro.getdataCompra());
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Inclusão");
            }

        }
    }
}
