namespace Variaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;

            nome = txt_Nome.Text;

            MessageBox.Show("Olá" + " " + nome + "!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txt_Numero.Text);

            if (num < 0)
                MessageBox.Show("Informou negativo");
            else
                MessageBox.Show("Informou positivo");

        }
    }
}