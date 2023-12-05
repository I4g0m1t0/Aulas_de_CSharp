namespace pares_no_intervalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int de = Convert.ToInt16(txb_de.Text);
            int para = Convert.ToInt16(txb_para.Text);

            ltb_resultado.Items.Clear();

            if (de > para)
            {
                ltb_resultado.Items.Add("Por favor, não faça isso");
            }
            
            for (int i = de; i <= para; i++)
            {
                
                if (de == para)
                {
                    ltb_resultado.Items.Add("Por favor, adicione valores diferentes");
                }
                else if (i % 2 == 0)
                {

                    ltb_resultado.Items.Add(i.ToString());
                }
            }
        }

        private void bn_limpar_Click(object sender, EventArgs e)
        {
            ltb_resultado.Items.Clear();
            txb_de.Clear();
            txb_para.Clear();
        }
    }
}