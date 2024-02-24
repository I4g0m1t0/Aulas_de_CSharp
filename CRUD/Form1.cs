using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=JLE207P060987;Initial Catalog=CRUD;Persist Security Info=True;User ID=sa;Password=Ia@26092006";
        private string strSql = string.Empty;

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO Funcionarios (Id, Nome, Endereco, CEP, Bairro, Cidade, UF, Telefone) values (@Id, @Nome, @Endereco, @CEP, @Bairro, @Cidade, @UF, @Telefone)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txbCep.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txtUF.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txbTelefone.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tsbPesquisar.Enabled = true;
                tstBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEndereco.Enabled = false;
                txbCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                txbTelefone.Enabled = false;

                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txbCep.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtUF.Text = string.Empty;
                txbTelefone.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void tsbPesquisar_Click(object sender, EventArgs e)
        {
            strSql = "select * from Funcionarios where Id=@Id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = tstBuscar.Text;

            try
            {
                if (tstBuscar.Text == string.Empty)
                {
                    throw new Exception("Digite um Id antes de ralizar uma busca!");
                }
                
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (dr.HasRows == false)
                {
                    throw new Exception("Id não cadastrado!");
                }

                txtId.Text = Convert.ToString(dr["Id"]);
                txtNome.Text = Convert.ToString(dr["Nome"]);
                txtEndereco.Text = Convert.ToString(dr["Endereco"]);
                txbCep.Text = Convert.ToString(dr["CEP"]);
                txtBairro.Text = Convert.ToString(dr["Bairro"]);
                txtCidade.Text = Convert.ToString(dr["Cidade"]);
                txtUF.Text = Convert.ToString(dr["UF"]);
                txbTelefone.Text = Convert.ToString(dr["Telefone"]);

                tsbNovo.Enabled = false;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = true;
                tsbCancelar.Enabled = true;
                tsbExcluir.Enabled = true;
                tsbPesquisar.Enabled = true;
                tstBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = true;
                txtEndereco.Enabled = true;
                txbCep.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                txtUF.Enabled = true;
                txbTelefone.Enabled = true;

                tstBuscar.Text = string.Empty;
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update Funcionarios set Id=@Id, Nome=@Nome, Endereco=@Endereco, CEP=@CEP, Bairro=@Bairro, Cidade=@Cidade, UF=@UF, Telefone=@Telefone where Id=@IdBuscar";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = txtId.Text;

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = txtId.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = txbCep.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txtUF.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txbTelefone.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!");

                tsbNovo.Enabled = true;
                tsbSalvar.Enabled = false;
                tsbAlterar.Enabled = false;
                tsbCancelar.Enabled = false;
                tsbExcluir.Enabled = false;
                tsbPesquisar.Enabled = true;
                tstBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEndereco.Enabled = false;
                txbCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                txbTelefone.Enabled = false;

                tstBuscar.Text = string.Empty;
                txtId.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txbCep.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtUF.Text = string.Empty;
                txbTelefone.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este funcionário?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            else
            {
                strSql = "delete from Funcionarios where Id=@Id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = txtId.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Funcionário deletado com sucesso!");

                    tsbNovo.Enabled = true;
                    tsbSalvar.Enabled = false;
                    tsbAlterar.Enabled = false;
                    tsbCancelar.Enabled = false;
                    tsbExcluir.Enabled = false;
                    tsbPesquisar.Enabled = true;
                    tstBuscar.Enabled = true;
                    txtId.Enabled = false;
                    txtNome.Enabled = false;
                    txtEndereco.Enabled = false;
                    txbCep.Enabled = false;
                    txtBairro.Enabled = false;
                    txtCidade.Enabled = false;
                    txtUF.Enabled = false;
                    txbTelefone.Enabled = false;

                    tstBuscar.Text = string.Empty;
                    txtId.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txbCep.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    txtCidade.Text = string.Empty;
                    txtUF.Text = string.Empty;
                    txbTelefone.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tsbPesquisar.Enabled = false;
            tstBuscar.Enabled = false;
            txtId.Enabled = true;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txbCep.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txbTelefone.Enabled = true;

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbPesquisar.Enabled = true;
            tstBuscar.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txbCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txbTelefone.Enabled = false;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txbCep.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtUF.Text = string.Empty;
            txbTelefone.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbAlterar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbPesquisar.Enabled = true;
            tstBuscar.Enabled = true;
            txtId.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txbCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUF.Enabled = false;
            txbTelefone.Enabled = false;
        }
    }
}
