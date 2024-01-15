namespace Relógio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.parar = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cronometro = new System.Windows.Forms.Button();
            this.temporizador = new System.Windows.Forms.Button();
            this.alarme = new System.Windows.Forms.Button();
            this.volta = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_iniciarTemp = new System.Windows.Forms.Button();
            this.btn_pararTemp = new System.Windows.Forms.Button();
            this.btn_continuarTemp = new System.Windows.Forms.Button();
            this.cmb_minTemp = new System.Windows.Forms.ComboBox();
            this.lbl_minTemp = new System.Windows.Forms.Label();
            this.lbl_secTemp = new System.Windows.Forms.Label();
            this.cmb_secTemp = new System.Windows.Forms.ComboBox();
            this.timer_temp = new System.Windows.Forms.Timer(this.components);
            this.lbl_temp = new System.Windows.Forms.Label();
            this.btn_resetTemp = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dateTimePickerAlarme = new System.Windows.Forms.DateTimePicker();
            this.btn_iniciarAlarme = new System.Windows.Forms.Button();
            this.btn_pararAlarme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_alarme = new System.Windows.Forms.Timer(this.components);
            this.btnSelecionarMusica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "11:11:11.11";
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(236, 216);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(91, 32);
            this.iniciar.TabIndex = 1;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Visible = false;
            this.iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // parar
            // 
            this.parar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parar.Location = new System.Drawing.Point(370, 216);
            this.parar.Name = "parar";
            this.parar.Size = new System.Drawing.Size(91, 32);
            this.parar.TabIndex = 2;
            this.parar.Text = "Parar";
            this.parar.UseVisualStyleBackColor = true;
            this.parar.Visible = false;
            this.parar.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(504, 216);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 32);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reiniciar";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cronometro
            // 
            this.cronometro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cronometro.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cronometro.Location = new System.Drawing.Point(52, 108);
            this.cronometro.Name = "cronometro";
            this.cronometro.Size = new System.Drawing.Size(119, 29);
            this.cronometro.TabIndex = 5;
            this.cronometro.Text = "Cronômetro";
            this.cronometro.UseVisualStyleBackColor = false;
            this.cronometro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // temporizador
            // 
            this.temporizador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.temporizador.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temporizador.Location = new System.Drawing.Point(52, 152);
            this.temporizador.Name = "temporizador";
            this.temporizador.Size = new System.Drawing.Size(119, 29);
            this.temporizador.TabIndex = 6;
            this.temporizador.Text = "Temporizador";
            this.temporizador.UseVisualStyleBackColor = false;
            this.temporizador.Click += new System.EventHandler(this.temporizador_Click);
            // 
            // alarme
            // 
            this.alarme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.alarme.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarme.Location = new System.Drawing.Point(52, 62);
            this.alarme.Name = "alarme";
            this.alarme.Size = new System.Drawing.Size(119, 29);
            this.alarme.TabIndex = 7;
            this.alarme.Text = "Alarme";
            this.alarme.UseVisualStyleBackColor = false;
            this.alarme.Click += new System.EventHandler(this.button3_Click);
            // 
            // volta
            // 
            this.volta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volta.Location = new System.Drawing.Point(655, 216);
            this.volta.Name = "volta";
            this.volta.Size = new System.Drawing.Size(91, 32);
            this.volta.TabIndex = 8;
            this.volta.Text = "Volta";
            this.volta.UseVisualStyleBackColor = true;
            this.volta.Visible = false;
            this.volta.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(236, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 124);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            // 
            // btn_iniciarTemp
            // 
            this.btn_iniciarTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarTemp.Location = new System.Drawing.Point(236, 216);
            this.btn_iniciarTemp.Name = "btn_iniciarTemp";
            this.btn_iniciarTemp.Size = new System.Drawing.Size(91, 32);
            this.btn_iniciarTemp.TabIndex = 10;
            this.btn_iniciarTemp.Text = "Iniciar";
            this.btn_iniciarTemp.UseVisualStyleBackColor = true;
            this.btn_iniciarTemp.Visible = false;
            this.btn_iniciarTemp.Click += new System.EventHandler(this.btn_iniciarTemp_Click);
            // 
            // btn_pararTemp
            // 
            this.btn_pararTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pararTemp.Location = new System.Drawing.Point(370, 216);
            this.btn_pararTemp.Name = "btn_pararTemp";
            this.btn_pararTemp.Size = new System.Drawing.Size(91, 32);
            this.btn_pararTemp.TabIndex = 11;
            this.btn_pararTemp.Text = "Parar";
            this.btn_pararTemp.UseVisualStyleBackColor = true;
            this.btn_pararTemp.Visible = false;
            this.btn_pararTemp.Click += new System.EventHandler(this.btn_pararTemp_Click);
            // 
            // btn_continuarTemp
            // 
            this.btn_continuarTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuarTemp.Location = new System.Drawing.Point(655, 216);
            this.btn_continuarTemp.Name = "btn_continuarTemp";
            this.btn_continuarTemp.Size = new System.Drawing.Size(115, 32);
            this.btn_continuarTemp.TabIndex = 12;
            this.btn_continuarTemp.Text = "Continuar";
            this.btn_continuarTemp.UseVisualStyleBackColor = true;
            this.btn_continuarTemp.Visible = false;
            this.btn_continuarTemp.Click += new System.EventHandler(this.btn_continuarTemp_Click);
            // 
            // cmb_minTemp
            // 
            this.cmb_minTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_minTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_minTemp.FormattingEnabled = true;
            this.cmb_minTemp.Location = new System.Drawing.Point(361, 310);
            this.cmb_minTemp.Name = "cmb_minTemp";
            this.cmb_minTemp.Size = new System.Drawing.Size(121, 26);
            this.cmb_minTemp.TabIndex = 13;
            this.cmb_minTemp.Visible = false;
            // 
            // lbl_minTemp
            // 
            this.lbl_minTemp.AutoSize = true;
            this.lbl_minTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minTemp.Location = new System.Drawing.Point(356, 282);
            this.lbl_minTemp.Name = "lbl_minTemp";
            this.lbl_minTemp.Size = new System.Drawing.Size(94, 25);
            this.lbl_minTemp.TabIndex = 14;
            this.lbl_minTemp.Text = "Minutos:";
            this.lbl_minTemp.Visible = false;
            // 
            // lbl_secTemp
            // 
            this.lbl_secTemp.AutoSize = true;
            this.lbl_secTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secTemp.Location = new System.Drawing.Point(504, 282);
            this.lbl_secTemp.Name = "lbl_secTemp";
            this.lbl_secTemp.Size = new System.Drawing.Size(115, 25);
            this.lbl_secTemp.TabIndex = 15;
            this.lbl_secTemp.Text = "Segundos:";
            this.lbl_secTemp.Visible = false;
            // 
            // cmb_secTemp
            // 
            this.cmb_secTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_secTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_secTemp.FormattingEnabled = true;
            this.cmb_secTemp.Location = new System.Drawing.Point(509, 310);
            this.cmb_secTemp.Name = "cmb_secTemp";
            this.cmb_secTemp.Size = new System.Drawing.Size(121, 26);
            this.cmb_secTemp.TabIndex = 16;
            this.cmb_secTemp.Visible = false;
            // 
            // timer_temp
            // 
            this.timer_temp.Interval = 1000;
            this.timer_temp.Tick += new System.EventHandler(this.timer_temp_Tick);
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.Location = new System.Drawing.Point(352, 84);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(284, 108);
            this.lbl_temp.TabIndex = 17;
            this.lbl_temp.Text = "00:00";
            this.lbl_temp.Visible = false;
            // 
            // btn_resetTemp
            // 
            this.btn_resetTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetTemp.Location = new System.Drawing.Point(504, 216);
            this.btn_resetTemp.Name = "btn_resetTemp";
            this.btn_resetTemp.Size = new System.Drawing.Size(108, 32);
            this.btn_resetTemp.TabIndex = 18;
            this.btn_resetTemp.Text = "Reset";
            this.btn_resetTemp.UseVisualStyleBackColor = true;
            this.btn_resetTemp.Visible = false;
            this.btn_resetTemp.Click += new System.EventHandler(this.btn_resetTemp_Click);
            // 
            // dateTimePickerAlarme
            // 
            this.dateTimePickerAlarme.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAlarme.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dateTimePickerAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAlarme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAlarme.Location = new System.Drawing.Point(236, 80);
            this.dateTimePickerAlarme.Name = "dateTimePickerAlarme";
            this.dateTimePickerAlarme.Size = new System.Drawing.Size(510, 116);
            this.dateTimePickerAlarme.TabIndex = 19;
            this.dateTimePickerAlarme.Visible = false;
            this.dateTimePickerAlarme.ValueChanged += new System.EventHandler(this.dateTimePickerAlarme_ValueChanged);
            // 
            // btn_iniciarAlarme
            // 
            this.btn_iniciarAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarAlarme.Location = new System.Drawing.Point(264, 216);
            this.btn_iniciarAlarme.Name = "btn_iniciarAlarme";
            this.btn_iniciarAlarme.Size = new System.Drawing.Size(91, 32);
            this.btn_iniciarAlarme.TabIndex = 20;
            this.btn_iniciarAlarme.Text = "Iniciar";
            this.btn_iniciarAlarme.UseVisualStyleBackColor = true;
            this.btn_iniciarAlarme.Visible = false;
            this.btn_iniciarAlarme.Click += new System.EventHandler(this.btn_iniciarAlarme_Click);
            // 
            // btn_pararAlarme
            // 
            this.btn_pararAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pararAlarme.Location = new System.Drawing.Point(395, 216);
            this.btn_pararAlarme.Name = "btn_pararAlarme";
            this.btn_pararAlarme.Size = new System.Drawing.Size(108, 32);
            this.btn_pararAlarme.TabIndex = 21;
            this.btn_pararAlarme.Text = "Parar";
            this.btn_pararAlarme.UseVisualStyleBackColor = true;
            this.btn_pararAlarme.Visible = false;
            this.btn_pararAlarme.Click += new System.EventHandler(this.btn_pararAlarme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer_alarme
            // 
            this.timer_alarme.Tick += new System.EventHandler(this.timer_alarme_Tick);
            // 
            // btnSelecionarMusica
            // 
            this.btnSelecionarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarMusica.Location = new System.Drawing.Point(531, 216);
            this.btnSelecionarMusica.Name = "btnSelecionarMusica";
            this.btnSelecionarMusica.Size = new System.Drawing.Size(196, 32);
            this.btnSelecionarMusica.TabIndex = 23;
            this.btnSelecionarMusica.Text = "Selecionar música";
            this.btnSelecionarMusica.UseVisualStyleBackColor = true;
            this.btnSelecionarMusica.Visible = false;
            this.btnSelecionarMusica.Click += new System.EventHandler(this.btnSelecionarMusica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecionarMusica);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pararAlarme);
            this.Controls.Add(this.btn_iniciarAlarme);
            this.Controls.Add(this.dateTimePickerAlarme);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.cmb_secTemp);
            this.Controls.Add(this.lbl_secTemp);
            this.Controls.Add(this.lbl_minTemp);
            this.Controls.Add(this.cmb_minTemp);
            this.Controls.Add(this.btn_pararTemp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.volta);
            this.Controls.Add(this.alarme);
            this.Controls.Add(this.temporizador);
            this.Controls.Add(this.cronometro);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.parar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_resetTemp);
            this.Controls.Add(this.btn_continuarTemp);
            this.Controls.Add(this.btn_iniciarTemp);
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button parar;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button cronometro;
        private System.Windows.Forms.Button temporizador;
        private System.Windows.Forms.Button alarme;
        private System.Windows.Forms.Button volta;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_iniciarTemp;
        private System.Windows.Forms.Button btn_pararTemp;
        private System.Windows.Forms.Button btn_continuarTemp;
        private System.Windows.Forms.ComboBox cmb_minTemp;
        private System.Windows.Forms.Label lbl_minTemp;
        private System.Windows.Forms.Label lbl_secTemp;
        private System.Windows.Forms.ComboBox cmb_secTemp;
        private System.Windows.Forms.Timer timer_temp;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Button btn_resetTemp;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlarme;
        private System.Windows.Forms.Button btn_iniciarAlarme;
        private System.Windows.Forms.Button btn_pararAlarme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_alarme;
        private System.Windows.Forms.Button btnSelecionarMusica;
    }
}

