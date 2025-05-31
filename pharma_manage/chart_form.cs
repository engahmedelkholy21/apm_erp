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
    public partial class chart_form : Form
    {
        public chart_form()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                
                this.chart1.Series["الوارد"].Points.Clear();
                this.chart1.Series["الصادر"].Points.Clear();

                income_tableTableAdapter1.FillBy_date(dataSet11.income_table, dateTimePicker1.Value.ToShortDateString(), far3txt.Text);
                for (DateTime date = dateTimePicker1.Value; date.Date <= dateTimePicker2.Value.Date; date = date.AddDays(1)) 
                {
                    income_tableTableAdapter1.FillBy_date(dataSet11.income_table, date.ToShortDateString(), far3txt.Text);
                    decimal sum = 0;
                    for (int i = 0; i < dataSet11.income_table.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataSet11.income_table.Rows[i]["income_cost"]);
                    }
                    dataGridView1.Rows.Add(date.ToShortDateString(), sum.ToString());
                    //MessageBox.Show(date.ToShortDateString());
                }

                foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                {
                    this.chart1.Series["الوارد"].Points.AddXY(dgr.Cells[0].Value.ToString(),dgr.Cells[1].Value.ToString());
                }

                
              
            }
            catch { }



            //outcome
            try
            {
                outcome_tableTableAdapter1.FillBy_date(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString());
                for (DateTime date = dateTimePicker1.Value; date.Date <= dateTimePicker2.Value.Date; date = date.AddDays(1))
                {
                    outcome_tableTableAdapter1.FillBy_date(dataSet11.outcome_table, date.ToShortDateString());
                    decimal sum = 0;
                    for (int i = 0; i < dataSet11.outcome_table.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataSet11.outcome_table.Rows[i]["outcome_cost"]);
                    }
                    dataGridView2.Rows.Add(date.ToShortDateString(), sum.ToString());
                    //MessageBox.Show(date.ToShortDateString());
                }

                foreach (DataGridViewRow dgr in dataGridView2.Rows) 
                {
                    this.chart1.Series["الصادر"].Points.AddXY(dgr.Cells[0].Value.ToString(),dgr.Cells[1].Value.ToString());
                }
                
               
            }
            catch { }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void chart_form_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }
    }
}
