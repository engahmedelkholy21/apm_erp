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
    public partial class tawreedat_fatora : Form
    {
        public tawreedat_fatora()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void mas7obat_fatora_Load(object sender, EventArgs e)
        {
            try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table,stock_txt.Text);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["tawreedat_ID"].ToString();
            }
            catch { }

            suggest_product();
            this.categoryTableAdapter1.Fill(this.dataSet11.Category);
            foreach (DataRow dr in dataSet11.Category.Rows)
            {
                category_txt.Items.Add(dr["Category_name"].ToString());
            }
        }

        

        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;

            stock_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            stock_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollection_stock = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
                DataCollection_stock.Add(dr["pro_stock"].ToString());
               // category_txt.Items.Add(dr["materials_category"].ToString());
            }

            this.mo3adalat_tasnee3_tableTableAdapter1.Fill(this.dataSet11.mo3adalat_tasnee3_table);
            product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
            {
                DataCollection.Add(dr["mo3adalat_tasnee3_pro_name"].ToString());
            }

            product_nameTXT.AutoCompleteCustomSource = DataCollection;
            stock_txt.AutoCompleteCustomSource = DataCollection_stock;

            this.employee_tableTableAdapter1.Fill(this.dataSet11.employee_table);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.employee_table.Rows)
            {
                DataCollection2.Add(dr["employee_name"].ToString());
                // category_txt.Items.Add(dr["materials_category"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection2;

        }

        string pro_id = "";
        decimal pro_count = 0;

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void check_pro(string pro_name) 
        {
            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name,stock_txt.Text);
            if (dataSet11.products_table.Rows.Count <= 0)
            {
                if (bee3_txt.Text == "")
                {
                    MessageBox.Show("ادخل سعر البيع");
                    bee3_txt.Select();
                    return;
                } if (Convert.ToDecimal(bee3_txt.Text) == 0 || Convert.ToDecimal(bee3_txt.Text) <= Convert.ToDecimal(cost_txt.Text))
                {
                    MessageBox.Show("تأكد من سعر البيع");
                    bee3_txt.Select();
                    return;
                }

                string int_code_;
                if (code_txt.Text == "")
                {
                    int_code_ = "";
                }
                else 
                {
                    int_code_ = code_txt.Text;
                }
                products_tableTableAdapter1.Insert_product(pro_name,category_txt.Text, Convert.ToDecimal(cost_txt.Text), Convert.ToDecimal(bee3_txt.Text),0,0,DateTime.Today.ToShortDateString()
                    , "", "", "", "", user_txt.Text, 0, stock_txt.Text, 1, 0, Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(bee3_txt.Text), int_code_, "تم الجرد", dateTimePicker1.Value.ToShortDateString());
                if (int_code_ == "") 
                {
                    // products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text,stock_txt.Text);
                    products_tableTableAdapter1.FillBy_last_id(dataSet11.products_table);
                    int intcode = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"].ToString());
                    //   MessageBox.Show(intcode.ToString());
                    products_tableTableAdapter1.Update_int_code_by_id(intcode.ToString(), intcode);
                }

                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name, stock_txt.Text);
                pro_id = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
            }
            else 
            {
                if (Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]) == 0 || dataSet11.products_table.Rows[0]["pro_bee3"].ToString() == "")
                {

                    int pro_id = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"]);
                    string pro_name_ = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(Convert.ToDecimal(cost_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(bee3_txt.Text), pro_name_);

                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name, stock_txt.Text);
                    pro_id = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"]);
                    pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();

                }
                else 
                {
                    pro_id = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                }
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (stock_txt.Text == "")
                {
                    MessageBox.Show("ادخل الفرع");
                    stock_txt.Select();
                    return;
                }
                check_pro(product_nameTXT.Text);
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text)
                    {
                        MessageBox.Show("الصنف موجود بالفعل");
                        product_nameTXT.Select();
                        return;
                    }
                }

                if (countTXT.Text == "")
                {
                    MessageBox.Show("أدخل الكمية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    countTXT.Select();
                    return;
                }
                if (bee3_txt.Text == "")
                {
                    MessageBox.Show("ادخل سعر البيع","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    bee3_txt.Select();
                    return;
                } if (Convert.ToDecimal(bee3_txt.Text) == 0 || Convert.ToDecimal(bee3_txt.Text) <= Convert.ToDecimal(cost_txt.Text))
                {
                    MessageBox.Show("تأكد من سعر البيع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bee3_txt.Select();
                    return;
                }

                //if (Convert.ToDecimal(countTXT.Text) > pro_count)
                //{
                //    MessageBox.Show("الكمية غير متاحة في مخزن الخامات");
                //    countTXT.Select();
                //    return;
                //}
                 products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text,stock_txt.Text);
                 int id= Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"]);
                 products_tableTableAdapter1.Update_cost_price_5_by_id(Convert.ToDecimal(cost_txt.Text), id);
                    dataGridView1.Rows.Add(pro_id.ToString(), product_nameTXT.Text, countTXT.Text);


                    product_nameTXT.Clear(); countTXT.Clear(); cost_txt.Clear(); bee3_txt.Clear(); expected_count_txt.Clear(); code_txt.Clear();
                    category_txt.ResetText();
                    product_nameTXT.Focus();

                
               




                if (dataGridView1.Columns.Count == 3)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 75;
                    btn.Text = "حذف";
                    btn.DefaultCellStyle.BackColor = Color.Red;
                    btn.Name = "الحذف";
                    btn.UseColumnTextForButtonValue = true;


                    dataGridView1.Columns.Add(btn);
                }
            }
            catch
            {

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, selectedRow.Cells[1].Value.ToString(),stock_txt.Text);

                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
            }
            catch { }

            try
            {
                if (e.ColumnIndex == 3)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[1].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (stock_txt.Text == "")
            {
                MessageBox.Show("ادخل الفرع");
                stock_txt.Select();
                return;
            }
            try 
            {

                int fatora_no;
                fatora_no = Convert.ToInt32(salesID_TXT.Text);
                //update materials

                //insert ma5zoon
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    //insert ma5zoon
                    products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(dgr.Cells[0].Value));
                    decimal count_before = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal current_count = Convert.ToDecimal(dgr.Cells[2].Value);
                    decimal count_after = count_before +current_count;

                    ma5zoon_movesTableAdapter1.Insert(dateTimePicker1.Value, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString(), current_count,
                        0, 0, count_before, count_after, "توريد من الانتاج", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, user_txt.Text, stock_txt.Text);

                     //insert mas7obat
                    tawreedat_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, cst_nameTXT.Text, dgr.Cells[0].Value.ToString(), dgr.Cells[1].Value.ToString()
                        , Convert.ToDecimal(dgr.Cells[2].Value), "", amr_sho3l_txt.Text, user_txt.Text,stock_txt.Text);

                   
                    // update materials
                    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[2].Value), Convert.ToDecimal(dgr.Cells[2].Value), dgr.Cells[0].Value.ToString(),stock_txt.Text);
                }

                DialogResult d = MessageBox.Show("تم الحفظ بنجاح هل تريد طباعة الفاتورة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (d == DialogResult.Yes)
                {

                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    string printer_name = srr.ReadLine();

                    string param;
                    string address_param = "فاتورة توريدات";

                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                   try
                    {

                        tawreedat_report1.Refresh();
                        tawreedat_report1.SetDataSource(dataSet11);


                        // MessageBox.Show(param);
                        tawreedat_report1.SetParameterValue("test", param);

                        tawreedat_report1.SetParameterValue("address_param", address_param);

                     
                       tawreedat_tableTableAdapter1.FillBy_tawreedat_no(dataSet11.tawreedat_table, fatora_no);
                        tawreedat_report1.PrintOptions.PrinterName = printer_name;
                        tawreedat_report1.PrintToPrinter(1, false, 0, 0);
                        tawreedat_report1.Dispose();
                        tawreedat_report1.Close();
                        tawreedat_report1.Refresh();


                    }
                    catch
                    { }
                }
               

                //update numbers
                numbers_tableTableAdapter1.Update_tawreedat_ID(stock_txt.Text);

                dataGridView1.Rows.Clear();
                cst_nameTXT.Clear();
                cost_txt.Clear();

                mas7obat_fatora_Load(sender, e);
            }
            catch { }
        }

        private void bee3_txt_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
        }

        private void countTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
            try
            {
            if (countTXT.Focused == true)
            {
                product_nameTXT_TextChanged(sender, e);
                decimal halek_cost = (Convert.ToDecimal(expected_count_txt.Text) - Convert.ToDecimal(countTXT.Text)) * cost_already;
                //MessageBox.Show(expected_count_txt.Text);
               // MessageBox.Show((Convert.ToDecimal(expected_count_txt.Text) - Convert.ToDecimal(countTXT.Text)).ToString());
                //MessageBox.Show(count_already.ToString());
                //MessageBox.Show(cost_already.ToString());
                //MessageBox.Show(halek_cost.ToString());
                decimal new_cost = (halek_cost / Convert.ToDecimal(countTXT.Text)) + Convert.ToDecimal(cost_txt.Text);
                cost_txt.Text = new_cost.ToString("0.00");
            }
            }
            catch { }
        }

        decimal cost_already;
        decimal count_already;
        private void amr_sho3l_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void product_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                try
                {
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.Text, stock_txt.Text);
                    if (dataSet11.products_table.Rows.Count <= 0)
                    {
                        products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_nameTXT.Text, stock_txt.Text);
                    }
                    pro_id = dataSet11.products_table.Rows[0]["pro_ID"].ToString();

                    pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    if (dataSet11.products_table.Rows[0]["pro_bee3"].ToString() == "0")
                    {
                        bee3_txt.Text = "";
                    }
                    else
                    {
                        bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    }
                    product_nameTXT.Text = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    cost_already = Convert.ToDecimal(cost_txt.Text);
                    countTXT.Focus();
                    this.AcceptButton = addbtn;
                }
                catch
                {
                    pro_id = "";
                    pro_count = 0;
                    bee3_txt.Text = "";
                    code_txt.Text = "";
                    category_txt.ResetText();
                    product_nameTXT.Text = "";
                    // unit_price_txt.Text = "";
                    raseed_now_txt.Text = "";
                    //cost_already = null;
                    //limit_txt.Text = "";
                }
            }
        }

        private void amr_sho3l_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                //try
                //{
                
                    amr_tableTableAdapter1.FillBy_amr_num(dataSet11.amr_table, Convert.ToInt32(amr_sho3l_txt.Text));
                    if (dataSet11.amr_table.Rows.Count > 0)
                    {
                        product_nameTXT.Text = dataSet11.amr_table.Rows[0]["amr_pro_name"].ToString();
                        countTXT.Text = dataSet11.amr_table.Rows[0]["amr_amount"].ToString();
                        expected_count_txt.Text = dataSet11.amr_table.Rows[0]["amr_amount"].ToString();
                        count_already = Convert.ToDecimal(dataSet11.amr_table.Rows[0]["amr_amount"].ToString());

                        amr_material_tableTableAdapter1.FillBy_TOTAL_COST_by_amr_num(dataSet11.amr_material_table, Convert.ToInt32(amr_sho3l_txt.Text));
                        decimal cost_material = Convert.ToDecimal(dataSet11.amr_material_table.Rows[0]["TOTAL_COST"]) / Convert.ToDecimal(countTXT.Text);
                        cost_txt.Text = cost_material.ToString();

                        check_pro(product_nameTXT.Text);
                        cost_already = Convert.ToDecimal(cost_txt.Text);
                    }
                    else
                    {
                        product_nameTXT.Text = "";// dataSet11.amr_table.Rows[0]["amr_pro_name"].ToString();
                        countTXT.Text = "";//dataSet11.amr_table.Rows[0]["amr_amount"].ToString();
                        expected_count_txt.Text = "";// dataSet11.amr_table.Rows[0]["amr_amount"].ToString();
                        //  count_already = Convert.ToDecimal(dataSet11.amr_table.Rows[0]["amr_amount"].ToString());
                        ////  check_pro(product_nameTXT.Text);
                        //  cost_already = Convert.ToDecimal(cost_txt.Text);
                    }
                //}
                //catch { }
            }
        }

        
    }
}
