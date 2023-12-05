using System.Drawing;
using System.Windows.Forms;

namespace Exercício_Temperatura_Vetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] temperatura = new int[10];
        int cont = 0;

        float media;
        int quant = 0;
        int maior;
        int menor;
        float teste;
        int maior_media = 0;
        int menor_media = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            quant++;

            if (cont == 9)// Atingiu o limite do Vetor
            {
                btn_add.Enabled = false;
                txt_temp.Enabled = false;
                txt_temp.Text = "";
            }

            if (cont <= 10 && txt_temp.Text != "")
            {
                temperatura[cont] = Convert.ToInt16(txt_temp.Text);

                txt_temp.Text = null;
                txt_temp.Focus();
                ltb_temp.Items.Add(temperatura[cont].ToString() + "°");
                cont++;
            }
        }

        private void txt_temp_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            int i;

            for (i = 0; i < quant; i++)
            {
                teste += temperatura[i];
                media = teste / quant;
                txt_media.Text = media.ToString();
            }

            for (i = 0; i < quant; i++)
            {
                if (temperatura[i] > media)
                {
                    maior_media++;
                }

                if (temperatura[i] < media)
                {
                    menor_media++;
                }

                if (i == 0)
                {
                    maior = temperatura[0];
                    menor = temperatura[0];
                }

                if (temperatura[i] > maior)
                    maior = temperatura[i];
                if (temperatura[i] < menor)
                    menor = temperatura[i];
            }


            txt_maior.Text = maior.ToString();
            txt_menor.Text = menor.ToString();
            txb_maiormedia.Text = maior_media.ToString();
            txb_menormedia.Text = menor_media.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_maior.Clear();
            txt_menor.Clear();
            txt_media.Clear();
            txb_maiormedia.Clear();
            txb_menormedia.Clear();
            ltb_temp.Items.Clear();
            quant = 0;
        }
    }
}
