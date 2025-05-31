using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharma_manage
{
    public partial class da2n_print : Form
    {
        public da2n_print()
        {
            InitializeComponent();
        }

        private void da2n_print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.da2n_small_reports' table. You can move, or remove it, as needed.
            this.da2n_small_reportsTableAdapter.Fill(this.DataSet1.da2n_small_reports);
            this.reportViewer1.RefreshReport();

        }
    }
}
