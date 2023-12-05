namespace comobobox_dependente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmb_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_1.Items.Clear();
            cmb_2.Items.Clear();

            if (cmb_categorias.Text == "Comprimento")
            {
                cmb_1.Items.Add("Metro");
                cmb_2.Items.Add("Metro");
            }
        }
    }
}