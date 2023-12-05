namespace Vetor_caracteres
{
    public partial class Form1 : Form
    {
        int contadorMaiusculos = 0;
        int contadorMinusculos = 0;
        int contadorEspeciais = 0;
        int contadorNumeros = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            string texto = txb_texto.Text;
            contadorMaiusculos = 0;
            contadorMinusculos = 0;
            contadorEspeciais = 0;
            contadorNumeros = 0;

            foreach (char caractere in texto)
            {
                if (char.IsUpper(caractere))
                {
                    contadorMaiusculos++;
                }

                else if (char.IsLower(caractere))
                {
                    contadorMinusculos++;
                }

                else if (char.IsDigit(caractere))
                {
                    contadorNumeros++;
                }

                else
                {
                    contadorEspeciais++;
                }
            }

            lbl_maiusc.Text = contadorMaiusculos.ToString();
            lbl_minusc.Text = contadorMinusculos.ToString();
            lbl_num.Text = contadorNumeros.ToString();
            lbl_especial.Text = contadorEspeciais.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_especial.Text = "";
            lbl_maiusc.Text = "";
            lbl_minusc.Text = "";
            lbl_num.Text = "";
            txb_texto.Clear();

            contadorMaiusculos = 0;
            contadorMinusculos = 0;
            contadorEspeciais = 0;
            contadorNumeros = 0;
        }
    }
}