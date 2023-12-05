namespace Calculadora_elaborada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lbl_operacao = new Label();
            btnIgual = new Button();
            btn_divide = new Button();
            btn_clear = new Button();
            btn_ce = new Button();
            btn_porcentagem = new Button();
            btn_multiplica = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_subtrai = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_soma = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_aoquadrado = new Button();
            btn_virgula = new Button();
            btn_0 = new Button();
            btn_parentese = new Button();
            txtVisor = new TextBox();
            btnRaizQuadrada = new Button();
            btnSeno = new Button();
            btnCosseno = new Button();
            btnTangente = new Button();
            btnLog = new Button();
            SuspendLayout();
            // 
            // lbl_operacao
            // 
            lbl_operacao.AutoSize = true;
            lbl_operacao.BackColor = Color.White;
            lbl_operacao.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_operacao.ForeColor = Color.Black;
            lbl_operacao.Location = new Point(430, 15);
            lbl_operacao.Name = "lbl_operacao";
            lbl_operacao.Size = new Size(0, 59);
            lbl_operacao.TabIndex = 45;
            lbl_operacao.Click += lbl_operacao_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnIgual.Location = new Point(12, 428);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(479, 53);
            btnIgual.TabIndex = 43;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn_divide
            // 
            btn_divide.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_divide.Location = new Point(303, 192);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(91, 53);
            btn_divide.TabIndex = 42;
            btn_divide.Text = "÷";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            btn_divide.MouseClick += btnOperacao_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.Location = new Point(206, 133);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(91, 53);
            btn_clear.TabIndex = 41;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_ce
            // 
            btn_ce.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ce.Location = new Point(109, 133);
            btn_ce.Name = "btn_ce";
            btn_ce.Size = new Size(91, 53);
            btn_ce.TabIndex = 40;
            btn_ce.Text = "CE";
            btn_ce.UseVisualStyleBackColor = true;
            btn_ce.Click += btn_ce_Click;
            // 
            // btn_porcentagem
            // 
            btn_porcentagem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_porcentagem.Location = new Point(12, 133);
            btn_porcentagem.Name = "btn_porcentagem";
            btn_porcentagem.Size = new Size(91, 53);
            btn_porcentagem.TabIndex = 39;
            btn_porcentagem.Text = "%";
            btn_porcentagem.UseVisualStyleBackColor = true;
            btn_porcentagem.Click += btn_porcentagem_Click;
            // 
            // btn_multiplica
            // 
            btn_multiplica.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_multiplica.Location = new Point(303, 251);
            btn_multiplica.Name = "btn_multiplica";
            btn_multiplica.Size = new Size(91, 53);
            btn_multiplica.TabIndex = 38;
            btn_multiplica.Text = "x";
            btn_multiplica.UseVisualStyleBackColor = true;
            btn_multiplica.Click += btn_multiplica_Click;
            btn_multiplica.MouseClick += btnOperacao_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_9.Location = new Point(206, 192);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(91, 53);
            btn_9.TabIndex = 37;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.MouseClick += btnNumero_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_8.Location = new Point(109, 192);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(91, 53);
            btn_8.TabIndex = 36;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.MouseClick += btnNumero_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_7.Location = new Point(12, 192);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(91, 53);
            btn_7.TabIndex = 35;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.MouseClick += btnNumero_Click;
            // 
            // btn_subtrai
            // 
            btn_subtrai.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_subtrai.Location = new Point(303, 310);
            btn_subtrai.Name = "btn_subtrai";
            btn_subtrai.Size = new Size(91, 53);
            btn_subtrai.TabIndex = 34;
            btn_subtrai.Text = "-";
            btn_subtrai.UseVisualStyleBackColor = true;
            btn_subtrai.Click += btn_subtrai_Click;
            btn_subtrai.MouseClick += btnOperacao_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_6.Location = new Point(206, 251);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(91, 53);
            btn_6.TabIndex = 33;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.MouseClick += btnNumero_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_5.Location = new Point(109, 251);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(91, 53);
            btn_5.TabIndex = 32;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.MouseClick += btnNumero_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_4.Location = new Point(12, 251);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(91, 53);
            btn_4.TabIndex = 31;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.MouseClick += btnNumero_Click;
            // 
            // btn_soma
            // 
            btn_soma.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_soma.Location = new Point(303, 369);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(91, 53);
            btn_soma.TabIndex = 30;
            btn_soma.Text = "+";
            btn_soma.UseVisualStyleBackColor = true;
            btn_soma.Click += btn_soma_Click;
            btn_soma.MouseClick += btnOperacao_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_3.Location = new Point(206, 310);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(91, 53);
            btn_3.TabIndex = 29;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.MouseClick += btnNumero_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_2.Location = new Point(109, 310);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(91, 53);
            btn_2.TabIndex = 28;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.MouseClick += btnNumero_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_1.Location = new Point(12, 310);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(91, 53);
            btn_1.TabIndex = 27;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.MouseClick += btnNumero_Click;
            // 
            // btn_aoquadrado
            // 
            btn_aoquadrado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_aoquadrado.Location = new Point(303, 133);
            btn_aoquadrado.Name = "btn_aoquadrado";
            btn_aoquadrado.Size = new Size(91, 53);
            btn_aoquadrado.TabIndex = 26;
            btn_aoquadrado.Text = "x²";
            btn_aoquadrado.UseVisualStyleBackColor = true;
            btn_aoquadrado.Click += btn_aoquadrado_Click;
            btn_aoquadrado.MouseClick += btnOperacao_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_virgula.Location = new Point(206, 369);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(91, 53);
            btn_virgula.TabIndex = 25;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = true;
            btn_virgula.Click += btn_virgula_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_0.Location = new Point(109, 369);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(91, 53);
            btn_0.TabIndex = 24;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.MouseClick += btnNumero_Click;
            // 
            // btn_parentese
            // 
            btn_parentese.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_parentese.Location = new Point(12, 369);
            btn_parentese.Name = "btn_parentese";
            btn_parentese.Size = new Size(91, 53);
            btn_parentese.TabIndex = 23;
            btn_parentese.Text = "+/-";
            btn_parentese.UseVisualStyleBackColor = true;
            btn_parentese.Click += btn_parentese_Click;
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            txtVisor.Location = new Point(12, 12);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(479, 67);
            txtVisor.TabIndex = 44;
            txtVisor.TextChanged += txtVisor_TextChanged;
            // 
            // btnRaizQuadrada
            // 
            btnRaizQuadrada.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaizQuadrada.Location = new Point(400, 133);
            btnRaizQuadrada.Name = "btnRaizQuadrada";
            btnRaizQuadrada.Size = new Size(91, 53);
            btnRaizQuadrada.TabIndex = 46;
            btnRaizQuadrada.Text = "√";
            btnRaizQuadrada.UseVisualStyleBackColor = true;
            btnRaizQuadrada.Click += btnRaizQuadrada_Click;
            // 
            // btnSeno
            // 
            btnSeno.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeno.Location = new Point(400, 192);
            btnSeno.Name = "btnSeno";
            btnSeno.Size = new Size(91, 53);
            btnSeno.TabIndex = 47;
            btnSeno.Text = "Sin";
            btnSeno.UseVisualStyleBackColor = true;
            btnSeno.Click += btnSeno_Click;
            // 
            // btnCosseno
            // 
            btnCosseno.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCosseno.Location = new Point(400, 251);
            btnCosseno.Name = "btnCosseno";
            btnCosseno.Size = new Size(91, 53);
            btnCosseno.TabIndex = 48;
            btnCosseno.Text = "Cos";
            btnCosseno.UseVisualStyleBackColor = true;
            btnCosseno.Click += btnCosseno_Click;
            // 
            // btnTangente
            // 
            btnTangente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnTangente.Location = new Point(400, 310);
            btnTangente.Name = "btnTangente";
            btnTangente.Size = new Size(91, 53);
            btnTangente.TabIndex = 49;
            btnTangente.Text = "Tan";
            btnTangente.UseVisualStyleBackColor = true;
            btnTangente.Click += btnTangente_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.Location = new Point(400, 369);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(91, 53);
            btnLog.TabIndex = 50;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 493);
            Controls.Add(btnLog);
            Controls.Add(btnTangente);
            Controls.Add(btnCosseno);
            Controls.Add(btnSeno);
            Controls.Add(btnRaizQuadrada);
            Controls.Add(lbl_operacao);
            Controls.Add(btnIgual);
            Controls.Add(btn_divide);
            Controls.Add(btn_clear);
            Controls.Add(btn_ce);
            Controls.Add(btn_porcentagem);
            Controls.Add(btn_multiplica);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_subtrai);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_soma);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_aoquadrado);
            Controls.Add(btn_virgula);
            Controls.Add(btn_0);
            Controls.Add(btn_parentese);
            Controls.Add(txtVisor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Mega calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_operacao;
        private Button btnIgual;
        private Button btn_divide;
        private Button btn_clear;
        private Button btn_ce;
        private Button btn_porcentagem;
        private Button btn_multiplica;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_subtrai;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_soma;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_aoquadrado;
        private Button btn_virgula;
        private Button btn_0;
        private Button btn_parentese;
        private TextBox txtVisor;
        private Button btnRaizQuadrada;
        private Button btnSeno;
        private Button btnCosseno;
        private Button btnTangente;
        private Button btnLog;
    }
}