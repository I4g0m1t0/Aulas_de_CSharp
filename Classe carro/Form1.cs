namespace Classe_carro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 carro = new Form2();
            carro.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnimal formAnimal = new FormAnimal();
            formAnimal.Show();
        }
    }
}