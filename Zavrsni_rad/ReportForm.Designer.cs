namespace Zavrsni_rad
{
    partial class ReportForm
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.zavrsniDataSet1 = new Zavrsni_rad.ZavrsniDataSet();
            this.trkacTableAdapter1 = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TrkacTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Zavrsni_rad.Trkaci.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(835, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // zavrsniDataSet1
            // 
            this.zavrsniDataSet1.DataSetName = "ZavrsniDataSet";
            this.zavrsniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trkacTableAdapter1
            // 
            this.trkacTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.zavrsniDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 636);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.Text = "Izvješće";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ZavrsniDataSet zavrsniDataSet1;
        private ZavrsniDataSetTableAdapters.TrkacTableAdapter trkacTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}