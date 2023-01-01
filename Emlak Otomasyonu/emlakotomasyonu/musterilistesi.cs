using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace emlakotomasyonu
{
    public partial class musterilistesi : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
    public static DataSet ds = new DataSet();
       BindingSource bs = new BindingSource();
       BindingSource bs1 = new BindingSource();
       BindingSource bs2 = new BindingSource();
       BindingSource bs3 = new BindingSource();
       public static DataSet dataset = new DataSet();
        int tutindex;
        public musterilistesi()
        {
            InitializeComponent();
        }
        void kayit_sayısı_göster()
        {
           toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds.Tables["musteri"].Rows.Count.ToString();

        }
        void veri()
        {
            if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
             OleDbDataAdapter da = new OleDbDataAdapter("SElect * from musteri", conn);
            da.Fill(ds, "musteri");
            bs.DataSource = ds.Tables["musteri"];
            dataGridView1.DataSource = bs;


        }
        void doldur()
        {
            if (dataset.Tables["musteri"] != null) dataset.Tables["musteri"].Clear();
            OleDbDataAdapter oadap = new OleDbDataAdapter("SElect musteri.adi,musteri.soyadi,ev.*from musteri,ev where musteri.tc=ev.tc AND musteri.tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", conn);//burada tablo birleştirdik);
            oadap.Fill(dataset, "musterii");
            bs.DataSource = dataset.Tables["musterii"];
            dataGridView1.DataSource = bs;
         
        }

            

        private void listeler_Load(object sender, EventArgs e)
        {
            geri.Enabled = false;

            if (conn.State == ConnectionState.Closed) conn.Open();

            veri();
            kayit_sayısı_göster();

          
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ileri_Click(object sender, EventArgs e)
        {
            geri.Enabled = true;
            if (++bs.Position == ds.Tables["musteri"].Rows.Count - 1)
                ileri.Enabled = false;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            ileri.Enabled = true;
            if (--bs.Position == 0)
                geri.Enabled = false;
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbisim_CheckedChanged(object sender, EventArgs e)
        {
           
            tbaranan.Focus();
        }

        private void rbsoyisim_CheckedChanged(object sender, EventArgs e)
        {
            
            tbaranan.Focus();
        }

        private void rbtc_CheckedChanged(object sender, EventArgs e)
        {
            
            tbaranan.Focus();
        }

        private void tbaranan_TextChanged(object sender, EventArgs e)
        {
            if (tbaranan.Text == "")
            {
                
                veri();
            }
            else
            {
                if (rbtc.Checked == false & rbisim.Checked == false & rbsoyisim.Checked == false)
                {
                    MessageBox.Show("Lütfen Arama Yöntemi Seçiniz!", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tbaranan.Text = "";
                    toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds.Tables["musteri"].Rows.Count.ToString();

                }
                else if (rbtc.Checked)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
                    OleDbDataAdapter da1 = new OleDbDataAdapter("SElect * from musteri where tc LIKE '%" + tbaranan.Text + "%'", conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "musteri");
                    bs1.DataSource = ds1.Tables["musteri"];
                    dataGridView1.DataSource = bs1;
                    toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds1.Tables["musteri"].Rows.Count.ToString();

                }
                else if (rbisim.Checked)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
                    OleDbDataAdapter da2 = new OleDbDataAdapter("SElect * from musteri where adi LIKE '%" + tbaranan.Text + "%'", conn);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "musteri");
                    bs2.DataSource = ds2.Tables["musteri"];
                    dataGridView1.DataSource = bs2;
                    toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds2.Tables["musteri"].Rows.Count.ToString();
                }
                else if (rbsoyisim.Checked)
                {

                    if (conn.State == ConnectionState.Closed) conn.Open();
                    if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
                    OleDbDataAdapter da3 = new OleDbDataAdapter("SElect * from musteri where soyadi LIKE '%" + tbaranan.Text + "%'", conn);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3, "musteri");
                    bs3.DataSource = ds3.Tables["musteri"];
                    dataGridView1.DataSource = bs3;
                    toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds3.Tables["musteri"].Rows.Count.ToString();
                }

            }
        }


        private void silme_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            tutindex = bs.Position;
            DialogResult c = MessageBox.Show("Kayıtı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {

                string tc = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from musteri  where tc=@tc";
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi!");    //BEN BURADA DA DATAGRİDWİEWİN ÜZERİNE GELEREK SİLİYORUM..  
                toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds.Tables["musteri"].Rows.Count.ToString();
                bs.Position = tutindex;
                veri();
                
            }
        }

        private void tbaranan_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (rbtc.Checked )
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
               else   if (rbisim.Checked || rbsoyisim.Checked)
               {
                   e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                    && !char.IsSeparator(e.KeyChar);
               }
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Çıkış Yapmak İstiyor Musunuz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void tumkayit_CheckedChanged(object sender, EventArgs e)
        {
            if (tumkayit.Checked)
            {

                veri();
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
           doldur();
           özelrapor gecis = new özelrapor();
            gecis.ShowDialog();
        }

        private void tumkayit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tumkayit.Checked)
            {
                veri();
              
            }
        }
    }
        }



