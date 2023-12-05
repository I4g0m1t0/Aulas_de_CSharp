using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Receita
{
    public partial class FormReceita : Form
    {
        public FormReceita()
        {
            InitializeComponent();
        }
        Receita objreceita = new Receita();
        private void btnCadastrarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                objreceita.nome = txtNome.Text;
                objreceita.calorias = Convert.ToInt16(txtCalorias.Text);
                objreceita.dtcadastro = dtpCadastro.Value;
                if (redbSaudavel.Checked)
                    objreceita.saudavel = true;
                lstReceita.Items.Add(objreceita.nome);
                lstReceita.Items.Add(objreceita.dtcadastro);
                if (objreceita.saudavel == true)
                    lstReceita.Items.Add("Receita Saudável");
                else
                    lstReceita.Items.Add("Receita Ruim");
                lstReceita.Items.Add("=====INGREDIENTES=====");
                
                // Mostra os ingrediente conforme a qtde cadastrada
                foreach (var item in objreceita.Ingredientes)
                {
                    lstReceita.Items.Add(item);
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Inclusão");
            }
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            objreceita.Ingredientes.Add(txtIngrediente.Text);
            
            txtIngrediente.Text = "";
          

        }
    }
}
