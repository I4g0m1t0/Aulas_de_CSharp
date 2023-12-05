namespace Vetores02
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
            ltb_numeros = new ListBox();
            label1 = new Label();
            btn_gerarnumeros = new Button();
            btn_gerarvetor = new Button();
            label2 = new Label();
            lbl_vetor = new Label();
            btn_ordenarvetor = new Button();
            btn_ordenarbuble = new Button();
            ltb_caracteres = new ListBox();
            btn_gerarcaracteres = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ltb_numeros
            // 
            ltb_numeros.FormattingEnabled = true;
            ltb_numeros.ItemHeight = 15;
            ltb_numeros.Location = new Point(45, 211);
            ltb_numeros.Name = "ltb_numeros";
            ltb_numeros.Size = new Size(120, 244);
            ltb_numeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 80);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 1;
            label1.Text = "Números";
            // 
            // btn_gerarnumeros
            // 
            btn_gerarnumeros.BackColor = Color.Gold;
            btn_gerarnumeros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gerarnumeros.Location = new Point(51, 129);
            btn_gerarnumeros.Name = "btn_gerarnumeros";
            btn_gerarnumeros.Size = new Size(109, 74);
            btn_gerarnumeros.TabIndex = 2;
            btn_gerarnumeros.Text = "Gerar Números";
            btn_gerarnumeros.UseVisualStyleBackColor = false;
            btn_gerarnumeros.Click += btn_gerarnumeros_Click;
            // 
            // btn_gerarvetor
            // 
            btn_gerarvetor.BackColor = Color.FromArgb(128, 255, 255);
            btn_gerarvetor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gerarvetor.Location = new Point(610, 74);
            btn_gerarvetor.Name = "btn_gerarvetor";
            btn_gerarvetor.Size = new Size(78, 39);
            btn_gerarvetor.TabIndex = 4;
            btn_gerarvetor.Text = "Gerar";
            btn_gerarvetor.UseVisualStyleBackColor = false;
            btn_gerarvetor.Click += btn_gerarvetor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(390, 80);
            label2.Name = "label2";
            label2.Size = new Size(60, 27);
            label2.TabIndex = 3;
            label2.Text = "Vetor";
            // 
            // lbl_vetor
            // 
            lbl_vetor.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_vetor.Location = new Point(390, 153);
            lbl_vetor.Name = "lbl_vetor";
            lbl_vetor.Size = new Size(298, 220);
            lbl_vetor.TabIndex = 5;
            lbl_vetor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_ordenarvetor
            // 
            btn_ordenarvetor.BackColor = Color.FromArgb(255, 192, 192);
            btn_ordenarvetor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ordenarvetor.Location = new Point(503, 435);
            btn_ordenarvetor.Name = "btn_ordenarvetor";
            btn_ordenarvetor.Size = new Size(103, 66);
            btn_ordenarvetor.TabIndex = 6;
            btn_ordenarvetor.Text = "Ordenar Vetor";
            btn_ordenarvetor.UseVisualStyleBackColor = false;
            btn_ordenarvetor.Click += btn_ordenarvetor_Click;
            // 
            // btn_ordenarbuble
            // 
            btn_ordenarbuble.BackColor = Color.FromArgb(192, 192, 255);
            btn_ordenarbuble.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ordenarbuble.Location = new Point(667, 401);
            btn_ordenarbuble.Name = "btn_ordenarbuble";
            btn_ordenarbuble.Size = new Size(103, 100);
            btn_ordenarbuble.TabIndex = 7;
            btn_ordenarbuble.Text = "Ordenar Buble Sort";
            btn_ordenarbuble.UseVisualStyleBackColor = false;
            btn_ordenarbuble.Click += btn_ordenarbuble_Click;
            // 
            // ltb_caracteres
            // 
            ltb_caracteres.FormattingEnabled = true;
            ltb_caracteres.ItemHeight = 15;
            ltb_caracteres.Location = new Point(201, 211);
            ltb_caracteres.Name = "ltb_caracteres";
            ltb_caracteres.Size = new Size(120, 244);
            ltb_caracteres.TabIndex = 8;
            // 
            // btn_gerarcaracteres
            // 
            btn_gerarcaracteres.BackColor = Color.Gold;
            btn_gerarcaracteres.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_gerarcaracteres.Location = new Point(204, 129);
            btn_gerarcaracteres.Name = "btn_gerarcaracteres";
            btn_gerarcaracteres.Size = new Size(111, 72);
            btn_gerarcaracteres.TabIndex = 9;
            btn_gerarcaracteres.Text = "Gerar Caracteres";
            btn_gerarcaracteres.UseVisualStyleBackColor = false;
            btn_gerarcaracteres.Click += btn_gerarcaracteres_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(208, 80);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 10;
            label4.Text = "Caracteres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(207, 18);
            label5.Name = "label5";
            label5.Size = new Size(386, 36);
            label5.TabIndex = 11;
            label5.Text = "Gerando Números Aleatórios";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_gerarcaracteres);
            Controls.Add(ltb_caracteres);
            Controls.Add(btn_ordenarbuble);
            Controls.Add(btn_ordenarvetor);
            Controls.Add(lbl_vetor);
            Controls.Add(btn_gerarvetor);
            Controls.Add(label2);
            Controls.Add(btn_gerarnumeros);
            Controls.Add(label1);
            Controls.Add(ltb_numeros);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ltb_numeros;
        private Label label1;
        private Button btn_gerarnumeros;
        private Button btn_gerarvetor;
        private Label label2;
        private Label lbl_vetor;
        private Button btn_ordenarvetor;
        private Button btn_ordenarbuble;
        private ListBox ltb_caracteres;
        private Button btn_gerarcaracteres;
        private Label label4;
        private Label label5;
    }
}