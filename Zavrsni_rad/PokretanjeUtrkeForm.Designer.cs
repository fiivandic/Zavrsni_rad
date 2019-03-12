namespace Zavrsni_rad
{
    partial class PokretanjeUtrkeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbldatPok = new System.Windows.Forms.Label();
            this.lblStartnoVrijemePOk = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btStop = new System.Windows.Forms.Button();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.lblRFID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.adgvTrkaci = new ADGV.AdvancedDataGridView();
            this.idUtrkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.utrkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zavrsniDataSet = new Zavrsni_rad.ZavrsniDataSet();
            this.idTrkacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zavr = new System.Windows.Forms.DataGridViewButtonColumn();
            this.trkacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBroj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trkacTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TrkacTableAdapter();
            this.osobaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.OsobaTableAdapter();
            this.utrkaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.UtrkaTableAdapter();
            this.tableAdapterManager1 = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TableAdapterManager();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvTrkaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbldatPok);
            this.splitContainer1.Panel1.Controls.Add(this.lblStartnoVrijemePOk);
            this.splitContainer1.Panel1.Controls.Add(this.lblIme);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(956, 587);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbldatPok
            // 
            this.lbldatPok.AutoSize = true;
            this.lbldatPok.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatPok.Location = new System.Drawing.Point(699, 29);
            this.lbldatPok.Name = "lbldatPok";
            this.lbldatPok.Size = new System.Drawing.Size(52, 18);
            this.lbldatPok.TabIndex = 19;
            this.lbldatPok.Text = "Utrka";
            // 
            // lblStartnoVrijemePOk
            // 
            this.lblStartnoVrijemePOk.AutoSize = true;
            this.lblStartnoVrijemePOk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartnoVrijemePOk.Location = new System.Drawing.Point(699, 9);
            this.lblStartnoVrijemePOk.Name = "lblStartnoVrijemePOk";
            this.lblStartnoVrijemePOk.Size = new System.Drawing.Size(52, 18);
            this.lblStartnoVrijemePOk.TabIndex = 18;
            this.lblStartnoVrijemePOk.Text = "Utrka";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(328, 10);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(52, 18);
            this.lblIme.TabIndex = 17;
            this.lblIme.Text = "Utrka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Utrka:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Startno vrijeme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datum:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btStop);
            this.splitContainer2.Panel1.Controls.Add(this.txtRFID);
            this.splitContainer2.Panel1.Controls.Add(this.lblRFID);
            this.splitContainer2.Panel1.Controls.Add(this.btnReset);
            this.splitContainer2.Panel1.Controls.Add(this.btnStart);
            this.splitContainer2.Panel1.Controls.Add(this.lblTimer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.adgvTrkaci);
            this.splitContainer2.Panel2.Controls.Add(this.lblBroj);
            this.splitContainer2.Size = new System.Drawing.Size(956, 532);
            this.splitContainer2.SplitterDistance = 257;
            this.splitContainer2.TabIndex = 0;
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(93, 134);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 33);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(46, 240);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(163, 20);
            this.txtRFID.TabIndex = 5;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            this.txtRFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRFID_KeyDown);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(40, 198);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(51, 25);
            this.lblRFID.TabIndex = 4;
            this.lblRFID.Text = "RFID";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(174, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(11, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(68, 61);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 33);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "label3";
            // 
            // adgvTrkaci
            // 
            this.adgvTrkaci.AllowUserToAddRows = false;
            this.adgvTrkaci.AutoGenerateColumns = false;
            this.adgvTrkaci.AutoGenerateContextFilters = true;
            this.adgvTrkaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvTrkaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtrkaDataGridViewTextBoxColumn,
            this.idTrkacDataGridViewTextBoxColumn,
            this.idOsobaDataGridViewTextBoxColumn,
            this.rFIDDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.Zavr});
            this.adgvTrkaci.DataSource = this.trkacBindingSource;
            this.adgvTrkaci.DateWithTime = false;
            this.adgvTrkaci.Location = new System.Drawing.Point(3, 7);
            this.adgvTrkaci.Name = "adgvTrkaci";
            this.adgvTrkaci.ReadOnly = true;
            this.adgvTrkaci.Size = new System.Drawing.Size(684, 495);
            this.adgvTrkaci.TabIndex = 3;
            this.adgvTrkaci.TimeFilter = false;
            this.adgvTrkaci.SortStringChanged += new System.EventHandler(this.adgvTrkaci_SortStringChanged);
            this.adgvTrkaci.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            this.adgvTrkaci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvTrkaci_CellClick);
            // 
            // idUtrkaDataGridViewTextBoxColumn
            // 
            this.idUtrkaDataGridViewTextBoxColumn.DataPropertyName = "IdUtrka";
            this.idUtrkaDataGridViewTextBoxColumn.DataSource = this.utrkaBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idUtrkaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idUtrkaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.idUtrkaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idUtrkaDataGridViewTextBoxColumn.HeaderText = "Utrka naziv";
            this.idUtrkaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idUtrkaDataGridViewTextBoxColumn.Name = "idUtrkaDataGridViewTextBoxColumn";
            this.idUtrkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtrkaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUtrkaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idUtrkaDataGridViewTextBoxColumn.ValueMember = "IdUtrka";
            // 
            // utrkaBindingSource
            // 
            this.utrkaBindingSource.DataMember = "Utrka";
            this.utrkaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // zavrsniDataSet
            // 
            this.zavrsniDataSet.DataSetName = "ZavrsniDataSet";
            this.zavrsniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTrkacDataGridViewTextBoxColumn
            // 
            this.idTrkacDataGridViewTextBoxColumn.DataPropertyName = "IdTrkac";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idTrkacDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idTrkacDataGridViewTextBoxColumn.HeaderText = "Startni broj";
            this.idTrkacDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idTrkacDataGridViewTextBoxColumn.Name = "idTrkacDataGridViewTextBoxColumn";
            this.idTrkacDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrkacDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idOsobaDataGridViewTextBoxColumn
            // 
            this.idOsobaDataGridViewTextBoxColumn.DataPropertyName = "IdOsoba";
            this.idOsobaDataGridViewTextBoxColumn.DataSource = this.osobaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idOsobaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idOsobaDataGridViewTextBoxColumn.DisplayMember = "Opis";
            this.idOsobaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idOsobaDataGridViewTextBoxColumn.HeaderText = "Trkač";
            this.idOsobaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idOsobaDataGridViewTextBoxColumn.Name = "idOsobaDataGridViewTextBoxColumn";
            this.idOsobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOsobaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idOsobaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idOsobaDataGridViewTextBoxColumn.ValueMember = "IdOsoba";
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "Osoba";
            this.osobaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // rFIDDataGridViewTextBoxColumn
            // 
            this.rFIDDataGridViewTextBoxColumn.DataPropertyName = "RFID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rFIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.rFIDDataGridViewTextBoxColumn.HeaderText = "RFID";
            this.rFIDDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.rFIDDataGridViewTextBoxColumn.Name = "rFIDDataGridViewTextBoxColumn";
            this.rFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "Vrijeme";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vrijemeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            this.vrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vrijemeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Zavr
            // 
            this.Zavr.HeaderText = "Završi utrku";
            this.Zavr.MinimumWidth = 22;
            this.Zavr.Name = "Zavr";
            this.Zavr.ReadOnly = true;
            this.Zavr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zavr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Zavr.Text = "Završi utrku";
            this.Zavr.UseColumnTextForButtonValue = true;
            // 
            // trkacBindingSource
            // 
            this.trkacBindingSource.DataMember = "Trkac";
            this.trkacBindingSource.DataSource = this.zavrsniDataSet;
            this.trkacBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.trkacBindingSource_ListChanged);
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(541, 510);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(131, 18);
            this.lblBroj.TabIndex = 2;
            this.lblBroj.Text = "Broj natjecatelja :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trkacTableAdapter
            // 
            this.trkacTableAdapter.ClearBeforeFill = true;
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // utrkaTableAdapter
            // 
            this.utrkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.OsobaTableAdapter = null;
            this.tableAdapterManager1.TrkacTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Zavrsni_rad.ZavrsniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UtrkaStanjeTableAdapter = null;
            this.tableAdapterManager1.UtrkaTableAdapter = null;
            this.tableAdapterManager1.UtrkaVrstaTableAdapter = null;
            // 
            // PokretanjeUtrkeForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 587);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PokretanjeUtrkeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokretanje utrke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PokretanjeUtrkeForm_FormClosing);
            this.Load += new System.EventHandler(this.PokretanjeUtrkeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvTrkaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ZavrsniDataSet zavrsniDataSet;
        private System.Windows.Forms.BindingSource trkacBindingSource;
        private ZavrsniDataSetTableAdapters.TrkacTableAdapter trkacTableAdapter;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private ZavrsniDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.BindingSource utrkaBindingSource;
        private ZavrsniDataSetTableAdapters.UtrkaTableAdapter utrkaTableAdapter;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label lblRFID;
        private ZavrsniDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        public System.Windows.Forms.Label lblIme;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private ADGV.AdvancedDataGridView adgvTrkaci;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUtrkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrkacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idOsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Zavr;
        public System.Windows.Forms.Label lblStartnoVrijemePOk;
        public System.Windows.Forms.Label lbldatPok;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Timer timer2;
    }
}