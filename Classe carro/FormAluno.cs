using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_carro
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }
        int i = 0;
        Aluno[] objCarro_array = new Aluno[10];

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            double media;
            double nota1;
            double nota2;

            nota1 = Convert.ToDouble(txb_nota1.Text);
            nota2 = Convert.ToDouble(txb_nota2.Text);

            media = (nota1 + nota2) / 2;

            try
            {
                // Construtor
                objCarro_array[i] = new Aluno();
                // atribuir valr aos atributos com os set's
                objCarro_array[i].setNome(txb_nome.Text);
                objCarro_array[i].setSexo(cmb_sexo.Text);
                objCarro_array[i].setNota1(txb_nota1.Text);
                objCarro_array[i].setNota2(txb_nota2.Text);
                objCarro_array[i].setCurso(cmb_curso.Text);
                objCarro_array[i].setdataNasc(dateTimePicker1.Value);

                // acessando os métodos get's
                lbl_cadastro.Text = ("Nome: " + objCarro_array[i].getnome());
                lbl_cadastro.Text += ("\nSexo: " + objCarro_array[i].getSexo());
                lbl_cadastro.Text += ("\nNota 1: " + objCarro_array[i].getNota1());
                lbl_cadastro.Text += ("\nNota 2: " + objCarro_array[i].getNota2());
                lbl_cadastro.Text += ("\nMédia: " + media);
                lbl_cadastro.Text += ("\nCurso: " + objCarro_array[i].getCurso());
                lbl_cadastro.Text += ("\nData de nascimento: " + objCarro_array[i].getdataNasc());
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Inclusão");
            }

        }
    }
}
