namespace Classe_carro
{
    partial class Form2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txb_placa = new TextBox();
            txb_marca = new TextBox();
            txb_modelo = new TextBox();
            txb_combustivel = new TextBox();
            txb_batidas = new TextBox();
            txb_preco = new TextBox();
            label9 = new Label();
            btn_cadastrar = new Button();
            label10 = new Label();
            label11 = new Label();
            cmb_cor = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            txb_tempodeUso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 120);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 165);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(75, 210);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 2;
            label3.Text = "Cor:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 255);
            label4.Name = "label4";
            label4.Size = new Size(152, 32);
            label4.TabIndex = 3;
            label4.Text = "Combustível:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 75);
            label5.Name = "label5";
            label5.Size = new Size(73, 32);
            label5.TabIndex = 4;
            label5.Text = "Placa:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(75, 437);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 5;
            label6.Text = "Data da compra:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(75, 345);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 6;
            label7.Text = "Preço:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(75, 300);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 7;
            label8.Text = "Batidas:";
            label8.Click += label8_Click;
            // 
            // txb_placa
            // 
            txb_placa.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_placa.Location = new Point(154, 76);
            txb_placa.Name = "txb_placa";
            txb_placa.Size = new Size(100, 31);
            txb_placa.TabIndex = 8;
            // 
            // txb_marca
            // 
            txb_marca.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_marca.Location = new Point(165, 121);
            txb_marca.Name = "txb_marca";
            txb_marca.Size = new Size(100, 31);
            txb_marca.TabIndex = 9;
            // 
            // txb_modelo
            // 
            txb_modelo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_modelo.Location = new Point(183, 166);
            txb_modelo.Name = "txb_modelo";
            txb_modelo.Size = new Size(100, 31);
            txb_modelo.TabIndex = 10;
            // 
            // txb_combustivel
            // 
            txb_combustivel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_combustivel.Location = new Point(233, 256);
            txb_combustivel.Name = "txb_combustivel";
            txb_combustivel.Size = new Size(100, 31);
            txb_combustivel.TabIndex = 12;
            // 
            // txb_batidas
            // 
            txb_batidas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_batidas.Location = new Point(176, 301);
            txb_batidas.Name = "txb_batidas";
            txb_batidas.Size = new Size(100, 31);
            txb_batidas.TabIndex = 13;
            // 
            // txb_preco
            // 
            txb_preco.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_preco.Location = new Point(159, 346);
            txb_preco.Name = "txb_preco";
            txb_preco.Size = new Size(100, 31);
            txb_preco.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(313, 19);
            label9.Name = "label9";
            label9.Size = new Size(174, 37);
            label9.TabIndex = 16;
            label9.Text = "Classe Carro";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.White;
            btn_cadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(557, 99);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(156, 75);
            btn_cadastrar.TabIndex = 17;
            btn_cadastrar.Text = "Cadastrar Carro";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(557, 206);
            label10.Name = "label10";
            label10.Size = new Size(222, 32);
            label10.TabIndex = 18;
            label10.Text = "Classe cadastrada:";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(557, 251);
            label11.Name = "label11";
            label11.Size = new Size(222, 171);
            label11.TabIndex = 19;
            label11.Text = "lbl_classe";
            // 
            // cmb_cor
            // 
            cmb_cor.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_cor.FormattingEnabled = true;
            cmb_cor.Items.AddRange(new object[] { "Azulzinho", "Preto", "Rosa", "Amarelão", "Verde", "Roxo" });
            cmb_cor.Location = new Point(137, 211);
            cmb_cor.Name = "cmb_cor";
            cmb_cor.Size = new Size(121, 31);
            cmb_cor.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(269, 438);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 31);
            dateTimePicker1.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(75, 391);
            label12.Name = "label12";
            label12.Size = new Size(171, 32);
            label12.TabIndex = 23;
            label12.Text = "Tempo de uso:";
            // 
            // txb_tempodeUso
            // 
            txb_tempodeUso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txb_tempodeUso.Location = new Point(252, 392);
            txb_tempodeUso.Name = "txb_tempodeUso";
            txb_tempodeUso.Size = new Size(100, 31);
            txb_tempodeUso.TabIndex = 24;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 491);
            Controls.Add(txb_tempodeUso);
            Controls.Add(label12);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmb_cor);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btn_cadastrar);
            Controls.Add(label9);
            Controls.Add(txb_preco);
            Controls.Add(txb_batidas);
            Controls.Add(txb_combustivel);
            Controls.Add(txb_modelo);
            Controls.Add(txb_marca);
            Controls.Add(txb_placa);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txb_placa;
        private TextBox txb_marca;
        private TextBox txb_modelo;
        private TextBox txb_combustivel;
        private TextBox txb_batidas;
        private TextBox txb_preco;
        private Label label9;
        private Button btn_cadastrar;
        private Label label10;
        private Label label11;
        private ComboBox cmb_cor;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private TextBox txb_tempodeUso;
    }
}