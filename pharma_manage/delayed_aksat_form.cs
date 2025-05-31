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
    public partial class delayed_aksat_form : Form
    {
        public delayed_aksat_form()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
           
        }

        private void delayed_aksat_form_Load(object sender, EventArgs e)
        {

            if (this.Text.Contains("متأخرة"))
            {
                delayed_aksatTableAdapter.Fill_by_fatra_not_paid(dataSet1.delayed_aksat, Convert.ToDateTime("1-1-1900").ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);

                try
                {
                    decimal sum = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[4].Value);
                    }
                    textBox1.Text = sum.ToString("0.00");
                }
                catch { }
            }
            else
            {
                delayed_aksatTableAdapter.Fill_by_fatra_paid(dataSet1.delayed_aksat, Convert.ToDateTime("1-1-1900").ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);

                try
                {
                    decimal sum = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[4].Value);
                    }
                    textBox1.Text = sum.ToString("0.00");
                }
                catch { }

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("متأخرة"))
            {
                delayed_aksatTableAdapter.Fill_by_fatra_not_paid(dataSet1.delayed_aksat, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);

                try
                {
                    decimal sum = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[4].Value);
                    }
                    textBox1.Text = sum.ToString("0.00");
                    count_txt.Text = dataGridView1.Rows.Count.ToString();
                }
                catch { }
            }
            else
            {
                delayed_aksatTableAdapter.Fill_by_fatra_paid(dataSet1.delayed_aksat, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);

                try
                {
                    decimal sum = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[4].Value);
                    }
                    textBox1.Text = sum.ToString("0.00");
                    count_txt.Text = dataGridView1.Rows.Count.ToString();
                }
                catch { }

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("متأخرة"))
            {
                delayed_aksatTableAdapter.Fill_by_fatra_not_paid(dataSet1.delayed_aksat, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);

                try
                {
                    decimal sum = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[4].Value);
                    }
                    textBox1.Text = sum.ToString("0.00");
                    count_txt.Text = dataGridView1.Rows.Count.ToString();
                }
                catch { }
            }
            else
            {
                delayed_aksatTableAdapter.Fill_by_fatra_paid(dataSet1.delayed_aksat, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);

                try
                {
                    decimal sum = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum += Convert.ToDecimal(dgr.Cells[4].Value);
                    }
                    textBox1.Text = sum.ToString("0.00");
                    count_txt.Text = dataGridView1.Rows.Count.ToString();
                }
                catch { }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.Text.Contains("متأخرة"))
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string tamweel = selectedRow.Cells[7].Value.ToString();
                    string far3 = selectedRow.Cells[8].Value.ToString();
                    pay_kest p = new pay_kest();
                    p.user_txt.Text = user_txt.Text;
                    p.substringAutoCompleteTextBox1.TextBox_.Text = tamweel;
                    p.far3_txt.Text = far3;
                    Form1 f = new Form1();
                    f.SubscribeToLoadEvent(p);
                    f.ApplyFormStyling(p);
                    p.ShowDialog();
                    dateTimePicker1_ValueChanged(sender, e);
                }
            }
            catch { }
        }
    }
}
