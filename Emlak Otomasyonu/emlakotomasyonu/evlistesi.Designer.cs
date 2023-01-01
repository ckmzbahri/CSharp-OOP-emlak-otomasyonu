namespace emlakotomasyonu
{
    partial class evlistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(evlistesi));
            this.tumkayit = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aranan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbadres = new System.Windows.Forms.RadioButton();
            this.rbdrum = new System.Windows.Forms.RadioButton();
            this.geri = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tumkayit
            // 
            this.tumkayit.AutoSize = true;
            this.tumkayit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tumkayit.Location = new System.Drawing.Point(56, 603);
            this.tumkayit.Name = "tumkayit";
            this.tumkayit.Size = new System.Drawing.Size(272, 27);
            this.tumkayit.TabIndex = 37;
            this.tumkayit.Text = "TÜM KAYITLARI GÖSTER";
            this.tumkayit.UseVisualStyleBackColor = true;
            this.tumkayit.CheckedChanged += new System.EventHandler(this.tumkayit_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aranan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(22, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(375, 254);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARANACAK METİN";
            // 
            // aranan
            // 
            this.aranan.Location = new System.Drawing.Point(4, 71);
            this.aranan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aranan.Name = "aranan";
            this.aranan.Size = new System.Drawing.Size(360, 33);
            this.aranan.TabIndex = 0;
            this.aranan.TextChanged += new System.EventHandler(this.aranan_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbadres);
            this.groupBox1.Controls.Add(this.rbdrum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(375, 272);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA KRİTERLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbadres
            // 
            this.rbadres.AutoSize = true;
            this.rbadres.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbadres.Location = new System.Drawing.Point(4, 68);
            this.rbadres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbadres.Name = "rbadres";
            this.rbadres.Size = new System.Drawing.Size(251, 27);
            this.rbadres.TabIndex = 20;
            this.rbadres.TabStop = true;
            this.rbadres.Text = "ADRESE GÖRE ARAMA";
            this.rbadres.UseVisualStyleBackColor = false;
            this.rbadres.CheckedChanged += new System.EventHandler(this.rbadres_CheckedChanged);
            // 
            // rbdrum
            // 
            this.rbdrum.AutoSize = true;
            this.rbdrum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbdrum.Location = new System.Drawing.Point(4, 140);
            this.rbdrum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbdrum.Name = "rbdrum";
            this.rbdrum.Size = new System.Drawing.Size(331, 27);
            this.rbdrum.TabIndex = 22;
            this.rbdrum.TabStop = true;
            this.rbdrum.Text = "EVİN DURUMUNA GÖRE ARAMA";
            this.rbdrum.UseVisualStyleBackColor = false;
            this.rbdrum.CheckedChanged += new System.EventHandler(this.rbdrum_CheckedChanged);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.White;
            this.geri.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri.Location = new System.Drawing.Point(813, 568);
            this.geri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(143, 62);
            this.geri.TabIndex = 32;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // ileri
            // 
            this.ileri.BackColor = System.Drawing.Color.White;
            this.ileri.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ileri.Location = new System.Drawing.Point(1114, 568);
            this.ileri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(135, 61);
            this.ileri.TabIndex = 31;
            this.ileri.Text = "İLERİ";
            this.ileri.UseVisualStyleBackColor = false;
            this.ileri.Click += new System.EventHandler(this.ileri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(405, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "EV LİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 322);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 243);
            this.dataGridView1.TabIndex = 29;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(433, 574);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(123, 25);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // evlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tumkayit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "evlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evlistesi";
            this.Load += new System.EventHandler(this.evlistesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox tumkayit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox aranan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbadres;
        private System.Windows.Forms.RadioButton rbdrum;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}