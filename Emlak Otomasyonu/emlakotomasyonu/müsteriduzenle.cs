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
    public partial class müsteriduzenle : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        string  adres,telefon,tc,ad,soyad,dogum,cinsiyet;
        
        void verileri_cek()
        {
            if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
            OleDbDataAdapter da = new OleDbDataAdapter("SElect * from musteri", conn);
            da.Fill(ds, "musteri");
            bs.DataSource = ds.Tables["musteri"];
            dataGridView1.DataSource = bs;

        }
        public müsteriduzenle()
        {
            InitializeComponent();
        }

      

        private void anamenü_Click(object sender, EventArgs e)
        {

            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }



        

        private void silveduzenle_Load(object sender, EventArgs e)
        {
            tbtc.Focus();
            tbtelefon.Text = "0";
            cbdogum.SelectedIndex = 0;
            verileri_cek();
            if (conn.State == ConnectionState.Closed) conn.Open();

            verileri_cek();
            bs.DataSource = ds.Tables["musteri"];
             dataGridView1.DataSource = bs;
             tbtc.DataBindings.Add("Text", bs, "tc");
             tbadi.DataBindings.Add("Text", bs, "adi");
             tbsoyadi.DataBindings.Add("Text", bs, "soyadi");
             cbdogum.DataBindings.Add("SelectedItem", bs, "dogumyeri");
             CBCİNSİYET.DataBindings.Add("SelectedItem", bs, "cinsiyet");
             tbtelefon.DataBindings.Add("Text", bs, "telefon");
             tbadres.DataBindings.Add("Text", bs, "adres");
             pictureBox1.DataBindings.Add("ImageLocation", bs, "resim");
              tc = tbtc.Text;
             ad = tbadi.Text;
              soyad = tbsoyadi.Text;
             dogum = cbdogum.Text;
             cinsiyet = CBCİNSİYET.Text;
              telefon = tbtelefon.Text;
               adres = tbadres.Text;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void güncelle_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbadres.Text == "" ||tbtelefon.Text=="")
            {
                MessageBox.Show("Lütfen Hepsini Doldurun.");
            }
            else
                if (tbadres.Text==adres && tbtc.Text==tc && tbadi.Text==ad && tbsoyadi.Text==soyad && cbdogum.Text==dogum &&CBCİNSİYET.Text==cinsiyet && tbtelefon.Text==telefon)
                {
                    MessageBox.Show("Aynı Veri Girildi Veya Güncellenmedi.");
                }
            else
            {
                if (tbtc.TextLength == 11 && tbtelefon.TextLength == 11 )
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;


                    cmd.CommandText = "update musteri set tc=@tc,adi=@adi,soyadi=@soyadi,dogumyeri=@dogumyeri,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,resim=@resim where tc=@tc";
                    cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                    cmd.Parameters.AddWithValue("@adi", tbadi.Text);
                    cmd.Parameters.AddWithValue("@soyadi", tbsoyadi.Text);
                    cmd.Parameters.AddWithValue("@dogumyeri", cbdogum.SelectedItem);
                    cmd.Parameters.AddWithValue("@cinsiyet", CBCİNSİYET.SelectedItem);
                    cmd.Parameters.AddWithValue("@telefon", tbtelefon.Text);
                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                    cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız Güncellendi");
                    verileri_cek();

                }

                else
                {
                    MessageBox.Show("TC Kimlik Numaranız Yada Telefon Numaranı Eksik Girildi.");
                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void RESİMEKLE_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";// initialdirectory başlangıç klasörü resim klasörü olsun

            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void tbtc_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) //silme işlemiinide anlamıyordu backsapceini aplicodu 8 dir.
            {
                e.Handled = true;
            }
        }

        private void tbtelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) //silme işlemiinide anlamıyordu backsapceini aplicodu 8 dir.
            {
                e.Handled = true;
            }
        }

        private void tbadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
    && !char.IsSeparator(e.KeyChar);
        }

        private void tbsoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
  && !char.IsSeparator(e.KeyChar);
        }

        private void aranan_TextChanged(object sender, EventArgs e)
        {
            if (aranan.Text == "")
            {
                verileri_cek();
            }
            else
            {

                if (conn.State == ConnectionState.Closed) conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SElect * from musteri where tc LIKE '%" + aranan.Text + "%'", conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset, "musteri");
                bs.DataSource = dataset.Tables["musteri"];
                dataGridView1.DataSource = bs;
                //toolStripLabel1.Text = " MÜŞTERİ KAYIT SAYISI=" + ds.Tables["musteri"].Rows.Count.ToString();
            }
        }

        }
    }
