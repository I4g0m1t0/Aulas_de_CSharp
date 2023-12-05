namespace Coversor_de_medidas
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
            btn_converter = new Button();
            txt_entrada = new TextBox();
            label2 = new Label();
            txt_resultado = new TextBox();
            cmb_de = new ComboBox();
            cmb_para = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 22);
            label1.Name = "label1";
            label1.Size = new Size(542, 37);
            label1.TabIndex = 0;
            label1.Text = "Conversor de medidas Mega Bombástico";
            // 
            // btn_converter
            // 
            btn_converter.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_converter.Location = new Point(327, 325);
            btn_converter.Name = "btn_converter";
            btn_converter.Size = new Size(137, 38);
            btn_converter.TabIndex = 1;
            btn_converter.Text = "Converter";
            btn_converter.UseVisualStyleBackColor = true;
            btn_converter.Click += btn_converter_Click;
            // 
            // txt_entrada
            // 
            txt_entrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_entrada.Location = new Point(129, 260);
            txt_entrada.Name = "txt_entrada";
            txt_entrada.Size = new Size(164, 29);
            txt_entrada.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(129, 224);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 3;
            label2.Text = "Valor a converter:";
            label2.Click += label2_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_resultado.Location = new Point(507, 260);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(164, 29);
            txt_resultado.TabIndex = 4;
            // 
            // cmb_de
            // 
            cmb_de.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_de.FormattingEnabled = true;
            cmb_de.Items.AddRange(new object[] { "Centímetros", "Metros", "Quilômetros" });
            cmb_de.Location = new Point(129, 147);
            cmb_de.Name = "cmb_de";
            cmb_de.Size = new Size(166, 29);
            cmb_de.TabIndex = 5;
            cmb_de.SelectedIndexChanged += cmb_de_SelectedIndexChanged;
            // 
            // cmb_para
            // 
            cmb_para.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_para.FormattingEnabled = true;
            cmb_para.Items.AddRange(new object[] { "Centímetros", "Metros", "Quilômetros" });
            cmb_para.Location = new Point(505, 147);
            cmb_para.Name = "cmb_para";
            cmb_para.Size = new Size(166, 29);
            cmb_para.TabIndex = 6;
            cmb_para.SelectedIndexChanged += cmb_para_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(507, 224);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 7;
            label3.Text = "Resultado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(129, 114);
            label4.Name = "label4";
            label4.Size = new Size(32, 21);
            label4.TabIndex = 8;
            label4.Text = "De:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(505, 114);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 9;
            label5.Text = "Para:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_para);
            Controls.Add(cmb_de);
            Controls.Add(txt_resultado);
            Controls.Add(label2);
            Controls.Add(txt_entrada);
            Controls.Add(btn_converter);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mega Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_converter;
        private TextBox txt_entrada;
        private Label label2;
        private TextBox txt_resultado;
        private ComboBox cmb_de;
        private ComboBox cmb_para;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmb_categorias;
    }
}