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
    public partial class purchases_print : Form
    {
        public purchases_print()
        {
            InitializeComponent();
        }

        private void purchases_print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Purchases_table' table. You can move, or remove it, as needed.
            ReportParameterCollection rep_param = new ReportParameterCollection();
            // TODO: This line of code loads data into the 'DataSet1.sales_table' table. You can move, or remove it, as needed.
            //  this.sales_tableTableAdapter.Fill(this.DataSet1.sales_table);
            if (label1.Text == "fatra")
            {
                Purchases_tableTableAdapter.FillBy_fatra(DataSet1.Purchases_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);

                rep_param.Add(new ReportParameter("ReportParameter1", " المشتريات من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(rep_param);
                this.reportViewer1.RefreshReport();
            }
            else if (label1.Text == "cst")
            {
                Purchases_tableTableAdapter.FillBy_mwared_name_and_fatra(DataSet1.Purchases_table, textBox1.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(),far3txt.Text);

                rep_param.Add(new ReportParameter("ReportParameter1", " مشتريات المورد  " + textBox1.Text + " من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(rep_param);
                this.reportViewer1.RefreshReport();
            }

            else if (label1.Text == "pro")
            {
                Purchases_tableTableAdapter.FillBy_product_name(DataSet1.Purchases_table, textBox1.Text,far3txt.Text);
                rep_param.Add(new ReportParameter("ReportParameter1", " مشتريات منتج " + textBox1.Text));//+ " من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(rep_param);
                this.reportViewer1.RefreshReport();
            }

            //this.reportViewer1.RefreshReport();
        }
    }
}
