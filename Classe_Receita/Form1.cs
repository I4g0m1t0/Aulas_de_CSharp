namespace Classe_Receita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReceita_Click(object sender, EventArgs e)
        {
            FormReceita dois = new FormReceita();   
            dois.ShowDialog();

        }
    }
}