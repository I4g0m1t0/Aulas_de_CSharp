using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using NAudio.Wave;


namespace Relógio
{
    public partial class Form1 : Form
    {
        //elemento fundamental
        private Stopwatch stopWatch;
        private List<TimeSpan> temposDasVoltas;
        private int totalSegundos;

        //som do alarme
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private SoundPlayer playerAlarme;
        public Form1()
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();
            playerAlarme = new SoundPlayer();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            temposDasVoltas = new List<TimeSpan>();

            for (int i = 0; i < 60; i++)
            {
                this.cmb_minTemp.Items.Add(i.ToString());
                this.cmb_secTemp.Items.Add(i.ToString());
            }
            this.btn_pararTemp.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            volta.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            reset.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            reset.Visible = false;
            listBox1.Visible = false;
            volta.Visible = false;

            temposDasVoltas.Clear();  // Limpa os tempos das voltas ao reiniciar o cronômetro

            // Limpa os tempos das voltas do ListBox
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopWatch.Elapsed);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopWatch.Elapsed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alarme.BackColor = Color.GreenYellow;
            cronometro.BackColor = SystemColors.ControlLight;
            temporizador.BackColor = SystemColors.ControlLight;

            //desabilitados
            iniciar.Visible = false;
            parar.Visible = false;
            listBox1.Visible = false;
            volta.Visible = false;
            reset.Visible = false;
            this.lbl_temp.Visible = false;
            label1.Visible = false;
            btn_iniciarAlarme.Enabled = false;
            btn_pararAlarme.Enabled = false;
            lbl_temp.Visible = false;
            btn_continuarTemp.Visible = false;
            btn_resetTemp.Visible = false;
            btn_iniciarTemp.Visible = false;
            btn_pararTemp.Visible = false;
            cmb_minTemp.Visible = false;
            cmb_secTemp.Visible = false;
            lbl_minTemp.Visible = false;
            lbl_secTemp.Visible = false;
            //Parar o timer do temporizador senão a música toca depois de trocar o modo
            this.timer_temp.Enabled = false;

            //habilitados
            dateTimePickerAlarme.Visible = true;
            btnSelecionarMusica.Visible = true;
            btn_iniciarAlarme.Visible = true;
            btn_pararAlarme.Visible= true;

            //exibe uma mensagem fundamental para que o usuário possa entender como o alarme funciona
            MessageBox.Show("Por favor, para que o alarme funcione, primeiro selecione uma música para desbloquear o botão de iniciar.");

            //pra parar o cronômetro
            stopWatch.Reset();

            //pra reiniciar o temporizador
            this.timer_temp.Enabled = false;
            this.lbl_temp.Text = "00:00";
            this.cmb_minTemp.SelectedItem = null;
            this.cmb_secTemp.SelectedItem = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cronometro.BackColor = Color.GreenYellow;
            alarme.BackColor = SystemColors.ControlLight;
            temporizador.BackColor = SystemColors.ControlLight;

            //habilitados
            label1.Visible = true;
            iniciar.Visible = true;
            parar.Visible = true;

            //Desabilitados
            lbl_temp.Visible = false;
            btn_continuarTemp.Visible = false;
            btn_resetTemp.Visible = false;
            btn_iniciarTemp.Visible = false;
            btn_pararTemp.Visible = false;
            cmb_minTemp.Visible = false;
            cmb_secTemp.Visible = false;
            lbl_minTemp.Visible = false;
            lbl_secTemp.Visible = false;
            dateTimePickerAlarme.Visible = false;
            btnSelecionarMusica.Visible = false;
            btn_iniciarAlarme.Visible = false;
            btn_pararAlarme.Visible = false;
            pictureBox1.Visible = false;
            //Parar o timer do temporizador senão a música toca depois de trocar o modo
            this.timer_temp.Enabled = false;

            //pra parar o cronômetro
            stopWatch.Reset();

            //pra reiniciar o temporizador
            this.timer_temp.Enabled = false;
            this.lbl_temp.Text = "00:00";
            this.cmb_minTemp.SelectedItem = null;
            this.cmb_secTemp.SelectedItem = null;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            // Armazena o tempo da volta na lista
            temposDasVoltas.Add(stopWatch.Elapsed);

