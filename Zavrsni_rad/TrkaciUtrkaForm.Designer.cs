namespace Zavrsni_rad
{
    partial class TrkaciUtrkaForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDTrk = new System.Windows.Forms.Label();
            this.lblSvTr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.trkacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zavrsniDataSet = new Zavrsni_rad.ZavrsniDataSet();
            this.lbNatjeca = new System.Windows.Forms.ListBox();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsDodajOsobu = new System.Windows.Forms.ToolStripButton();
            this.tsbDodajTrkača = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremi = new System.Windows.Forms.ToolStripButton();
            this.tsbObris = new System.Windows.Forms.ToolStripButton();
            this.tsbUredi = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.rtbNapoemna = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUtrka = new System.Windows.Forms.DataGridView();
            this.idTrkacDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOsobaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idUtrkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.utrkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBroj = new System.Windows.Forms.Label();
            this.dgvTrkaci = new System.Windows.Forms.DataGridView();
            this.idTrkacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaTrkacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.OsobaTableAdapter();
            this.trkacTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.TrkacTableAdapter();
            this.utrkaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.UtrkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrkaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaTrkacBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblDTrk);
            this.splitContainer1.Panel1.Controls.Add(this.lblSvTr);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblId);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(971, 604);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblDTrk
            // 
            this.lblDTrk.AutoSize = true;
            this.lblDTrk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTrk.Location = new System.Drawing.Point(732, 31);
            this.lblDTrk.Name = "lblDTrk";
            this.lblDTrk.Size = new System.Drawing.Size(30, 18);
            this.lblDTrk.TabIndex = 19;
            this.lblDTrk.Text = "str";
            // 
            // lblSvTr
            // 
            this.lblSvTr.AutoSize = true;
            this.lblSvTr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvTr.Location = new System.Drawing.Point(732, 9);
            this.lblSvTr.Name = "lblSvTr";
            this.lblSvTr.Size = new System.Drawing.Size(30, 18);
            this.lblSvTr.TabIndex = 18;
            this.lblSvTr.Text = "str";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Utrka:  ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(310, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 18);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Startno vrijeme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 5;
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
            this.splitContainer2.Panel1.Controls.Add(this.txtRFID);
            this.splitContainer2.Panel1.Controls.Add(this.lbNatjeca);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.txtTrazi);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.rtbNapoemna);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.dgvUtrka);
            this.splitContainer2.Panel2.Controls.Add(this.lblBroj);
            this.splitContainer2.Size = new System.Drawing.Size(971, 546);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtRFID
            // 
            this.txtRFID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trkacBindingSource, "RFID", true));
            this.txtRFID.Enabled = false;
            this.txtRFID.Location = new System.Drawing.Point(115, 381);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(183, 20);
            this.txtRFID.TabIndex = 0;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            this.txtRFID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRFID_KeyDown);
            // 
            // trkacBindingSource
            // 
            this.trkacBindingSource.DataMember = "Trkac";
            this.trkacBindingSource.DataSource = this.zavrsniDataSet;
            this.trkacBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.trkacBindingSource_ListChanged);
            // 
            // zavrsniDataSet
            // 
            this.zavrsniDataSet.DataSetName = "ZavrsniDataSet";
            this.zavrsniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbNatjeca
            // 
            this.lbNatjeca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trkacBindingSource, "IdOsoba", true));
            this.lbNatjeca.DataSource = this.osobaBindingSource;
            this.lbNatjeca.DisplayMember = "Opis";
            this.lbNatjeca.Enabled = false;
            this.lbNatjeca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNatjeca.FormattingEnabled = true;
            this.lbNatjeca.HorizontalScrollbar = true;
            this.lbNatjeca.ItemHeight = 17;
            this.lbNatjeca.Location = new System.Drawing.Point(115, 94);
            this.lbNatjeca.Name = "lbNatjeca";
            this.lbNatjeca.Size = new System.Drawing.Size(183, 106);
            this.lbNatjeca.TabIndex = 45;
            this.lbNatjeca.TabStop = false;
            this.lbNatjeca.UseTabStops = false;
            this.lbNatjeca.ValueMember = "IdOsoba";
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "Osoba";
            this.osobaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Traži trkače";
            // 
            // txtTrazi
            // 
            this.txtTrazi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTrazi.Enabled = false;
            this.txtTrazi.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrazi.Location = new System.Drawing.Point(115, 63);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(183, 25);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TabStop = false;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDodajOsobu,
            this.tsbDodajTrkača,
            this.tsbSpremi,
            this.tsbObris,
            this.tsbUredi,
            this.tsbIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(390, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsDodajOsobu
            // 
            this.tsDodajOsobu.Image = global::Zavrsni_rad.Properties.Resources.Add_8x_16x;
            this.tsDodajOsobu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDodajOsobu.Name = "tsDodajOsobu";
            this.tsDodajOsobu.Size = new System.Drawing.Size(90, 22);
            this.tsDodajOsobu.Text = "Nova osoba";
            this.tsDodajOsobu.Click += new System.EventHandler(this.tsDodajOsobu_Click);
            // 
            // tsbDodajTrkača
            // 
            this.tsbDodajTrkača.Image = global::Zavrsni_rad.Properties.Resources.Add_8x_16x;
            this.tsbDodajTrkača.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDodajTrkača.Name = "tsbDodajTrkača";
            this.tsbDodajTrkača.Size = new System.Drawing.Size(81, 22);
            this.tsbDodajTrkača.Text = "Novi trkač";
            this.tsbDodajTrkača.Click += new System.EventHandler(this.tsbDodajTrkača_Click);
            // 
            // tsbSpremi
            // 
            this.tsbSpremi.Image = global::Zavrsni_rad.Properties.Resources.Save_16x;
            this.tsbSpremi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpremi.Name = "tsbSpremi";
            this.tsbSpremi.Size = new System.Drawing.Size(64, 22);
            this.tsbSpremi.Text = "Spremi";
            this.tsbSpremi.Click += new System.EventHandler(this.tsbSpremi_Click);
            // 
            // tsbObris
            // 
            this.tsbObris.Image = global::Zavrsni_rad.Properties.Resources.if_Close_18910231;
            this.tsbObris.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbObris.Name = "tsbObris";
            this.tsbObris.Size = new System.Drawing.Size(58, 22);
            this.tsbObris.Text = "Obriši";
            this.tsbObris.Click += new System.EventHandler(this.tsbObris_Click);
            // 
            // tsbUredi
            // 
            this.tsbUredi.Image = global::Zavrsni_rad.Properties.Resources.ASX_Edit_blue_16x;
            this.tsbUredi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUredi.Name = "tsbUredi";
            this.tsbUredi.Size = new System.Drawing.Size(55, 22);
            this.tsbUredi.Text = "Uredi";
            this.tsbUredi.Click += new System.EventHandler(this.tsbUredi_Click_1);
            // 
            // tsbIzlaz
            // 
            this.tsbIzlaz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIzlaz.Image = global::Zavrsni_rad.Properties.Resources.ShutDown_16x_24;
            this.tsbIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzlaz.Name = "tsbIzlaz";
            this.tsbIzlaz.Size = new System.Drawing.Size(23, 22);
            this.tsbIzlaz.Text = "toolStripButton1";
            this.tsbIzlaz.Click += new System.EventHandler(this.tsbIzlaz_Click);
            // 
            // rtbNapoemna
            // 
            this.rtbNapoemna.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trkacBindingSource, "Napomena", true));
            this.rtbNapoemna.Enabled = false;
            this.rtbNapoemna.Location = new System.Drawing.Point(12, 264);
            this.rtbNapoemna.Name = "rtbNapoemna";
            this.rtbNapoemna.Size = new System.Drawing.Size(286, 98);
            this.rtbNapoemna.TabIndex = 1;
            this.rtbNapoemna.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Dodaj RFID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Napiši napomenu";
            // 
            // dgvUtrka
            // 
            this.dgvUtrka.AllowUserToAddRows = false;
            this.dgvUtrka.AutoGenerateColumns = false;
            this.dgvUtrka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtrka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrkacDataGridViewTextBoxColumn1,
            this.idOsobaDataGridViewTextBoxColumn1,
            this.idUtrkaDataGridViewTextBoxColumn,
            this.rFIDDataGridViewTextBoxColumn1,
            this.napomenaDataGridViewTextBoxColumn1});
            this.dgvUtrka.DataSource = this.trkacBindingSource;
            this.dgvUtrka.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvUtrka.Location = new System.Drawing.Point(3, 0);
            this.dgvUtrka.Name = "dgvUtrka";
            this.dgvUtrka.ReadOnly = true;
            this.dgvUtrka.Size = new System.Drawing.Size(571, 518);
            this.dgvUtrka.TabIndex = 0;
            this.dgvUtrka.TabStop = false;
           
            // idTrkacDataGridViewTextBoxColumn1
            // 
            this.idTrkacDataGridViewTextBoxColumn1.DataPropertyName = "IdTrkac";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idTrkacDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.idTrkacDataGridViewTextBoxColumn1.HeaderText = "Startni broj";
            this.idTrkacDataGridViewTextBoxColumn1.Name = "idTrkacDataGridViewTextBoxColumn1";
            this.idTrkacDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idOsobaDataGridViewTextBoxColumn1
            // 
            this.idOsobaDataGridViewTextBoxColumn1.DataPropertyName = "IdOsoba";
            this.idOsobaDataGridViewTextBoxColumn1.DataSource = this.osobaBindingSource;
            this.idOsobaDataGridViewTextBoxColumn1.DisplayMember = "Opis";
            this.idOsobaDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idOsobaDataGridViewTextBoxColumn1.HeaderText = "Natjecatelj";
            this.idOsobaDataGridViewTextBoxColumn1.Name = "idOsobaDataGridViewTextBoxColumn1";
            this.idOsobaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idOsobaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idOsobaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idOsobaDataGridViewTextBoxColumn1.ValueMember = "IdOsoba";
            // 
            // idUtrkaDataGridViewTextBoxColumn
            // 
            this.idUtrkaDataGridViewTextBoxColumn.DataPropertyName = "IdUtrka";
            this.idUtrkaDataGridViewTextBoxColumn.DataSource = this.utrkaBindingSource;
            this.idUtrkaDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.idUtrkaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idUtrkaDataGridViewTextBoxColumn.HeaderText = "Utrka";
            this.idUtrkaDataGridViewTextBoxColumn.Name = "idUtrkaDataGridViewTextBoxColumn";
            this.idUtrkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUtrkaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUtrkaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUtrkaDataGridViewTextBoxColumn.ValueMember = "IdUtrka";
            // 
            // utrkaBindingSource
            // 
            this.utrkaBindingSource.DataMember = "Utrka";
            this.utrkaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // rFIDDataGridViewTextBoxColumn1
            // 
            this.rFIDDataGridViewTextBoxColumn1.DataPropertyName = "RFID";
            this.rFIDDataGridViewTextBoxColumn1.HeaderText = "RFID";
            this.rFIDDataGridViewTextBoxColumn1.Name = "rFIDDataGridViewTextBoxColumn1";
            this.rFIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn1
            // 
            this.napomenaDataGridViewTextBoxColumn1.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.Name = "napomenaDataGridViewTextBoxColumn1";
            this.napomenaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(375, 521);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(131, 18);
            this.lblBroj.TabIndex = 1;
            this.lblBroj.Text = "Broj natjecatelja :";
            // 
            // dgvTrkaci
            // 
            this.dgvTrkaci.AllowUserToAddRows = false;
            this.dgvTrkaci.AllowUserToDeleteRows = false;
            this.dgvTrkaci.AutoGenerateColumns = false;
            this.dgvTrkaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrkaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTrkacDataGridViewTextBoxColumn,
            this.idOsobaDataGridViewTextBoxColumn,
            this.rFIDDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dgvTrkaci.Location = new System.Drawing.Point(3, 37);
            this.dgvTrkaci.Name = "dgvTrkaci";
            this.dgvTrkaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTrkaci.Size = new System.Drawing.Size(500, 511);
            this.dgvTrkaci.TabIndex = 0;
            // 
            // idTrkacDataGridViewTextBoxColumn
            // 
            this.idTrkacDataGridViewTextBoxColumn.DataPropertyName = "IdTrkac";
            this.idTrkacDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idTrkacDataGridViewTextBoxColumn.Name = "idTrkacDataGridViewTextBoxColumn";
            this.idTrkacDataGridViewTextBoxColumn.Width = 50;
            // 
            // idOsobaDataGridViewTextBoxColumn
            // 
            this.idOsobaDataGridViewTextBoxColumn.DataPropertyName = "IdOsoba";
            this.idOsobaDataGridViewTextBoxColumn.HeaderText = "Osoba";
            this.idOsobaDataGridViewTextBoxColumn.Name = "idOsobaDataGridViewTextBoxColumn";
            // 
            // rFIDDataGridViewTextBoxColumn
            // 
            this.rFIDDataGridViewTextBoxColumn.DataPropertyName = "RFID";
            this.rFIDDataGridViewTextBoxColumn.HeaderText = "RFID";
            this.rFIDDataGridViewTextBoxColumn.Name = "rFIDDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.Width = 200;
            // 
            // osobaTrkacBindingSource
            // 
            this.osobaTrkacBindingSource.DataMember = "OsobaTrkac";
            this.osobaTrkacBindingSource.DataSource = this.osobaBindingSource;
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // trkacTableAdapter
            // 
            this.trkacTableAdapter.ClearBeforeFill = true;
            // 
            // utrkaTableAdapter
            // 
            this.utrkaTableAdapter.ClearBeforeFill = true;
            // 
            // TrkaciUtrkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 604);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "TrkaciUtrkaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trkaci na utrka";
            this.Load += new System.EventHandler(this.TrkaciUtrkaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrkaciUtrkaForm_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.trkacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtrka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utrkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrkaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaTrkacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ZavrsniDataSet zavrsniDataSet;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private ZavrsniDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrkacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNapoemna;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvTrkaci;
        private System.Windows.Forms.BindingSource trkacBindingSource;
        private ZavrsniDataSetTableAdapters.TrkacTableAdapter trkacTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsDodajOsobu;
        private System.Windows.Forms.ToolStripButton tsbDodajTrkača;
        private System.Windows.Forms.ToolStripButton tsbSpremi;
        private System.Windows.Forms.BindingSource osobaTrkacBindingSource;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.ListBox lbNatjeca;
        private System.Windows.Forms.Label lblBroj;
        private ZavrsniDataSetTableAdapters.UtrkaTableAdapter utrkaTableAdapter;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.BindingSource utrkaBindingSource;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblSvTr;
        public System.Windows.Forms.DataGridView dgvUtrka;
        public System.Windows.Forms.Label lblDTrk;
        private System.Windows.Forms.ToolStripButton tsbObris;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrkacDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idOsobaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUtrkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton tsbUredi;
    }
}