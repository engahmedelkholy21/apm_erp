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
    public partial class print_barcode : Form
    {
        public print_barcode()
        {
            InitializeComponent();
        }

        private void print_barcode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.print_barcode' table. You can move, or remove it, as needed.
            this.print_barcodeTableAdapter.Fill(this.DataSet1.print_barcode);

            this.reportViewer1.RefreshReport();
        }
    }
}
