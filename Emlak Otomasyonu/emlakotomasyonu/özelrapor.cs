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
    public partial class özelrapor : Form
    {
        public özelrapor()
        {
            InitializeComponent();
        }

        private void özelrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakotomasyonDataSet.ev' table. You can move, or remove it, as needed.
           // this.evTableAdapter.Fill(this.emlakotomasyonDataSet.ev);
            ReportDataSource rds = new ReportDataSource("DataSet1",musterilistesi.dataset.Tables["musterii"]);//raporun veriyi alacağı kaynağı bulduk.
            this.reportViewer1.LocalReport.DataSources.Clear();//eski datasourceyi temizledik
            this.reportViewer1.LocalReport.DataSources.Add(rds);//yenisini ekledik
            this.reportViewer1.LocalReport.Refresh();
             this.reportViewer1.RefreshReport();
        }
    }
}
