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
    public partial class madeen_details_print : Form
    {
        public madeen_details_print()
        {
            InitializeComponent();
        }

        private void madeen_details_print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.madeen_table' table. You can move, or remove it, as needed.
            madeen_tableTableAdapter.FillBy_by_madeen(DataSet1.madeen_table,textBox1.Text);
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);

            this.reportViewer1.RefreshReport();
        }
    }
}
