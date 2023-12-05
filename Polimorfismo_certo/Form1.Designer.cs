namespace Polimorfismo_certo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBoloBasico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sensacao = new System.Windows.Forms.Button();
            this.btn_negra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENCOMENDA DE BOLOS";
            // 
            // btnBoloBasico
            // 
            this.btnBoloBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoloBasico.Location = new System.Drawing.Point(301, 180);
            this.btnBoloBasico.Name = "btnBoloBasico";
            this.btnBoloBasico.Size = new System.Drawing.Size(163, 80);
            this.btnBoloBasico.TabIndex = 3;
            this.btnBoloBasico.Text = "BOLO BÁSICO";
            this.btnBoloBasico.UseVisualStyleBackColor = true;
            this.btnBoloBasico.Click += new System.EventHandler(this.btnBoloBasico_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "NOZES + 40%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sensacao
            // 
            this.btn_sensacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sensacao.Location = new System.Drawing.Point(296, 331);
            this.btn_sensacao.Name = "btn_sensacao";
            this.btn_sensacao.Size = new System.Drawing.Size(168, 97);
            this.btn_sensacao.TabIndex = 8;
            this.btn_sensacao.Text = "SENSAÇÃO + 50%";
            this.btn_sensacao.UseVisualStyleBackColor = true;
            this.btn_sensacao.Click += new System.EventHandler(this.btn_sensacao_Click);
            // 
            // btn_negra
            // 
            this.btn_negra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_negra.Location = new System.Drawing.Point(523, 331);
            this.btn_negra.Name = "btn_negra";
            this.btn_negra.Size = new System.Drawing.Size(173, 97);
            this.btn_negra.TabIndex = 9;
            this.btn_negra.Text = "FLORESTA NEGRA + 20%";
            this.btn_negra.UseVisualStyleBackColor = true;
            this.btn_negra.Click += new System.EventHandler(this.btn_negra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço Bolo:";
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoFinal.Location = new System.Drawing.Point(301, 504);
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.Size = new System.Drawing.Size(202, 35);
            this.txtPrecoFinal.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(782, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 305);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(852, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 80);
            this.button2.TabIndex = 14;
            this.button2.Text = "Abrir Imagem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(418, 663);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 305);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imagem cadastrada:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 1003);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrecoFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_negra);
            this.Controls.Add(this.btn_sensacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBoloBasico);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBoloBasico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sensacao;
        private System.Windows.Forms.Button btn_negra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

