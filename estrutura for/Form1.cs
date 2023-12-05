namespace estrutura_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int num, cont, tab;
            num = Convert.ToInt16(txbNum.Text);
            for (cont = 0; cont <= 10; cont++)
            {
                tab = num * cont;
                ltbTabuada.Items.Add(num.ToString() + " * " + cont.ToString() + " = " +
               tab.ToString());
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbTabuada.Items.Clear();
            txbNum.Clear();
        }

        private void btn_impares_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(txbNum.Text);
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    ltbTabuada.Items.Add(i.ToString());
                }
            }
        }

        private void btn_fatorial_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(txbNum.Text);
            for (int i = num - 1; i > 0; i--)
            {
                num *= i;
            }
            ltbTabuada.Items.Add(num);
        }
    }
}