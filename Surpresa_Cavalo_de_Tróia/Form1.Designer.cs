namespace Surpresa
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Cmb_jogador = new ComboBox();
            btn_link = new Button();
            pictureBox1 = new PictureBox();
            lbl_texto = new Label();
            button1 = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Javanese Text", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 51);
            label1.Name = "label1";
            label1.Size = new Size(283, 62);
            label1.TabIndex = 0;
            label1.Text = "Selecione um jogador:";
            // 
            // Cmb_jogador
            // 
            Cmb_jogador.Font = new Font("Javanese Text", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Cmb_jogador.FormattingEnabled = true;
            Cmb_jogador.ImeMode = ImeMode.NoControl;
            Cmb_jogador.IntegralHeight = false;
            Cmb_jogador.Items.AddRange(new object[] { "Cristiano Ronaldo", "Lionel Messi", "Neymar", "Mbappé", "Haaland" });
            Cmb_jogador.Location = new Point(429, 51);
            Cmb_jogador.Name = "Cmb_jogador";
            Cmb_jogador.Size = new Size(231, 53);
            Cmb_jogador.TabIndex = 1;
            Cmb_jogador.SelectedIndexChanged += Cmb_jogador_SelectedIndexChanged;
            Cmb_jogador.TextChanged += Cmb_jogador_SelectedIndexChanged;
            // 
            // btn_link
            // 
            btn_link.Enabled = false;
            btn_link.Font = new Font("Javanese Text", 15F, FontStyle.Underline, GraphicsUnit.Point);
            btn_link.Location = new Point(317, 384);
            btn_link.Name = "btn_link";
            btn_link.Size = new Size(166, 45);
            btn_link.TabIndex = 2;
            btn_link.Text = "Highlights";
            btn_link.UseVisualStyleBackColor = true;
            btn_link.Click += btn_link_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(522, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl_texto
            // 
            lbl_texto.AllowDrop = true;
            lbl_texto.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_texto.Location = new Point(80, 131);
            lbl_texto.Name = "lbl_texto";
            lbl_texto.Size = new Size(403, 220);
            lbl_texto.TabIndex = 4;
            lbl_texto.Text = "Por favor, selecione um jogador";
            lbl_texto.Click += lbl_texto_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(740, 412);
            button1.Name = "button1";
            button1.Size = new Size(48, 26);
            button1.TabIndex = 5;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "naom_650a1079a9674.jpg");
            imageList1.Images.SetKeyName(1, "Lionel-Messi-Inter-Miami-Wallpaper-HD.jpg");
            imageList1.Images.SetKeyName(2, "mbappe.jpg");
            imageList1.Images.SetKeyName(3, "Neymar-se-junta-ao-Al-Hilal-em-contratacao-historica-por-R-17-Bilhao.jpg");
            imageList1.Images.SetKeyName(4, "Erling_Haaland_Manchester_City_Newcastle_2022-23.jpg");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl_texto);
            Controls.Add(pictureBox1);
            Controls.Add(btn_link);
            Controls.Add(Cmb_jogador);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Surpresinha pra teacher";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Cmb_jogador;
        private Button btn_link;
        private PictureBox pictureBox1;
        private Label lbl_texto;
        private Button button1;
        private ImageList imageList1;
    }
}