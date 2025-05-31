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
    public partial class most7kat_mas2ooleen : Form
    {
        public most7kat_mas2ooleen()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void most7kat_mas2ooleen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mosta7akat_mas2oleen_table' table. You can move, or remove it, as needed.
          //  this.mosta7akat_mas2oleen_tableTableAdapter.Fill(this.dataSet1.mosta7akat_mas2oleen_table);
            cst_name_txt_TextChanged(sender, e);
        }

        private void cst_name_txt_TextChanged(object sender, EventArgs e)
        {
            mosta7akat_mas2oleen_tableTableAdapter.FillBy_mas2ool_name_fatra(dataSet1.mosta7akat_mas2oleen_table, cst_name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            try
            {
                dataGridView4.Rows[dataGridView4.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;

                string x = dataGridView4.Rows[dataGridView4.Rows.Count - 1].Cells[7].Value.ToString();

                dataGridView4.Rows.Add("", "", "", x);
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cst_name_txt_TextChanged(sender, e);
        }
    }
}
