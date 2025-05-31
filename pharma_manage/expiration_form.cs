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
    public partial class expiration_form : Form
    {
        public expiration_form()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void expiration_form_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            products_tableTableAdapter.FillBy_expiration_fatra(dataSet1.products_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            products_tableTableAdapter.FillBy_expiration_fatra(dataSet1.products_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
        
        }
    }
}
