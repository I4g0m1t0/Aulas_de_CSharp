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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_surprisemtfck_Click(object sender, EventArgs e)
        {
            ltb_diferenca.Items.Clear();
            TimeSpan difference = dateTimePicker1.Value - dateTimePicker2.Value;
            int ano = dateTimePicker2.Value.Year - dateTimePicker1.Value.Year;

            ltb_diferenca.Items.Add($"A diferença entra as datas");
            ltb_diferenca.Items.Add($"{dateTimePicker1.Value} e {dateTimePicker2.Value} é de:");
            ltb_diferenca.Items.Add($"{ano} anos");
            ltb_diferenca.Items.Add($"{difference.TotalDays:00} dias");
            ltb_diferenca.Items.Add($"{difference.TotalHours:00} horas");
            ltb_diferenca.Items.Add($"{difference.Minutes:00} minutos");
            ltb_diferenca.Items.Add($"{difference.TotalSeconds:00} segundos");
        }
    }
}
