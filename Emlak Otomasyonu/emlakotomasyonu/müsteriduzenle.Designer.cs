namespace emlakotomasyonu
{
    partial class müsteriduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(müsteriduzenle));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.CBCİNSİYET = new System.Windows.Forms.ComboBox();
            this.cbdogum = new System.Windows.Forms.ComboBox();
            this.RESİMEKLE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbtelefon = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.güncelle = new System.Windows.Forms.PictureBox();
            this.aranan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.güncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(-68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "TC:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(270, 455);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(809, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(487, 333);
            this.dataGridView1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(34, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "TELEFON:";
            // 
            // CBCİNSİYET
            // 
            this.CBCİNSİYET.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBCİNSİYET.FormattingEnabled = true;
            this.CBCİNSİYET.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.CBCİNSİYET.Location = new System.Drawing.Point(186, 241);
            this.CBCİNSİYET.Name = "CBCİNSİYET";
            this.CBCİNSİYET.Size = new System.Drawing.Size(247, 31);
            this.CBCİNSİYET.TabIndex = 59;
            // 
            // cbdogum
            // 
            this.cbdogum.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbdogum.FormattingEnabled = true;
            this.cbdogum.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyon",
            " Ağrı",
            " Amasya",
            " Ankara",
            " Antalya",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkari",
            " Hatay",
            " Isparta",
            " İçel (Mersin)",
            " İstanbul",
            " İzmir",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " K.maraş",
            " Mardin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Rize",
            " Sakarya",
            " Samsun",
            " Siirt",
            " Sinop",
            " Sivas",
            " Tekirdağ",
            "Tokat",
            " Trabzon",
            " Tunceli",
            " Şanlıurfa",
            " Uşak",
            " Van",
            " Yozgat",
            " Zonguldak",
            " Aksaray",
            "Bayburt",
            " Karaman",
            " Kırıkkale",
            " Batman",
            " Şırnak",
            " Bartın",
            " Ardahan",
            " Iğdır",
            " Yalova",
            " Karabük",
            " Kilis",
            " Osmaniye",
            " Düzce",
            ""});
            this.cbdogum.Location = new System.Drawing.Point(186, 191);
            this.cbdogum.Name = "cbdogum";
            this.cbdogum.Size = new System.Drawing.Size(247, 31);
            this.cbdogum.TabIndex = 58;
            // 
            // RESİMEKLE
            // 
            this.RESİMEKLE.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RESİMEKLE.Location = new System.Drawing.Point(580, 229);
            this.RESİMEKLE.Name = "RESİMEKLE";
            this.RESİMEKLE.Size = new System.Drawing.Size(149, 53);
            this.RESİMEKLE.TabIndex = 57;
            this.RESİMEKLE.Text = "RESİM EKLE";
            this.RESİMEKLE.UseVisualStyleBackColor = true;
            this.RESİMEKLE.Click += new System.EventHandler(this.RESİMEKLE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(520, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // tbadres
            // 
            this.tbadres.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbadres.Location = new System.Drawing.Point(186, 328);
            this.tbadres.Multiline = true;
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(532, 121);
            this.tbadres.TabIndex = 55;
            // 
            // tbtelefon
            // 
            this.tbtelefon.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtelefon.Location = new System.Drawing.Point(186, 282);
            this.tbtelefon.Name = "tbtelefon";
            this.tbtelefon.Size = new System.Drawing.Size(247, 33);
            this.tbtelefon.TabIndex = 54;
            this.tbtelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtelefon_KeyPress);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsoyadi.Location = new System.Drawing.Point(186, 129);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(247, 30);
            this.tbsoyadi.TabIndex = 53;
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyadi_KeyPress);
            // 
            // tbadi
            // 
            this.tbadi.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbadi.Location = new System.Drawing.Point(186, 77);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(247, 33);
            this.tbadi.TabIndex = 52;
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadi_KeyPress);
            // 
            // tbtc
            // 
            this.tbtc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtc.Location = new System.Drawing.Point(186, 24);
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(247, 33);
            this.tbtc.TabIndex = 51;
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "ADRES:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "CİNSİYET:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "DOĞUM YERİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "SOYADI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "ADI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "TC:";
            // 
            // güncelle
            // 
            this.güncelle.Image = ((System.Drawing.Image)(resources.GetObject("güncelle.Image")));
            this.güncelle.Location = new System.Drawing.Point(520, 452);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(192, 131);
            this.güncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.güncelle.TabIndex = 61;
            this.güncelle.TabStop = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // aranan
            // 
            this.aranan.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aranan.Location = new System.Drawing.Point(1036, 47);
            this.aranan.Name = "aranan";
            this.aranan.Size = new System.Drawing.Size(237, 33);
            this.aranan.TabIndex = 62;
            this.aranan.TextChanged += new System.EventHandler(this.aranan_TextChanged);
             // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(889, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 27);
            this.label10.TabIndex = 63;
            this.label10.Text = "TC ARA:";
            // 
            // müsteriduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1319, 607);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.aranan);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBCİNSİYET);
            this.Controls.Add(this.cbdogum);
            this.Controls.Add(this.RESİMEKLE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbadres);
            this.Controls.Add(this.tbtelefon);
            this.Controls.Add(this.tbsoyadi);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.tbtc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "müsteriduzenle";
            this.Text = "silveduzenle";
            this.Load += new System.EventHandler(this.silveduzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.güncelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBCİNSİYET;
        private System.Windows.Forms.ComboBox cbdogum;
        private System.Windows.Forms.Button RESİMEKLE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbtelefon;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox güncelle;
        private System.Windows.Forms.TextBox aranan;
        private System.Windows.Forms.Label label10;
    }
}