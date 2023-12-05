namespace Classe_carro
{
    partial class FormAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            lbl_cadastro = new Label();
            label10 = new Label();
            btn_cadastrar = new Button();
            label9 = new Label();
            txb_nota1 = new TextBox();
            txb_nome = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            cmb_sexo = new ComboBox();
            cmb_curso = new ComboBox();
            txb_nota2 = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(312, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 31);
            dateTimePicker1.TabIndex = 44;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cadastro.Location = new Point(602, 199);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(222, 170);
            lbl_cadastro.TabIndex = 42;
            lbl_cadastro.Text = "lbl_classe";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(602, 154);
            label10.Name = "label10";
            label10.Size = new Size(223, 32);
            label10.TabIndex = 41;
            label10.Text = "Aluno cadastrado:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(602, 69);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(223, 53);
            btn_cadastrar.TabIndex = 40;
            btn_cadastrar.Text = "Cadastrar Aluno";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(337, 12);
            label9.Name = "label9";
            label9.Size = new Size(179, 37);
            label9.TabIndex = 39;
            label9.Text = "Classe Aluno";
            // 
            // txb_nota1
            // 
            txb_nota1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nota1.Location = new Point(171, 159);
            txb_nota1.Name = "txb_nota1";
            txb_nota1.Size = new Size(100, 31);
            txb_nota1.TabIndex = 35;
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(165, 69);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(100, 31);
            txb_nome.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(74, 245);
            label8.Name = "label8";
            label8.Size = new Size(80, 32);
            label8.TabIndex = 32;
            label8.Text = "Curso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 68);
            label5.Name = "label5";
            label5.Size = new Size(85, 32);
            label5.TabIndex = 29;
            label5.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 203);
            label3.Name = "label3";
            label3.Size = new Size(91, 32);
            label3.TabIndex = 27;
            label3.Text = "Nota 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 158);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 26;
            label2.Text = "Nota 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 113);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 25;
            label1.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(74, 291);
            label6.Name = "label6";
            label6.Size = new Size(232, 32);
            label6.TabIndex = 30;
            label6.Text = "Data de nascimento:";
            // 
            // cmb_sexo
            // 
            cmb_sexo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_sexo.FormattingEnabled = true;
            cmb_sexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmb_sexo.Location = new Point(150, 114);
            cmb_sexo.Name = "cmb_sexo";
            cmb_sexo.Size = new Size(121, 31);
            cmb_sexo.TabIndex = 47;
            // 
            // cmb_curso
            // 
            cmb_curso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_curso.FormattingEnabled = true;
            cmb_curso.Items.AddRange(new object[] { "Curso Superior de Tecnologia em Análise e Desenvolvimento de Sistemas", "Curso Superior de Tecnologia em Gastronomia", "Curso Superior de Tecnologia em Gestão de Recursos Humanos" });
            cmb_curso.Location = new Point(160, 246);
            cmb_curso.Name = "cmb_curso";
            cmb_curso.Size = new Size(412, 31);
            cmb_curso.TabIndex = 48;
            // 
            // txb_nota2
            // 
            txb_nota2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nota2.Location = new Point(171, 204);
            txb_nota2.Name = "txb_nota2";
            txb_nota2.Size = new Size(100, 31);
            txb_nota2.TabIndex = 49;
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 378);
            Controls.Add(txb_nota2);
            Controls.Add(cmb_curso);
            Controls.Add(cmb_sexo);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_cadastro);
            Controls.Add(label10);
            Controls.Add(btn_cadastrar);
            Controls.Add(label9);
            Controls.Add(txb_nota1);
            Controls.Add(txb_nome);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAluno";
            Text = "FormAluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label lbl_cadastro;
        private Label label10;
        private Button btn_cadastrar;
        private Label label9;
        private TextBox txb_nota1;
        private TextBox txb_nome;
        private Label label8;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox cmb_sexo;
        private ComboBox cmb_curso;
        private TextBox txb_nota2;
    }
}