namespace emlakotomasyonu
{
    partial class musterilistesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musterilistesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ileri = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.rbisim = new System.Windows.Forms.RadioButton();
            this.rbtc = new System.Windows.Forms.RadioButton();
            this.rbsoyisim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbaranan = new System.Windows.Forms.TextBox();
            this.silme = new System.Windows.Forms.PictureBox();
            this.anasayfa = new System.Windows.Forms.PictureBox();
            this.tumkayit = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 342);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 243);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "MÜŞTERİ LİSTESİ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(59, 645);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(124, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // ileri
            // 
            this.ileri.BackColor = System.Drawing.Color.White;
            this.ileri.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.Location = new System.Drawing.Point(954, 271);
            this.ileri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(135, 61);
            this.ileri.TabIndex = 18;
            this.ileri.Text = "İLERİ";
            this.ileri.UseVisualStyleBackColor = false;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Location = new System.Drawing.Point(1094, 270);
            this.geri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(143, 62);
            this.geri.TabIndex = 19;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // rbisim
            // 
            this.rbisim.AutoSize = true;
            this.rbisim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbisim.Location = new System.Drawing.Point(61, 64);
            this.rbisim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbisim.Name = "rbisim";
            this.rbisim.Size = new System.Drawing.Size(226, 27);
            this.rbisim.TabIndex = 20;
            this.rbisim.TabStop = true;
            this.rbisim.Text = "İSİME GÖRE ARAMA";
            this.rbisim.UseVisualStyleBackColor = false;
            this.rbisim.CheckedChanged += new System.EventHandler(this.rbisim_CheckedChanged);
            // 
            // rbtc
            // 
            this.rbtc.AutoSize = true;
            this.rbtc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtc.Location = new System.Drawing.Point(61, 192);
            this.rbtc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtc.Name = "rbtc";
            this.rbtc.Size = new System.Drawing.Size(402, 27);
            this.rbtc.TabIndex = 21;
            this.rbtc.TabStop = true;
            this.rbtc.Text = "TC KİMLİK NUMARASINA GÖRE ARAMA";
            this.rbtc.UseVisualStyleBackColor = false;
            this.rbtc.CheckedChanged += new System.EventHandler(this.rbtc_CheckedChanged);
            // 
            // rbsoyisim
            // 
            this.rbsoyisim.AutoSize = true;
            this.rbsoyisim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbsoyisim.Location = new System.Drawing.Point(61, 128);
            this.rbsoyisim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbsoyisim.Name = "rbsoyisim";
            this.rbsoyisim.Size = new System.Drawing.Size(269, 27);
            this.rbsoyisim.TabIndex = 22;
            this.rbsoyisim.TabStop = true;
            this.rbsoyisim.Text = "SOYİSİME GÖRE ARAMA";
            this.rbsoyisim.UseVisualStyleBackColor = false;
            this.rbsoyisim.CheckedChanged += new System.EventHandler(this.rbsoyisim_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbisim);
            this.groupBox1.Controls.Add(this.rbtc);
            this.groupBox1.Controls.Add(this.rbsoyisim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(26, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(537, 272);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA KRİTERLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbaranan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(571, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(375, 254);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARANACAK METİN";
            // 
            // tbaranan
            // 
            this.tbaranan.Location = new System.Drawing.Point(4, 71);
            this.tbaranan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbaranan.Name = "tbaranan";
            this.tbaranan.Size = new System.Drawing.Size(360, 33);
            this.tbaranan.TabIndex = 0;
            this.tbaranan.TextChanged += new System.EventHandler(this.tbaranan_TextChanged);
            this.tbaranan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbaranan_KeyPress);
            // 
            // silme
            // 
            this.silme.Image = ((System.Drawing.Image)(resources.GetObject("silme.Image")));
            this.silme.Location = new System.Drawing.Point(609, 625);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(191, 117);
            this.silme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.silme.TabIndex = 25;
            this.silme.TabStop = false;
            this.silme.Click += new System.EventHandler(this.silme_Click);
            // 
            // anasayfa
            // 
            this.anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("anasayfa.Image")));
            this.anasayfa.Location = new System.Drawing.Point(876, 625);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(171, 117);
            this.anasayfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anasayfa.TabIndex = 26;
            this.anasayfa.TabStop = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // tumkayit
            // 
            this.tumkayit.AutoSize = true;
            this.tumkayit.Location = new System.Drawing.Point(954, 135);
            this.tumkayit.Name = "tumkayit";
            this.tumkayit.Size = new System.Drawing.Size(272, 27);
            this.tumkayit.TabIndex = 27;
            this.tumkayit.Text = "TÜM KAYITLARI GÖSTER";
            this.tumkayit.UseVisualStyleBackColor = true;
            this.tumkayit.CheckedChanged += new System.EventHandler(this.tumkayit_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1110, 625);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1012, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 100);
            this.button1.TabIndex = 29;
            this.button1.Text = "RAPOR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musterilistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1325, 971);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tumkayit);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.silme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "musterilistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listeler";
            this.Load += new System.EventHandler(this.listeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anasayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.RadioButton rbisim;
        private System.Windows.Forms.RadioButton rbtc;
        private System.Windows.Forms.RadioButton rbsoyisim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbaranan;
        private System.Windows.Forms.PictureBox silme;
        private System.Windows.Forms.PictureBox anasayfa;
        private System.Windows.Forms.CheckBox tumkayit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}