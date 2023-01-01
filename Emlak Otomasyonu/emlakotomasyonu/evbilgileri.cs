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
    public partial class evbilgileri : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        int tutindex;
        void veriler()
        {
            if (ds.Tables["ev"] != null) ds.Tables["ev"].Clear();
            string seckomutu = "select * from ev";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, conn);
            da.Fill(ds, "ev");
        }

        public evbilgileri()
        {
            InitializeComponent();
        }

        private void evbilgileri_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from durum", conn);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                CBDURUM.Items.Add(read["durum"]);
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

            OleDbCommand cmd4 = new OleDbCommand("Select * from zemin", conn);
            OleDbDataReader read4 = cmd4.ExecuteReader();
            while (read4.Read())
            {
                CBZEMİN.Items.Add(read4["zemin"]);
            }
            OleDbCommand cmd5 = new OleDbCommand("Select * from metrekare", conn);
            OleDbDataReader read5 = cmd5.ExecuteReader();
            while (read5.Read())
            {
                cbmetre.Items.Add(read5["metrekare"]);
            }
            if (conn.State == ConnectionState.Closed) conn.Open();
            veriler();
            bs.DataSource = ds.Tables["ev"];
            dataGridView1.DataSource = bs;
            TBADRES.DataBindings.Add("Text", bs, "adres");
            cbkatsayi.DataBindings.Add("SelectedItem", bs, "katsayi");
            CBODA.DataBindings.Add("SelectedItem", bs, "odasayi");
            CBDURUM.DataBindings.Add("SelectedItem", bs, "durum");
            cbcephe.DataBindings.Add("SelectedItem", bs, "cephe");
            TBBİNA.DataBindings.Add("Text", bs, "binayasi");
            TBFİYAT.DataBindings.Add("Text", bs, "fiyat");
            CBBALKON.DataBindings.Add("SelectedItem", bs, "balkon");
            cbmetre.DataBindings.Add("SelectedItem", bs, "metrekare");
            CBZEMİN.DataBindings.Add("SelectedItem", bs, "zemin");
            TBTC.DataBindings.Add("Text", bs, "tc");

        }

        private void güncelle_Click(object sender, EventArgs e)
        {
          
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            tutindex = bs.Position;
            DialogResult c = MessageBox.Show("Kayıtı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {

                string tc = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from ev  where tc=@tc";
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi!");    //BEN BURADA DA DATAGRİDWİEWİN ÜZERİNE GELEREK SİLİYORUM..  
                TBTC.Text = "";  CBZEMİN.Text = ""; cbmetre.Text =""; CBBALKON.Text = ""; TBFİYAT.Text = "" ; TBBİNA.Text = "";  cbcephe.Text ="";  CBDURUM.Text = "";  CBODA.Text = "";  cbkatsayi.Text = "";  TBADRES.Text = "";
                bs.Position = tutindex;
                veriler();

            }
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
             if (arama.Text == "")
            {
                veriler();
            }
            else
            {
                
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("Select * from ev where tc LIKE '%" + arama.Text + "%'", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ev");
                    bs.DataSource = ds.Tables["ev"];
                    dataGridView1.DataSource = bs;
                

                
                
                }
        }

        private void düzenle1_Click(object sender, EventArgs e)
        {
            if (TBTC.Text == "" || CBZEMİN.Text == "" || cbmetre.Text == "" || CBBALKON.Text == "" || TBFİYAT.Text == "" || TBBİNA.Text == "" || cbcephe.Text == "" || CBDURUM.Text == "" || CBODA.Text == "" || cbkatsayi.Text == "" || TBADRES.Text == "")
            {
                MessageBox.Show("Lütfen Hepsini Doldurun.");
            }
            else
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                OleDbCommand komut = new OleDbCommand();
                komut.Connection = conn;


                komut.CommandText = "update ev set adres=@adres,katsayi=@katsayi,odasayi=@odasayi,durum=@durum,cephe=@cephe,binayasi=@binayasi,fiyat=@fiyat,balkon=@balkon,metrekare=@metrekare,zemin=@zemin,tc=@tc where tc=@tc";
                komut.Parameters.AddWithValue("@adres", TBADRES.Text);
                komut.Parameters.AddWithValue("@katsayi", cbkatsayi.SelectedItem);
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
                MessageBox.Show("Kaydınız Güncellendi");
                veriler();
                TBTC.Text = ""; CBZEMİN.Text = ""; cbmetre.Text = ""; CBBALKON.Text = ""; TBFİYAT.Text = ""; TBBİNA.Text = ""; cbcephe.Text = ""; CBDURUM.Text = ""; CBODA.Text = ""; cbkatsayi.Text = ""; TBADRES.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Güncellemeden Çıkmak İster Misiniz","UYARI",MessageBoxButtons.YesNoCancel);
                if (c == DialogResult.Yes)
                {

                    Form form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                    if (c==DialogResult.No)
                    {
                     
                        
                     düzenle1_Click(sender,e);//düzenle1_click olayını çağırdım
                    }
                
                

                

           
        }

        private void CBBALKON_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
