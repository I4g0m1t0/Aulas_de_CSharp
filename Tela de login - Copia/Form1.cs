using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Tela_de_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=JLE207P060987;Initial Catalog=Exemplo_Login;Persist Security Info=True;User ID=SA;Password=Ia@26092006");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private static extern void SendMessage(System.IntPtr hund, int wmsg, int wparam, int lparam);
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuário")
            {
                textBox1.Text= "";
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuário";
                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
            {
                textBox2.Text = "";
                textBox2.BackColor = Color.White;
                textBox2.ForeColor = Color.FromArgb(0, 0, 0);
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Senha";
                textBox2.BackColor = Color.White;
                textBox2.ForeColor = Color.FromArgb(0, 0, 0);
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username,password;
            username = textBox1.Text;
            password = textBox2.Text;

            try
            {

                String query = "SELECT * FROM Usuarios WHERE login='" + username + "' AND senha='" + password + "'";

                SqlDataAdapter sad = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sad.Fill(dt);

                if (dt.Rows.Count > 0 )
                {
                    if(username == "admin")
                    {
                        Form2 admin = new Form2();
                        admin.Show();
                        this.Hide();
                    }
                    else if (username == "Ana")
                    {
                        Form3 normal = new Form3();
                        normal.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Senha inválida", "Error2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Login inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
