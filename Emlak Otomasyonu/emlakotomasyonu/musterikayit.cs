using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//access kütüphanesini çağırdık.
namespace emlakotomasyonu
{
    public partial class musterikayit : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
        bool durum;
        BindingSource bs = new BindingSource();
        DataSet ds =new DataSet();
        int tutindex;
        void tekrar()
        {
            if (conn.State == ConnectionState.Closed) conn.Open(); 
        
            OleDbCommand cmd = new OleDbCommand("select * from musteri where tc=@tc",conn);
            cmd.Parameters.AddWithValue("@tc",tbtc.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else 
            {
                durum =true;
            }
         
            
            }
        void verileri_cek()
        {
            if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
            string seckomutu = "select * from musteri";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, conn);
            da.Fill(ds, "musteri");
        }

        public musterikayit()
        {
            InitializeComponent();
        }
      





        private void kaydet_Click(object sender, EventArgs e)
        {
            tutindex = bs.Position;
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbadres.Text == "")
            {
                MessageBox.Show("Lütfen Hepsini Doldurun.");
            }
           
                else
                {
                    tekrar();
                    if (durum == true)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = conn;


                        cmd.CommandText = "insert into musteri (tc,adi,soyadi,dogumyeri,cinsiyet,telefon,adres,resim) Values (@tc,@adi,@soyadi,@dogumyeri,@cinsiyet,@telefon,@adres,@resim)";
                        cmd.Parameters.AddWithValue("@tc", tbtc.Text);
                        cmd.Parameters.AddWithValue("@adi", tbadi.Text);
                        cmd.Parameters.AddWithValue("@soyadi", tbsoyadi.Text);
                        cmd.Parameters.AddWithValue("@dogumyeri", cbdogum.SelectedItem);
                        cmd.Parameters.AddWithValue("@cinsiyet", CBCİNSİYET.SelectedItem);
                        cmd.Parameters.AddWithValue("@telefon", tbtelefon.Text);
                        cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                        cmd.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız Yapıldı");
                        verileri_cek();
                        tbtc.Clear(); tbadi.Clear(); tbsoyadi.Clear(); tbadres.Clear(); CBCİNSİYET.SelectedIndex = 0; cbdogum.SelectedIndex = 0; tbtelefon.Clear(); pictureBox1.ImageLocation = "";
                        bs.Position = tutindex;

                    }     
                    else
                    {

                        MessageBox.Show("Bu TC Kimlik Numarası Bulunmaktadır.");
                        tbtc.Clear(); tbadi.Clear(); tbsoyadi.Clear(); tbadres.Clear(); CBCİNSİYET.SelectedIndex = 0; cbdogum.SelectedIndex = 0; tbtelefon.Clear(); pictureBox1.ImageLocation = "";

                    }
                

            }
        }
       

        private void musterikayit_Load(object sender, EventArgs e)
        {
            tbtc.Focus();
            tbtelefon.Text="0";
            cbdogum.SelectedIndex = 0;
            CBCİNSİYET.SelectedIndex = 0;

            if (conn.State == ConnectionState.Closed) conn.Open();
          
            verileri_cek();
            bs.DataSource = ds.Tables["musteri"];
           dataGridView1.DataSource = bs;
        
         
        }

     

     

      

        private void tbtc_Click(object sender, EventArgs e)
        {
         
        }

        private void tbtc_KeyPress(object sender, KeyPressEventArgs e)
        { //e.Handled klavyeden gelen o tuşun tutulmasını sağlar. key charda o karakterin alınması ve erana yazdırılması
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar !=8) //silme işlemiinide anlamıyordu backsapceini aplicodu 8 dir.
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

        private void RESİMEKLE_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";// initialdirectory başlangıç klasörü resim klasörü olsun

            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void tbtc_Leave(object sender, EventArgs e)
        {
            if (tbtc.Text.Length > 11)
            {
                MessageBox.Show(" TC Kimlik Numarası 11 Karakterden Fazla OLMAZ!");
                tbtc.Clear();
                tbtc.Focus();
            }
            if (tbtc.Text.Length < 10)
            {
                MessageBox.Show(" TC Kimlik NUmarasını Lütfen 11 Karakter Olarak Giriniz.");
                tbtc.Clear();
                tbtc.Focus();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void tbtelefon_Leave(object sender, EventArgs e)
        {
            if (tbtelefon.Text.Length > 11)
            {
                MessageBox.Show(" Telefon Numarası 11 Karakterden Fazla GİRİLMEZ!");
                tbtelefon.Clear();
                tbtelefon.Focus();
            }
            if (tbtelefon.Text.Length < 10)
            {
                MessageBox.Show(" Telefon Numarasını Lütfen 11 Karakter Giriniz.");
                tbtelefon.Clear();
                tbtelefon.Focus();
            }
        }

        
        }
    }

