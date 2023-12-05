namespace Exercícios_de_estrutura_de_repetição
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
            btn_voltar = new Button();
            btn_sair = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_base = new TextBox();
            txb_exp = new TextBox();
            label1 = new Label();
            txb_resultado = new TextBox();
            button1 = new Button();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_voltar.Location = new Point(12, 400);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 38);
            btn_voltar.TabIndex = 2;
            btn_voltar.Text = "Home";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sair.Location = new Point(713, 400);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 38);
            btn_sair.TabIndex = 4;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(261, 30);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 5;
            label2.Text = "Cálculo Exponencial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(315, 130);
            label3.Name = "label3";
            label3.Size = new Size(65, 27);
            label3.TabIndex = 10;
            label3.Text = "Base:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(292, 178);
            label4.Name = "label4";
            label4.Size = new Size(110, 27);
            label4.TabIndex = 11;
            label4.Text = "Expoente:";
            // 
            // txb_base
            // 
            txb_base.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_base.Location = new Point(386, 130);
            txb_base.Name = "txb_base";
            txb_base.Size = new Size(100, 27);
            txb_base.TabIndex = 12;
            // 
            // txb_exp
            // 
            txb_exp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_exp.Location = new Point(408, 178);
            txb_exp.Name = "txb_exp";
            txb_exp.Size = new Size(100, 27);
            txb_exp.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 299);
            label1.Name = "label1";
            label1.Size = new Size(114, 27);
            label1.TabIndex = 14;
            label1.Text = "Resultado:";
            // 
            // txb_resultado
            // 
            txb_resultado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txb_resultado.Location = new Point(352, 299);
            txb_resultado.Name = "txb_resultado";
            txb_resultado.ReadOnly = true;
            txb_resultado.Size = new Size(217, 27);
            txb_resultado.TabIndex = 15;
            txb_resultado.TextChanged += txb_resultado_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(349, 235);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 16;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_limpar.Location = new Point(354, 400);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(93, 38);
            btn_limpar.TabIndex = 17;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_limpar);
            Controls.Add(button1);
            Controls.Add(txb_resultado);
            Controls.Add(label1);
            Controls.Add(txb_exp);
            Controls.Add(txb_base);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_sair);
            Controls.Add(btn_voltar);
            Name = "Form2";
            Text = "Cálculo Exponencial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltar;
        private Button btn_sair;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_base;
        private TextBox txb_exp;
        private Label label1;
        private TextBox txb_resultado;
        private Button button1;
        private Button btn_limpar;
    }
}