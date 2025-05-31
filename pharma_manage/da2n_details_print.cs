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
    public partial class da2n_details_print : Form
    {
        public da2n_details_print()
        {
            InitializeComponent();
        }

        private void da2n_details_print_Load(object sender, EventArgs e)
        {
            this.da2n_tableTableAdapter.FillBy_name(this.DataSet1.da2n_table, textBox1.Text);

            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);

        }
    }
}
