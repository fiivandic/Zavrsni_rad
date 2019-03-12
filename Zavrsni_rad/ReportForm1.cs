using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_rad
{
    public partial class ReportForm1 : Form
    {
        public ReportForm1()
        {
            InitializeComponent();
        }

        private void ReportForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ZavrsniDataSet.Trkac' table. You can move, or remove it, as needed.
            this.TrkacTableAdapter.Fill(this.ZavrsniDataSet.Trkac);
            // TODO: This line of code loads data into the 'ZavrsniDataSet.Osoba' table. You can move, or remove it, as needed.
            this.OsobaTableAdapter.Fill(this.ZavrsniDataSet.Osoba);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