            // Exibe o número da volta e o tempo no Listbox e formata
            listBox1.Items.Add($"Volta {temposDasVoltas.Count}: {stopWatch.Elapsed.ToString(@"hh\:mm\:ss\:ff")}");
        }

        private void temporizador_Click(object sender, EventArgs e)
        {
            temporizador.BackColor = Color.GreenYellow;
            alarme.BackColor = SystemColors.ControlLight;
            cronometro.BackColor = SystemColors.ControlLight;

            //Desabilitados
            iniciar.Visible = false;
            parar.Visible = false;
            listBox1.Visible = false;
            volta.Visible = false;
            reset.Visible = false;
            this.label1.Visible = false;
            dateTimePickerAlarme.Visible = false;
            btnSelecionarMusica.Visible = false;
            btn_iniciarAlarme.Visible = false;
            btn_pararAlarme.Visible = false;
            pictureBox1.Visible = false;

            //Habilitados
            btn_iniciarTemp.Visible = true;
            btn_iniciarTemp.Enabled = true;
            btn_pararTemp.Visible = true;
            btn_pararTemp.Enabled = false;
            lbl_minTemp.Visible = true;
            lbl_secTemp.Visible = true;
            cmb_minTemp.Visible = true;
            cmb_secTemp.Visible = true;
            lbl_temp.Visible = true;

            stopWatch.Reset();
        }

        private void btn_iniciarTemp_Click(object sender, EventArgs e)
        {

            // Verifica se ambas as ComboBoxes têm valores selecionados
            if (cmb_minTemp.SelectedItem == null || cmb_secTemp.SelectedItem == null)
            {
                // Exibe uma mensagem ou toma alguma ação apropriada para informar o usuário sobre a seleção necessária.
                MessageBox.Show("Por favor, selecione valores para minutos e segundos.");
                return; // Sai do método se alguma ComboBox estiver sem seleção
            }

            this.btn_iniciarTemp.Enabled = false;
            this.btn_pararTemp.Enabled = true;


            int minutos = int.Parse(cmb_minTemp.SelectedItem.ToString());
            int segundos = int.Parse(cmb_secTemp.SelectedItem.ToString());

            totalSegundos = (minutos * 60) + segundos;

            this.timer_temp.Enabled = true;
        }

        private void btn_pararTemp_Click(object sender, EventArgs e)
        {
            this.btn_continuarTemp.Visible = true;
            this.btn_pararTemp.Enabled = false;
            this.btn_iniciarTemp.Enabled = true;
            btn_resetTemp.Visible = true;

            this.timer_temp.Stop();
        }

        private void btn_continuarTemp_Click(object sender, EventArgs e)
        {
            this.btn_continuarTemp.Visible = false;
            this.btn_pararTemp.Enabled = true;
            this.timer_temp.Start();
            this.btn_resetTemp.Visible = false;
            this.btn_iniciarTemp.Enabled = false;
        }

        private void timer_temp_Tick(object sender, EventArgs e)
        {
            if (totalSegundos > 0)
            {
                int minutos = totalSegundos / 60;
                int segundos = totalSegundos % 60;
                this.lbl_temp.Text = $"{minutos:D2}:{segundos:D2}";
                totalSegundos--;
            }
            else
            {
                this.timer_temp.Enabled = false;

                // Substitua pelo caminho absoluto real do seu arquivo de áudio
                string caminhoDoArquivoDeAudio = @"musica.wav";
            

                // Verifica se o arquivo de áudio existe antes de tentar reproduzi-lo
                if (System.IO.File.Exists(caminhoDoArquivoDeAudio))
                {
                    try
                    {
                        SoundPlayer player = new SoundPlayer(caminhoDoArquivoDeAudio);
                        player.Play();
                        btn_resetTemp.Visible = true;
                        btn_pararTemp.Enabled = false;
                        // Exibe a mensagem e interrompe a reprodução após o clique em "OK"
                        MessageBox.Show("Parece que o tempo acabou");
                        player.Stop();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao reproduzir a música: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo de áudio não encontrado!");
                }
            }

        }


        private void btn_resetTemp_Click(object sender, EventArgs e)
        {
            this.btn_resetTemp.Visible = false;
            this.btn_continuarTemp.Visible = false;
            this.timer_temp.Enabled = false;
            this.lbl_temp.Text = "00:00";
            this.btn_iniciarTemp.Enabled = true;
            this.cmb_minTemp.SelectedItem = null;
            this.cmb_secTemp.SelectedItem = null;

        }

        private void dateTimePickerAlarme_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_iniciarAlarme_Click(object sender, EventArgs e)
        {
            timer_alarme.Start();
            btn_iniciarAlarme.Enabled = false;
            btn_pararAlarme.Enabled = true;
            btnSelecionarMusica.Enabled = false;
        }

        private void btn_pararAlarme_Click(object sender, EventArgs e)
        {
            
            btn_pararAlarme.Enabled = false;
            btnSelecionarMusica.Enabled = true;
            playerAlarme.Stop();

            //método para parar a música
            PararReproducao();
        }


        private void timer_alarme_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            DateTime alarme = dateTimePickerAlarme.Value;

            if (agora.Hour == alarme.Hour && agora.Minute == alarme.Minute && agora.Second == alarme.Second)
            {
                timer_alarme.Stop();
                pictureBox1.Visible = true;

                //método para reproduzir a música
                ReproduzirMusica();
            }
        }

        private void btnSelecionarMusica_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Música|*.mp3;*.wav";
                openFileDialog.Title = "Escolha uma música";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoMusica = openFileDialog.FileName;
                    ConfigurarMusica(caminhoMusica);
                }
            }

            btn_iniciarAlarme.Enabled = true;
        }

        //para selecionar e guardar a música selecionada
        private void ConfigurarMusica(string caminhoMusica)
        {
            if (caminhoMusica.EndsWith(".mp3"))
            {
                if (audioFile != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    audioFile.Dispose();
                }

                audioFile = new AudioFileReader(caminhoMusica);
                outputDevice.Init(audioFile);
            }
            else if (caminhoMusica.EndsWith(".wav"))
            {
                if (audioFile != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    audioFile.Dispose();
                }

                audioFile = new AudioFileReader(caminhoMusica);
                outputDevice.Init(audioFile);
            }
        }

        private void ReproduzirMusica()
        {
            if (audioFile != null)
            {
                outputDevice.Play();
            }
        }

        private void PararReproducao()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
            }

            pictureBox1.Visible = false;
        }
    }
}
