using System.Drawing;
using System;

namespace Vetores_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Criando o Vetor
        int[] idades = new int[10];


        //Variáveis Globais
        int cont = 0;//contador

        float media;
        int maior;
        int menor;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIndice.Text = "1º";
            btnInserir.Enabled = false;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cont == 9)// Atingiu o limite do Vetor
            {
                btnInserir.Enabled = false;
                txtNum.Enabled = false;
                txtIndice.Text = "";
            }

            if (cont < 10 && txtNum.Text != "")
            {
                idades[cont] = Convert.ToInt16(txtNum.Text);

                txtNum.Text = null;
                txtNum.Focus(); //dá o foco para o componente
                //Para enfeitar
                if (cont < 10)
                    txtIndice.Text = (cont + 1).ToString() + "º";
                // Inserir o número na listBox
                lsbVetor.Items.Add(idades[cont].ToString());
                //cont = cont + 1;
                cont++;
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
        }













        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i;
            //Calculando a Média das Idades
            for (i = 0; i < 10; i++)
                media = media + idades[i];
            media = media / 10;
            txtMedia.Text = media.ToString();



            // Calculando a maior e a menor idade
            for (i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    maior = idades[0];
                    menor = idades[0];
                }

                if (idades[i] > maior)
                    maior = idades[i];
                if (idades[i] < menor)
                    menor = idades[i];
            }
            txtMaior.Text = maior.ToString();
            txtMenor.Text = menor.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}