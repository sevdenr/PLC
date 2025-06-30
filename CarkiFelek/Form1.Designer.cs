namespace CarkiFelek
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
            groupBox1 = new GroupBox();
            O2Puan = new Label();
            label3 = new Label();
            O1Puan = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            Durdur = new Button();
            baslat = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            seçeneklerToolStripMenuItem = new ToolStripMenuItem();
            zorlukSeviyesiToolStripMenuItem = new ToolStripMenuItem();
            turSayısıToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(O2Puan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(O1Puan);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(Durdur);
            groupBox1.Controls.Add(baslat);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // O2Puan
            // 
            O2Puan.AutoSize = true;
            O2Puan.Location = new Point(380, 144);
            O2Puan.Name = "O2Puan";
            O2Puan.Size = new Size(0, 15);
            O2Puan.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Location = new Point(380, 129);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Oyuncu 2 Puan:";
            // 
            // O1Puan
            // 
            O1Puan.AutoSize = true;
            O1Puan.Location = new Point(380, 97);
            O1Puan.Name = "O1Puan";
            O1Puan.Size = new Size(0, 15);
            O1Puan.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Location = new Point(380, 82);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 4;
            label1.Text = "Oyuncu 1 Puan:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.Location = new Point(160, 139);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 58);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Durdur
            // 
            Durdur.Location = new Point(207, 314);
            Durdur.Name = "Durdur";
            Durdur.Size = new Size(140, 62);
            Durdur.TabIndex = 2;
            Durdur.Text = "Durdur";
            Durdur.UseVisualStyleBackColor = true;
            Durdur.Click += Durdur_Click;
            // 
            // baslat
            // 
            baslat.Location = new Point(51, 314);
            baslat.Name = "baslat";
            baslat.Size = new Size(140, 62);
            baslat.TabIndex = 1;
            baslat.Text = "Başlat";
            baslat.UseVisualStyleBackColor = true;
            baslat.Click += baslat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cark11;
            pictureBox1.Location = new Point(51, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 50;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { seçeneklerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(580, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // seçeneklerToolStripMenuItem
            // 
            seçeneklerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zorlukSeviyesiToolStripMenuItem, turSayısıToolStripMenuItem });
            seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            seçeneklerToolStripMenuItem.Size = new Size(75, 20);
            seçeneklerToolStripMenuItem.Text = "Seçenekler";
            // 
            // zorlukSeviyesiToolStripMenuItem
            // 
            zorlukSeviyesiToolStripMenuItem.Name = "zorlukSeviyesiToolStripMenuItem";
            zorlukSeviyesiToolStripMenuItem.Size = new Size(152, 22);
            zorlukSeviyesiToolStripMenuItem.Text = "Zorluk Seviyesi";
            zorlukSeviyesiToolStripMenuItem.Click += zorlukSeviyesiToolStripMenuItem_Click;
            // 
            // turSayısıToolStripMenuItem
            // 
            turSayısıToolStripMenuItem.Name = "turSayısıToolStripMenuItem";
            turSayısıToolStripMenuItem.Size = new Size(152, 22);
            turSayısıToolStripMenuItem.Text = "Tur Sayısı";
            turSayısıToolStripMenuItem.Click += turSayısıToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(580, 479);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button Durdur;
        private Button baslat;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label O2Puan;
        private Label label3;
        private Label O1Puan;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem seçeneklerToolStripMenuItem;
        private ToolStripMenuItem zorlukSeviyesiToolStripMenuItem;
        private ToolStripMenuItem turSayısıToolStripMenuItem;
    }
}
