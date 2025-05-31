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
    public partial class arba7_report : Form
    {
        public arba7_report()
        {
            InitializeComponent();
        }

        private void arba7_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.arba7_table' table. You can move, or remove it, as needed.
            this.arba7_tableTableAdapter.Fill(this.DataSet1.arba7_table);
            if (dateTimePicker1.Value == dateTimePicker2.Value)
            {
                arba7_tableTableAdapter.FillBy_date_stock(DataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(),far3txt.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                arba7_tableTableAdapter.FillBy_fatra_stock(DataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);
                this.reportViewer1.RefreshReport();

            }
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);

            this.reportViewer1.RefreshReport();
        }
    }
}
