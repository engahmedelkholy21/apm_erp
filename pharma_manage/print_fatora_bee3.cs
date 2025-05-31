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
    public partial class print_fatora_bee3 : Form
    {
        public print_fatora_bee3()
        {
            InitializeComponent();
        }

        private void print_fatora_bee3_Load(object sender, EventArgs e)
        {
            ReportParameterCollection rep_param = new ReportParameterCollection();
            
                rep_param.Add(new ReportParameter("ReportParameter1", textBox2.Text));
                this.reportViewer1.LocalReport.SetParameters(rep_param);

            // TODO: This line of code loads data into the 'DataSet1.sales_table' table. You can move, or remove it, as needed.
             //   sales_tableTableAdapter.FillBy_ID(DataSet1.sales_table, Convert.ToInt32(textBox1.Text), far3_txt.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
