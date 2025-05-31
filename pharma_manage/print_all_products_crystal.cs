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
    public partial class print_all_products_crystal : Form
    {
        public print_all_products_crystal()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void print_all_products_crystal_Load(object sender, EventArgs e)
        {
            products_crystal_for_all_including_zero1.Refresh();
            products_crystal_for_all_including_zero1.SetDataSource(dataSet11);


            products_tableTableAdapter1.FillBy_stock(dataSet11.products_table,far3txt.Text);

            crystalReportViewer1.RefreshReport();


            products_crystal_for_all_without_zero1.Refresh();
            products_crystal_for_all_without_zero1.SetDataSource(dataSet12);


            products_tableTableAdapter1.FillBy_stock(dataSet12.products_table, far3txt.Text);

            crystalReportViewer2.RefreshReport();


            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
