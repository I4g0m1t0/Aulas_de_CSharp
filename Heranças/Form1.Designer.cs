namespace Heranças
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtp = new DateTimePicker();
            txb_endereco = new TextBox();
            txb_mat = new TextBox();
            txb_nome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_usuario = new Button();
            groupBox2 = new GroupBox();
            btn_professor = new Button();
            txb_cargaHoraria = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            txb_turma = new TextBox();
            groupBox3 = new GroupBox();
            btn_aluno = new Button();
            txb_nota2 = new TextBox();
            label6 = new Label();
            txb_nota1 = new TextBox();
            label5 = new Label();
            groupBox4 = new GroupBox();
            btn_ingles = new Button();
            label10 = new Label();
            cmb_ingles = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp);
            groupBox1.Controls.Add(txb_endereco);
            groupBox1.Controls.Add(txb_mat);
            groupBox1.Controls.Add(txb_nome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(148, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuário";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtp
            // 
            dtp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp.Location = new Point(119, 119);
            dtp.Name = "dtp";
            dtp.Size = new Size(301, 29);
            dtp.TabIndex = 7;
            // 
            // txb_endereco
            // 
            txb_endereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_endereco.Location = new Point(100, 159);
            txb_endereco.Name = "txb_endereco";
            txb_endereco.Size = new Size(293, 29);
            txb_endereco.TabIndex = 6;
            // 
            // txb_mat
            // 
            txb_mat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_mat.Location = new Point(100, 84);
            txb_mat.Name = "txb_mat";
            txb_mat.Size = new Size(293, 29);
            txb_mat.TabIndex = 5;
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(79, 47);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(293, 29);
            txb_nome.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 163);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 123);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Matrícula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // btn_usuario
            // 
            btn_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_usuario.Location = new Point(316, 249);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(102, 30);
            btn_usuario.TabIndex = 1;
            btn_usuario.Text = "Cadastrar";
            btn_usuario.UseVisualStyleBackColor = true;
            btn_usuario.Click += btn_usuario_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_professor);
            groupBox2.Controls.Add(txb_cargaHoraria);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(397, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 146);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Professor";
            // 
            // btn_professor
            // 
            btn_professor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_professor.Location = new Point(144, 94);
            btn_professor.Name = "btn_professor";
            btn_professor.Size = new Size(102, 30);
            btn_professor.TabIndex = 9;
            btn_professor.Text = "Cadastrar";
            btn_professor.UseVisualStyleBackColor = true;
            btn_professor.Click += btn_professor_Click;
            // 
            // txb_cargaHoraria
            // 
            txb_cargaHoraria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_cargaHoraria.Location = new Point(131, 47);
            txb_cargaHoraria.Name = "txb_cargaHoraria";
            txb_cargaHoraria.Size = new Size(241, 29);
            txb_cargaHoraria.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(17, 51);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 0;
            label8.Text = "Carga horária:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 51);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 0;
            label9.Text = "Turma:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 88);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 1;
            // 
            // txb_turma
            // 
            txb_turma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_turma.Location = new Point(79, 47);
            txb_turma.Name = "txb_turma";
            txb_turma.Size = new Size(180, 29);
            txb_turma.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_aluno);
            groupBox3.Controls.Add(txb_nota2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txb_nota1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txb_turma);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(23, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(331, 203);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aluno";
            // 
            // btn_aluno
            // 
            btn_aluno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aluno.Location = new Point(79, 162);
            btn_aluno.Name = "btn_aluno";
            btn_aluno.Size = new Size(102, 30);
            btn_aluno.TabIndex = 9;
            btn_aluno.Text = "Cadastrar";
            btn_aluno.UseVisualStyleBackColor = true;
            btn_aluno.Click += btn_aluno_Click;
            // 
            // txb_nota2
            // 
            txb_nota2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nota2.Location = new Point(79, 122);
            txb_nota2.Name = "txb_nota2";
            txb_nota2.Size = new Size(180, 29);
            txb_nota2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(17, 126);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 7;
            label6.Text = "Nota2:";
            // 
            // txb_nota1
            // 
            txb_nota1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nota1.Location = new Point(79, 84);
            txb_nota1.Name = "txb_nota1";
            txb_nota1.Size = new Size(180, 29);
            txb_nota1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 88);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 5;
            label5.Text = "Nota1:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cmb_ingles);
            groupBox4.Controls.Add(btn_ingles);
            groupBox4.Controls.Add(label10);
            groupBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(397, 491);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(410, 146);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Professor de inglês";
            // 
            // btn_ingles
            // 
            btn_ingles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingles.Location = new Point(144, 94);
            btn_ingles.Name = "btn_ingles";
            btn_ingles.Size = new Size(102, 30);
            btn_ingles.TabIndex = 9;
            btn_ingles.Text = "Cadastrar";
            btn_ingles.UseVisualStyleBackColor = true;
            btn_ingles.Click += btn_ingles_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 51);
            label10.Name = "label10";
            label10.Size = new Size(149, 21);
            label10.TabIndex = 0;
            label10.Text = "Professor de inglês?";
            // 
            // cmb_ingles
            // 
            cmb_ingles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_ingles.FormattingEnabled = true;
            cmb_ingles.Items.AddRange(new object[] { "Sim", "Não" });
            cmb_ingles.Location = new Point(172, 47);
            cmb_ingles.Name = "cmb_ingles";
            cmb_ingles.Size = new Size(157, 29);
            cmb_ingles.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 682);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btn_usuario);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtp;
        private TextBox txb_endereco;
        private TextBox txb_mat;
        private TextBox txb_nome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_usuario;
        private GroupBox groupBox2;
        private TextBox txb_cargaHoraria;
        private Label label8;
        private Button btn_professor;
        private Label label9;
        private Label label7;
        private TextBox txb_turma;
        private GroupBox groupBox3;
        private Button btn_aluno;
        private TextBox txb_nota2;
        private Label label6;
        private TextBox txb_nota1;
        private Label label5;
        private GroupBox groupBox4;
        private Button btn_ingles;
        private Label label10;
        private ComboBox cmb_ingles;
    }
}