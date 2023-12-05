namespace estrutura_for
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
            txbNum = new TextBox();
            ltbTabuada = new ListBox();
            btnTabuada = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            btn_impares = new Button();
            btn_fatorial = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Número:";
            // 
            // txbNum
            // 
            txbNum.Location = new Point(167, 50);
            txbNum.Name = "txbNum";
            txbNum.Size = new Size(100, 23);
            txbNum.TabIndex = 1;
            // 
            // ltbTabuada
            // 
            ltbTabuada.FormattingEnabled = true;
            ltbTabuada.ItemHeight = 15;
            ltbTabuada.Location = new Point(41, 92);
            ltbTabuada.Name = "ltbTabuada";
            ltbTabuada.Size = new Size(120, 289);
            ltbTabuada.TabIndex = 2;
            // 
            // btnTabuada
            // 
            btnTabuada.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnTabuada.Location = new Point(214, 92);
            btnTabuada.Name = "btnTabuada";
            btnTabuada.Size = new Size(117, 41);
            btnTabuada.TabIndex = 3;
            btnTabuada.Text = "Tabuada";
            btnTabuada.UseVisualStyleBackColor = true;
            btnTabuada.Click += btnTabuada_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(214, 275);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(117, 41);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(214, 336);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(117, 41);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btn_impares
            // 
            btn_impares.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_impares.Location = new Point(214, 153);
            btn_impares.Name = "btn_impares";
            btn_impares.Size = new Size(117, 41);
            btn_impares.TabIndex = 6;
            btn_impares.Text = "Ímpares";
            btn_impares.UseVisualStyleBackColor = true;
            btn_impares.Click += btn_impares_Click;
            // 
            // btn_fatorial
            // 
            btn_fatorial.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_fatorial.Location = new Point(214, 214);
            btn_fatorial.Name = "btn_fatorial";
            btn_fatorial.Size = new Size(117, 41);
            btn_fatorial.TabIndex = 7;
            btn_fatorial.Text = "Fatorial";
            btn_fatorial.UseVisualStyleBackColor = true;
            btn_fatorial.Click += btn_fatorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(btn_fatorial);
            Controls.Add(btn_impares);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnTabuada);
            Controls.Add(ltbTabuada);
            Controls.Add(txbNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNum;
        private ListBox ltbTabuada;
        private Button btnTabuada;
        private Button btnLimpar;
        private Button btnSair;
        private Button btn_impares;
        private Button btn_fatorial;
    }
}