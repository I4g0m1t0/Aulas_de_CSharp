namespace Classe_imóvel
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txb_nome = new TextBox();
            txb_loc = new TextBox();
            txb_metros = new TextBox();
            txb_preco = new TextBox();
            txb_dono = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btn_cadastrar = new Button();
            lbl_cadastro = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            lbl_cadastrado = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(199, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome do imóvel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 1;
            label2.Text = "Localização:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 2;
            label3.Text = "Metragem:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 3;
            label4.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 4;
            label5.Text = "Dono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 295);
            label6.Name = "label6";
            label6.Size = new Size(225, 32);
            label6.TabIndex = 5;
            label6.Text = "Data de construção:";
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_nome.Location = new Point(217, 76);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(181, 34);
            txb_nome.TabIndex = 7;
            // 
            // txb_loc
            // 
            txb_loc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_loc.Location = new Point(157, 120);
            txb_loc.Name = "txb_loc";
            txb_loc.Size = new Size(241, 34);
            txb_loc.TabIndex = 8;
            // 
            // txb_metros
            // 
            txb_metros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_metros.Location = new Point(148, 165);
            txb_metros.Name = "txb_metros";
            txb_metros.Size = new Size(100, 34);
            txb_metros.TabIndex = 9;
            // 
            // txb_preco
            // 
            txb_preco.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_preco.Location = new Point(96, 208);
            txb_preco.Name = "txb_preco";
            txb_preco.Size = new Size(100, 34);
            txb_preco.TabIndex = 10;
            // 
            // txb_dono
            // 
            txb_dono.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txb_dono.Location = new Point(96, 253);
            txb_dono.Name = "txb_dono";
            txb_dono.Size = new Size(213, 34);
            txb_dono.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(243, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(372, 34);
            dateTimePicker1.TabIndex = 13;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cadastrar.Location = new Point(624, 50);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(243, 58);
            btn_cadastrar.TabIndex = 14;
            btn_cadastrar.Text = "Finalizar Cadastro";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Location = new Point(641, 120);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(217, 207);
            lbl_cadastro.TabIndex = 15;
            lbl_cadastro.Text = "lbl_cadastro";
            lbl_cadastro.Click += label7_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(908, 123);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(171, 32);
            button1.TabIndex = 16;
            button1.Text = "Diminuir R$ 1.000";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(908, 168);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(184, 32);
            button2.TabIndex = 17;
            button2.Text = "Diminuir R$ 10.000";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(908, 279);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(184, 32);
            button3.TabIndex = 19;
            button3.Text = "Aumentar R$ 10.000";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(908, 234);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(184, 32);
            button4.TabIndex = 18;
            button4.Text = "Aumentar R$ 1.000";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lbl_cadastrado
            // 
            lbl_cadastrado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cadastrado.Location = new Point(76, 429);
            lbl_cadastrado.Name = "lbl_cadastrado";
            lbl_cadastrado.Size = new Size(955, 321);
            lbl_cadastrado.TabIndex = 21;
            lbl_cadastrado.Text = "label7";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(456, 358);
            button5.Name = "button5";
            button5.Size = new Size(243, 58);
            button5.TabIndex = 20;
            button5.Text = "Imóveis Cadastrados";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 808);
            Controls.Add(lbl_cadastrado);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_cadastro);
            Controls.Add(btn_cadastrar);
            Controls.Add(dateTimePicker1);
            Controls.Add(txb_dono);
            Controls.Add(txb_preco);
            Controls.Add(txb_metros);
            Controls.Add(txb_loc);
            Controls.Add(txb_nome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Imóvel";
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
        private TextBox txb_nome;
        private TextBox txb_loc;
        private TextBox txb_metros;
        private TextBox txb_preco;
        private TextBox txb_dono;
        private DateTimePicker dateTimePicker1;
        private Button btn_cadastrar;
        private Label lbl_cadastro;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lbl_cadastrado;
        private Button button5;
    }
}