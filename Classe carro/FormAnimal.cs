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
    public partial class FormAnimal : Form
    {

        public FormAnimal()
        {
            InitializeComponent();

        }
        Animal objCarro = new Animal();

        private void FormAnimal_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // atribuir valr aos atributos com os set's
                objCarro.setNome(txb_nome.Text);
                objCarro.setPeso(Convert.ToInt16(txb_peso.Text));
                objCarro.setPreco(Convert.ToInt16(txb_peso.Text));
                objCarro.setCor(cmb_cor.Text);
                if (cmb_castrado.Text == "sim")
                {
                    objCarro.setCastrado(true);
                }
                else
                {
                    objCarro.setCastrado(false);
                }
                objCarro.setdataObito(dt_obito.Value);
                objCarro.setdataNasc(dateTimePicker1.Value);

                // acessando os métodos get's
                lbl_cadastro.Text = ("Nome: " + objCarro.getNome());
                lbl_cadastro.Text += ("\nPeso: " + objCarro.getPeso());
                lbl_cadastro.Text += ("\nPreço: " + objCarro.getPreco());
                lbl_cadastro.Text += ("\nCor: " + objCarro.getCor());
                if (objCarro.getCastrado())
                {
                    lbl_cadastro.Text += "\nCastrado: Sim";
                }
                else
                {
                    lbl_cadastro.Text += "\nCastrado: Não";
                }
                lbl_cadastro.Text += ("\nData de nascimento: " + objCarro.getdataNasc());
                lbl_cadastro.Text += ("\nData de óbito: " + objCarro.getdataObito());
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Inclusão");
            }
        }

        private void cmb_castrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
