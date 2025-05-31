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
    public partial class barcode_form : Form
    {
        public barcode_form()
        {
            InitializeComponent();
        }

        private void barcode_form_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dataSet11.stock_table' table. You can move, or remove it, as needed.


                this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
                foreach (DataRow dr in dataSet11.stock_table.Rows)
                {
                    stock_txt.Items.Add(dr["stock_name"].ToString());
                }
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                label1.Text = dataSet1.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
                // TODO: This line of code loads data into the 'dataSet1.print_barcode' table. You can move, or remove it, as needed.
                this.print_barcodeTableAdapter1.Fill(this.dataSet1.print_barcode);
                dataGridView1.Rows.Clear();
                this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
                foreach (DataRow dr in dataSet11.products_table.Rows)
                {
                    dataGridView1.Rows.Add(dr["pro_int_code"].ToString(), dr["pro_name"].ToString(), "", dr["pro_count"].ToString(), dr["pro_stock"].ToString(), dr["pro_category"].ToString());
                }
                suggest_product();
            }
            catch { }
        }


        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet1.products_table);
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());


            }

            textBox1.AutoCompleteCustomSource = DataCollection;

        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string pro_id = selectedRow.Cells[0].Value.ToString();
                string pro_name = selectedRow.Cells[1].Value.ToString();
                string count = selectedRow.Cells[2].Value.ToString();
                if (dataGridView2.Rows.Contains(selectedRow))
                {
                    //dataGridView2.Rows.Remove(selectedRow);
                    //dataGridView2.Rows.Add(pro_id, pro_name, count);
                }
                else
                {
                    dataGridView2.Rows.Add(pro_id, pro_name, count);
                    textBox1.Select();
                }
            }
            catch { }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    dr.Selected = false;
                }

                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    if (dr.Cells[0].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
                        dr.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[2];
                        dataGridView1.BeginEdit(true);

                    }
                    else if (dr.Cells[1].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
                        dr.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
                        dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[2];
                        dataGridView1.BeginEdit(true);

                    }
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.BeginEdit(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            stock_txt.Items.Clear();

            barcode_form_Load(sender, e);
        }

        private void stock_txt_TextChanged(object sender, EventArgs e)
        {
            stock_txt.Items.Clear();

            barcode_form_Load(sender, e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            print_barcodeTableAdapter1.DeleteQuery();
            foreach (DataGridViewRow dgr in dataGridView2.Rows)
            {
                //try
                //   {
                if (dgr.Cells[2].Value.ToString() != "")
                {


                    string name = dgr.Cells[1].Value.ToString();
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[0].Value.ToString());
                    decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                    int count = Convert.ToInt32(dgr.Cells[2].Value);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    for (int i = 1; i <= count; i++)
                    {
                        string code = "*" + pro_code + "*"; ;
                        //if (pro_code.Length > 7)
                        //{
                        //    code = code = pro_code;
                        //}
                        print_barcodeTableAdapter1.Insert(code, name, price, label1.Text);
                    }

                }
            }

            string barcode_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt").First();
            string param = barcode_yes_or_no;
            string barcode_bc__yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt").First();
            string param2 = barcode_bc__yes_or_no;

            //settings_form cc = new settings_form();
            //cc.colors_form_Load(sender, e);
          
           
            //if (cc.checkBox1.Checked == true)
            //{

            //    param = "yes";
            //}
            //else
            //{
            //    param = "no";
            //}

            //if (cc.checkBox2.Checked == true)
            //{

            //    param2 = "yes";
            //}
            //else
            //{
            //    param2 = "no";
            //}



            //  MessageBox.Show(cc.checkBox1.CheckState.ToString());

            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt");
            string printer_name = srr.ReadLine();


            this.print_barcodeTableAdapter1.Fill(this.dataSet11.print_barcode);
            string barcode_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt").First();
            string decimals = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals").First();

            if (barcode_type == "عادي")
            {

                crystalReport21.SetDataSource(dataSet11);
                crystalReport21.Refresh();
                crystalReport21.SetParameterValue("price_yes_or_no", param);
                crystalReport21.SetParameterValue("price_bc_color", param2);
                crystalReport21.SetParameterValue("decimals", decimals);

                crystalReport21.PrintOptions.PrinterName = printer_name;
                crystalReport21.PrintToPrinter(1, false, 0, 0);
                crystalReport21.Dispose();
                crystalReport21.Close();
                crystalReport21.Refresh();
            }
            else if (barcode_type == "مقسوم")
            {

                crystalReport2_small1.SetDataSource(dataSet11);
                crystalReport2_small1.Refresh();
                crystalReport2_small1.SetParameterValue("price_yes_or_no", param);
                crystalReport2_small1.SetParameterValue("price_bc_color", param2);
                crystalReport2_small1.SetParameterValue("decimals", decimals);
                crystalReport2_small1.PrintOptions.PrinterName = printer_name;
                crystalReport2_small1.PrintToPrinter(1, false, 0, 0);
                crystalReport2_small1.Dispose();
                crystalReport2_small1.Close();
                crystalReport2_small1.Refresh();
            }
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                dgr.Cells[2].Value = "";

            }


            dataGridView2.Rows.Clear();

            //this.Close();
            //crystal_report_form s = new crystal_report_form();
            //s.ShowDialog();
            //print_barcode p = new print_barcode();
            //p.ShowDialog();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
