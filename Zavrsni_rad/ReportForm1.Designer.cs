namespace Zavrsni_rad
{
    partial class ReportForm1
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ZavrsniDataSet = new Zavrsni_rad.ZavrsniDataSet();
            this.TrkacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrkacTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TrkacTableAdapter();
            this.OsobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OsobaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.OsobaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ZavrsniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsobaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "kura";
            reportDataSource1.Value = this.TrkacBindingSource;
            reportDataSource2.Name = "pica";
            reportDataSource2.Value = this.OsobaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Zavrsni_rad.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 449);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ZavrsniDataSet
            // 
            this.ZavrsniDataSet.DataSetName = "ZavrsniDataSet";
            this.ZavrsniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TrkacBindingSource
            // 
            this.TrkacBindingSource.DataMember = "Trkac";
            this.TrkacBindingSource.DataSource = this.ZavrsniDataSet;
            // 
            // TrkacTableAdapter
            // 
            this.TrkacTableAdapter.ClearBeforeFill = true;
            // 
            // OsobaBindingSource
            // 
            this.OsobaBindingSource.DataMember = "Osoba";
            this.OsobaBindingSource.DataSource = this.ZavrsniDataSet;
            // 
            // OsobaTableAdapter
            // 
            this.OsobaTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm1";
            this.ShowIcon = false;
            this.Text = "Report rezultata";
            this.Load += new System.EventHandler(this.ReportForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZavrsniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrkacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OsobaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TrkacBindingSource;
        private ZavrsniDataSet ZavrsniDataSet;
        private System.Windows.Forms.BindingSource OsobaBindingSource;
        private ZavrsniDataSetTableAdapters.TrkacTableAdapter TrkacTableAdapter;
        private ZavrsniDataSetTableAdapters.OsobaTableAdapter OsobaTableAdapter;
    }
}