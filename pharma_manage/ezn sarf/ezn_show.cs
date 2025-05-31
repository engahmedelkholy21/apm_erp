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
    public partial class ezn_show : Form
    {
        public ezn_show()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void ezn_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ezn_sarf' table. You can move, or remove it, as needed.
            this.ezn_sarfTableAdapter.Fill(this.dataSet1.ezn_sarf);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ezn_sarfTableAdapter.FillBy_fatra(dataSet1.ezn_sarf, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
             dateTimePicker1_ValueChanged(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                decimal sum = 0;

                foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                {
                    sum += Convert.ToDecimal(dgr.Cells[2].Value);
                }
                total_txt.Text = sum.ToString();
            }
            catch { }
        }
    }
}
