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
    public partial class purchases_fatora : Form
    {
        public purchases_fatora()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void purchases_fatora_Load(object sender, EventArgs e)
        {
            try
            {
                purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text),far3txt.Text);

                cst_nameTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_name"].ToString();
                cst_phoneTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_phone"].ToString();
                cst_addressTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_address"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(dataSet11.Purchases_table.Rows[0]["Purchases_date"]);


                madfoo3TXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_madfoo3"].ToString();

                mwazafTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_user"].ToString();

                notesTXT.Text = dataSet11.Purchases_table.Rows[0]["sales_notes"].ToString();

                discount_txt.Text = dataSet11.Purchases_table.Rows[0]["bounce"].ToString();
                foreach (DataRow dr in dataSet11.Purchases_table.Rows)
                {
                    dataGridView1.Rows.Add(dr["Purchases_product_ID"].ToString(), dr["Purchases_product_name"].ToString(), dr["Purchases_product_count"].ToString(), dr["Purchases_unit_price"].ToString(), dr["sales_price_for_sell"].ToString(), true,Convert.ToInt32(dr["Purchases_product_count"]).ToString());
                }


                //decimal sum = 0;
                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                //    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                //}

                //egmaly_elfatoraTXT.Text = Convert.ToString(sum);

                //try
                //{
                //    safy_txt.Text = (Convert.ToDecimal(egmaly_elfatoraTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();
                //}
                //catch
                //{
                //    discount_txt.Text = "0";
                //    safy_txt.Text = (Convert.ToDecimal(egmaly_elfatoraTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();

                //}

                try
                {
                    mosta7akat_da2neen_tableTableAdapter1.FillBy_NAME_only_LAST_RECORD(dataSet11.mosta7akat_da2neen_table, cst_nameTXT.Text);
                    decimal matloob_in_fatora_old = Convert.ToDecimal(dataSet11.mosta7akat_da2neen_table.Rows[0]["matloob_fatora"]);
                    decimal madfoo3_in_fatora_old = Convert.ToDecimal(dataSet11.mosta7akat_da2neen_table.Rows[0]["mosta7akat_da2neen_dof3ah_amount"]);
                    int fatora_num = Convert.ToInt32(dataSet11.mosta7akat_da2neen_table.Rows[0]["fatora_number"]);
                   // MessageBox.Show(matloob_in_fatora_old.ToString()+"  "+ madfoo3_in_fatora_old.ToString());
                   // if (matloob_in_fatora_old != Convert.ToDecimal(safy_txt.Text))// || madfoo3_in_fatora_old != Convert.ToDecimal(madfoo3TXT.Text))
                    if (fatora_num != Convert.ToInt32(salesID_TXT.Text))
                    {
                        button2.Visible = false;
                    }
                }
                catch { }


                
            }
            catch
            {
                this.Hide();
                MessageBox.Show("تأكد من رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);

                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }

            egmaly_elfatoraTXT.Text = Convert.ToString(sum);

            try 
            {
                safy_txt.Text = (Convert.ToDecimal(egmaly_elfatoraTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();
            }
            catch 
            {
                discount_txt.Text = "0";
                safy_txt.Text = (Convert.ToDecimal(egmaly_elfatoraTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();
         
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                delete_fatora();
                MessageBox.Show("تم الحذف بنجاح ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void delete_fatora()
        {
            
                //da2n 
            //da2n 
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
            if (dataSet11.da2n_small_reports.Rows.Count > 0)
            {

                mosta7akat_da2neen_tableTableAdapter1.FillBy_NAME_LAST_RECORD(dataSet11.mosta7akat_da2neen_table, cst_nameTXT.Text,Convert.ToInt32(salesID_TXT.Text));
                decimal matloob_in_fatora_old = Convert.ToDecimal(dataSet11.mosta7akat_da2neen_table.Rows[0]["matloob_fatora"]);
                decimal madfoo3_in_fatora_old = Convert.ToDecimal(dataSet11.mosta7akat_da2neen_table.Rows[0]["mosta7akat_da2neen_dof3ah_amount"]);

                try
                {
                    //if madeen exist

                    //madeen small report update
                    da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(-matloob_in_fatora_old, -madfoo3_in_fatora_old, cst_nameTXT.Text);

                }
                catch { }
                mosta7akat_da2neen_tableTableAdapter1.Delete_by_cst_name_and_fatora_num(cst_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text));
            }





                //ma5zoon


              //  ma5zoon_movesTableAdapter1.Delete_by_fatora_ID(Convert.ToInt32(salesID_TXT.Text));


                //ma5zoon

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[1].Value.ToString(), far3txt.Text);
                    if (dataSet11.products_table.Rows.Count <= 0)
                    {
                        products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dgr.Cells[0].Value.ToString(), far3txt.Text);
                    
                    }
                    if (dataSet11.products_table.Rows.Count > 0)
                    {
                        string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                        decimal pro_count_after = pro_count - Convert.ToDecimal(dgr.Cells[2].Value);

                        ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                            Convert.ToDecimal(dgr.Cells[4].Value), pro_count, pro_count_after, "حذف فاتورة شراء", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, far3txt.Text);
                    }
                }


                //products

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    try
                    {
                        products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(dgr.Cells[0].Value.ToString()));
                        // MessageBox.Show(dgr.Cells[1].Value.ToString());

                        string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), pro_id,far3txt.Text);
                   
                    }
                    catch
                    {
                        // products_tableTableAdapter1.Insert_product(
                    }
                }
                //purchases
                purchases_tableTableAdapter1.Delete_by_id(Convert.ToInt32(salesID_TXT.Text));
                //foreach (DataGridViewRow dgr in dataGridView1.Rows)
                //{
                //    purchases_tableTableAdapter1.Insert_Purchases(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
                //        , Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(),
                //        Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[3].Value), notesTXT.Text, Convert.ToDecimal(0));
                //}



                outcome_tableTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text),far3txt.Text);



                //safe_ upadate
                safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(madfoo3TXT.Text));

                //current
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(madfoo3TXT.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                string ph_name = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
                print_barcodeTableAdapter1.DeleteQuery();
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    //try
                    //{
                        if (Convert.ToBoolean(dgr.Cells[5].Value) == true)
                        {
                            string name = dgr.Cells[1].Value.ToString();
                            products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[0].Value.ToString());
                            decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                           // MessageBox.Show(name);
                            int count = Convert.ToInt32(dgr.Cells[6].Value);
                            string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                            for (int i = 1; i <= count; i++)
                            {
                                print_barcodeTableAdapter1.Insert("*" + pro_code + "*", name, price, ph_name);
                            }
                        }
                    //}
                    //catch { }
                }




                string barcode_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt").First();
                string param = barcode_yes_or_no;
                string barcode_bc__yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt").First();
              


                string decimals = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals").First();
          
                this.print_barcodeTableAdapter1.Fill(this.dataSet11.print_barcode);
                if (dataSet11.print_barcode.Rows.Count > 0)
                {
                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt");
                    string printer_name = srr.ReadLine();


                   // string barcode_bc__yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt").First();

                    string barcode_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt").First();
                    if (barcode_type == "عادي")
                    {

                        crystalReport21.SetDataSource(dataSet11);
                        crystalReport21.Refresh();
                        crystalReport21.SetParameterValue("price_yes_or_no", param);
                        crystalReport21.SetParameterValue("price_bc_color", barcode_bc__yes_or_no);
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
                        crystalReport2_small1.SetParameterValue("decimals", decimals);
                        crystalReport2_small1.SetParameterValue("price_bc_color", barcode_bc__yes_or_no);
                        crystalReport2_small1.PrintOptions.PrinterName = printer_name;
                        crystalReport2_small1.PrintToPrinter(1, false, 0, 0);
                        crystalReport2_small1.Dispose();
                        crystalReport2_small1.Close();
                        crystalReport2_small1.Refresh();
                    }

                }
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                if (Convert.ToBoolean(selectedRow.Cells[5].Value) == true)
                {
                    selectedRow.Cells[5].Value = true;
                }
                else 
                {
                    selectedRow.Cells[5].Value = false;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string buy_type_txt = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt").First();
            if (buy_type_txt == "نسبة")
            {
                buy_nesba b = new buy_nesba();
                b.Text = "تعديل فاتورة شراء";
                b.stock_txt.Text = far3txt.Text;
                b.type_txt.Text = "تعديل";
                b.usertxt.Text = usertxt.Text;
                b.salesID_TXT.Text = salesID_TXT.Text;

                b.ShowDialog();

                purchases_fatora_Load(sender, e);
            }
            else
            {

                buy b = new buy();
                b.Text = "تعديل فاتورة شراء";
                b.stock_txt.Text = far3txt.Text;
                b.type_txt.Text = "تعديل";
                b.usertxt.Text = usertxt.Text;
                b.salesID_TXT.Text = salesID_TXT.Text;
                b.ShowDialog();
                purchases_fatora_Load(sender, e);
            }
        }
        
        
    }
}
