using System;
using System.Windows.Forms;

namespace pharma_manage
{
    public partial class products_print2 : Form
    {
        public products_print2()
        {
            InitializeComponent();

            // Apply styling and subscribe to load event
            var f1 = new Form1();
            f1.ApplyFormStyling(this);
            f1.SubscribeToLoadEvent(this);
        }

        // Ensure this method name matches what SubscribeToLoadEvent expects
        public void products_print2_Load(object sender, EventArgs e)
        {
            // Maximize the window
            this.WindowState = FormWindowState.Maximized;

            // Load data into DataSet
            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
          

            // ReportViewer setup
           

            // Crystal Report setup
            products_crystal_taklefa_bee31.SetDataSource(dataSet11);
            products_crystal_taklefa_bee31.Refresh();

            // Fill products table based on the branch text
            products_tableTableAdapter1.FillBy_stock(dataSet11.products_table, far3txt.Text);

            crystalReportViewer1.RefreshReport();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var p = new print_all_products_crystal
            {
                far3txt = { Text = far3txt.Text }
            };
            p.ShowDialog();
        }
    }
}
