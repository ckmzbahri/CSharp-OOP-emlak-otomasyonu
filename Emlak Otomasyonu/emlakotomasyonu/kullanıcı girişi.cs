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
    public partial class kullanıcı_girişi : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
       
        public kullanıcı_girişi()

        {
            InitializeComponent();
        }

      

        private void GİRİS_Click(object sender, EventArgs e)
        {
            
            
        }
           

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            if (tbka.Text == "" && tbsf.Text == "")
            {
                MessageBox.Show("Lütfen Giriş Bilgilerini Yazın!");
            }
            else if (tbka.Text == "")
            {
                MessageBox.Show("Kullanıcı Adını Giriniz.");
            }
            else if (tbsf.Text == "")
            {
                MessageBox.Show("Şifrenizi Giriniz.");
            }
            else
            {


                if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbCommand cmd = new OleDbCommand("select * from kullanicigirisi where kullaniciadi='" + tbka.Text.ToString() + "'", conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                {
                    if (tbka.Text.ToString() == dr["kullaniciadi"].ToString() && tbsf.Text.ToString() == dr["sifre"].ToString())
                    {
                        MessageBox.Show("HOŞGELDİNİZ");
                        Form form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Kullanıcıadı veya şifre yanlıştır.");
                        tbka.Clear(); tbsf.Clear();
                    }
                }
           
                else 
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlıştır.");
                        tbka.Clear(); tbsf.Clear();
                    }
                        
                    }
            
                }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Çıkmak İstiyor musunuz?", "UYARI!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (c == DialogResult.No)
            {
                tbka.Clear(); tbsf.Clear();
            }
        }

        private void tbka_TextChanged(object sender, EventArgs e)
        {

        }

   
        }

        
    
  
}
    

