namespace DropBox
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
            groupBox1 = new GroupBox();
            rb_chocolate = new RadioButton();
            rb_frango = new RadioButton();
            rb_4queijos = new RadioButton();
            rb_calabresa = new RadioButton();
            groupBox2 = new GroupBox();
            ckb_suco = new CheckBox();
            ckb_soda = new CheckBox();
            ckb_refri = new CheckBox();
            ckb_agua = new CheckBox();
            label2 = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            msk_cpf = new MaskedTextBox();
            btn_sair = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbl_pizza = new Label();
            lbl_adicional = new Label();
            lbl_bebida = new Label();
            lbl_pgto = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(323, 27);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(157, 47);
            label1.TabIndex = 0;
            label1.Text = "Escolhas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_chocolate);
            groupBox1.Controls.Add(rb_frango);
            groupBox1.Controls.Add(rb_4queijos);
            groupBox1.Controls.Add(rb_calabresa);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(102, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 169);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizzas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rb_chocolate
            // 
            rb_chocolate.AutoSize = true;
            rb_chocolate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rb_chocolate.Location = new Point(6, 131);
            rb_chocolate.Name = "rb_chocolate";
            rb_chocolate.Size = new Size(97, 25);
            rb_chocolate.TabIndex = 3;
            rb_chocolate.Text = "Chocolate";
            rb_chocolate.UseVisualStyleBackColor = true;
            rb_chocolate.CheckedChanged += rb_chocolate_CheckedChanged;
            // 
            // rb_frango
            // 
            rb_frango.AutoSize = true;
            rb_frango.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rb_frango.Location = new Point(6, 100);
            rb_frango.Name = "rb_frango";
            rb_frango.Size = new Size(157, 25);
            rb_frango.TabIndex = 2;
            rb_frango.Text = "Frango c/ Catupiry";
            rb_frango.UseVisualStyleBackColor = true;
            rb_frango.CheckedChanged += rb_frango_CheckedChanged;
            // 
            // rb_4queijos
            // 
            rb_4queijos.AutoSize = true;
            rb_4queijos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rb_4queijos.Location = new Point(6, 69);
            rb_4queijos.Name = "rb_4queijos";
            rb_4queijos.Size = new Size(94, 25);
            rb_4queijos.TabIndex = 1;
            rb_4queijos.Text = "4 Queijos";
            rb_4queijos.UseVisualStyleBackColor = true;
            rb_4queijos.CheckedChanged += rb_4queijos_CheckedChanged;
            // 
            // rb_calabresa
            // 
            rb_calabresa.AutoSize = true;
            rb_calabresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rb_calabresa.Location = new Point(6, 38);
            rb_calabresa.Name = "rb_calabresa";
            rb_calabresa.Size = new Size(96, 25);
            rb_calabresa.TabIndex = 0;
            rb_calabresa.Text = "Calabresa";
            rb_calabresa.UseVisualStyleBackColor = true;
            rb_calabresa.CheckedChanged += rb_calabresa_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckb_suco);
            groupBox2.Controls.Add(ckb_soda);
            groupBox2.Controls.Add(ckb_refri);
            groupBox2.Controls.Add(ckb_agua);
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(469, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 169);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bebidas";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // ckb_suco
            // 
            ckb_suco.AutoSize = true;
            ckb_suco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_suco.Location = new Point(15, 131);
            ckb_suco.Name = "ckb_suco";
            ckb_suco.Size = new Size(130, 25);
            ckb_suco.TabIndex = 3;
            ckb_suco.Text = "Sucos naturais";
            ckb_suco.UseVisualStyleBackColor = true;
            ckb_suco.CheckedChanged += ckb_suco_CheckedChanged;
            // 
            // ckb_soda
            // 
            ckb_soda.AutoSize = true;
            ckb_soda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_soda.Location = new Point(15, 100);
            ckb_soda.Name = "ckb_soda";
            ckb_soda.Size = new Size(118, 25);
            ckb_soda.TabIndex = 2;
            ckb_soda.Text = "Soda italiana";
            ckb_soda.UseVisualStyleBackColor = true;
            ckb_soda.CheckedChanged += ckb_soda_CheckedChanged;
            // 
            // ckb_refri
            // 
            ckb_refri.AutoSize = true;
            ckb_refri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_refri.Location = new Point(15, 69);
            ckb_refri.Name = "ckb_refri";
            ckb_refri.Size = new Size(91, 25);
            ckb_refri.TabIndex = 1;
            ckb_refri.Text = "Refri lata";
            ckb_refri.UseVisualStyleBackColor = true;
            ckb_refri.CheckedChanged += ckb_refri_CheckedChanged;
            // 
            // ckb_agua
            // 
            ckb_agua.AutoSize = true;
            ckb_agua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_agua.Location = new Point(15, 38);
            ckb_agua.Name = "ckb_agua";
            ckb_agua.Size = new Size(65, 25);
            ckb_agua.TabIndex = 0;
            ckb_agua.Text = "Água";
            ckb_agua.UseVisualStyleBackColor = true;
            ckb_agua.CheckedChanged += ckb_agua_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(108, 360);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(122, 32);
            label2.TabIndex = 5;
            label2.Text = "Adicionais";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Borda recheada", "Batata frita", "Cebola extra", "Camarão" });
            listBox1.Location = new Point(102, 406);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 151);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Crédito", "Débito", "Pix", "Dinheiro" });
            comboBox1.Location = new Point(469, 403);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 29);
            comboBox1.TabIndex = 7;
            toolTip1.SetToolTip(comboBox1, "Selecione uma forma de pagamento");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(480, 360);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(244, 32);
            label3.TabIndex = 8;
            label3.Text = "Forma de pagamento";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(484, 480);
            button1.Name = "button1";
            button1.Size = new Size(240, 48);
            button1.TabIndex = 9;
            button1.Text = "Limpar Tudo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(816, 151);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(816, 360);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(54, 32);
            label4.TabIndex = 11;
            label4.Text = "CPF";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // msk_cpf
            // 
            msk_cpf.Location = new Point(876, 369);
            msk_cpf.Mask = "999\\.999\\.999-99";
            msk_cpf.Name = "msk_cpf";
            msk_cpf.Size = new Size(167, 23);
            msk_cpf.TabIndex = 12;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.Transparent;
            btn_sair.ForeColor = Color.Transparent;
            btn_sair.Image = (Image)resources.GetObject("btn_sair.Image");
            btn_sair.Location = new Point(970, 490);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(73, 67);
            btn_sair.TabIndex = 13;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1135, 144);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(144, 32);
            label5.TabIndex = 14;
            label5.Text = "Pedido Final";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1146, 188);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 15;
            label6.Text = "Pizza:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1146, 217);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 16;
            label7.Text = "Adicional:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1146, 248);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 17;
            label8.Text = "Bebida(s):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1146, 277);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 18;
            label9.Text = "Pgto:";
            // 
            // lbl_pizza
            // 
            lbl_pizza.AutoSize = true;
            lbl_pizza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pizza.Location = new Point(1206, 188);
            lbl_pizza.Name = "lbl_pizza";
            lbl_pizza.Size = new Size(0, 21);
            lbl_pizza.TabIndex = 19;
            // 
            // lbl_adicional
            // 
            lbl_adicional.AutoSize = true;
            lbl_adicional.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_adicional.Location = new Point(1239, 217);
            lbl_adicional.Name = "lbl_adicional";
            lbl_adicional.Size = new Size(0, 21);
            lbl_adicional.TabIndex = 20;
            lbl_adicional.Click += label10_Click;
            // 
            // lbl_bebida
            // 
            lbl_bebida.AutoSize = true;
            lbl_bebida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_bebida.Location = new Point(1239, 248);
            lbl_bebida.Name = "lbl_bebida";
            lbl_bebida.Size = new Size(0, 21);
            lbl_bebida.TabIndex = 21;
            // 
            // lbl_pgto
            // 
            lbl_pgto.AutoSize = true;
            lbl_pgto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pgto.Location = new Point(1202, 279);
            lbl_pgto.Name = "lbl_pgto";
            lbl_pgto.Size = new Size(0, 21);
            lbl_pgto.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1135, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "4 queijos.jpg");
            imageList1.Images.SetKeyName(1, "frango.jpg");
            imageList1.Images.SetKeyName(2, "receitas-de-pizza-de-calabresa-6.jpg");
            imageList1.Images.SetKeyName(3, "pizza-de-chocolate.jpg");
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 578);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_pgto);
            Controls.Add(lbl_bebida);
            Controls.Add(lbl_adicional);
            Controls.Add(lbl_pizza);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_sair);
            Controls.Add(msk_cpf);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rb_frango;
        private RadioButton rb_4queijos;
        private RadioButton rb_calabresa;
        private RadioButton rb_chocolate;
        private GroupBox groupBox2;
        private CheckBox ckb_suco;
        private CheckBox ckb_soda;
        private CheckBox ckb_refri;
        private CheckBox ckb_agua;
        private Label label2;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private MaskedTextBox msk_cpf;
        private Button btn_sair;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_pizza;
        private Label lbl_adicional;
        private Label lbl_bebida;
        private Label lbl_pgto;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private ToolTip toolTip1;
    }
}