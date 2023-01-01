namespace emlakotomasyonu
{
    partial class özelrapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.emlakotomasyonDataSet = new emlakotomasyonu.emlakotomasyonDataSet();
            this.evBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evTableAdapter = new emlakotomasyonu.emlakotomasyonDataSetTableAdapters.evTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emlakotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.evBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "emlakotomasyonu.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(638, 447);
            this.reportViewer1.TabIndex = 0;
            // 
            // emlakotomasyonDataSet
            // 
            this.emlakotomasyonDataSet.DataSetName = "emlakotomasyonDataSet";
            this.emlakotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evBindingSource
            // 
            this.evBindingSource.DataMember = "ev";
            this.evBindingSource.DataSource = this.emlakotomasyonDataSet;
            // 
            // evTableAdapter
            // 
            this.evTableAdapter.ClearBeforeFill = true;
            // 
            // özelrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "özelrapor";
            this.Text = "özelrapor";
            this.Load += new System.EventHandler(this.özelrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emlakotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource evBindingSource;
        private emlakotomasyonDataSet emlakotomasyonDataSet;
        private emlakotomasyonDataSetTableAdapters.evTableAdapter evTableAdapter;
    }
}