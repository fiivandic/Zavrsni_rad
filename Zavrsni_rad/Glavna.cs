using System;
using System.Windows.Forms;

namespace Zavrsni_rad
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnOsoba_Click(object sender, EventArgs e)
        {
            var forma = new Osoba();
            forma.ShowDialog();
           
        }

        private void btnUtrka_Click(object sender, EventArgs e)
        {

            var forma = new UtrkaForm();
            forma.ShowDialog();
            
        }

        private void Glavna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyValue == 49)
            {
                btnOsoba_Click(sender, null);
            }
            else if (e.Control == true && e.KeyValue == 50)
            {
               btnUtrka_Click(sender, null);
            }
        }

       
    }
}
