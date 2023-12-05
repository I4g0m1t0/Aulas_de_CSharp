namespace comobobox_dependente
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
            cmb_categorias = new ComboBox();
            cmb_2 = new ComboBox();
            cmb_1 = new ComboBox();
            SuspendLayout();
            // 
            // cmb_categorias
            // 
            cmb_categorias.FormattingEnabled = true;
            cmb_categorias.Items.AddRange(new object[] { "Comprimento", "Tempo" });
            cmb_categorias.Location = new Point(336, 118);
            cmb_categorias.Name = "cmb_categorias";
            cmb_categorias.Size = new Size(121, 23);
            cmb_categorias.TabIndex = 0;
            cmb_categorias.SelectedIndexChanged += cmb_categorias_SelectedIndexChanged;
            // 
            // cmb_2
            // 
            cmb_2.FormattingEnabled = true;
            cmb_2.Items.AddRange(new object[] { "Mês", "M/s", "Metro" });
            cmb_2.Location = new Point(467, 217);
            cmb_2.Name = "cmb_2";
            cmb_2.Size = new Size(121, 23);
            cmb_2.TabIndex = 1;
            // 
            // cmb_1
            // 
            cmb_1.FormattingEnabled = true;
            cmb_1.Items.AddRange(new object[] { "Mês", "Km/h", "Metro" });
            cmb_1.Location = new Point(213, 217);
            cmb_1.Name = "cmb_1";
            cmb_1.Size = new Size(121, 23);
            cmb_1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_1);
            Controls.Add(cmb_2);
            Controls.Add(cmb_categorias);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb_categorias;
        private ComboBox cmb_2;
        private ComboBox cmb_1;
    }
}