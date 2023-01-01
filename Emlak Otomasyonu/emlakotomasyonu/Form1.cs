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
    public partial class Form1 : Form
    {
       // OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void mkayit_Click(object sender, EventArgs e)
        {
            Form musteri = new  musterikayit();
             this.Hide();  
            musteri.ShowDialog();
            this.Show();
       
       
        }

        private void evkayit_Click(object sender, EventArgs e)
        {
            Form evkayit = new evkayit();
            this.Hide();    
            evkayit.ShowDialog();
            this.Show();
        


        }

        private void LİSTELER_Click(object sender, EventArgs e)
        {
            Form liste = new musterilistesi();
            this.Hide();
            liste.ShowDialog();
            this.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Form rapor = new rapor();
          this.Hide();   
            rapor.ShowDialog();
            this.Show();
           
        }

        private void SİLVEDUZENLE_Click(object sender, EventArgs e)
        {
            Form silveduzenle = new müsteriduzenle();
                this.Hide();
            silveduzenle.ShowDialog();
            this.Show();
        }

        private void evlistesi_Click(object sender, EventArgs e)
        {
            Form evlistesi = new evlistesi();
            this.Hide();
            evlistesi.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form evbilgileri = new evbilgileri();
            this.Hide();
            evbilgileri.ShowDialog();
            this.Show();
        }

        
    }
}
