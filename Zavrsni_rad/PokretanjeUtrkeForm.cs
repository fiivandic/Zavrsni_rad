using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Zavrsni_rad
{
    public partial class PokretanjeUtrkeForm : Form
    {
        private static Stopwatch watch = new Stopwatch();
        private int count;

       
        public PokretanjeUtrkeForm()
        {
            InitializeComponent();
            UpdateTime();
        }

        private void PokretanjeUtrkeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zavrsniDataSet.Utrka' table. You can move, or remove it, as needed.
            this.utrkaTableAdapter.Fill(this.zavrsniDataSet.Utrka);
            // TODO: This line of code loads data into the 'zavrsniDataSet.Osoba' table. You can move, or remove it, as needed.
            this.osobaTableAdapter.Fill(this.zavrsniDataSet.Osoba);
            // TODO: This line of code loads data into the 'zavrsniDataSet.Trkac' table. You can move, or remove it, as needed.
            this.trkacTableAdapter.Fill(this.zavrsniDataSet.Trkac);
            count = int.Parse(trkacTableAdapter.CountTrkaciBezVremena(IdUtrkas).ToString());
           
            if (count == 0)
            {
                

                btStop.Enabled = false;
                btnStart.Enabled = false;
                btnReset.Enabled = false;
            }
            
        }
        private int _idUtrka;
        public int IdUtrkas
        {
            get { return _idUtrka; }
            set { _idUtrka = value; }
            
        }

        private void UpdateTime()
        {
            lblTimer.Text = GetTimeString(watch.Elapsed);

        }

        private string GetTimeString(TimeSpan elapsed)
        {
            string rezultati = string.Empty;
            rezultati = string.Format("{0:00}:{1:00}.{2:000}",
               elapsed.Minutes,
               elapsed.Seconds,
               elapsed.Milliseconds);
            return rezultati;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            
                txtRFID.Focus();
                watch.Start();
                timer1.Enabled = true;

            
           
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

            watch.Reset();
            timer1.Enabled = false;
            UpdateTime();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void trkacBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblBroj.Text = string.Format("Broj trkača: {0}", trkacBindingSource.List.Count);
        }


        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(txtRFID.Text, "[^0-9]"))
            {
                MessageBox.Show("Molim vas unesite samo brojeve od 0 do 9");
                txtRFID.Text = txtRFID.Text.Remove(txtRFID.Text.Length - 1);
            }            
            if (string.IsNullOrEmpty(txtRFID.Text))
            {
            }
            else if (true)
            {
                int rFID = int.Parse(txtRFID.Text);
                string lol = lblTimer.Text;
                trkacTableAdapter.UpdateQuery(lol, rFID);
                trkacTableAdapter.Fill(zavrsniDataSet.Trkac);
            }


            if enter
                piši u bazu
            catch error
                krivi unos
            finally
                clear txt i focus

            if (ima trkaca na utrci bez upisanog vremena)
                zaustavi utrku


            */
        }
        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.trkacBindingSource.Filter = this.adgvTrkaci.FilterString;
        }

        private void adgvTrkaci_SortStringChanged(object sender, EventArgs e)
        {
            this.trkacBindingSource.Sort = this.adgvTrkaci.SortString;
        }

        private void adgvTrkaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                
                DataRowView current = (DataRowView)trkacBindingSource.Current;
                current.Row["Vrijeme"] = "60:00:000";

                trkacTableAdapter.Update(zavrsniDataSet.Trkac);
                trkacTableAdapter.Fill(zavrsniDataSet.Trkac);
                count = count - 1;
                watch.Stop();
            }
        }

        private void txtRFID_KeyDown(object sender, KeyEventArgs e)
        {
            txtRFID.KeyPress += (sndr, ev) =>
            {
                if (ev.KeyChar.Equals((char)13))
                {
                    try
                    {
                        int rFID = int.Parse(txtRFID.Text);
                        string lol = lblTimer.Text;// ov je 
                        trkacTableAdapter.UpdateQuery(lol, rFID);
                        count = count - 1;
                        trkacTableAdapter.Fill(zavrsniDataSet.Trkac);
                        // call your method for action on enter
                        ev.Handled = true; // suppress default handling
                    }
                    catch
                    {
                        
                    }
                    finally
                    {
                        txtRFID.Clear();
                        txtRFID.Focus();
                    }
                    if (count == 0)
                    {
                        watch.Stop();
                        btStop.Enabled = false;
                        btnStart.Enabled = false;
                        btnReset.Enabled = false;
                     
                        DataRowView current = (DataRowView)utrkaBindingSource.Current;
                        current.Row["idUtrkaStanje"] = "3";

                        utrkaBindingSource.EndEdit();
                        utrkaTableAdapter.Update(zavrsniDataSet.Utrka);
                        
                    }
                }
            };
        }
            
        private void PokretanjeUtrkeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            watch.Reset();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            watch.Stop();
        }
    }
}
