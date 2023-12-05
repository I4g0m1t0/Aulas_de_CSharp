using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_datas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TimeSpan tempo_transcorrido;
        double dias;
        private void button1_Click(object sender, EventArgs e)
        {
            tempo_transcorrido = dateTimePicker1.Value - dateTimePicker2.Value;
            dias = Convert.ToDouble(tempo_transcorrido.Days / 1);
            lbl_dias.Text = dias.ToString() + " dias";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempo_transcorrido = dateTimePicker1.Value - dateTimePicker2.Value;
            dias = Convert.ToDouble(tempo_transcorrido.Days / 12);
            lbl_meses.Text = dias.ToString() + " meses";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tempo_transcorrido = dateTimePicker1.Value - dateTimePicker2.Value;
            dias = Convert.ToDouble(tempo_transcorrido.Days / 365);
            lbl_anos.Text = dias.ToString() + " anos";
        }
    }
}
