namespace Jogo_da_velha
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoJogoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contador_x = new Label();
            contador_empate = new Label();
            contador_o = new Label();
            reiniciarContadorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(374, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoJogoToolStripMenuItem, reiniciarContadorToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoJogoToolStripMenuItem
            // 
            novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            novoJogoToolStripMenuItem.Size = new Size(180, 22);
            novoJogoToolStripMenuItem.Text = "Novo Jogo";
            novoJogoToolStripMenuItem.Click += novoJogoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // A1
            // 
            A1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            A1.Location = new Point(72, 80);
            A1.Name = "A1";
            A1.Size = new Size(75, 75);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            A1.MouseEnter += mouse_enter;
            A1.MouseLeave += mouse_leave;
            // 
            // A2
            // 
            A2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            A2.Location = new Point(153, 80);
            A2.Name = "A2";
            A2.Size = new Size(75, 75);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            A2.MouseEnter += mouse_enter;
            A2.MouseLeave += mouse_leave;
            // 
            // A3
            // 
            A3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            A3.Location = new Point(234, 80);
            A3.Name = "A3";
            A3.Size = new Size(75, 75);
            A3.TabIndex = 3;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            A3.MouseEnter += mouse_enter;
            A3.MouseLeave += mouse_leave;
            // 
            // B1
            // 
            B1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            B1.Location = new Point(72, 161);
            B1.Name = "B1";
            B1.Size = new Size(75, 75);
            B1.TabIndex = 4;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            B1.MouseEnter += mouse_enter;
            B1.MouseLeave += mouse_leave;
            // 
            // B2
            // 
            B2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            B2.Location = new Point(153, 161);
            B2.Name = "B2";
            B2.Size = new Size(75, 75);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            B2.MouseEnter += mouse_enter;
            B2.MouseLeave += mouse_leave;
            // 
            // B3
            // 
            B3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            B3.Location = new Point(234, 161);
            B3.Name = "B3";
            B3.Size = new Size(75, 75);
            B3.TabIndex = 6;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            B3.MouseEnter += mouse_enter;
            B3.MouseLeave += mouse_leave;
            // 
            // C1
            // 
            C1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            C1.Location = new Point(72, 242);
            C1.Name = "C1";
            C1.Size = new Size(75, 75);
            C1.TabIndex = 7;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            C1.MouseEnter += mouse_enter;
            C1.MouseLeave += mouse_leave;
            // 
            // C2
            // 
            C2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            C2.Location = new Point(153, 242);
            C2.Name = "C2";
            C2.Size = new Size(75, 75);
            C2.TabIndex = 8;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            C2.MouseEnter += mouse_enter;
            C2.MouseLeave += mouse_leave;
            // 
            // C3
            // 
            C3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            C3.Location = new Point(234, 242);
            C3.Name = "C3";
            C3.Size = new Size(75, 75);
            C3.TabIndex = 9;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            C3.MouseEnter += mouse_enter;
            C3.MouseLeave += mouse_leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 329);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 10;
            label1.Text = "X ganhou:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 329);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Empatou:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 329);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "O ganhou:";
            // 
            // contador_x
            // 
            contador_x.AutoSize = true;
            contador_x.Location = new Point(96, 350);
            contador_x.Name = "contador_x";
            contador_x.Size = new Size(13, 15);
            contador_x.TabIndex = 13;
            contador_x.Text = "0";
            // 
            // contador_empate
            // 
            contador_empate.AutoSize = true;
            contador_empate.Location = new Point(183, 350);
            contador_empate.Name = "contador_empate";
            contador_empate.Size = new Size(13, 15);
            contador_empate.TabIndex = 14;
            contador_empate.Text = "0";
            // 
            // contador_o
            // 
            contador_o.AutoSize = true;
            contador_o.Location = new Point(270, 350);
            contador_o.Name = "contador_o";
            contador_o.Size = new Size(13, 15);
            contador_o.TabIndex = 15;
            contador_o.Text = "0";
            // 
            // reiniciarContadorToolStripMenuItem
            // 
            reiniciarContadorToolStripMenuItem.Name = "reiniciarContadorToolStripMenuItem";
            reiniciarContadorToolStripMenuItem.Size = new Size(180, 22);
            reiniciarContadorToolStripMenuItem.Text = "Reiniciar Contador";
            reiniciarContadorToolStripMenuItem.Click += reiniciarContadorToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 400);
            Controls.Add(contador_o);
            Controls.Add(contador_empate);
            Controls.Add(contador_x);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da velha";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoJogoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label contador_x;
        private Label contador_empate;
        private Label contador_o;
        private ToolStripMenuItem reiniciarContadorToolStripMenuItem;
    }
}