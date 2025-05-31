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
    public partial class madeen_print_2 : Form
    {
        public madeen_print_2()
        {
            InitializeComponent();
        }

        private void madeen_print_2_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(dataSet1.customers);
            madeen_small_reportTableAdapter.Fill(dataSet1.madeen_small_report);
            crystalReportViewer1.ReportSource = madeen_list_report1;
            crystalReportViewer1.Refresh();


            madeen_list_report1.SetDataSource(dataSet1);
            madeen_list_report1.Refresh();
            //  crystalReportViewer1.Zoom(50);
          
        }
    }
}
