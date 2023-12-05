namespace pares_no_intervalo
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
            txb_de = new TextBox();
            txb_para = new TextBox();
            ltb_resultado = new ListBox();
            btn_calcular = new Button();
            bn_limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 74);
            label1.Name = "label1";
            label1.Size = new Size(56, 37);
            label1.TabIndex = 0;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(407, 74);
            label2.Name = "label2";
            label2.Size = new Size(63, 37);
            label2.TabIndex = 1;
            label2.Text = "Até:";
            // 
            // txb_de
            // 
            txb_de.Location = new Point(199, 86);
            txb_de.Name = "txb_de";
            txb_de.Size = new Size(100, 23);
            txb_de.TabIndex = 2;
            // 
            // txb_para
            // 
            txb_para.Location = new Point(476, 86);
            txb_para.Name = "txb_para";
            txb_para.Size = new Size(100, 23);
            txb_para.TabIndex = 3;
            // 
            // ltb_resultado
            // 
            ltb_resultado.FormattingEnabled = true;
            ltb_resultado.ItemHeight = 15;
            ltb_resultado.Location = new Point(241, 205);
            ltb_resultado.Name = "ltb_resultado";
            ltb_resultado.Size = new Size(231, 139);
            ltb_resultado.TabIndex = 4;
            // 
            // btn_calcular
            // 
            btn_calcular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_calcular.Location = new Point(297, 146);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(119, 37);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // bn_limpar
            // 
            bn_limpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bn_limpar.Location = new Point(297, 368);
            bn_limpar.Name = "bn_limpar";
            bn_limpar.Size = new Size(119, 37);
            bn_limpar.TabIndex = 6;
            bn_limpar.Text = "Limpar";
            bn_limpar.UseVisualStyleBackColor = true;
            bn_limpar.Click += bn_limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(bn_limpar);
            Controls.Add(btn_calcular);
            Controls.Add(ltb_resultado);
            Controls.Add(txb_para);
            Controls.Add(txb_de);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txb_de;
        private TextBox txb_para;
        private ListBox ltb_resultado;
        private Button btn_calcular;
        private Button bn_limpar;
    }
}