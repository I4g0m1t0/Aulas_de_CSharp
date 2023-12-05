namespace Classe_Receita
{
    partial class FormReceita
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            redbSaudavel = new RadioButton();
            btnCadastrarReceita = new Button();
            btnIngrediente = new Button();
            label3 = new Label();
            txtIngrediente = new TextBox();
            lstReceita = new ListBox();
            dtpCadastro = new DateTimePicker();
            label4 = new Label();
            txtCalorias = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 50);
            label1.Name = "label1";
            label1.Size = new Size(142, 46);
            label1.TabIndex = 0;
            label1.Text = "RECEITA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 135);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(141, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(287, 32);
            txtNome.TabIndex = 2;
            // 
            // redbSaudavel
            // 
            redbSaudavel.AllowDrop = true;
            redbSaudavel.AutoSize = true;
            redbSaudavel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            redbSaudavel.Location = new Point(68, 238);
            redbSaudavel.Name = "redbSaudavel";
            redbSaudavel.Size = new Size(129, 29);
            redbSaudavel.TabIndex = 3;
            redbSaudavel.TabStop = true;
            redbSaudavel.Text = "SAUDÁVEL?";
            redbSaudavel.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarReceita
            // 
            btnCadastrarReceita.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarReceita.Location = new Point(185, 394);
            btnCadastrarReceita.Name = "btnCadastrarReceita";
            btnCadastrarReceita.Size = new Size(132, 72);
            btnCadastrarReceita.TabIndex = 4;
            btnCadastrarReceita.Text = "CADASTRAR RECEITA";
            btnCadastrarReceita.UseVisualStyleBackColor = true;
            btnCadastrarReceita.Click += btnCadastrarReceita_Click;
            // 
            // btnIngrediente
            // 
            btnIngrediente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngrediente.Location = new Point(408, 309);
            btnIngrediente.Name = "btnIngrediente";
            btnIngrediente.Size = new Size(132, 70);
            btnIngrediente.TabIndex = 5;
            btnIngrediente.Text = "Cadastrar Ingrediente";
            btnIngrediente.UseVisualStyleBackColor = true;
            btnIngrediente.Click += btnIngrediente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 332);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 6;
            label3.Text = "Ingredientes:";
            // 
            // txtIngrediente
            // 
            txtIngrediente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngrediente.Location = new Point(141, 325);
            txtIngrediente.Name = "txtIngrediente";
            txtIngrediente.Size = new Size(261, 32);
            txtIngrediente.TabIndex = 7;
            // 
            // lstReceita
            // 
            lstReceita.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstReceita.FormattingEnabled = true;
            lstReceita.ItemHeight = 21;
            lstReceita.Location = new Point(558, 52);
            lstReceita.Name = "lstReceita";
            lstReceita.Size = new Size(412, 445);
            lstReceita.TabIndex = 8;
            // 
            // dtpCadastro
            // 
            dtpCadastro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCadastro.Location = new Point(141, 188);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(287, 32);
            dtpCadastro.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 195);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 10;
            label4.Text = "Data:";
            // 
            // txtCalorias
            // 
            txtCalorias.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalorias.Location = new Point(141, 271);
            txtCalorias.Name = "txtCalorias";
            txtCalorias.Size = new Size(117, 32);
            txtCalorias.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 279);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 11;
            label5.Text = "Calorias:";
            // 
            // FormReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 543);
            Controls.Add(txtCalorias);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpCadastro);
            Controls.Add(lstReceita);
            Controls.Add(txtIngrediente);
            Controls.Add(label3);
            Controls.Add(btnIngrediente);
            Controls.Add(btnCadastrarReceita);
            Controls.Add(redbSaudavel);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormReceita";
            Text = "FormReceita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private RadioButton redbSaudavel;
        private Button btnCadastrarReceita;
        private Button btnIngrediente;
        private Label label3;
        private TextBox txtIngrediente;
        private ListBox lstReceita;
        private DateTimePicker dtpCadastro;
        private Label label4;
        private TextBox txtCalorias;
        private Label label5;
    }
}