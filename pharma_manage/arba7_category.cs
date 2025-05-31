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
    public partial class arba7_category : Form
    {
        public arba7_category()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void arba7_category_Load(object sender, EventArgs e)
        {
            this.stock_tableTableAdapter1.Fill(this.dataSet1.stock_table);
            foreach (DataRow dr in dataSet1.stock_table.Rows)
            {
                if (far3_txt.Items.Contains(dr["stock_name"].ToString()))
                { }
                else
                {
                    far3_txt.Items.Add(dr["stock_name"].ToString());
                }
            }

            // TODO: This line of code loads data into the 'dataSet1.arba7_cat_table' table. You can move, or remove it, as needed.
            this.arba7_cat_tableTableAdapter.Fill(this.dataSet1.arba7_cat_table);

            foreach (DataRow dr in dataSet1.arba7_cat_table.Rows) 
            {
                if (category_txt.Items.Contains(dr["arba7_cat_category"].ToString()))
                {
                }
                else 
                {
                    category_txt.Items.Add(dr["arba7_cat_category"].ToString());
                }
            }

        }

        private void category_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category_txt.Text == "")
            {
                arba7_cat_tableTableAdapter.FillBy_fatra_stock(dataSet1.arba7_cat_table, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(),far3_txt.Text);
         
            }
            else
            {
                arba7_cat_tableTableAdapter.FillBy_fatra_and_category_stock(dataSet1.arba7_cat_table, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), category_txt.Text,far3_txt.Text);
            }
        }

        private void category_txt_TextChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            category_txt_SelectedIndexChanged(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                textBox1.Text = sum.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                string param;
                string address;
                address = "تقرير الارباح للفئات في الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);
                try
                {

                    arba7_cat_report1.Refresh();
                    arba7_cat_report1.SetDataSource(dataSet1);


                    // MessageBox.Show(param);
                    arba7_cat_report1.SetParameterValue("test", param);
                    arba7_cat_report1.SetParameterValue("address", address);

                    // sales_tableTableAdapter1.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(sales_num.Text));
                    dateTimePicker1_ValueChanged(sender, e);

                    arba7_cat_report1.PrintOptions.PrinterName = printer_name;
                    arba7_cat_report1.PrintToPrinter(1, false, 0, 0);
                    arba7_cat_report1.Dispose();



                }
                catch { }
        }
    }
}
