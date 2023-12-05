namespace Exercícios_de_estrutura_de_repetição
{
    partial class Form4
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
            btn_sair = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sair.Location = new Point(713, 400);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 38);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_voltar.Location = new Point(12, 400);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 38);
            btn_voltar.TabIndex = 6;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_voltar);
            Controls.Add(btn_sair);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_sair;
        private Button btn_voltar;
    }
}