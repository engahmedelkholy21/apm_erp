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
    public partial class ta2feel_arba7 : Form
    {
        public ta2feel_arba7()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void ta2feel_arba7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.profit_shares_table' table. You can move, or remove it, as needed.
            this.profit_shares_tableTableAdapter.FillBy_worked_and_summary(this.dataSet1.profit_shares_table);
            // TODO: This line of code loads data into the 'dataSet1.partners_share_table' table. You can move, or remove it, as needed.
          //  this.partners_share_tableTableAdapter.Fill(this.dataSet1.partners_share_table);\


            decimal sum = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows) 
            {
                if (dgr.Cells[2].Value.ToString() == "")
                {
                    dgr.DefaultCellStyle.BackColor = Color.Green;
                    dgr.DefaultCellStyle.ForeColor = Color.White;
                    sum += Convert.ToDecimal(dgr.Cells[6].Value);
                } 
            }
            total_txt.Text = sum.ToString();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //  //  decimal total_shares = 0;
            //   // partners_share_tableTableAdapter.FillBy_between_start_and_end_date(dataSet1.partners_share_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            //    decimal sum = 0;


            //    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //    {
            //        sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
            //    }
            //  //  total_shares = sum;

            //  //  MessageBox.Show( total_shares.ToString());
            //    arba7_tableTableAdapter1.FillBy_TOTAL_ARBA7_FATRA_FAR3(dataSet1.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

            //    decimal total_arba7 = Convert.ToDecimal(dataSet1.arba7_table.Rows[0]["TOTAL_ARBA7"]);
            //    MessageBox.Show(total_arba7.ToString() + "   " + total_shares.ToString());
            //}
            //catch { }
        }
    }
}
