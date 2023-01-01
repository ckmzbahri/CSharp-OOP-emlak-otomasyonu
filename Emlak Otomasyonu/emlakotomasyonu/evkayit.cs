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
    public partial class evkayit : Form
    {
       
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int tutindex;
        void verileri_cek()
        {
            if (ds.Tables["musteri"] != null) ds.Tables["musteri"].Clear();
            string seckomutu = "select * from musteri";
            OleDbDataAdapter adapter = new OleDbDataAdapter(seckomutu, conn);
            adapter.Fill(ds, "musteri");
        }
        
        public evkayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

           
        }

   

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void KAYDET_Click(object sender, EventArgs e)
        {

            if (cbkatsayi.Text == "" || CBODA.Text == "" || CBDURUM.Text == "" || TBBİNA.Text == "" || TBFİYAT.Text == "")
            {
                MessageBox.Show("Lütfen Hepsini Doldurun.");
            }

            else
            {
                


                OleDbCommand komut  = new OleDbCommand();

                komut.Connection = conn;
                komut.CommandText = "insert into ev (adres,katsayi,odasayi,durum,cephe,binayasi,fiyat,balkon,metrekare,zemin,tc) Values (@adres,@katsayi,@odasayi,@durum,@cephe,@binayasi,@fiyat,@balkon,@metrekare,@zemin,@tc)";
                komut.Parameters.AddWithValue("@adres", TBADRES.Text);
                komut.Parameters.AddWithValue("@katsayi", cbkatsayi.Text);
                komut.Parameters.AddWithValue("@odasayi", CBODA.SelectedItem);
                komut.Parameters.AddWithValue("@durum", CBDURUM.SelectedItem);
                komut.Parameters.AddWithValue("@cephe", cbcephe.SelectedItem);
                komut.Parameters.AddWithValue("@binayasi", TBBİNA.Text);
                komut.Parameters.AddWithValue("@fiyat", TBFİYAT.Text);
                komut.Parameters.AddWithValue("@balkon", CBBALKON.SelectedItem);
                komut.Parameters.AddWithValue("@metrekare", cbmetre.SelectedItem);
                komut.Parameters.AddWithValue("@zemin", CBZEMİN.SelectedItem);
                komut.Parameters.AddWithValue("@tc", TBTC.Text);
                komut.ExecuteNonQuery();   
                MessageBox.Show("Kaydınız Yapıldı");
                TBTC.Clear(); TBFİYAT.Clear(); TBBİNA.Clear(); TBADRES.Clear(); cbkatsayi.Text = ""; ; CBODA.Text = ""; ; CBDURUM.Text = ""; cbcephe.Text = ""; CBZEMİN.Text = ""; cbmetre.Text = ""; CBBALKON.Text = "";

            }
        }

        private void evkayit_Load(object sender, EventArgs e)
        {

            tutindex = bs.Position;
            if (conn.State == ConnectionState.Closed) conn.Open();
            verileri_cek();
            bs.DataSource = ds.Tables["musteri"];
            dataGridView1.DataSource = bs;
             TBTC.DataBindings.Add("Text", bs, "tc");
             TBADRES.DataBindings.Add("Text", bs, "adres");



             if (conn.State == ConnectionState.Closed) conn.Open();
             OleDbCommand cmd = new OleDbCommand("Select * from durum", conn);
             OleDbDataReader read = cmd.ExecuteReader();
             while (read.Read())
             {
                CBDURUM.Items.Add(read ["durum"]);
             }
           


             OleDbCommand cmd1 = new OleDbCommand("Select * from cephe", conn);
             OleDbDataReader read1 = cmd1.ExecuteReader();
             while (read1.Read())
             {
                cbcephe.Items.Add(read1["cephe"]);
             }
            
            
            OleDbCommand cmd2 = new OleDbCommand("Select * from odasayisi", conn);
             OleDbDataReader read2 = cmd2.ExecuteReader();
             while (read2.Read())
             {
                 CBODA.Items.Add(read2["odasayisi"]);
             }
            
            
            OleDbCommand cmd3 = new OleDbCommand("Select * from katsayisi", conn);
             OleDbDataReader read3 = cmd3.ExecuteReader();
             while (read3.Read())
             {
                 cbkatsayi.Items.Add(read3["katsayisi"]);
             }
             bs.Position = tutindex;
             OleDbCommand cmd4 = new OleDbCommand("Select * from zemin", conn);
             OleDbDataReader read4 = cmd4.ExecuteReader();
            while(read4.Read())
            {
                CBZEMİN.Items.Add(read4["zemin"]);
            }
            OleDbCommand cmd5 = new OleDbCommand("Select * from metrekare", conn);
            OleDbDataReader read5 = cmd5.ExecuteReader();
            while (read5.Read())
            {
                cbmetre.Items.Add(read5["metrekare"]);
            } 
        }
    

         private void TBTC_TextChanged(object sender, EventArgs e)
         {

            
        }

       

      

        private void TBADRES_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBBİNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBBİNA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) //silme işlemiinide anlamıyordu backspaceini aplicodu 8 dir.
            {
                e.Handled = true;
            }
        }

        private void TBFİYAT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) //silme işlemiinide anlamıyordu backspaceini aplicodu 8 dir.
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBALKON.SelectedIndex == 0)
            {
                rbbalkon1.Visible = true;
                rbbalkon2.Visible = true;
                rbbalkon3.Visible = true;
            }
            else
            {
                rbbalkon2.Visible = false;
                rbbalkon1.Visible = false;
                rbbalkon3.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Çıkış Yapmak İstiyor Musunuz?", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}