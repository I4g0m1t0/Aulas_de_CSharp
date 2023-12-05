namespace Exercício_Temperatura_Vetores
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
            ltb_temp = new ListBox();
            txt_temp = new TextBox();
            btn_add = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_maior = new TextBox();
            txt_menor = new TextBox();
            txt_media = new TextBox();
            btn_calcular = new Button();
            label5 = new Label();
            txb_menormedia = new TextBox();
            label6 = new Label();
            txb_maiormedia = new TextBox();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 78);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 0;
            label1.Text = "Informe a temperatura:";
            // 
            // ltb_temp
            // 
            ltb_temp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ltb_temp.FormattingEnabled = true;
            ltb_temp.ItemHeight = 23;
            ltb_temp.Location = new Point(90, 134);
            ltb_temp.Name = "ltb_temp";
            ltb_temp.Size = new Size(138, 257);
            ltb_temp.TabIndex = 1;
            // 
            // txt_temp
            // 
            txt_temp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_temp.Location = new Point(300, 78);
            txt_temp.Name = "txt_temp";
            txt_temp.Size = new Size(100, 34);
            txt_temp.TabIndex = 2;
            txt_temp.TextChanged += txt_temp_TextChanged;
            // 
            // btn_add
            // 
            btn_add.Enabled = false;
            btn_add.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(427, 77);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(109, 37);
            btn_add.TabIndex = 3;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(324, 207);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 4;
            label2.Text = "Maior Temperatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(324, 253);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 5;
            label3.Text = "Menor Temperatura:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(324, 299);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 6;
            label4.Text = "Média Temperatura: ";
            // 
            // txt_maior
            // 
            txt_maior.Enabled = false;
            txt_maior.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_maior.Location = new Point(512, 207);
            txt_maior.Name = "txt_maior";
            txt_maior.Size = new Size(100, 34);
            txt_maior.TabIndex = 7;
            // 
            // txt_menor
            // 
            txt_menor.Enabled = false;
            txt_menor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_menor.Location = new Point(518, 253);
            txt_menor.Name = "txt_menor";
            txt_menor.Size = new Size(100, 34);
            txt_menor.TabIndex = 8;
            // 
            // txt_media
            // 
            txt_media.Enabled = false;
            txt_media.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_media.Location = new Point(518, 299);
            txt_media.Name = "txt_media";
            txt_media.Size = new Size(100, 34);
            txt_media.TabIndex = 9;
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calcular.Location = new Point(380, 155);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(109, 37);
            btn_calcular.TabIndex = 10;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(294, 19);
            label5.Name = "label5";
            label5.Size = new Size(212, 37);
            label5.TabIndex = 11;
            label5.Text = "TEMPERATURA";
            // 
            // txb_menormedia
            // 
            txb_menormedia.Enabled = false;
            txb_menormedia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_menormedia.Location = new Point(539, 340);
            txb_menormedia.Name = "txb_menormedia";
            txb_menormedia.Size = new Size(100, 34);
            txb_menormedia.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(324, 340);
            label6.Name = "label6";
            label6.Size = new Size(209, 28);
            label6.TabIndex = 12;
            label6.Text = "Menores que  a média:";
            // 
            // txb_maiormedia
            // 
            txb_maiormedia.Enabled = false;
            txb_maiormedia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_maiormedia.Location = new Point(533, 380);
            txb_maiormedia.Name = "txb_maiormedia";
            txb_maiormedia.Size = new Size(100, 34);
            txb_maiormedia.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(324, 380);
            label7.Name = "label7";
            label7.Size = new Size(203, 28);
            label7.TabIndex = 14;
            label7.Text = "Maiores que  a média:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(105, 401);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 16;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txb_maiormedia);
            Controls.Add(label7);
            Controls.Add(txb_menormedia);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_calcular);
            Controls.Add(txt_media);
            Controls.Add(txt_menor);
            Controls.Add(txt_maior);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_add);
            Controls.Add(txt_temp);
            Controls.Add(ltb_temp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Exercício_Temp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ltb_temp;
        private TextBox txt_temp;
        private Button btn_add;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_maior;
        private TextBox txt_menor;
        private TextBox txt_media;
        private Button btn_calcular;
        private Label label5;
        private TextBox txb_menormedia;
        private Label label6;
        private TextBox txb_maiormedia;
        private Label label7;
        private Button button1;
    }
}