namespace _3_botao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            btn_dois.Enabled = true;
            btn_um.Enabled = false;
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            btn_dois.Enabled = false;
            btn_um.Enabled = true;
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                MessageBox.Show("Então Tchauzinho", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}