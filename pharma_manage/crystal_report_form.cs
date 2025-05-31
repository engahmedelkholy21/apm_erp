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
    public partial class crystal_report_form : Form
    {
        public crystal_report_form()
        {
            InitializeComponent();
        }

        private void crystal_report_form_Load(object sender, EventArgs e)
        {
            this.print_barcodeTableAdapter1.Fill(this.dataSet11.print_barcode);
            CrystalReport22.SetDataSource(dataSet11);
            CrystalReport22.Refresh();
           
            
        }

       
    }
}
