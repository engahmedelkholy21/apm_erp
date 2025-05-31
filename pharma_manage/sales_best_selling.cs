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
    public partial class sales_best_selling : Form
    {
        public sales_best_selling()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void sales_best_selling_Load(object sender, EventArgs e)
        {
            sales_table_most_selling_TableAdapter.Fill(dataSet1.sales_table_most_selling, "1-1-1900",DateTime.Today.ToShortDateString(), far3_txt.Text);

            decimal sum_count = 0;
            decimal sum_money = 0;

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                sum_count += Convert.ToDecimal(dgr.Cells[2].Value);
                sum_money += Convert.ToDecimal(dgr.Cells[3].Value);
            }
            sum_count_txt.Text = sum_count.ToString("0.00");
            sum_money_txt.Text = sum_money.ToString("0.00");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sales_table_most_selling_TableAdapter.Fill(dataSet1.sales_table_most_selling, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            decimal sum_count = 0;
            decimal sum_money = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                sum_count += Convert.ToDecimal(dgr.Cells[2].Value);
                sum_money += Convert.ToDecimal(dgr.Cells[3].Value);
            }
            sum_count_txt.Text = sum_count.ToString("0.00");
            sum_money_txt.Text = sum_money.ToString("0.00");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }
    }
}
