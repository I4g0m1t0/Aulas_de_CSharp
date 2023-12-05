namespace Vetores_01
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
            btnInserir = new Button();
            label1 = new Label();
            txtNum = new TextBox();
            lsbVetor = new ListBox();
            label2 = new Label();
            txtIndice = new Label();
            label3 = new Label();
            txtMaior = new TextBox();
            txtMenor = new TextBox();
            label4 = new Label();
            txtMedia = new TextBox();
            label5 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnInserir.Location = new Point(429, 93);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(156, 42);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "INSERIR";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 1;
            label1.Text = "Insira uma Idade:";
            label1.Click += label1_Click;
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNum.Location = new Point(323, 96);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 39);
            txtNum.TabIndex = 2;
            txtNum.TextChanged += txtNum_TextChanged;
            // 
            // lsbVetor
            // 
            lsbVetor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lsbVetor.FormattingEnabled = true;
            lsbVetor.ItemHeight = 32;
            lsbVetor.Location = new Point(72, 148);
            lsbVetor.Name = "lsbVetor";
            lsbVetor.Size = new Size(155, 324);
            lsbVetor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(282, 36);
            label2.Name = "label2";
            label2.Size = new Size(131, 37);
            label2.TabIndex = 4;
            label2.Text = "VETORES";
            // 
            // txtIndice
            // 
            txtIndice.AutoSize = true;
            txtIndice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtIndice.Location = new Point(276, 98);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(0, 32);
            txtIndice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(342, 263);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 6;
            label3.Text = "Maior Idade:";
            // 
            // txtMaior
            // 
            txtMaior.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaior.Location = new Point(495, 260);
            txtMaior.Name = "txtMaior";
            txtMaior.Size = new Size(100, 35);
            txtMaior.TabIndex = 7;
            // 
            // txtMenor
            // 
            txtMenor.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenor.Location = new Point(495, 311);
            txtMenor.Name = "txtMenor";
            txtMenor.Size = new Size(100, 35);
            txtMenor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(342, 314);
            label4.Name = "label4";
            label4.Size = new Size(155, 29);
            label4.TabIndex = 8;
            label4.Text = "Menor Idade:";
            // 
            // txtMedia
            // 
            txtMedia.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedia.Location = new Point(495, 364);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 35);
            txtMedia.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(342, 367);
            label5.Name = "label5";
            label5.Size = new Size(153, 29);
            label5.TabIndex = 10;
            label5.Text = "Média Idade:";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(373, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(156, 42);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(btnCalcular);
            Controls.Add(txtMedia);
            Controls.Add(label5);
            Controls.Add(txtMenor);
            Controls.Add(label4);
            Controls.Add(txtMaior);
            Controls.Add(label3);
            Controls.Add(txtIndice);
            Controls.Add(label2);
            Controls.Add(lsbVetor);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Controls.Add(btnInserir);
            Name = "Form1";
            Text = "VETORES";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Label label1;
        private TextBox txtNum;
        private ListBox lsbVetor;
        private Label label2;
        private Label txtIndice;
        private Label label3;
        private TextBox txtMaior;
        private TextBox txtMenor;
        private Label label4;
        private TextBox txtMedia;
        private Label label5;
        private Button btnCalcular;
    }
}