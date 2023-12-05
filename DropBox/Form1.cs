namespace DropBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            rb_calabresa.Checked = false;
            rb_4queijos.Checked = false;
            rb_frango.Checked = false;
            rb_chocolate.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_calabresa.Checked = false;
            rb_4queijos.Checked = false;
            rb_frango.Checked = false;
            rb_chocolate.Checked = false;
        }

        private void rb_calabresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_calabresa.Checked)
            {
                lbl_pizza.Text = "Calabresa";
                pictureBox1.Image = imageList1.Images[2];
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rb_4queijos_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_4queijos.Checked)
            {
                lbl_pizza.Text = "4 Queijos";
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void rb_frango_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_frango.Checked)
            {
                lbl_pizza.Text = "Frango c/ Catupiry";
                pictureBox1.Image = imageList1.Images[1];
            }
        }

        private void rb_chocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_chocolate.Checked)
            {
                lbl_pizza.Text = "Chocolate";
                pictureBox1.Image = imageList1.Images[3];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rb_4queijos.Checked = false;
            rb_chocolate.Checked = false;
            rb_frango.Checked = false;
            rb_calabresa.Checked = false;

            ckb_agua.Checked = false;
            ckb_refri.Checked = false;
            ckb_soda.Checked = false;
            ckb_suco.Checked = false;

            lbl_adicional.Text = string.Empty;
            lbl_bebida.Text = string.Empty;
            lbl_pgto.Text = string.Empty;
            lbl_pizza.Text = string.Empty;



            msk_cpf.Text = string.Empty;

            pictureBox1.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ckb_agua_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_agua.Checked)
            {
                lbl_bebida.Text += "Água  ";
            }

        }

        private void ckb_refri_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_refri.Checked)
            {
                lbl_bebida.Text += "Refri lata  ";
            }
        }

        private void ckb_soda_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_soda.Checked)
            {
                lbl_bebida.Text += "Soda Italiana  ";
            }
        }

        private void ckb_suco_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_suco.Checked)
            {
                lbl_bebida.Text += "Suco  ";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                lbl_adicional.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_pgto.Text = comboBox1.SelectedItem.ToString();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}