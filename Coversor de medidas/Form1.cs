using System.CodeDom.Compiler;

namespace Coversor_de_medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            if (cmb_de.SelectedItem.ToString() == "Cent�metros" & cmb_para.SelectedItem.ToString() == "Cent�metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) * 1;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Cent�metros" & cmb_para.SelectedItem.ToString() == "Metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) / 100;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Cent�metros" & cmb_para.SelectedItem.ToString() == "Quil�metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) / 100000;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Metros" & cmb_para.SelectedItem.ToString() == "Cent�metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) * 100;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Metros" & cmb_para.SelectedItem.ToString() == "Metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) * 1;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Metros" & cmb_para.SelectedItem.ToString() == "Quil�metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) / 1000;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Quil�metros" & cmb_para.SelectedItem.ToString() == "Cent�metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) * 100000;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Quil�metros" & cmb_para.SelectedItem.ToString() == "Metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) * 1000;
                txt_resultado.Text = conversao.ToString();
            }
            else if (cmb_de.SelectedItem.ToString() == "Quil�metros" & cmb_para.SelectedItem.ToString() == "Quil�metros")
            {
                double conversao;
                conversao = double.Parse(txt_entrada.Text) * 1;
                txt_resultado.Text = conversao.ToString();
            }
        }
        private void cmb_de_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_para_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}