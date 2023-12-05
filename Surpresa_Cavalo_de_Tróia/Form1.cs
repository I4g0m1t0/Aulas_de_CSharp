using System;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms;

namespace Surpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_texto_Click(object sender, EventArgs e)
        {


        }

        private void Cmb_jogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_link.Enabled = true;

            if (Cmb_jogador.Text == "Cristiano Ronaldo")
            {
                lbl_texto.Text = "Cristiano Ronaldo, nascido em 5 de fevereiro de 1985, é uma lenda viva do futebol. Natural de Portugal, ele é amplamente considerado um dos maiores jogadores de todos os tempos. Ronaldo é conhecido por sua velocidade, habilidade de driblar, força física e impressionante capacidade de marcar gols. Ele passou grande parte de sua carreira no Manchester United, no Real Madrid e, mais recentemente, no retorno ao Manchester United em 2021. Sua rivalidade com Lionel Messi é uma das mais épicas da história do futebol. Atualmente ele joga pelo Al-Nassr, na liga saudita.";
                pictureBox1.Image = imageList1.Images[0];
            }
            else if (Cmb_jogador.Text == "Lionel Messi")
            {
                lbl_texto.Text = "Nascido em 24 de junho de 1987 em Rosário, Argentina, Lionel Messi é um jogador extraordinário. Ele é frequentemente descrito como o melhor jogador de todos os tempos devido à sua habilidade de driblar incrível, visão de jogo excepcional e precisão em chutes a gol. Messi passou a maior parte de sua carreira no Barcelona, onde conquistou inúmeras taças e prêmios individuais, incluindo múltiplas Bolas de Ouro da FIFA. Em 2021, ele surpreendeu o mundo do futebol ao se transferir para o Paris Saint-Germain (PSG), continuando a encantar os fãs em todo o mundo. Atualmente ele joga pelo Inter Miami, na MLS.";
                pictureBox1.Image = imageList1.Images[1];
            }
            else if (Cmb_jogador.Text == "Neymar")
            {
                lbl_texto.Text = "Neymar Jr., nascido em 5 de fevereiro de 1992 no Brasil, é um dos jogadores mais habilidosos e carismáticos da atualidade. Ele é conhecido por suas fintas espetaculares, dribles desconcertantes e habilidades de finalização. Neymar começou sua carreira no Santos FC antes de se mudar para o Barcelona em 2013. Em 2017, ele transferiu-se para o Paris Saint-Germain em uma transferência recorde. Neymar é uma peça fundamental na seleção brasileira e tem sido uma figura destacada no cenário do futebol mundial por muitos anos. Atualmente ele joga pelo Al-Hilal, na liga saudita.";
                pictureBox1.Image = imageList1.Images[3];
            }
            else if (Cmb_jogador.Text == "Mbappé")
            {
                lbl_texto.Text = "Kylian Mbappé, nascido em 20 de dezembro de 1998 na França, é uma jovem estrela do futebol que rapidamente se tornou um dos jogadores mais promissores do mundo. Sua velocidade incrível e habilidade para marcar gols fizeram dele uma figura central no Paris Saint-Germain (PSG) e na seleção francesa. Mbappé deslumbrou o mundo ao vencer a Copa do Mundo de 2018 com a França, onde também recebeu o prêmio de Melhor Jogador Jovem do torneio. Atualmente ele joga pelo PSG, na Ligue 1.";
                pictureBox1.Image = imageList1.Images[2];
            }
            else if (Cmb_jogador.Text == "Haaland")
            {
                lbl_texto.Text = "Erling Haaland, nascido em 21 de julho de 2000 na Noruega, é uma das jovens estrelas em ascensão no futebol mundial. Com uma capacidade de finalização impressionante e uma presença física notável, Haaland se destacou no RB Salzburg e, posteriormente, no Borussia Dortmund antes de atrair o interesse dos maiores clubes europeus. Ele é conhecido por sua mentalidade de artilheiro e sua capacidade de marcar gols em quase todas as partidas em que joga. Sua ascensão no cenário do futebol o torna um jogador a ser observado nos próximos anos. Atualmente ele joga pelo Manchester City, na Premier League.";
                pictureBox1.Image = imageList1.Images[4];
            }
            else
            {
                lbl_texto.Text = "Por favor, selecione um jogador";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe uma MessageBox de confirmação para sair
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a escolha do usuário
            if (result == DialogResult.Yes)
            {
                // Fecha o aplicativo se o usuário escolher "Sim"
                Application.Exit();
            }
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.youtube.com/watch?v=ZPWg5Hpwtwg";
            string url2 = "https://www.youtube.com/watch?v=DMBc5LjZPSI";
            string url3 = "https://www.youtube.com/watch?v=K2csY1cMpfA&t=14s";
            string url4 = "https://www.youtube.com/watch?v=_T7z287ofn8";
            string url5 = "https://www.youtube.com/watch?v=zx1kqJvFO38&t=50s";


            if (Cmb_jogador.Text == "Cristiano Ronaldo")
            {
                try
                {
                    // Verifique se o navegador padrão está definido
                    if (!string.IsNullOrEmpty(url1))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url1,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
                }

            }
            else if (Cmb_jogador.Text == "Lionel Messi")
            {
                try
                {
                    // Verifique se o navegador padrão está definido
                    if (!string.IsNullOrEmpty(url2))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url2,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
                }
            }
            else if (Cmb_jogador.Text == "Neymar")
            {
                try
                {
                    // Verifique se o navegador padrão está definido
                    if (!string.IsNullOrEmpty(url3))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url3,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
                }
            }
            else if (Cmb_jogador.Text == "Mbappé")
            {
                try
                {
                    // Verifique se o navegador padrão está definido
                    if (!string.IsNullOrEmpty(url4))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url4,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
                }
            }
            else if (Cmb_jogador.Text == "Haaland")
            {
                try
                {
                    // Verifique se o navegador padrão está definido
                    if (!string.IsNullOrEmpty(url5))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url5,
                            UseShellExecute = true
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir o link. Erro: " + ex.Message);
                }
            }
        }
    }
}