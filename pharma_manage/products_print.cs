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
    public partial class products_print : Form
    {
        public products_print()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);


            this.stock_tableTableAdapter1.Fill(this.dataSet11.stock_table);
            foreach (DataRow dr in dataSet11.stock_table.Rows)
            {
                if (froo3_txt.Items.Contains(dr["stock_name"].ToString()))
                {
                }
                else
                {
                    froo3_txt.Items.Add(dr["stock_name"].ToString());
                }
            }
        }

        private void products_print_Load(object sender, EventArgs e)
        {
           


            
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            print_all_products_crystal p = new print_all_products_crystal();
            p.far3txt.Text = froo3_txt.Text;
            p.ShowDialog();
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            froo3_txt.Text = froo3_txt.Text;
            products_print_Shown(sender, e);
        }

        private void products_print_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'DataSet1.pharmacy_data' table. You can move, or remove it, as needed.
            this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);
            // TODO: This line of code loads data into the 'DataSet1.products_table' table. You can move, or remove it, as needed.
          this.products_tableTableAdapter.Fill(this.DataSet1.products_table);
           
            

            this.reportViewer1.RefreshReport();
            //this.reportViewer1.
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer3.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            products_tableTableAdapter1.FillBy_stock(dataSet11.products_table, froo3_txt.Text);


            products_crystal_taklefa_bee31.Refresh();
            products_crystal_taklefa_bee31.SetDataSource(dataSet11);


           

            crystalReportViewer1.RefreshReport();
        }
    }
}
