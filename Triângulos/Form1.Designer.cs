namespace Triângulos
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
            label2 = new Label();
            label3 = new Label();
            txt_lado1 = new TextBox();
            txt_lado2 = new TextBox();
            txt_lado3 = new TextBox();
            btn_verificar = new Button();
            label4 = new Label();
            label_resultado = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 73);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Lado 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 101);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 1;
            label2.Text = "Lado 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 131);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 2;
            label3.Text = "Lado 3";
            // 
            // txt_lado1
            // 
            txt_lado1.Location = new Point(202, 76);
            txt_lado1.Name = "txt_lado1";
            txt_lado1.Size = new Size(190, 23);
            txt_lado1.TabIndex = 3;
            txt_lado1.TextChanged += textBox1_TextChanged;
            // 
            // txt_lado2
            // 
            txt_lado2.Location = new Point(202, 104);
            txt_lado2.Name = "txt_lado2";
            txt_lado2.Size = new Size(190, 23);
            txt_lado2.TabIndex = 4;
            // 
            // txt_lado3
            // 
            txt_lado3.Location = new Point(202, 134);
            txt_lado3.Name = "txt_lado3";
            txt_lado3.Size = new Size(190, 23);
            txt_lado3.TabIndex = 5;
            // 
            // btn_verificar
            // 
            btn_verificar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_verificar.Location = new Point(158, 184);
            btn_verificar.Name = "btn_verificar";
            btn_verificar.Size = new Size(177, 45);
            btn_verificar.TabIndex = 6;
            btn_verificar.Text = "Verificar";
            btn_verificar.UseVisualStyleBackColor = true;
            btn_verificar.Click += btn_verificar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(101, 274);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 7;
            label4.Text = "Resultado:";
            label4.Click += label4_Click;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_resultado.Location = new Point(215, 274);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(0, 28);
            label_resultado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(476, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "triangulo-isosceles-PhotoRoom.png-PhotoRoom.png");
            imageList1.Images.SetKeyName(1, "triangulo-escaleno-PhotoRoom.png-PhotoRoom.png");
            imageList1.Images.SetKeyName(2, "triangulo-equilatero-PhotoRoom.png-PhotoRoom.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label_resultado);
            Controls.Add(label4);
            Controls.Add(btn_verificar);
            Controls.Add(txt_lado3);
            Controls.Add(txt_lado2);
            Controls.Add(txt_lado1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_lado1;
        private TextBox txt_lado2;
        private TextBox txt_lado3;
        private Button btn_verificar;
        private Label label4;
        private Label label_resultado;
        private PictureBox pictureBox1;
        private ImageList imageList1;
    }
}