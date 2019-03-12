namespace Zavrsni_rad
{
    partial class UtrkaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtrkaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpStartnoVrijeme = new System.Windows.Forms.DateTimePicker();
            this.utrkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zavrsniDataSet = new Zavrsni_rad.ZavrsniDataSet();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.utrkaVrstaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utrkaStanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDodaj = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremi = new System.Windows.Forms.ToolStripButton();
            this.tsbUredi = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pregledStanjaUtrkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledVrstaUtrkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtmDatum = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvUtrka = new System.Windows.Forms.DataGridView();
            this.idUtrkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startnoVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtrkaStanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idUtrkaVrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmTrkaci = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmPokretanje = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmReport = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.utrkaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.UtrkaTableAdapter();
            this.utrkaStanjeTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.UtrkaStanjeTableAdapter();
            this.utrkaVrstaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.UtrkaVrstaTableAdapter();
            this.trkacTableAdapter1 = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TrkacTableAdapter();
            this.tableAdapterManager1 = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaVrstaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaStanjeBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrka)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpStartnoVrijeme);
            this.splitContainer1.Panel1.Controls.Add(this.cmbVrsta);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.txtNaziv);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.dtmDatum);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvUtrka);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1340, 311);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 3;
            // 
            // dtpStartnoVrijeme
            // 
            this.dtpStartnoVrijeme.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartnoVrijeme.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utrkaBindingSource, "StartnoVrijeme", true));
            this.dtpStartnoVrijeme.Enabled = false;
            this.dtpStartnoVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartnoVrijeme.Location = new System.Drawing.Point(139, 131);
            this.dtpStartnoVrijeme.Name = "dtpStartnoVrijeme";
            this.dtpStartnoVrijeme.ShowUpDown = true;
            this.dtpStartnoVrijeme.Size = new System.Drawing.Size(202, 20);
            this.dtpStartnoVrijeme.TabIndex = 2;
            this.dtpStartnoVrijeme.Value = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
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
            // cmbVrsta
            // 
            this.cmbVrsta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.utrkaBindingSource, "IdUtrkaVrsta", true));
            this.cmbVrsta.DataSource = this.utrkaVrstaBindingSource;
            this.cmbVrsta.DisplayMember = "Naziv";
            this.cmbVrsta.Enabled = false;
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(139, 176);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(202, 21);
            this.cmbVrsta.TabIndex = 4;
            this.cmbVrsta.ValueMember = "IdUtrkaVrsta";
            // 
            // utrkaVrstaBindingSource
            // 
            this.utrkaVrstaBindingSource.DataMember = "UtrkaVrsta";
            this.utrkaVrstaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // utrkaStanjeBindingSource
            // 
            this.utrkaStanjeBindingSource.DataMember = "UtrkaStanje";
            this.utrkaStanjeBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDodaj,
            this.tsbSpremi,
            this.tsbUredi,
            this.toolStripDropDownButton1,
            this.tsbIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(443, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDodaj
            // 
            this.tsbDodaj.Image = ((System.Drawing.Image)(resources.GetObject("tsbDodaj.Image")));
            this.tsbDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDodaj.Name = "tsbDodaj";
            this.tsbDodaj.Size = new System.Drawing.Size(119, 22);
            this.tsbDodaj.Text = "Dodaj novu utrku";
            this.tsbDodaj.Click += new System.EventHandler(this.tsbDodaj_Click);
            // 
            // tsbSpremi
            // 
            this.tsbSpremi.Image = ((System.Drawing.Image)(resources.GetObject("tsbSpremi.Image")));
            this.tsbSpremi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpremi.Name = "tsbSpremi";
            this.tsbSpremi.Size = new System.Drawing.Size(64, 22);
            this.tsbSpremi.Text = "Spremi";
            this.tsbSpremi.Click += new System.EventHandler(this.tsbSpremi_Click);
            // 
            // tsbUredi
            // 
            this.tsbUredi.Image = global::Zavrsni_rad.Properties.Resources.ASX_Edit_blue_16x;
            this.tsbUredi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUredi.Name = "tsbUredi";
            this.tsbUredi.Size = new System.Drawing.Size(55, 22);
            this.tsbUredi.Text = "Uredi";
            this.tsbUredi.Click += new System.EventHandler(this.tsbUredi_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledStanjaUtrkaToolStripMenuItem,
            this.pregledVrstaUtrkaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(106, 22);
            this.toolStripDropDownButton1.Text = "Pregled utrka";
            this.toolStripDropDownButton1.ToolTipText = "Pregled utrka";
            // 
            // pregledStanjaUtrkaToolStripMenuItem
            // 
            this.pregledStanjaUtrkaToolStripMenuItem.Name = "pregledStanjaUtrkaToolStripMenuItem";
            this.pregledStanjaUtrkaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pregledStanjaUtrkaToolStripMenuItem.Text = "Pregled stanja utrka";
            this.pregledStanjaUtrkaToolStripMenuItem.Click += new System.EventHandler(this.pregledStanjaUtrkaToolStripMenuItem_Click);
            // 
            // pregledVrstaUtrkaToolStripMenuItem
            // 
            this.pregledVrstaUtrkaToolStripMenuItem.Name = "pregledVrstaUtrkaToolStripMenuItem";
            this.pregledVrstaUtrkaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pregledVrstaUtrkaToolStripMenuItem.Text = "Pregled vrsta utrka";
            this.pregledVrstaUtrkaToolStripMenuItem.Click += new System.EventHandler(this.pregledVrstaUtrkaToolStripMenuItem_Click);
            // 
            // tsbIzlaz
            // 
            this.tsbIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("tsbIzlaz.Image")));
            this.tsbIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzlaz.Name = "tsbIzlaz";
            this.tsbIzlaz.Size = new System.Drawing.Size(49, 22);
            this.tsbIzlaz.Text = "Izlaz";
            this.tsbIzlaz.Click += new System.EventHandler(this.tsbIzlaz_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utrkaBindingSource, "Naziv", true));
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(139, 57);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(202, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Vrsta utrke :";
            // 
            // dtmDatum
            // 
            this.dtmDatum.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDatum.CustomFormat = "dd.MM.yyyy";
            this.dtmDatum.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.utrkaBindingSource, "Datum", true));
            this.dtmDatum.Enabled = false;
            this.dtmDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDatum.Location = new System.Drawing.Point(139, 93);
            this.dtmDatum.Name = "dtmDatum";
            this.dtmDatum.Size = new System.Drawing.Size(202, 20);
            this.dtmDatum.TabIndex = 1;
            this.dtmDatum.Value = new System.DateTime(2018, 5, 18, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Startno vrijeme :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Naziv utrke : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Datum  :";
            // 
            // dgvUtrka
            // 
            this.dgvUtrka.AllowUserToAddRows = false;
            this.dgvUtrka.AutoGenerateColumns = false;
            this.dgvUtrka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtrka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtrkaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.startnoVrijemeDataGridViewTextBoxColumn,
            this.idUtrkaStanjeDataGridViewTextBoxColumn,
            this.idUtrkaVrstaDataGridViewTextBoxColumn,
            this.cmTrkaci,
            this.cmPokretanje,
            this.cmReport});
            this.dgvUtrka.DataSource = this.utrkaBindingSource;
            this.dgvUtrka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtrka.Location = new System.Drawing.Point(0, 0);
            this.dgvUtrka.Name = "dgvUtrka";
            this.dgvUtrka.ReadOnly = true;
            this.dgvUtrka.Size = new System.Drawing.Size(893, 311);
            this.dgvUtrka.TabIndex = 0;
            this.dgvUtrka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtrka_CellClick);
            // 
            // idUtrkaDataGridViewTextBoxColumn
            // 
            this.idUtrkaDataGridViewTextBoxColumn.DataPropertyName = "IdUtrka";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idUtrkaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.idUtrkaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idUtrkaDataGridViewTextBoxColumn.Name = "idUtrkaDataGridViewTextBoxColumn";
            this.idUtrkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtrkaDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nazivDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "dd.MM.yyyy";
            dataGridViewCellStyle15.NullValue = null;
            this.datumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startnoVrijemeDataGridViewTextBoxColumn
            // 
            this.startnoVrijemeDataGridViewTextBoxColumn.DataPropertyName = "StartnoVrijeme";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "H:mm";
            dataGridViewCellStyle16.NullValue = null;
            this.startnoVrijemeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.startnoVrijemeDataGridViewTextBoxColumn.HeaderText = "Startno vrijeme";
            this.startnoVrijemeDataGridViewTextBoxColumn.Name = "startnoVrijemeDataGridViewTextBoxColumn";
            this.startnoVrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startnoVrijemeDataGridViewTextBoxColumn.Width = 120;
            // 
            // idUtrkaStanjeDataGridViewTextBoxColumn
            // 
            this.idUtrkaStanjeDataGridViewTextBoxColumn.DataPropertyName = "IdUtrkaStanje";
            this.idUtrkaStanjeDataGridViewTextBoxColumn.DataSource = this.utrkaStanjeBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idUtrkaStanjeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.idUtrkaStanjeDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.idUtrkaStanjeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idUtrkaStanjeDataGridViewTextBoxColumn.HeaderText = "Utrka stanje";
            this.idUtrkaStanjeDataGridViewTextBoxColumn.Name = "idUtrkaStanjeDataGridViewTextBoxColumn";
            this.idUtrkaStanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtrkaStanjeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUtrkaStanjeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUtrkaStanjeDataGridViewTextBoxColumn.ValueMember = "IdUtrkaStanja";
            // 
            // idUtrkaVrstaDataGridViewTextBoxColumn
            // 
            this.idUtrkaVrstaDataGridViewTextBoxColumn.DataPropertyName = "IdUtrkaVrsta";
            this.idUtrkaVrstaDataGridViewTextBoxColumn.DataSource = this.utrkaVrstaBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idUtrkaVrstaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.idUtrkaVrstaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.idUtrkaVrstaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idUtrkaVrstaDataGridViewTextBoxColumn.HeaderText = "Utrka vrsta";
            this.idUtrkaVrstaDataGridViewTextBoxColumn.Name = "idUtrkaVrstaDataGridViewTextBoxColumn";
            this.idUtrkaVrstaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtrkaVrstaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUtrkaVrstaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUtrkaVrstaDataGridViewTextBoxColumn.ValueMember = "IdUtrkaVrsta";
            // 
            // cmTrkaci
            // 
            this.cmTrkaci.HeaderText = "Trkači na utrci";
            this.cmTrkaci.Name = "cmTrkaci";
            this.cmTrkaci.ReadOnly = true;
            this.cmTrkaci.Text = "Trkači na utrci";
            this.cmTrkaci.UseColumnTextForButtonValue = true;
            // 
            // cmPokretanje
            // 
            this.cmPokretanje.HeaderText = "Pokretanje utrke";
            this.cmPokretanje.Name = "cmPokretanje";
            this.cmPokretanje.ReadOnly = true;
            this.cmPokretanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmPokretanje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmPokretanje.Text = "Pokretanje utrke";
            this.cmPokretanje.UseColumnTextForButtonValue = true;
            this.cmPokretanje.Width = 110;
            // 
            // cmReport
            // 
            this.cmReport.HeaderText = "Rezultati";
            this.cmReport.Name = "cmReport";
            this.cmReport.ReadOnly = true;
            this.cmReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmReport.Text = "Rezultati";
            this.cmReport.ToolTipText = "Rezultati";
            this.cmReport.UseColumnTextForButtonValue = true;
            this.cmReport.Width = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-195, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Napomena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-195, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Datum rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-195, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-195, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "OIB :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-195, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prezime :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-195, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime : ";
            // 
            // utrkaTableAdapter
            // 
            this.utrkaTableAdapter.ClearBeforeFill = true;
            // 
            // utrkaStanjeTableAdapter
            // 
            this.utrkaStanjeTableAdapter.ClearBeforeFill = true;
            // 
            // utrkaVrstaTableAdapter
            // 
            this.utrkaVrstaTableAdapter.ClearBeforeFill = true;
            // 
            // trkacTableAdapter1
            // 
            this.trkacTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.OsobaTableAdapter = null;
            this.tableAdapterManager1.TrkacTableAdapter = this.trkacTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Zavrsni_rad.ZavrsniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UtrkaStanjeTableAdapter = this.utrkaStanjeTableAdapter;
            this.tableAdapterManager1.UtrkaTableAdapter = this.utrkaTableAdapter;
            this.tableAdapterManager1.UtrkaVrstaTableAdapter = this.utrkaVrstaTableAdapter;
            // 
            // UtrkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 311);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "UtrkaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utrka";
            this.Load += new System.EventHandler(this.UtrkaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UtrkaForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utrkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaVrstaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaStanjeBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDodaj;
        private System.Windows.Forms.ToolStripButton tsbSpremi;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtmDatum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZavrsniDataSet zavrsniDataSet;
        private System.Windows.Forms.BindingSource utrkaBindingSource;
        private ZavrsniDataSetTableAdapters.UtrkaTableAdapter utrkaTableAdapter;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pregledStanjaUtrkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledVrstaUtrkaToolStripMenuItem;
        private System.Windows.Forms.BindingSource utrkaStanjeBindingSource;
        private ZavrsniDataSetTableAdapters.UtrkaStanjeTableAdapter utrkaStanjeTableAdapter;
        private System.Windows.Forms.BindingSource utrkaVrstaBindingSource;
        private ZavrsniDataSetTableAdapters.UtrkaVrstaTableAdapter utrkaVrstaTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpStartnoVrijeme;
        public System.Windows.Forms.DataGridView dgvUtrka;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtrkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startnoVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUtrkaStanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUtrkaVrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn cmTrkaci;
        private System.Windows.Forms.DataGridViewButtonColumn cmPokretanje;
        private System.Windows.Forms.DataGridViewButtonColumn cmReport;
        private System.Windows.Forms.ToolStripButton tsbUredi;
        private ZavrsniDataSetTableAdapters.TrkacTableAdapter trkacTableAdapter1;
        private ZavrsniDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}