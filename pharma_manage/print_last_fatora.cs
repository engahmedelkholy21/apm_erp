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
    public partial class print_last_fatora : Form
    {
        public print_last_fatora()
        {
            InitializeComponent();
        }

        private void print_last_fatora_Load(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter1.FillBy_LAST_FATORA_stock(dataSet11.sales_table, far3txt.Text);

                sales_num.Text = dataSet11.sales_table.Rows[0]["sales_id"].ToString();
                cst_name_txt.Text = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
            }
            catch { }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {


            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text),far3txt.Text);

            ListBox l = new ListBox();
             string ezn_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt").First();

             select_printer s = new select_printer();
             foreach (DataGridViewRow dgr in dataGridView1.Rows)
             {
                 if (ezn_type == "الفئة")
                 {
                     if (s.listBox1.Items.Contains(dgr.Cells[5].Value.ToString()))
                     {
                     }
                     else
                     {
                         s.listBox1.Items.Add(dgr.Cells[5].Value.ToString());
                     }
                 }
                 else if (ezn_type == "الفرع")
                 {
                     if (s.listBox1.Items.Contains(dgr.Cells[6].Value.ToString()))
                     {
                     }
                     else
                     {
                         s.listBox1.Items.Add(dgr.Cells[6].Value.ToString());
                     }
                 }

             }
            l.Items.Remove("0.00");

            foreach (var item in l.Items)
            {
                s.listBox1.Items.Add(item);
            }
            s.type_txt.Text = "بيع";
            s.sales_num.Text = sales_num.Text;
            s.far3txt.Text = far3txt.Text;
            s.cst_name_txt.Text = cst_nameTXT;
            s.nesba_or_not_txt.Text = fatora_type.Text;
            s.ShowDialog();

            //DialogResult re = MessageBox.Show("هل تريد طباعة الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (re == DialogResult.Yes)
            //{

            //    try
            //    {
            //        crystalReport11.Refresh();
            //        crystalReport11.SetDataSource(dataSet11);
            //    }
            //    catch
            //    {

            //        crystalReport11.Refresh();
            //        crystalReport11.SetDataSource(dataSet11);
            //    }
            //    sales_tableTableAdapter1.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(sales_num.Text));


            //    crystalReport11.PrintToPrinter(1, false, 0, 0);



            //    string ppath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Copy of CrystalReport1.rpt";

            //    foreach (var item in l.Items)
            //    {
            //        // MessageBox.Show(item.ToString());
            //        try
            //        {




            //            try
            //            {
            //                copy_of_CrystalReport11.Refresh();
            //                copy_of_CrystalReport11.SetDataSource(dataSet11);
            //            }
            //            catch
            //            {

            //                copy_of_CrystalReport11.Refresh();
            //                copy_of_CrystalReport11.SetDataSource(dataSet11);
            //            }

            //            sales_tableTableAdapter1.FillBy_sales_id_and_dariba(dataSet11.sales_table, Convert.ToInt32(sales_num.Text), Convert.ToDecimal(item.ToString()));//(;.., item.ToString());

            //            copy_of_CrystalReport11.PrintToPrinter(1, false, 0, 0);


            //        }
            //        catch { }
            //    }


            //}


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            print_last_fatora_Load(sender, e);
        }

        string cst_nameTXT="";
         //   s.cst_name_txt.Text = cst_nameTXT.Text;
        private void sales_num_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                dataGridView1.Rows.Clear();
                sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(sales_num.Text),far3txt.Text);
                cst_nameTXT = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
                cst_name_txt.Text = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
                fatora_type.Text = dataSet11.sales_table.Rows[0]["sales_fatora_type"].ToString();
                foreach (DataRow dr in dataSet11.sales_table.Rows)
                {
                    dataGridView1.Rows.Add(dr["sales_product_ID"].ToString(), dr["sales_product_name"].ToString(), dr["sales_product_count"].ToString(), dr["sales_unit_price"].ToString(), dr["sales_price_for_sell"].ToString(), dr["sales_pro_category"].ToString(), dr["sales_pro_stock"].ToString(), dr["sales_dariba"].ToString());
                }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                //decimal sum_dariba = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    // dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                    // sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) + Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);

                }
                textBox1.Text = sum.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                sales_num.Text = (Convert.ToInt32(sales_num.Text) - 1).ToString();
                sales_num.Focus();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sales_num.Text = (Convert.ToInt32(sales_num.Text) + 1).ToString();
                sales_num.Focus();
            }
            catch { }
        }

        private void print_last_fatora_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F12)
                {
                    savebtn_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Right) 
                {
                    button1_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    button2_Click(sender, e);
                }
            }
            catch { }
        }
    }
}
