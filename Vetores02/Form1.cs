using System.Security.Cryptography;
using System.Windows.Forms;

namespace Vetores02
{
    public partial class Form1 : Form
    {
        int[] vetor = new int[30];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gerarnumeros_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                // ltb_numeros.Items.Add(randNum.Next()); //O método .Next retorna um número aleatório ão negativo
                ltb_numeros.Items.Add(randNum.Next(100)); //Gera números menores que 100
                // ltb_numeros.Items.Add(randNum.Next(10, 50)); //Gera números entre 10 e 50, a vírgula separa o intervalo
            }
        }

        private void btn_gerarvetor_Click(object sender, EventArgs e)
        {
            Random randNum1 = new Random();

            for (int i = 0; i < 30; i++)
            {
                vetor[i] = randNum1.Next(100, 200);
                lbl_vetor.Text += vetor[i].ToString();
                lbl_vetor.Text += " - ";
            }
        }

        private void btn_ordenarvetor_Click(object sender, EventArgs e)
        {
            lbl_vetor.Text = string.Empty;
            Array.Sort(vetor); //Ordena em ordem crescente
            for (int i = 0; i < 30; i++)
            {
                lbl_vetor.Text += vetor[i].ToString();
                lbl_vetor.Text += " - ";
            }
        }

        private void btn_ordenarbuble_Click(object sender, EventArgs e)
        {
            //MÉTODO BOLHA - BUBBLE SORT
            var n = vetor.Length; // pega o tamanho do vetor
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (vetor[j] > vetor[j + 1])
                    {
                        var tempVar = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = tempVar;
                    }



            //IMPRIMINDO
            lbl_vetor.Text = string.Empty;
            for (int i = 0; i < 30; i++)
            {
                lbl_vetor.Text += vetor[i].ToString();
                lbl_vetor.Text += " - ";
            }
        }

        private void btn_gerarcaracteres_Click(object sender, EventArgs e)
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[10];
            var random = new Random();



            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
                ltb_caracteres.Items.Add(Charsarr[i]);
            }
        }
    }
}
