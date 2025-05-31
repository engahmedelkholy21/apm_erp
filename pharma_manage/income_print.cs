using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace pharma_manage
{
    public partial class income_print : Form
    {
        public income_print()
        {
            InitializeComponent();
        }

        private void income_print_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rep_param = new ReportParameterCollection();
            if (textBox1.Text != "")
            {
                rep_param.Add(new ReportParameter("ReportParameter1", "كشف حساب " + textBox1.Text + " في الفتره من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
            }
            else { rep_param.Add(new ReportParameter("ReportParameter1", "الوارد للخزينه في الفتره من "+dateTimePicker1.Value.ToShortDateString()+" إلى "+dateTimePicker2.Value.ToShortDateString())); }
            this.reportViewer1.LocalReport.SetParameters(rep_param);

            // TODO: This line of code loads data into the 'DataSet1.income_table' table. You can move, or remove it, as needed.
           // this.income_tableTableAdapter.Fill(this.dataSet11.income_table);
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            if (textBox1.Text == "")
            {
                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    income_tableTableAdapter.FillBy_date(DataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), far3_txt.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    income_tableTableAdapter.FillBy_fatra(DataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else 
            {
                income_tableTableAdapter.FillBy_esm_elmashroo3_in_fatra(DataSet1.income_table, textBox1.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
                this.reportViewer1.RefreshReport();
            }
            //this.pharmacy_dataTableAdapter.Fill(this.dataSet11.pharmacy_data);

           // this.reportViewer1.RefreshReport();
        }
    }
}
