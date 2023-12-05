namespace Vetor_caracteres
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
            label1 = new Label();
            txb_texto = new TextBox();
            label2 = new Label();
            btn_verificar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbl_maiusc = new Label();
            lbl_especial = new Label();
            lbl_minusc = new Label();
            lbl_num = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 25);
            label1.Name = "label1";
            label1.Size = new Size(570, 37);
            label1.TabIndex = 0;
            label1.Text = "Leitor de caracteres HIPER-BOMBÁSTICO!!!";
            // 
            // txb_texto
            // 
            txb_texto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_texto.Location = new Point(163, 143);
            txb_texto.Name = "txb_texto";
            txb_texto.Size = new Size(474, 34);
            txb_texto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(338, 95);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 2;
            label2.Text = "Escreva algo:";
            // 
            // btn_verificar
            // 
            btn_verificar.BackColor = Color.Lime;
            btn_verificar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_verificar.Location = new Point(344, 203);
            btn_verificar.Name = "btn_verificar";
            btn_verificar.Size = new Size(113, 40);
            btn_verificar.TabIndex = 3;
            btn_verificar.Text = "Verificar";
            btn_verificar.UseVisualStyleBackColor = false;
            btn_verificar.Click += btn_verificar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 260);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 4;
            label3.Text = "Maiúsculas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(163, 361);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 5;
            label4.Text = "Minúsculas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(510, 260);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 6;
            label5.Text = "Especiais:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(510, 361);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 7;
            label6.Text = "Números:";
            // 
            // lbl_maiusc
            // 
            lbl_maiusc.AutoSize = true;
            lbl_maiusc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_maiusc.Location = new Point(280, 260);
            lbl_maiusc.Name = "lbl_maiusc";
            lbl_maiusc.Size = new Size(0, 28);
            lbl_maiusc.TabIndex = 8;
            // 
            // lbl_especial
            // 
            lbl_especial.AutoSize = true;
            lbl_especial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_especial.Location = new Point(609, 260);
            lbl_especial.Name = "lbl_especial";
            lbl_especial.Size = new Size(0, 28);
            lbl_especial.TabIndex = 9;
            // 
            // lbl_minusc
            // 
            lbl_minusc.AutoSize = true;
            lbl_minusc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_minusc.Location = new Point(281, 361);
            lbl_minusc.Name = "lbl_minusc";
            lbl_minusc.Size = new Size(0, 28);
            lbl_minusc.TabIndex = 10;
            // 
            // lbl_num
            // 
            lbl_num.AutoSize = true;
            lbl_num.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num.Location = new Point(612, 361);
            lbl_num.Name = "lbl_num";
            lbl_num.Size = new Size(0, 28);
            lbl_num.TabIndex = 11;
            lbl_num.Click += label10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(344, 398);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 12;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl_num);
            Controls.Add(lbl_minusc);
            Controls.Add(lbl_especial);
            Controls.Add(lbl_maiusc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_verificar);
            Controls.Add(label2);
            Controls.Add(txb_texto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_texto;
        private Label label2;
        private Button btn_verificar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_maiusc;
        private Label lbl_especial;
        private Label lbl_minusc;
        private Label lbl_num;
        private Button button1;
    }
}