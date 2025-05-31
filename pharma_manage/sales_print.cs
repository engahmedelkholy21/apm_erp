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
    public partial class sales_print : Form
    {
        public sales_print()
        {
            InitializeComponent();
        }

        private void sales_print_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rep_param = new ReportParameterCollection();
            // TODO: This line of code loads data into the 'DataSet1.sales_table' table. You can move, or remove it, as needed.
          //  this.sales_tableTableAdapter.Fill(this.DataSet1.sales_table);
            if (label1.Text == "fatra")
            {
                sales_tableTableAdapter.FillBy_Fatra(DataSet1.sales_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);

                rep_param.Add(new ReportParameter("ReportParameter1", " المبيعات من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(rep_param);
                this.reportViewer1.RefreshReport();
            }
          else  if (label1.Text == "cst")
            {
                sales_tableTableAdapter.FillBy_Cst_Name_IN_fatra(DataSet1.sales_table, textBox1.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);
   
                rep_param.Add(new ReportParameter("ReportParameter1", " مبيعات "+textBox1.Text+" من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(rep_param);
                this.reportViewer1.RefreshReport();
            }

            else if (label1.Text == "pro")
            {
                sales_tableTableAdapter.FillBy_Product_Name_IN_fatra(DataSet1.sales_table, textBox1.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3txt.Text);
                rep_param.Add(new ReportParameter("ReportParameter1", " مبيعات منتج " + textBox1.Text ));//+ " من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(rep_param);
                this.reportViewer1.RefreshReport();
            }

            
           // this.Hide();
           // this.reportViewer1.PrintDialog();
            
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.PrintDialog();
        }
    }
}
