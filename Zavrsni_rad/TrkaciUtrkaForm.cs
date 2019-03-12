using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Zavrsni_rad
{
    public partial class TrkaciUtrkaForm : Form
    {
       
        public TrkaciUtrkaForm()
        {
            InitializeComponent();
            trkacTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
           
        }
        
        void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                var id = (int)cmd.ExecuteScalar();
                e.Row["IDtrkac"] = id;
                e.Row.AcceptChanges();
            }
        }

       
        private void TrkaciUtrkaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zavrsniDataSet.Utrka' table. You can move, or remove it, as needed.
            this.utrkaTableAdapter.Fill(this.zavrsniDataSet.Utrka);
            // TODO: This line of code loads data into the 'zavrsniDataSet.Trkac' table. You can move, or remove it, as needed.
            this.trkacTableAdapter.Fill(this.zavrsniDataSet.Trkac);
            // TODO: This line of code loads data into the 'zavrsniDataSet.Osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.zavrsniDataSet.Osoba);
            trkacTableAdapter.FillByIDutrka(zavrsniDataSet.Trkac,IdUtrkas);
            
        }
        private int _idUtrka;
        public int IdUtrkas
        {
            get { return _idUtrka; }
            set { _idUtrka = value; }
        }
        private void tsDodajOsobu_Click(object sender, EventArgs e)
        {
           
            var forma = new Osoba();
            forma.ShowDialog();
        }
      

        private void tsbDodajTrkača_Click(object sender, EventArgs e)
        {
            txtTrazi.Enabled = true;
            txtTrazi.Focus();
            lbNatjeca.Enabled = true;
            txtRFID.Enabled = true;
            rtbNapoemna.Enabled = true;
            var row = zavrsniDataSet.Trkac.NewTrkacRow();

            zavrsniDataSet.Trkac.AddTrkacRow(row);

            int count = trkacBindingSource.Count;
            if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                    DataRowView current = (DataRowView)trkacBindingSource.Current;

                    trkacBindingSource.MoveNext();
                     }
                }
            
        }

        private void tsbSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRFID.Text))
            {
                MessageBox.Show("Unesite RFID trkača", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                txtTrazi.Text = string.Empty;
                trkacBindingSource.EndEdit();
                DataRowView current = (DataRowView)trkacBindingSource.Current;
                current.Row["IdUtrka"] = IdUtrkas;
                trkacTableAdapter.Update(zavrsniDataSet.Trkac);

            }  
        }

        private void tsbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TrkaciUtrkaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyValue == 78)
            {
                tsbDodajTrkača_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 83)
            {
                tsbSpremi_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 115)
            {
                tsbIzlaz_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 77)
            {
                tsDodajOsobu_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 68)
            {
                tsbObris_Click(sender, null);
            }
        }
    
        private void trkacBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblBroj.Text = string.Format("Broj trkača: {0}", trkacBindingSource.List.Count);
        }
        
        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
                
                DataView dv = new DataView();
                dv.Table = zavrsniDataSet.Tables[0];
                dv.RowFilter = "Ime+Prezime LIKE '%" + txtTrazi.Text + "%'";
                osobaBindingSource.DataSource = dv;
              
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRFID.Text, "[^0-9]"))
            {
                MessageBox.Show("Molim vas unesite samo brojeve od 0 do 9");
                txtRFID.Text = txtRFID.Text.Remove(txtRFID.Text.Length - 1);
            }
        }

        private void tsbObris_Click(object sender, EventArgs e)
        {
            string OIB = rtbNapoemna.Text;
            trkacBindingSource.EndEdit();
            trkacTableAdapter.Delete(OIB);
            trkacTableAdapter.Fill(zavrsniDataSet.Trkac);
        }
        
        private void tsbUredi_Click_1(object sender, EventArgs e)
        {
            txtTrazi.Enabled = true;
            lbNatjeca.Enabled = true;
            txtRFID.Enabled = true;
            rtbNapoemna.Enabled = true;
           
            trkacTableAdapter.Update(zavrsniDataSet.Trkac);
        }
        
        private void txtRFID_KeyDown(object sender, KeyEventArgs e)
        {
            txtRFID.KeyPress += (sndr, ev) =>
            {
                if (ev.KeyChar.Equals((char)13))
                {
                    tsbSpremi_Click(sender, null);
                    ev.Handled = true; // suppress default handling
                }
            };
        }

      
    }
}
