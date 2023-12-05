namespace Exercícios_de_estrutura_de_repetição
{
    partial class Form3
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
            btn_voltar = new Button();
            btn_sair = new Button();
            txb_1 = new TextBox();
            label3 = new Label();
            txb_par = new TextBox();
            label11 = new Label();
            txb_impar = new TextBox();
            label12 = new Label();
            btn_limpar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_voltar.Location = new Point(12, 292);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 38);
            btn_voltar.TabIndex = 3;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sair.Location = new Point(713, 292);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 38);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // txb_1
            // 
            txb_1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_1.Location = new Point(257, 90);
            txb_1.Name = "txb_1";
            txb_1.Size = new Size(100, 27);
            txb_1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(155, 88);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 13;
            label3.Text = "Número:";
            // 
            // txb_par
            // 
            txb_par.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_par.Location = new Point(232, 184);
            txb_par.Name = "txb_par";
            txb_par.ReadOnly = true;
            txb_par.Size = new Size(100, 27);
            txb_par.TabIndex = 34;
            txb_par.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(155, 184);
            label11.Name = "label11";
            label11.Size = new Size(71, 27);
            label11.TabIndex = 33;
            label11.Text = "Pares:";
            // 
            // txb_impar
            // 
            txb_impar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_impar.Location = new Point(535, 184);
            txb_impar.Name = "txb_impar";
            txb_impar.ReadOnly = true;
            txb_impar.Size = new Size(100, 27);
            txb_impar.TabIndex = 36;
            txb_impar.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(434, 184);
            label12.Name = "label12";
            label12.Size = new Size(95, 27);
            label12.TabIndex = 35;
            label12.Text = "Ímpares:";
            // 
            // btn_limpar
            // 
            btn_limpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpar.Location = new Point(354, 292);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(93, 38);
            btn_limpar.TabIndex = 37;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(434, 81);
            button1.Name = "button1";
            button1.Size = new Size(201, 38);
            button1.TabIndex = 38;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 340);
            Controls.Add(button1);
            Controls.Add(btn_limpar);
            Controls.Add(txb_impar);
            Controls.Add(label12);
            Controls.Add(txb_par);
            Controls.Add(label11);
            Controls.Add(txb_1);
            Controls.Add(label3);
            Controls.Add(btn_sair);
            Controls.Add(btn_voltar);
            Name = "Form3";
            Text = "Quantidade de números pares e ímpares com 10 números";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltar;
        private Button btn_sair;
        private TextBox txb_1;
        private Label label3;
        private TextBox txb_par;
        private Label label11;
        private TextBox txb_impar;
        private Label label12;
        private Button btn_limpar;
        private Button button1;
    }
}