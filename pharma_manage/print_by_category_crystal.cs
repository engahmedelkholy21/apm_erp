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
    public partial class print_by_category_crystal : Form
    {
        public print_by_category_crystal()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void print_by_category_crystal_Load(object sender, EventArgs e)
        {
            products_crystal1.Refresh();
            products_crystal1.SetDataSource(dataSet11);

           
                products_tableTableAdapter1.FillBy_category_and_far3(dataSet11.products_table, textBox1.Text,far3txt.Text);
            
            crystalReportViewer1.RefreshReport();
        }
    }
}
