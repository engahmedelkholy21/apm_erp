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
    public partial class mas7obat_syana : Form
    {
        public mas7obat_syana()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void suggest_cst_name()
        {
            this.outcome_tableTableAdapter.FillBy_mas7obat_syana(this.dataSet1.outcome_table);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.outcome_table.Rows)
            {
                DataCollection.Add(dr["outcome_esm_elmashroo3"].ToString());
            }


            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        private void mas7obat_syana_Load(object sender, EventArgs e)
        {
            suggest_cst_name();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try 
            {
                outcome_tableTableAdapter.FillBy_esm_elmashroo3_in_fatra_mas7obat_syana(dataSet1.outcome_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                syana_tableTableAdapter.FillBy_deliver_fatra(dataSet1.syana_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
              
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                }
                mas7obat_total_txt.Text = sum.ToString();



                decimal sum_syana = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum_syana += Convert.ToDecimal(dataGridView2.Rows[i].Cells[4].Value);

                }
                syana_total_txt.Text = sum_syana.ToString();


                ba2y_txt.Text = (Convert.ToDecimal(syana_total_txt.Text) - Convert.ToDecimal(mas7obat_total_txt.Text)).ToString();
                // MessageBox.Show(sum.ToString());
            }
            catch { }
        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged( sender,  e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }
    }
}
