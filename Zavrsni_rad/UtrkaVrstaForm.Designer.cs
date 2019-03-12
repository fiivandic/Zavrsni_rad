namespace Zavrsni_rad
{
    partial class UtrkaVrstaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zavrsniDataSet = new Zavrsni_rad.ZavrsniDataSet();
            this.utrkaVrstaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utrkaVrstaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.UtrkaVrstaTableAdapter();
            this.idUtrkaVrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaVrstaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtrkaVrstaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utrkaVrstaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // zavrsniDataSet
            // 
            this.zavrsniDataSet.DataSetName = "ZavrsniDataSet";
            this.zavrsniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utrkaVrstaBindingSource
            // 
            this.utrkaVrstaBindingSource.DataMember = "UtrkaVrsta";
            this.utrkaVrstaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // utrkaVrstaTableAdapter
            // 
            this.utrkaVrstaTableAdapter.ClearBeforeFill = true;
            // 
            // idUtrkaVrstaDataGridViewTextBoxColumn
            // 
            this.idUtrkaVrstaDataGridViewTextBoxColumn.DataPropertyName = "IdUtrkaVrsta";
            this.idUtrkaVrstaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idUtrkaVrstaDataGridViewTextBoxColumn.Name = "idUtrkaVrstaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // UtrkaVrstaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UtrkaVrstaForm";
            this.ShowIcon = false;
            this.Text = "Vrsta utrke";
            this.Load += new System.EventHandler(this.UtrkaVrstaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaVrstaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZavrsniDataSet zavrsniDataSet;
        private System.Windows.Forms.BindingSource utrkaVrstaBindingSource;
        private ZavrsniDataSetTableAdapters.UtrkaVrstaTableAdapter utrkaVrstaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtrkaVrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
    }
}