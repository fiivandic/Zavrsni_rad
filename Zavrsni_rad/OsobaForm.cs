using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Zavrsni_rad
{
    public partial class Osoba : Form
    {
        public Osoba()
        {
            InitializeComponent();
            osobaTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
        }
        void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                var id = (int)cmd.ExecuteScalar();
                e.Row["IDOsoba"] = id;
                e.Row.AcceptChanges();
            }
        }
        private void Osoba_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'zavrsniDataSet.Osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.zavrsniDataSet.Osoba);
           
        }
        
        private void izlazToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tsbDodaj_Click(object sender, System.EventArgs e)
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtOIB.Enabled = true;
            txtxEmail.Enabled = true;
            rtbNapomena.Enabled = true;
            tsbUredi.Enabled = true;
            tsbSpremi.Enabled=true;
            dtmDatum.Enabled = true;
  
            var row = zavrsniDataSet.Osoba.NewOsobaRow();
            zavrsniDataSet.Osoba.AddOsobaRow(row);
            
         
            osobaBindingSource.MoveLast();
            
            txtIme.Focus();
    
        }
        private void tsbSpremi_Click(object sender, System.EventArgs e)
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtOIB.Enabled = false;
            txtxEmail.Enabled = false;
            rtbNapomena.Enabled = false;
            dtmDatum.Enabled = false;
            tsbUredi.Enabled = true;

            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Unesite ime polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((string.IsNullOrEmpty(txtPrezime.Text)))
            {
                MessageBox.Show("Unesite prezime polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((string.IsNullOrEmpty(txtOIB.Text)))
            {
                MessageBox.Show("Unesite OIB polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(txtxEmail.Text)))
            {
                MessageBox.Show("Unesite email polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (true)
            {
                osobaBindingSource.EndEdit();
                osobaTableAdapter.Update(zavrsniDataSet.Osoba);
            }
           
        }

        private void tsbIzlaz_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void txtTrazi_TextChanged(object sender, System.EventArgs e)
        {
            DataView dv = new DataView();
            dv.Table = zavrsniDataSet.Tables[0];
            dv.RowFilter = " Ime + Prezime LIKE '%" + txtTrazi.Text + "%'";
            dgvOsoba.DataSource = dv;

        }

        private void txtOIB_TextChanged(object sender, System.EventArgs e)
        {
            this.txtOIB.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOIB.Text, "[^0-9]"))
            {
                MessageBox.Show("Molim vas unesite samo brojeve od 0 do 9");
                txtOIB.Text = txtOIB.Text.Remove(txtOIB.Text.Length - 1);
            }
        }

        private void Osoba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyValue == 78)
            {
                tsbDodaj_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 83)
            {
                tsbSpremi_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 115)
            {
                tsbIzlaz_Click(sender, null);
            }
            

        }

        private void tsbUredi_Click(object sender, System.EventArgs e)
        {
            txtIme.Enabled=true;
            txtPrezime.Enabled = true;
            txtOIB.Enabled = true;
            txtxEmail.Enabled = true;
            rtbNapomena.Enabled = true;
            dtmDatum.Enabled = true;
            osobaTableAdapter.Update(zavrsniDataSet.Osoba);
        }

        private void btnTraži_Click(object sender, System.EventArgs e)
        {
            txtTrazi.Visible = true;
            
        }

        
    }
}
