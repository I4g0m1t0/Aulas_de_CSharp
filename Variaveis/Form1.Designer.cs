namespace Variaveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txt_Nome = new TextBox();
            txt_Numero = new TextBox();
            btnConfirmar = new Button();
            btnVerificar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 54);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 104);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 1;
            label2.Text = "Digite um número:";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(118, 59);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(276, 23);
            txt_Nome.TabIndex = 2;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(234, 109);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(160, 23);
            txt_Numero.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(38, 229);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(95, 27);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.Location = new Point(171, 229);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(95, 27);
            btnVerificar.TabIndex = 5;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(299, 229);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(95, 27);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(436, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 332);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnVerificar);
            Controls.Add(btnConfirmar);
            Controls.Add(txt_Numero);
            Controls.Add(txt_Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Nome;
        private TextBox txt_Numero;
        private Button btnConfirmar;
        private Button btnVerificar;
        private Button btnSair;
        private PictureBox pictureBox1;
    }
}