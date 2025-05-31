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
    public partial class halek_show : Form
    {
        public halek_show()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void halek_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.halek_table' table. You can move, or remove it, as needed.
            this.halek_tableTableAdapter.Fill(this.dataSet1.halek_table);
            suggest_product();
            name_txt_TextChanged(sender, e);
        }

        private void suggest_product()
        {
            this.halek_tableTableAdapter.Fill(this.dataSet1.halek_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.halek_table.Rows)
            {
                DataCollection.Add(dr["halek_material_name"].ToString());
               
            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                foreach(DataGridViewRow dgr in dataGridView1.Rows)
                {
                    sum += Convert.ToDecimal(dgr.Cells[4].Value);
                }
                textBox1.Text = sum.ToString();
            } catch { }
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (name_txt.Text == "")
                {
                    halek_tableTableAdapter.FillBy_fatra_far3(dataSet1.halek_table,dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), stock_txt.Text);
                
                }
                else 
                {
                    halek_tableTableAdapter.FillBy_name_in_fatra_far3(dataSet1.halek_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), stock_txt.Text);
                
                }
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }
    }
}
