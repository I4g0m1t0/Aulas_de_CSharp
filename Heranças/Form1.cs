namespace Heranças
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = new Usuario();

                objUsuario.nome = txb_nome.Text;
                objUsuario.matricula = Convert.ToInt16(txb_mat.Text);
                objUsuario.dt_nasc = dtp.Value;
                objUsuario.endereco = txb_endereco.Text;

                MessageBox.Show("Usuário cadastrado com sucesso!\n\nNome: " + objUsuario.nome +
                    "\nMatrícula: " + objUsuario.matricula + "\nData de nascimento: " + objUsuario.dt_nasc +
                    "\nEndereço: " + objUsuario.endereco);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO", MessageBoxButtons.OK);
            }


        }

        private void btn_aluno_Click(object sender, EventArgs e)
        {
            Aluno novoAluno = new Aluno();

            novoAluno.nome = txb_nome.Text;
            novoAluno.matricula = Convert.ToInt16(txb_mat.Text);
            novoAluno.dt_nasc = dtp.Value;
            novoAluno.endereco = txb_endereco.Text;
            //Coisas do aluno
            novoAluno.turma = txb_turma.Text;
            novoAluno.nota1 = double.Parse(txb_nota1.Text);
            novoAluno.nota2 = double.Parse(txb_nota2.Text);
            novoAluno.Media();

            MessageBox.Show("Usuário cadastrado com sucesso!\n\nNome: " + novoAluno.nome +
                    "\nMatrícula: " + novoAluno.matricula + "\nData de nascimento: " + novoAluno.dt_nasc +
                    "\nEndereço: " + novoAluno.endereco + "\nTurma: " + novoAluno.turma + "\nNota1: " + novoAluno.nota1 +
                    "\nNota2: " + novoAluno.nota2 + "\nMédia: " + novoAluno.retornaMedia() + "\nResultado: " + novoAluno.aprovado());
        }

        private void btn_professor_Click(object sender, EventArgs e)
        {
            Professor novoProf = new Professor();

            novoProf.nome = txb_nome.Text;
            novoProf.matricula = Convert.ToInt16(txb_mat.Text);
            novoProf.dt_nasc = dtp.Value;
            novoProf.endereco = txb_endereco.Text;
            //Coisas do aluno
            novoProf.carga_horaria = txb_cargaHoraria.Text;

            MessageBox.Show("Usuário cadastrado com sucesso!\n\nNome: " + novoProf.nome +
                    "\nMatrícula: " + novoProf.matricula + "\nData de nascimento: " + novoProf.dt_nasc +
                    "\nEndereço: " + novoProf.endereco + "\nCarga horária: " + novoProf.carga_horaria);
        }

        private void btn_ingles_Click(object sender, EventArgs e)
        {
            Ingles ingles = new Ingles();

            ingles.nome = txb_nome.Text;
            ingles.matricula = Convert.ToInt16(txb_mat.Text);
            ingles.dt_nasc = dtp.Value;
            ingles.endereco= txb_endereco.Text;
            //Coisas do professor
            ingles.carga_horaria = txb_cargaHoraria.Text;
            //coisas do inglês
            ingles.ingles = cmb_ingles.Text;

            MessageBox.Show("Usuário cadastrado com sucesso!\n\nNome: " + ingles.nome +
                    "\nMatrícula: " + ingles.matricula + "\nData de nascimento: " + ingles.dt_nasc +
                    "\nEndereço: " + ingles.endereco + "\nCarga horária: " + ingles.carga_horaria + 
                    "\nProfessor de inglês: " + ingles.ingles);
        }
    }
}