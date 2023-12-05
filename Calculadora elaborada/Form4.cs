using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_elaborada
{
    public partial class Form4 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Random random = new Random();

        public Form4()
        {
            InitializeComponent();

            timer.Interval = 100; // Intervalo em milissegundos (1 segundo)
            timer.Tick += Timer_Tick;

            // Inicie o temporizador
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Mude a cor do botão para uma cor aleatória
            button2.BackColor = GerarCorAleatoria();
        }

        private Color GerarCorAleatoria()
        {
            // Gere uma cor aleatória
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
