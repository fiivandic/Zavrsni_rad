using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zavrsni_rad.ZavrsniDataSetTableAdapters;

namespace Zavrsni_rad
{
   
    public partial class UtrkaForm : Form
    {
    
        public UtrkaForm()
        {
            InitializeComponent();
            utrkaTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
        }
        void Adapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                var id = (int)cmd.ExecuteScalar();
                e.Row["IdUtrka"] = id;
                e.Row.AcceptChanges();
            }
        }
        private void UtrkaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zavrsniDataSet.UtrkaVrsta' table. You can move, or remove it, as needed.
            this.utrkaVrstaTableAdapter.Fill(this.zavrsniDataSet.UtrkaVrsta);
            // TODO: This line of code loads data into the 'zavrsniDataSet.UtrkaStanje' table. You can move, or remove it, as needed.
            this.utrkaStanjeTableAdapter.Fill(this.zavrsniDataSet.UtrkaStanje);
            // TODO: This line of code loads data into the 'zavrsniDataSet.Utrka' table. You can move, or remove it, as needed.
            this.utrkaTableAdapter.Fill(this.zavrsniDataSet.Utrka);
           
        }
       

        private void tsbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pregledStanjaUtrkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new UtrkaStanjeForm();
            forma.ShowDialog();
        }

        private void pregledVrstaUtrkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new UtrkaVrstaForm();
            forma.ShowDialog();
        }

     
        private void tsbDodaj_Click(object sender, EventArgs e)
        {
            txtNaziv.Enabled = true;
            txtNaziv.Focus();
            dtmDatum.Enabled = true;
         
            cmbVrsta.Enabled = true;
            dtpStartnoVrijeme.Enabled = true;
            var row = zavrsniDataSet.Utrka.NewUtrkaRow();
            zavrsniDataSet.Utrka.AddUtrkaRow(row);
            int count = utrkaBindingSource.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    DataRowView current = (DataRowView)utrkaBindingSource.Current;
                    utrkaBindingSource.MoveNext();
                }
            }
        }

        private void tsbSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv utrke", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbVrsta.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali vrstu sporta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if(cmbStanje.SelectedItem == null)
            //{
            //    MessageBox.Show("Niste odabrali stanje sporta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            else if (dtpStartnoVrijeme.Value == null)
            {
                MessageBox.Show("Niste odabrali stanje sporta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (true)
            {
                DataRowView current = (DataRowView)utrkaBindingSource.Current;
                current.Row["idUtrkaStanje"] = "1";

                utrkaBindingSource.EndEdit();
                utrkaTableAdapter.Update(zavrsniDataSet.Utrka);
            }

        }

        private void dgvUtrka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                TrkaciUtrkaForm forma = new TrkaciUtrkaForm();
             
                forma.IdUtrkas = Convert.ToInt32(dgvUtrka.CurrentRow.Cells[0].Value.ToString());
                forma.lblId.Text = dgvUtrka.CurrentRow.Cells[1].Value.ToString();

                DateTime shp = DateTime.Parse(dgvUtrka.CurrentRow.Cells[3].Value.ToString().ToString());
                forma.lblSvTr.Text = shp.ToString("t");

                DateTime shp2 = DateTime.Parse(dgvUtrka.CurrentRow.Cells[2].Value.ToString().ToString());
                forma.lblDTrk.Text = shp2.ToString("dd.MM.yyyy");
                forma.Show(); 
            }
            else if (e.ColumnIndex == 7)
            {
                PokretanjeUtrkeForm forma = new PokretanjeUtrkeForm();
                forma.IdUtrkas= Convert.ToInt32(dgvUtrka.CurrentRow.Cells[0].Value.ToString());
                forma.lblIme.Text = dgvUtrka.CurrentRow.Cells[1].Value.ToString();

                DateTime shp = DateTime.Parse(dgvUtrka.CurrentRow.Cells[3].Value.ToString().ToString());
                forma.lblStartnoVrijemePOk.Text = shp.ToString("t");

                DateTime shp2 = DateTime.Parse(dgvUtrka.CurrentRow.Cells[2].Value.ToString().ToString());
                forma.lbldatPok.Text = shp2.ToString("dd.MM.yyyy");
                forma.Show();

            }
            else if (e.ColumnIndex == 8)
            {
                ReportForm1 forma = new ReportForm1();
               
                forma.Show();
                
            }

        }

        private void UtrkaForm_KeyDown(object sender, KeyEventArgs e)
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

        private void tsbUredi_Click(object sender, EventArgs e)
        {
            txtNaziv.Enabled = true;
            dtmDatum.Enabled = true;
         
            cmbVrsta.Enabled = true;
            dtpStartnoVrijeme.Enabled = true;
            utrkaTableAdapter.Update(zavrsniDataSet.Utrka);
        }

        
    }
}
