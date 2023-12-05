namespace mega_sena_chatgpt
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSortear = new System.Windows.Forms.Button();
            this.flowLayoutPanelNumeros = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResultadoSorteio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(121, 256);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(237, 34);
            this.btnSortear.TabIndex = 121;
            this.btnSortear.Text = "Sortear números";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btn_sortear_Click);
            // 
            // flowLayoutPanelNumeros
            // 
            this.flowLayoutPanelNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelNumeros.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelNumeros.Name = "flowLayoutPanelNumeros";
            this.flowLayoutPanelNumeros.Size = new System.Drawing.Size(487, 227);
            this.flowLayoutPanelNumeros.TabIndex = 122;
            // 
            // lblResultadoSorteio
            // 
            this.lblResultadoSorteio.AutoSize = true;
            this.lblResultadoSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSorteio.Location = new System.Drawing.Point(12, 312);
            this.lblResultadoSorteio.Name = "lblResultadoSorteio";
            this.lblResultadoSorteio.Size = new System.Drawing.Size(0, 24);
            this.lblResultadoSorteio.TabIndex = 124;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.lblResultadoSorteio);
            this.Controls.Add(this.flowLayoutPanelNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumeros;
        private System.Windows.Forms.Label lblResultadoSorteio;
    }
}

