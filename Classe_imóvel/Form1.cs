namespace Classe_imóvel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        Imovel[] objImovel = new Imovel[10];


        private void Limpar()
        {
            txb_nome.Text = string.Empty;
            txb_loc.Text = string.Empty;
            txb_metros.Text = string.Empty;
            txb_preco.Text = string.Empty;
            txb_dono.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void Limpar2()
        {
            lbl_cadastro.Text = string.Empty;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objImovel[i] = new Imovel();

                objImovel[i].setNome(txb_nome.Text);
                objImovel[i].setLocalizacao(txb_loc.Text);
                objImovel[i].setMetragem(Convert.ToDouble(txb_metros.Text));
                objImovel[i].setPreco(Convert.ToDouble(txb_preco.Text));
                objImovel[i].setDono(txb_dono.Text);
                objImovel[i].setDt_Construcao(dateTimePicker1.Value);

                lbl_cadastro.Text = ("Nome: " + objImovel[i].getNome());
                lbl_cadastro.Text += ("\nLocalização: " + objImovel[i].getLocalizacao());
                lbl_cadastro.Text += ("\nMetragem: " + objImovel[i].getMetragem() + "m²");
                lbl_cadastro.Text += ("\nPreço: R$ " + objImovel[i].getPreco());
                lbl_cadastro.Text += ("\nDono: " + objImovel[i].getDono());
                lbl_cadastro.Text += ("\nData de construção: " + objImovel[i].getDt_Construcao());

                Limpar();

                i++;
            }
            catch
            {
                MessageBox.Show("Errou, cego");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objImovel[i].diminuir_preco();

            lbl_cadastro.Text = ("Nome: " + objImovel[i].getNome());
            lbl_cadastro.Text += ("\nLocalização: " + objImovel[i].getLocalizacao());
            lbl_cadastro.Text += ("\nMetragem: " + objImovel[i].getMetragem() + "m²");
            lbl_cadastro.Text += ("\nPreço: R$ " + objImovel[i].getPreco());
            lbl_cadastro.Text += ("\nDono: " + objImovel[i].getDono());
            lbl_cadastro.Text += ("\nData de construção: " + objImovel[i].getDt_Construcao());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objImovel[i].diminuir_preco2();

            lbl_cadastro.Text = ("Nome: " + objImovel[i].getNome());
            lbl_cadastro.Text += ("\nLocalização: " + objImovel[i].getLocalizacao());
            lbl_cadastro.Text += ("\nMetragem: " + objImovel[i].getMetragem() + "m²");
            lbl_cadastro.Text += ("\nPreço: R$ " + objImovel[i].getPreco());
            lbl_cadastro.Text += ("\nDono: " + objImovel[i].getDono());
            lbl_cadastro.Text += ("\nData de construção: " + objImovel[i].getDt_Construcao());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objImovel[i].aumentar_preco();

            lbl_cadastro.Text = ("Nome: " + objImovel[i].getNome());
            lbl_cadastro.Text += ("\nLocalização: " + objImovel[i].getLocalizacao());
            lbl_cadastro.Text += ("\nMetragem: " + objImovel[i].getMetragem() + "m²");
            lbl_cadastro.Text += ("\nPreço: R$ " + objImovel[i].getPreco());
            lbl_cadastro.Text += ("\nDono: " + objImovel[i].getDono());
            lbl_cadastro.Text += ("\nData de construção: " + objImovel[i].getDt_Construcao());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objImovel[i].aumentar_preco2();

            lbl_cadastro.Text = ("Nome: " + objImovel[i].getNome());
            lbl_cadastro.Text += ("\nLocalização: " + objImovel[i].getLocalizacao());
            lbl_cadastro.Text += ("\nMetragem: " + objImovel[i].getMetragem() + "m²");
            lbl_cadastro.Text += ("\nPreço: R$ " + objImovel[i].getPreco());
            lbl_cadastro.Text += ("\nDono: " + objImovel[i].getDono());
            lbl_cadastro.Text += ("\nData de construção: " + objImovel[i].getDt_Construcao());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpar2();

            if (objImovel[0] == null)
            {
                lbl_cadastrado.Text = string.Empty;
                lbl_cadastrado.Text = "Sem Registros de Imóveis";
            }
            else
            {
                for (int i = 0; i < objImovel.Length; i++)
                {
                    if (i == 0)
                    {
                        lbl_cadastrado.Text = "Nome: " + objImovel[i].getNome();
                        lbl_cadastrado.Text += "  Localização: " + objImovel[i].getLocalizacao();
                        lbl_cadastrado.Text += "  Metragem: " + objImovel[i].getMetragem() + "m²";
                        lbl_cadastrado.Text += "  Preço: R$ " + objImovel[i].getPreco();
                        lbl_cadastrado.Text += "  Dono: " + objImovel[i].getDono();
                        lbl_cadastrado.Text += "  Data de construção: " + objImovel[i].getDt_Construcao();
                    }
                    else if (i != 0 && objImovel[i] != null)
                    {
                        lbl_cadastrado.Text += "\nNome: " + objImovel[i].getNome();
                        lbl_cadastrado.Text += "  Localização: " + objImovel[i].getLocalizacao();
                        lbl_cadastrado.Text += "  Metragem: " + objImovel[i].getMetragem() + "m²";
                        lbl_cadastrado.Text += "  Preço: R$ " + objImovel[i].getPreco();
                        lbl_cadastrado.Text += "  Dono: " + objImovel[i].getDono();
                        lbl_cadastrado.Text += "  Data de construção: " + objImovel[i].getDt_Construcao();
                    }


                }
            }
        }
    }
}