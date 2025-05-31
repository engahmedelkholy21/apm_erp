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
    public partial class cards_form : Form
    {
        public cards_form()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void cards_form_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(dataSet11.customers);
            //madeen_small_reportTableAdapter.Fill(dataSet1.madeen_small_report);
            crystalReportViewer1.ReportSource = cards_report1;
            crystalReportViewer1.Refresh();


            cards_report1.SetDataSource(dataSet11);
            cards_report1.Refresh();
        }
    }
}
