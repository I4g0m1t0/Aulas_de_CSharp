namespace Classe_carro
{
    partial class FormAnimal
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
            txb_nome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            cmb_cor = new ComboBox();
            label3 = new Label();
            txb_preco = new TextBox();
            label7 = new Label();
            dt_obito = new DateTimePicker();
            label2 = new Label();
            cmb_castrado = new ComboBox();
            menuStrip1 = new MenuStrip();
            txb_peso = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(263, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 31);
            dateTimePicker1.TabIndex = 64;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cadastro.Location = new Point(553, 205);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(222, 171);
            lbl_cadastro.TabIndex = 63;
            lbl_cadastro.Text = "lbl_classe";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(553, 160);
            label10.Name = "label10";
            label10.Size = new Size(235, 32);
            label10.TabIndex = 62;
            label10.Text = "Animal cadastrado:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(553, 75);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(223, 53);
            btn_cadastrar.TabIndex = 61;
            btn_cadastrar.Text = "Cadastrar Animal";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(288, 18);
            label9.Name = "label9";
            label9.Size = new Size(194, 37);
            label9.TabIndex = 60;
            label9.Text = "Classe Animal";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(116, 75);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(100, 31);
            txb_nome.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 294);
            label6.Name = "label6";
            label6.Size = new Size(232, 32);
            label6.TabIndex = 55;
            label6.Text = "Data de nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 74);
            label5.Name = "label5";
            label5.Size = new Size(85, 32);
            label5.TabIndex = 54;
            label5.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 250);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 53;
            label4.Text = "Castrado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 118);
            label1.Name = "label1";
            label1.Size = new Size(68, 32);
            label1.TabIndex = 50;
            label1.Text = "Peso:";
            // 
            // cmb_cor
            // 
            cmb_cor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_cor.FormattingEnabled = true;
            cmb_cor.Items.AddRange(new object[] { "Azul", "Preto", "Marrom", "Caramelo", "Cinza", "Rosa", "Amarelo", "Verde", "Roxo" });
            cmb_cor.Location = new Point(87, 207);
            cmb_cor.Name = "cmb_cor";
            cmb_cor.Size = new Size(121, 31);
            cmb_cor.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 206);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 67;
            label3.Text = "Cor:";
            // 
            // txb_preco
            // 
            txb_preco.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_preco.Location = new Point(108, 165);
            txb_preco.Name = "txb_preco";
            txb_preco.Size = new Size(100, 31);
            txb_preco.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 162);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 69;
            label7.Text = "Preço:";
            // 
            // dt_obito
            // 
            dt_obito.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dt_obito.Location = new Point(196, 339);
            dt_obito.Name = "dt_obito";
            dt_obito.Size = new Size(260, 31);
            dt_obito.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 338);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 71;
            label2.Text = "Data de óbito:";
            // 
            // cmb_castrado
            // 
            cmb_castrado.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_castrado.FormattingEnabled = true;
            cmb_castrado.Items.AddRange(new object[] { "Sim", "Não" });
            cmb_castrado.Location = new Point(143, 251);
            cmb_castrado.Name = "cmb_castrado";
            cmb_castrado.Size = new Size(121, 31);
            cmb_castrado.TabIndex = 73;
            cmb_castrado.SelectedIndexChanged += cmb_castrado_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 74;
            menuStrip1.Text = "menuStrip1";
            // 
            // txb_peso
            // 
            txb_peso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_peso.Location = new Point(99, 119);
            txb_peso.Name = "txb_peso";
            txb_peso.Size = new Size(109, 31);
            txb_peso.TabIndex = 75;
            // 
            // FormAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 393);
            Controls.Add(txb_peso);
            Controls.Add(cmb_castrado);
            Controls.Add(dt_obito);
            Controls.Add(label2);
            Controls.Add(txb_preco);
            Controls.Add(label7);
            Controls.Add(cmb_cor);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_cadastro);
            Controls.Add(label10);
            Controls.Add(btn_cadastrar);
            Controls.Add(label9);
            Controls.Add(txb_nome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAnimal";
            Text = "FormAnimal";
            Load += FormAnimal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label lbl_cadastro;
        private Label label10;
        private Button btn_cadastrar;
        private Label label9;
        private TextBox txb_nome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private ComboBox cmb_cor;
        private Label label3;
        private TextBox txb_preco;
        private Label label7;
        private DateTimePicker dt_obito;
        private Label label2;
        private ComboBox cmb_castrado;
        private MenuStrip menuStrip1;
        private TextBox txb_peso;
    }
}