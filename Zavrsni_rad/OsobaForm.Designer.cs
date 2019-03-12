namespace Zavrsni_rad
{
    partial class Osoba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osoba));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDodaj = new System.Windows.Forms.ToolStripButton();
            this.tsbSpremi = new System.Windows.Forms.ToolStripButton();
            this.tsbUredi = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zavrsniDataSet = new Zavrsni_rad.ZavrsniDataSet();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtxEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmDatum = new System.Windows.Forms.DateTimePicker();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTraži = new System.Windows.Forms.Button();
            this.dgvOsoba = new System.Windows.Forms.DataGridView();
            this.idOsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.osobaTableAdapter = new Zavrsni_rad.ZavrsniDataSetTableAdapters.OsobaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoba)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtIme);
            this.splitContainer1.Panel1.Controls.Add(this.txtOIB);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtxEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrezime);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.dtmDatum);
            this.splitContainer1.Panel1.Controls.Add(this.rtbNapomena);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTraži);
            this.splitContainer1.Panel2.Controls.Add(this.dgvOsoba);
            this.splitContainer1.Panel2.Controls.Add(this.txtTrazi);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 509);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDodaj,
            this.tsbSpremi,
            this.tsbUredi,
            this.tsbIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(368, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDodaj
            // 
            this.tsbDodaj.Image = ((System.Drawing.Image)(resources.GetObject("tsbDodaj.Image")));
            this.tsbDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDodaj.Name = "tsbDodaj";
            this.tsbDodaj.Size = new System.Drawing.Size(101, 22);
            this.tsbDodaj.Text = "Dodaj novoga";
            this.tsbDodaj.Click += new System.EventHandler(this.tsbDodaj_Click);
            // 
            // tsbSpremi
            // 
            this.tsbSpremi.Enabled = false;
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
            // tsbIzlaz
            // 
            this.tsbIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("tsbIzlaz.Image")));
            this.tsbIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIzlaz.Name = "tsbIzlaz";
            this.tsbIzlaz.Size = new System.Drawing.Size(49, 22);
            this.tsbIzlaz.Text = "Izlaz";
            this.tsbIzlaz.Click += new System.EventHandler(this.tsbIzlaz_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Napomena :";
            // 
            // txtIme
            // 
            this.txtIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Ime", true));
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(132, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(202, 20);
            this.txtIme.TabIndex = 1;
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "Osoba";
            this.osobaBindingSource.DataSource = this.zavrsniDataSet;
            // 
            // zavrsniDataSet
            // 
            this.zavrsniDataSet.DataSetName = "ZavrsniDataSet";
            this.zavrsniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtOIB
            // 
            this.txtOIB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "OIB", true));
            this.txtOIB.Enabled = false;
            this.txtOIB.Location = new System.Drawing.Point(132, 120);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(202, 20);
            this.txtOIB.TabIndex = 3;
            this.txtOIB.TextChanged += new System.EventHandler(this.txtOIB_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Datum rođenja :";
            // 
            // txtxEmail
            // 
            this.txtxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Email", true));
            this.txtxEmail.Enabled = false;
            this.txtxEmail.Location = new System.Drawing.Point(132, 164);
            this.txtxEmail.Name = "txtxEmail";
            this.txtxEmail.Size = new System.Drawing.Size(202, 20);
            this.txtxEmail.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Prezime", true));
            this.txtPrezime.Enabled = false;
            this.txtPrezime.Location = new System.Drawing.Point(132, 83);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(202, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email :";
            // 
            // dtmDatum
            // 
            this.dtmDatum.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDatum.CustomFormat = "dd.MM.yyyy";
            this.dtmDatum.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.osobaBindingSource, "DatumRodenja", true));
            this.dtmDatum.Enabled = false;
            this.dtmDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDatum.Location = new System.Drawing.Point(132, 207);
            this.dtmDatum.Name = "dtmDatum";
            this.dtmDatum.Size = new System.Drawing.Size(202, 20);
            this.dtmDatum.TabIndex = 5;
            this.dtmDatum.Value = new System.DateTime(2001, 12, 13, 0, 0, 0, 0);
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Napomena", true));
            this.rtbNapomena.Enabled = false;
            this.rtbNapomena.Location = new System.Drawing.Point(9, 284);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(325, 213);
            this.rtbNapomena.TabIndex = 6;
            this.rtbNapomena.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "OIB :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ime : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Prezime :";
            // 
            // btnTraži
            // 
            this.btnTraži.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTraži.Location = new System.Drawing.Point(19, 23);
            this.btnTraži.Name = "btnTraži";
            this.btnTraži.Size = new System.Drawing.Size(116, 23);
            this.btnTraži.TabIndex = 38;
            this.btnTraži.Text = "Pretraži osobe";
            this.btnTraži.UseVisualStyleBackColor = true;
            this.btnTraži.Click += new System.EventHandler(this.btnTraži_Click);
            // 
            // dgvOsoba
            // 
            this.dgvOsoba.AllowUserToAddRows = false;
            this.dgvOsoba.AutoGenerateColumns = false;
            this.dgvOsoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsoba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOsobaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datumRodenjaDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dgvOsoba.DataSource = this.osobaBindingSource;
            this.dgvOsoba.Location = new System.Drawing.Point(3, 49);
            this.dgvOsoba.Name = "dgvOsoba";
            this.dgvOsoba.ReadOnly = true;
            this.dgvOsoba.Size = new System.Drawing.Size(735, 460);
            this.dgvOsoba.TabIndex = 7;
            // 
            // idOsobaDataGridViewTextBoxColumn
            // 
            this.idOsobaDataGridViewTextBoxColumn.DataPropertyName = "IdOsoba";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idOsobaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.idOsobaDataGridViewTextBoxColumn.HeaderText = "Id ";
            this.idOsobaDataGridViewTextBoxColumn.Name = "idOsobaDataGridViewTextBoxColumn";
            this.idOsobaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOsobaDataGridViewTextBoxColumn.Width = 50;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.imeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prezimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oIBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumRodenjaDataGridViewTextBoxColumn
            // 
            this.datumRodenjaDataGridViewTextBoxColumn.DataPropertyName = "DatumRodenja";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "dd.MM.yyyy";
            this.datumRodenjaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.datumRodenjaDataGridViewTextBoxColumn.HeaderText = "Datum Rodenja";
            this.datumRodenjaDataGridViewTextBoxColumn.Name = "datumRodenjaDataGridViewTextBoxColumn";
            this.datumRodenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumRodenjaDataGridViewTextBoxColumn.Width = 120;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.napomenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(141, 23);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(338, 20);
            this.txtTrazi.TabIndex = 33;
            this.txtTrazi.Visible = false;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
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
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum rođenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-195, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-195, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "OIB :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-195, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-195, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime : ";
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1110, 509);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "Osoba";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Osoba";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Osoba_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zavrsniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ZavrsniDataSet zavrsniDataSet;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private ZavrsniDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtxEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmDatum;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDodaj;
        private System.Windows.Forms.ToolStripButton tsbSpremi;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.DataGridView dgvOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbUredi;
        private System.Windows.Forms.Button btnTraži;
    }
}