using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace pharma_manage
{
    public partial class barcode_form_single : Form
    {
        public barcode_form_single()
        {
            InitializeComponent();
        }

        private void barcode_form_single_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dataSet11.stock_table' table. You can move, or remove it, as needed.


                //this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
                //foreach (DataRow dr in dataSet11.stock_table.Rows)
                //{
                //    stock_txt.Items.Add(dr["stock_name"].ToString());
                //}
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                label1.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
                // TODO: This line of code loads data into the 'dataSet1.print_barcode' table. You can move, or remove it, as needed.
                //this.print_barcodeTableAdapter1.Fill(this.dataSet1.print_barcode);
                //dataGridView1.Rows.Clear();
                //this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
                //foreach (DataRow dr in dataSet11.products_table.Rows)
                //{
                //    dataGridView1.Rows.Add(dr["pro_int_code"].ToString(), dr["pro_name"].ToString(), "", dr["pro_count"].ToString(), dr["pro_stock"].ToString(), dr["pro_category"].ToString());
                //}
                //suggest_product();
            }
            catch { }
        }


        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet1.products_table);
            pro_code_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            pro_code_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());


            }

            pro_code_txt.AutoCompleteCustomSource = DataCollection;

        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    foreach (DataGridViewRow dr in dataGridView1.Rows)
            //    {
            //        dr.Selected = false;
            //    }

            //    foreach (DataGridViewRow dr in dataGridView1.Rows)
            //    {
            //        if (dr.Cells[0].Value.ToString() == textBox1.Text)
            //        {
            //            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            //            dr.Selected = true;
            //            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
            //            dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[2];
            //            dataGridView1.BeginEdit(true);

            //        }
            //        else if (dr.Cells[1].Value.ToString() == textBox1.Text)
            //        {
            //            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            //            dr.Selected = true;
            //            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
            //            dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[2];
            //            dataGridView1.BeginEdit(true);

            //        }
            //    }
            //}
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //   dataGridView1.BeginEdit(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateStockItems()
        {
            // Clear and update stock items without reloading the form
            stock_txt.Items.Clear();

            try
            {
                // Reload data into the stock items
                this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
                foreach (DataRow dr in dataSet11.stock_table.Rows)
                {
                    stock_txt.Items.Add(dr["stock_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("An error occurred while updating stock items: " + ex.Message);
            }
        }
        private void stock_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (stock_txt.Focused)
            {
                UpdateStockItems();
            }
        }

        private void stock_txt_TextChanged(object sender, EventArgs e)
        {
            if (stock_txt.Focused)
            {
                UpdateStockItems();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Clear previous barcode entries
                print_barcodeTableAdapter1.DeleteQuery();

                // Retrieve product details
                string name = pro_name_txt.Text;
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, pro_code_txt.Text);
                decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                int count = Convert.ToInt32(count_txt.Text);
                string pro_code = dataSet11.products_table.Rows[0]["pro_ID"].ToString();

                // Insert new barcode records
                for (int i = 1; i <= count; i++)
                {
                    string code = "*" + pro_code + "*";
                    print_barcodeTableAdapter1.Insert(code, name, price, label1.Text);
                }

                // Load settings from external files
                string barcode_yes_or_no = File.ReadLines(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "price.txt")).First();
                string barcode_bc_yes_or_no = File.ReadLines(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "barcode_bc.txt")).First();
                string printer_name = File.ReadLines(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "barcode.txt")).First();
                string barcode_type = File.ReadLines(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "barcode_type.txt")).First();
                string decimals = File.ReadLines(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "decimals")).First();

                // Load the dataset to print barcodes
                this.print_barcodeTableAdapter1.Fill(this.dataSet11.print_barcode);

                if (barcode_type == "عادي")
                {
                    // Set parameters for the first report
                    crystalReport21.SetDataSource(dataSet11);
                    crystalReport21.SetParameterValue("price_yes_or_no", barcode_yes_or_no);
                    crystalReport21.SetParameterValue("price_bc_color", barcode_bc_yes_or_no);
                    crystalReport21.SetParameterValue("decimals", decimals);

                    // Configure printer and print the report
                    crystalReport21.PrintOptions.PrinterName = printer_name;
                    crystalReport21.PrintToPrinter(1, false, 0, 0);
                    crystalReport21.Dispose();
                    crystalReport21.Close();
                }
                else if (barcode_type == "مقسوم")
                {
                    // Set parameters for the second report
                    crystalReport2_small1.SetDataSource(dataSet11);
                    crystalReport2_small1.SetParameterValue("price_yes_or_no", barcode_yes_or_no);
                    crystalReport2_small1.SetParameterValue("price_bc_color", barcode_bc_yes_or_no);
                    crystalReport2_small1.SetParameterValue("decimals", decimals);

                    // Configure printer and print the report
                    crystalReport2_small1.PrintOptions.PrinterName = printer_name;
                    crystalReport2_small1.PrintToPrinter(1, false, 0, 0);
                    crystalReport2_small1.Dispose();
                    crystalReport2_small1.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("An error occurred: " + e.Error.Message);
            }
            else
            {
                // Only close if a certain condition is met
                // Example condition (modify as needed):

                this.Close();
            }
        }

    }
}
