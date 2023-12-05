namespace Jogo_da_mega_sena_certo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanelNumeros = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResultadoSorteio = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQuantidadeNumeros = new System.Windows.Forms.ComboBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNumeros
            // 
            this.flowLayoutPanelNumeros.BackColor = System.Drawing.Color.GreenYellow;
            this.flowLayoutPanelNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelNumeros.Location = new System.Drawing.Point(12, 57);
            this.flowLayoutPanelNumeros.Name = "flowLayoutPanelNumeros";
            this.flowLayoutPanelNumeros.Size = new System.Drawing.Size(463, 273);
            this.flowLayoutPanelNumeros.TabIndex = 123;
            this.flowLayoutPanelNumeros.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelNumeros_Paint);
            // 
            // lblResultadoSorteio
            // 
            this.lblResultadoSorteio.AutoSize = true;
            this.lblResultadoSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSorteio.Location = new System.Drawing.Point(12, 388);
            this.lblResultadoSorteio.Name = "lblResultadoSorteio";
            this.lblResultadoSorteio.Size = new System.Drawing.Size(0, 24);
            this.lblResultadoSorteio.TabIndex = 125;
            // 
            // btnSortear
            // 
            this.btnSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortear.Location = new System.Drawing.Point(126, 336);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(237, 34);
            this.btnSortear.TabIndex = 126;
            this.btnSortear.Text = "Sortear números";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 100);
            this.label1.TabIndex = 128;
            this.label1.Text = "Selecione a quantidade de números que deseja apostar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxQuantidadeNumeros
            // 
            this.comboBoxQuantidadeNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuantidadeNumeros.FormattingEnabled = true;
            this.comboBoxQuantidadeNumeros.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxQuantidadeNumeros.Location = new System.Drawing.Point(599, 209);
            this.comboBoxQuantidadeNumeros.Name = "comboBoxQuantidadeNumeros";
            this.comboBoxQuantidadeNumeros.Size = new System.Drawing.Size(121, 32);
            this.comboBoxQuantidadeNumeros.TabIndex = 129;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(570, 290);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(179, 34);
            this.btn_limpar.TabIndex = 130;
            this.btn_limpar.Text = "Refazer aposta";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 36);
            this.label2.TabIndex = 131;
            this.label2.Text = "Mega Mega-Sena";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.comboBoxQuantidadeNumeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.lblResultadoSorteio);
            this.Controls.Add(this.flowLayoutPanelNumeros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kasino Royale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNumeros;
        private System.Windows.Forms.Label lblResultadoSorteio;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQuantidadeNumeros;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label2;
    }
}

