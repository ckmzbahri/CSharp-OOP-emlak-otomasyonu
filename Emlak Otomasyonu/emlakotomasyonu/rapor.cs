using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace emlakotomasyonu
{
    public partial class rapor : Form
    {  

        public rapor()
        {
            InitializeComponent();
        }


        private void rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakotomasyonDataSet.musteri' table. You can move, or remove it, as needed.
        //  this.musteriTableAdapter.Fill(this.emlakotomasyonDataSet.musteri);

           ReportDataSource rds = new ReportDataSource("DataSet2", musterilistesi.ds.Tables["musteri"]);//raporun veriyi alacağı kaynağı bulduk.
            this.reportViewer1.LocalReport.DataSources.Clear();//eski datasourceyi temizledik
            this.reportViewer1.LocalReport.DataSources.Add(rds);//yenisini ekledik
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

      
     

        private void rapor_Load_3(object sender, EventArgs e)
        {
       
        }

        
    }
}
