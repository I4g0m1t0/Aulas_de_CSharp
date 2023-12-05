namespace Triângulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                double l1, l2, l3; //lados do triângulo
                l1 = Convert.ToDouble(txt_lado1.Text);
                l2 = Convert.ToDouble(txt_lado2.Text);
                l3 = Convert.ToDouble(txt_lado3.Text);
                if ((l1 + l2 >= l3) && (l1 + l3 >= l2) && (l2 + l3 >= l1))//verifica se é triângulo
                {
                    if (l1 == l2 && l2 == l3 && l3 == l1)//lados iguais?
                    {
                        label_resultado.Text = "Triângulo Equilátero";
                        pictureBox1.Image = imageList1.Images[2];
                    }
                    else if (l1 == l2 || l2 == l3 || l3 == l1)// dois lados são iguais?
                    {
                        label_resultado.Text = "Triângulo Isósceles";
                        pictureBox1.Image = imageList1.Images[0];
                    }
                    else if (l1 != l2 && l2 != l3 && l3 != l1)//os lados são diferentes?
                    {
                        label_resultado.Text = "Triângulo Escaleno";
                        pictureBox1.Image = imageList1.Images[1];
                    }
                }
                else
                {
                    label_resultado.Text = "Não é um triângulo";
                }
            }
            catch
            {
                label_resultado.Text = "Error!";
                MessageBox.Show("Insira valores numéricos válidos!", "Erro");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}