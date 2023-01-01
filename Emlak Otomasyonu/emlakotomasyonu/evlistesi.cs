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
    public partial class evlistesi : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "//emlakotomasyon.mdb");
      public static  DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void veriler()
        {
            if (ds.Tables["ev"] != null) ds.Tables["ev"].Clear();
            string seckomutu = "select * from ev";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, conn);
            da.Fill(ds, "ev");
            bs.DataSource = ds.Tables["ev"];
            dataGridView1.DataSource = bs;
        }
        public evlistesi()
        {
            InitializeComponent();
        }



        private void evlistesi_Load(object sender, EventArgs e)
        {
            geri.Enabled = false;

            if (conn.State == ConnectionState.Closed) conn.Open();

            veriler();
            toolStripLabel1.Text = " KAYITLI EV SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            ileri.Enabled = true;
            if (--bs.Position == 0)
                geri.Enabled = false;
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            geri.Enabled = true;
            if (++bs.Position == ds.Tables["ev"].Rows.Count - 1)
                ileri.Enabled = false;
        }

        private void rbadres_CheckedChanged(object sender, EventArgs e)
        {
            aranan.Text = "";
            aranan.Focus();


        }

        private void rbdrum_CheckedChanged(object sender, EventArgs e)
        {
            aranan.Text = "";
            aranan.Focus();
        }

        private void aranan_TextChanged(object sender, EventArgs e)
        {
             if (aranan.Text == "")
             {
                 veriler();
             }
             else
             {
                 if (rbadres.Checked == false & rbdrum.Checked == false )
                 {
                     MessageBox.Show("Lütfen Arama Yöntemi Seçiniz!", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Question);
                     aranan.Text = "";
                     toolStripLabel1.Text = "KAYITLI EV SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();

                 }
                 else if (rbadres.Checked)
                 {
                     if (conn.State == ConnectionState.Closed) conn.Open();
                     OleDbDataAdapter da = new OleDbDataAdapter("SElect * from ev where adres LIKE '%" + aranan.Text + "%'", conn);
                     DataSet ds = new DataSet();
                     da.Fill(ds, "ev");
                     bs.DataSource = ds.Tables["ev"];
                     dataGridView1.DataSource = bs;
                     toolStripLabel1.Text = "KAYITLI EV  SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();

                 }
                 else if (rbdrum.Checked)
                 {
                     if (conn.State == ConnectionState.Closed) conn.Open();
                     OleDbDataAdapter da = new OleDbDataAdapter("SElect * from ev where durum LIKE '%" + aranan.Text + "%'", conn);
                     DataSet ds = new DataSet();
                     da.Fill(ds, "ev");
                     bs.DataSource = ds.Tables["ev"];
                     dataGridView1.DataSource = bs;
                     toolStripLabel1.Text = " KAYITLI EV SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();
                 }
                
             }
         }

        private void tumkayit_CheckedChanged(object sender, EventArgs e)
        {
            if (tumkayit.Checked)
            {
                veriler();
                toolStripLabel1.Text = " KAYITLI EV SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();
            }
            else
            {
                if (rbadres.Checked == false & rbdrum.Checked == false)
                {
                    MessageBox.Show("Lütfen Arama Yöntemi Seçiniz!", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    aranan.Text = "";
                    toolStripLabel1.Text = "KAYITLI EV SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();

                }
                else if (rbadres.Checked)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("SElect * from ev where adres LIKE '%" + aranan.Text + "%'", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ev");
                    bs.DataSource = ds.Tables["ev"];
                    dataGridView1.DataSource = bs;
                    toolStripLabel1.Text = "KAYITLI EV  SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();

                }
                else if (rbdrum.Checked)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter("SElect * from ev where durum LIKE '%" + aranan.Text + "%'", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ev");
                    bs.DataSource = ds.Tables["ev"];
                    dataGridView1.DataSource = bs;
                    toolStripLabel1.Text = " KAYITLI EV SAYISI=" + ds.Tables["ev"].Rows.Count.ToString();
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }
     }
        }
    