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
    public partial class outcome_print : Form
    {
        public outcome_print()
        {
            InitializeComponent();
        }

        private void outcome_print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.outcome_table' table. You can move, or remove it, as needed.
            this.outcome_tableTableAdapter.Fill(this.DataSet1.outcome_table);
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            if (dateTimePicker1.Value == dateTimePicker2.Value)
            {
                outcome_tableTableAdapter.FillBy_date(DataSet1.outcome_table, dateTimePicker1.Value.ToShortDateString());
                this.reportViewer1.RefreshReport();
            }
            else if (dateTimePicker1.Value != dateTimePicker2.Value)
            {
                outcome_tableTableAdapter.FillBy_fatra(DataSet1.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                this.reportViewer1.RefreshReport();
            }
           

            this.reportViewer1.RefreshReport();
        }
    }
}
