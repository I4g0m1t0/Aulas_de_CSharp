namespace _3_botao
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
            btn_um = new Button();
            btn_dois = new Button();
            btn_teste = new Button();
            SuspendLayout();
            // 
            // btn_um
            // 
            btn_um.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            btn_um.Location = new Point(144, 90);
            btn_um.Name = "btn_um";
            btn_um.Size = new Size(178, 66);
            btn_um.TabIndex = 0;
            btn_um.Text = "Um";
            btn_um.UseVisualStyleBackColor = true;
            btn_um.Click += btn_um_Click;
            // 
            // btn_dois
            // 
            btn_dois.Enabled = false;
            btn_dois.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dois.Location = new Point(479, 90);
            btn_dois.Name = "btn_dois";
            btn_dois.Size = new Size(178, 66);
            btn_dois.TabIndex = 1;
            btn_dois.Text = "Dois";
            btn_dois.UseVisualStyleBackColor = true;
            btn_dois.Click += btn_dois_Click;
            // 
            // btn_teste
            // 
            btn_teste.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            btn_teste.Location = new Point(314, 305);
            btn_teste.Name = "btn_teste";
            btn_teste.Size = new Size(178, 66);
            btn_teste.TabIndex = 2;
            btn_teste.Text = "Teste";
            btn_teste.UseVisualStyleBackColor = true;
            btn_teste.Click += btn_teste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_teste);
            Controls.Add(btn_dois);
            Controls.Add(btn_um);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_um;
        private Button btn_dois;
        private Button btn_teste;
    }
}