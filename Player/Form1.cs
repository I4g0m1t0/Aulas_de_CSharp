using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WMPLib.IWMPPlaylist playlist;

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ofdAbrir.Title = "Abrir mídia";
            ofdAbrir.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            if(ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                playlist = player.playlistCollection.newPlaylist(ofdAbrir.FileName);

                foreach(var arquivo in ofdAbrir.FileNames) 
                {
                    playlist.appendItem(player.newMedia(arquivo));
                    ltbPlaylist.Items.Add(arquivo);

                    player.currentPlaylist = playlist;
                    player.Ctlcontrols.play();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ltbPlaylist.Items.Count > 0)
            {
                sfdSalvar.Title = "Salvar playlist";
                sfdSalvar.Filter = "Arquivo texto|*.txt";

                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter arquivo = new StreamWriter(sfdSalvar.FileName, false);
                    for (int i = 0; i < ltbPlaylist.Items.Count; i++)
                    {
                        arquivo.WriteLine(ltbPlaylist.Items[i].ToString());
                    }
                    arquivo.Close();
                }
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            ofdAbrir.Title = "Abrir playlist";
            ofdAbrir.Filter = "Arquivo texto|*.txt";
            ofdAbrir.Multiselect = false;
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(ofdAbrir.FileName);
                while (arquivo.Peek() != -1)
                {
                    ltbPlaylist.Items.Add(arquivo.ReadLine());
                }
                arquivo.Close();
            }
        }

        private void ltbPlaylist_DoubleClick(object sender, EventArgs e)
        {
            if (ltbPlaylist.Items.Count > 0)
            {
                player.URL = ltbPlaylist.SelectedItem.ToString();
                player.Ctlcontrols.play();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            player.URL = null;
            ltbPlaylist.Items.Clear();
        }

        private void ltbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
