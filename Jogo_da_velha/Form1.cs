using System.ComponentModel;
using System.Reflection;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        bool turno = true; //quando for true é p1
        int turno_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você precisa fechar 3 casas seguidas em coluna, linha ou na diagonal para ganhar", "Sobre");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turno)

                b.Text = "X";

            else

                b.Text = "O";

            turno = !turno;
            b.Enabled = false;
            turno_count++;
            VerificarGanhador();
        }

        private void VerificarGanhador()
        {
            bool temos_um_vencedor = false;

            //Linhas
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                temos_um_vencedor = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                temos_um_vencedor = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                temos_um_vencedor = true;

            //Colunas
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                temos_um_vencedor = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                temos_um_vencedor = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                temos_um_vencedor = true;

            //Diagonais
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                temos_um_vencedor = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                temos_um_vencedor = true;


            if (temos_um_vencedor)
            {
                desabilitarBotoes();

                string winner = "";

                if (turno)
                {
                    winner = "O";
                    contador_o.Text = (Int32.Parse(contador_o.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    contador_x.Text = (Int32.Parse(contador_x.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Ganhou!", "Oba!");
            }
            else
            {
                if (turno_count == 9)
                {
                    contador_empate.Text = (Int32.Parse(contador_empate.Text) + 1).ToString();
                    MessageBox.Show("Empate!", "Oba!");
                }
            }
        }

        private void desabilitarBotoes()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }


        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turno = true;
            turno_count = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }

        }

        private void mouse_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
                b.Text = "";
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turno)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void reiniciarContadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reiniciarContadorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            contador_o.Text = "0";
            contador_x.Text = "0";
            contador_empate.Text = "0";
        }
    }
}