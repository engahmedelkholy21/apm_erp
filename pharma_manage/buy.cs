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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();

            nesba_txt.KeyPress += DigitOnly_KeyPress;
            unit_price_txt.KeyPress += DigitOnly_KeyPress;
            bee3_txt.KeyPress += DigitOnly_KeyPress;
            bee3_gomla_txt.KeyPress += DigitOnly_KeyPress;
            pro_limit_txt.KeyPress += DigitOnly_KeyPress;
            discount_txt.KeyPress += DigitOnly_KeyPress;
            countTXT.KeyPress += DigitOnly_KeyPress;
            madfoo3TXT.KeyPress += DigitOnly_KeyPress;

            product_nameTXT.TextBox_.TextChanged += product_nameTXT_TextChanged;
            product_nameTXT.TextBox_.KeyDown += product_nameTXT_KeyDown;
            product_nameTXT.Listbox_.KeyDown += product_nameTXT_KeyDown;
            product_nameTXT.AttachListBoxToParent(this);
            product_nameTXT.AcceptButton = addbtn;
            product_nameTXT.next_textbox = countTXT;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal sum_keta3 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[5].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

                    sum_keta3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                egmalyTXT.Text = Convert.ToString(sum);
                count_pieces_txt.Text = sum_keta3.ToString();
            }
            catch { }
            try
            {
                if (discount_txt.Text == "")
                {
                    discount_txt.Text = "0";
                    matloobTXT.Text = (Convert.ToDecimal(egmalyTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();
                }
                else
                {
                    matloobTXT.Text = (Convert.ToDecimal(egmalyTXT.Text) - Convert.ToDecimal(discount_txt.Text)).ToString();

                }
            }
            catch { }
        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mwardeenTableAdapter1.FillBy_mwared_name(dataSet11.mwardeen, cst_nameTXT.Text);
                cst_phoneTXT.Text = dataSet11.mwardeen.Rows[0]["mwared_phone"].ToString();
                cst_addressTXT.Text = dataSet11.mwardeen.Rows[0]["mwared_address"].ToString();

                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                if (dataSet11.da2n_small_reports.Rows.Count > 0) 
                {
                    hesab_sabek.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();
                }
                else 
                {
                    hesab_sabek.Text = "0";
                }



            }
            catch { hesab_sabek.Text = "0"; }
        }

        string old_name = "";
        string old_int_code = "";
        int id_for_updating_int_code = 0;
        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = null;
            try
            {
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.TextBox_.Text);
                if (dataSet11.products_table.Rows.Count > 0)
                {
                    unit_price_txt.Text = dataSet11.products_table[0]["pro_cost_price"].ToString();
                    bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    int_code_txt.Text = dataSet11.products_table[0]["pro_int_code"].ToString();
                    category_txt.Text = dataSet11.products_table[0]["pro_category"].ToString();
                    pro_limit_txt.Text = dataSet11.products_table[0]["pro_limit"].ToString();
                    bee3_gomla_txt.Text = dataSet11.products_table[0]["pro_bee3_2"].ToString();
                    old_int_code= dataSet11.products_table[0]["pro_int_code"].ToString();
                    id_for_updating_int_code = Convert.ToInt32(dataSet11.products_table[0]["pro_ID"]);
                }
                
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    unit_price_txt.Text = "";
                    bee3_txt.Text ="";
                    int_code_txt.Text = "";
                   // product_nameTXT.TextBox_.Text = "";
                    category_txt.Text ="";
                    pro_limit_txt.Text = "0";
                        old_int_code="";
                        bee3_gomla_txt.Text = "";
                }

                //pieces_in_packet_txt.Text = dataSet11.products_table[0]["pro_pieces_in_packet"].ToString();
            }
            catch
            {
                label18.Visible = false;
                //label16.Visible = false;
                ////pieces_in_packet_txt.Visible = false;
                stock_txt.Visible = false;
                category_txt.Visible = false;
                label19.Visible = false;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (countTXT.Text == "")
                {
                    MessageBox.Show("أدخل الكمية");
                    countTXT.Select();
                    return;
                }

                if (unit_price_txt.Text == "")
                {
                    MessageBox.Show("أدخل سعر الوحدة");
                    unit_price_txt.Select();
                    return;
                }

                if (Convert.ToDecimal(unit_price_txt.Text) >= Convert.ToDecimal(bee3_txt.Text))
                {
                    MessageBox.Show("تاكد من ان سعر البيع اكبر من سعر الشراء");
                    bee3_txt.Select();
                    return;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == product_nameTXT.TextBox_.Text)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToDecimal(countTXT.Text);
                      //  MessageBox.Show("المنتج موجود بالفعل");
                        product_nameTXT.TextBox_.Clear(); countTXT.Clear(); unit_price_txt.Clear(); bee3_gomla_txt.Clear();
                        product_nameTXT.TextBox_.Focus(); int_code_txt.Clear();
                        product_nameTXT.TextBox_.Select();
                        return;
                    }


                }
               
                categoryTableAdapter.FillBy_name(dataSet11.Category, category_txt.Text);
                if (dataSet11.Category.Rows.Count <= 0)
                {
                    categoryTableAdapter.Insert(category_txt.Text, 0, "", 0);
                }
                category_txt.Items.Clear();
                this.categoryTableAdapter.Fill(this.dataSet11.Category);
                foreach (DataRow dr in dataSet11.Category.Rows)
                {
                    category_txt.Items.Add(dr["Category_name"].ToString());
                }

                if (int_code_txt.Text != old_int_code && old_int_code!="")
                {
                    DialogResult re = MessageBox.Show("الكود مختلف عن الكود القديم لنفس الصنف هل تريد تحديثه ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        products_tableTableAdapter1.Update_int_code_by_id(int_code_txt.Text, id_for_updating_int_code);

                        sales_tableTableAdapter1.Update_pro_id_by_old_id(int_code_txt.Text, product_nameTXT.TextBox_.Text, old_int_code, stock_txt.Text);
                        ma5zoon_movesTableAdapter1.Update_pro_code(int_code_txt.Text, product_nameTXT.TextBox_.Text, old_int_code);
                        purchases_tableTableAdapter1.Update_pro_id(int_code_txt.Text, product_nameTXT.TextBox_.Text, old_int_code, stock_txt.Text);
                        // mortaga3_purchasesTableAdapter1.Update_pro_id(Convert.ToInt32(int_code_txt.Text), name_txt.Text, Convert.ToInt32(old_int_code));
                        sales_mortaga3TableAdapter1.Update_pro_id(int_code_txt.Text, product_nameTXT.TextBox_.Text, old_int_code);
               
                    }
                    else
                    {
                        return;
                    }
                }

                if (int_code_txt.Text != "")
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, int_code_txt.Text, stock_txt.Text);
                    if (dataSet11.products_table.Rows.Count > 0)
                    {
                        string typedName = product_nameTXT.TextBox_.Text.Trim();
                        string existingName = dataSet11.products_table.Rows[0]["pro_name"].ToString().Trim();
                        if (!string.Equals(typedName, existingName, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("هذا الكود موجود مسبقا لصنف " + existingName + " برجاء المراجعة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                try
                {
                    products_tableTableAdapter1.Update_int_code_if_null();
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_nameTXT.TextBox_.Text, stock_txt.Text);
                    if (dataSet11.products_table.Rows.Count <= 0)
                    {
                        products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, int_code_txt.Text, stock_txt.Text);

                    }
                    if (dataSet11.products_table.Rows.Count > 0)
                    {
                        string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                        decimal old_cost = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                        decimal old_bee3 = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                        decimal existing_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                        string avg_or_new = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\avg_or_new.txt").First();

                        if (avg_or_new == "متوسط"&&existing_count>0)
                        {
                            decimal new_cost = Convert.ToDecimal(unit_price_txt.Text);
                            decimal new_count = Convert.ToDecimal(countTXT.Text);

                            decimal avg_unit_price = ((old_cost * existing_count) + (new_cost * new_count)) / (existing_count + new_count);
  
                            products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(avg_unit_price, Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text) * Convert.ToDecimal(1), Convert.ToDecimal(bee3_gomla_txt.Text), product_name);

                            if (old_cost != Convert.ToDecimal(unit_price_txt.Text) || old_bee3 != Convert.ToDecimal(bee3_txt.Text)) 
                            {
                                products_tableTableAdapter1.Update_added_by_pro_name_and_stock("تم تعديل الاسعار بواسطة "+usertxt.Text+" بتاريخ "+dateTimePicker1.Value.ToShortDateString(),product_name,stock_txt.Text);
                            }
                             
                        }
                        else
                        {
                            products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text) * Convert.ToDecimal(1), Convert.ToDecimal(bee3_gomla_txt.Text), product_name);
                            if (old_cost != Convert.ToDecimal(unit_price_txt.Text) || old_bee3 != Convert.ToDecimal(bee3_txt.Text))
                            {
                                products_tableTableAdapter1.Update_added_by_pro_name_and_stock("تم تعديل الاسعار بواسطة " + usertxt.Text + " بتاريخ " + dateTimePicker1.Value.ToShortDateString(), product_name, stock_txt.Text);
                            }
                        }
                        dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), pro_code, product_name, countTXT.Text, unit_price_txt.Text, "", true, countTXT.Text);
                        product_nameTXT.TextBox_.Clear(); countTXT.Clear(); unit_price_txt.Clear(); int_code_txt.Clear();
                        product_nameTXT.TextBox_.Focus();

                        if (dataGridView1.Columns.Count == 8)
                        {
                            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                            btn.Width = 75;
                            btn.Text = "حذف";
                            btn.Name = product_nameTXT.TextBox_.Text;
                            btn.UseColumnTextForButtonValue = true;


                            dataGridView1.Columns.Add(btn);
                        }
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
                    }
                    else
                    {
                        if (Convert.ToDecimal(bee3_txt.Text) < Convert.ToDecimal(unit_price_txt.Text))
                        {
                            MessageBox.Show("ادخل سعر بيع الوحدة");
                            bee3_txt.Select();
                            return;
                        }

                        if (bee3_gomla_txt.Text == "") 
                        {
                            bee3_gomla_txt.Text = bee3_txt.Text;
                        }
                        if (int_code_txt.Text == "")
                        {
                            try
                            {
                                products_tableTableAdapter1.Insert_product(product_nameTXT.TextBox_.Text, category_txt.Text, Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(0), Convert.ToDecimal(pro_limit_txt.Text), dateTimePicker1.Value.ToShortDateString(),
                                 "", "", cst_nameTXT.Text, cst_phoneTXT.Text, usertxt.Text, Convert.ToDecimal(0), stock_txt.Text, Convert.ToDecimal(1), Convert.ToDecimal(0), Convert.ToDecimal(bee3_gomla_txt.Text) * Convert.ToDecimal(1), Convert.ToDecimal(bee3_gomla_txt.Text), "", "تم الجرد",dateTimePicker1.Value.ToShortDateString());

                                products_tableTableAdapter1.Update_int_code_if_null();
                            }
                            catch 
                            {
                                products_tableTableAdapter1.Update_int_code_if_null();
                            }
                            //products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.TextBox_.Text);
                            //int intcode = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"].ToString());
                            //products_tableTableAdapter1.Update_int_code_by_id(intcode.ToString(), intcode);
                        }
                        else
                        {
                            products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, int_code_txt.Text, stock_txt.Text);
                            if (dataSet11.products_table.Rows.Count > 0 && dataSet11.products_table.Rows[0]["pro_name"].ToString() != product_nameTXT.TextBox_.Text)
                            {

                                MessageBox.Show("الكود موجود مسبقا لصنف اخر باسم" + dataSet11.products_table.Rows[0]["pro_name"].ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;

                            }

                            products_tableTableAdapter1.Insert_product(product_nameTXT.TextBox_.Text, category_txt.Text, Convert.ToDecimal(unit_price_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(0), Convert.ToDecimal(pro_limit_txt.Text), dateTimePicker1.Value.ToShortDateString(),
                               "", "", cst_nameTXT.Text, cst_phoneTXT.Text, usertxt.Text, Convert.ToDecimal(0), stock_txt.Text, Convert.ToDecimal(1), Convert.ToDecimal(0), Convert.ToDecimal(bee3_gomla_txt.Text) * Convert.ToDecimal(1), Convert.ToDecimal(bee3_gomla_txt.Text), int_code_txt.Text, "تم الجرد", dateTimePicker1.Value.ToShortDateString());
                            products_tableTableAdapter1.Update_int_code_if_null();

                        }
                        products_tableTableAdapter1.Update_int_code_if_null();
                        products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.TextBox_.Text);
                        string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();

                        dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), pro_code, product_name, countTXT.Text, unit_price_txt.Text, "", true, countTXT.Text);
                        product_nameTXT.TextBox_.Clear(); countTXT.Clear(); unit_price_txt.Clear();
                        product_nameTXT.TextBox_.Focus(); int_code_txt.Clear(); bee3_gomla_txt.Clear();

                        if (dataGridView1.Columns.Count == 8)
                        {
                            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                            btn.Width = 75;
                            btn.Text = "حذف";
                            btn.Name = product_nameTXT.TextBox_.Text;
                            btn.UseColumnTextForButtonValue = true;


                            dataGridView1.Columns.Add(btn);
                        }
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;


                    }
                }
                catch
                {


                }
            }
            catch
            { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            catch { MessageBox.Show("قم بتحديد العنصرالمراد حذفه"); }

        }

        private void check_mwared()
        {
            this.mwardeenTableAdapter1.Fill(this.dataSet11.mwardeen);
            DataTable tbl = (DataTable)dataSet11.mwardeen;

            bool contains = tbl.AsEnumerable()
               .Any(row => cst_nameTXT.Text == row.Field<String>("mwared_name"));

            DataRow[] foundAuthors = tbl.Select("mwared_name = '" + cst_nameTXT.Text + "'");
            if (foundAuthors.Length == 0)
            {
                mwardeenTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, "");
            }

        }
        private void madfoo3TXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = savebtn;
            try
            {
                decimal ba2y = Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text);
                ba2y_txt.Text = ba2y.ToString();
            }
            catch
            {
                ba2y_txt.Text = "0";
            }
        }

        string fatora_id;
        private void save_fatora()
        {
            check_mwared();
            if (madfoo3TXT.Text == "")
            {
                MessageBox.Show("ادخل المبلغ المدفوع");
                madfoo3TXT.Focus();
                return;
            }
            if (salesID_TXT.Text == "")
            {
                MessageBox.Show("ادخل رقم الفاتورة");
                salesID_TXT.Focus();
                return;
            }

            try
            {
                decimal sum = 0;
                decimal sum_keta3 = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    try
                    {
                        dataGridView1.Rows[i].Cells[5].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                        sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

                        sum_keta3 += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    catch 
                    {
                        MessageBox.Show("برجاء مراجعة الصنف " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                       dataGridView1.Rows[i].Selected = true;;
                        return;
                    }
                }
                
            }
            catch 
            {

            }

            fatora_id = salesID_TXT.Text;
            //da2n 
            //  da2n_tableTableAdapter1.Delete_when_ba2y0();
            da2n_small_reportsTableAdapter1.Delete_when0();
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

            try
            {
                //if da2n exist

                if (Convert.ToDecimal(madfoo3TXT.Text) > Convert.ToDecimal(matloobTXT.Text))
                {
                    decimal far2 = Convert.ToDecimal(madfoo3TXT.Text) - Convert.ToDecimal(matloobTXT.Text);

                    string _old_matloob = dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"].ToString();
                    string _old_madfoo3 = dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"].ToString();
                    string _old_ba2y = dataSet11.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();

                    /////////////
                    //////////
                    ////////////
                    string details = "مبلغ تنزيل من الحساب مع فاتورة رقم " + fatora_id;


                    da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                    decimal matloob_before = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                    decimal madfoo3_before = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);
                    decimal ba2y_before = matloob_before - madfoo3_before;





                    decimal matloob_all = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                    decimal madfoo3_all = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]) + far2;
                    decimal ba2y_all = matloob_all - madfoo3_all;






                    //insert madeen details
                    // da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), da2n_nameTXT.Text, details, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                    mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, matloob_all, madfoo3_all, 0, far2, usertxt.Text
                        , ba2y_before, ba2y_all, details, "دائن", 0);


                    //update madeen small report
                    da2n_small_reportsTableAdapter1.Update_madfoo3_by_name(far2, cst_nameTXT.Text);


                    //string outcome_details = "مبلغ من فاتورة شراء رقم " + fatora_id;




                    outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), details, far2, Convert.ToInt32(fatora_id), "دفعات دائنين", cst_nameTXT.Text, usertxt.Text, "", stock_txt.Text);


                    //safe_ upadate
                    safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(far2));

                    //current
                    safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -far2);



                    madfoo3TXT.Text = matloobTXT.Text;



                    /////////////
                    //////////
                    ////////////
                }




                string da2n_byan = "مبلغ فاتورة رقم " + fatora_id;


                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                decimal matloob_before2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                decimal madfoo3_before2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);
                decimal ba2y_before2 = matloob_before2 - madfoo3_before2;





                decimal matloob_all2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]) + Convert.ToDecimal(matloobTXT.Text);
                decimal madfoo3_all2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]) + Convert.ToDecimal(madfoo3TXT.Text);
                decimal ba2y_all2 = matloob_all2 - madfoo3_all2;






                //insert madeen details
                // da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), da2n_nameTXT.Text, details, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, matloob_all2, madfoo3_all2, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text
                    , ba2y_before2, ba2y_all2, da2n_byan, "دائن", Convert.ToInt32(fatora_id));

                //da2n small report update
                da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text), cst_nameTXT.Text);
                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

            }
            catch
            {
                //if da2n doesn't exist
                if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(matloobTXT.Text))
                {
                    //madeen small report
                    da2n_small_reportsTableAdapter1.Insert_da2n(cst_nameTXT.Text, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(madfoo3TXT.Text));

                    //madeen details insert
                    string da2n_byan = "مبلغ من فاتورة شراء رقم " + fatora_id;


                    decimal matloob_before = 0;
                    decimal madfoo3_before = 0;
                    decimal ba2y_before = 0;

                    decimal matloob_all = Convert.ToDecimal(matloobTXT.Text);
                    decimal madfoo3_all = Convert.ToDecimal(madfoo3TXT.Text);
                    decimal ba2y_all = matloob_all - madfoo3_all;

                    //insert most7kat da2neen
                    mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, DateTime.Today, matloob_all, madfoo3_all, matloob_all, Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text
                       , ba2y_before, ba2y_all, da2n_byan, "مدين", Convert.ToInt32(fatora_id));

                }
            }


            //bonus
            //foreach (DataGridViewRow dgr in dataGridView1.Rows)
            //{
            //     products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, Convert.ToInt32(dgr.Cells[1].Value.ToString()));
            //    string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();

            //    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[7].Value), pro_id);
            //}

            //ma5zoon

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dgr.Cells[2].Value.ToString(),stock_txt.Text);
                string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                decimal pro_count_after = pro_count + Convert.ToDecimal(dgr.Cells[3].Value);
                ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(dgr.Cells[3].Value),
                    Convert.ToDecimal(dgr.Cells[5].Value), pro_count, pro_count_after, "شراء", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, stock_txt.Text);
            }

            //products

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                try
                {
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[1].Value.ToString());
                    // MessageBox.Show(dgr.Cells[2].Value.ToString());

                    string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    products_tableTableAdapter1.Update_count_BY_ID_buy(Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[3].Value), pro_id, stock_txt.Text);
                }
                catch
                {
                    // products_tableTableAdapter1.Insert_product(
                }
            }
            //purchases
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                purchases_tableTableAdapter1.Insert_Purchases(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text
                    , Convert.ToDecimal(madfoo3TXT.Text), usertxt.Text, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(),
                    Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), notesTXT.Text, Convert.ToDecimal(discount_txt.Text), stock_txt.Text, Convert.ToDecimal(dgr.Cells[4].Value),0);
            }

            decimal outcome_cost;

            //if (Convert.ToDecimal(madfoo3TXT.Text) > Convert.ToDecimal(matloobTXT.Text))
            //{
            //    outcome_cost = Convert.ToDecimal(matloobTXT.Text);
            //}
            //else
            //{
            outcome_cost = Convert.ToDecimal(madfoo3TXT.Text);
            // }

            string outcome_details = "مبلغ من فاتورة شراء رقم " + salesID_TXT.Text;

            outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), outcome_details, outcome_cost, Convert.ToInt32(salesID_TXT.Text), "شراء", cst_nameTXT.Text, usertxt.Text, notesTXT.Text, stock_txt.Text);


            //safe_ upadate
            safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(madfoo3TXT.Text));

            //current
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -Convert.ToDecimal(madfoo3TXT.Text));


            if (url_txt.Text != "")
            {
                //  MessageBox.Show("aaaa");
                try
                {
                    Form1 f = new Form1();
                    f.upload_file_local(this.Text + salesID_TXT.Text, Path.GetExtension(url_txt.Text), dateTimePicker1.Value, url_txt.Text, usertxt.Text, this.Text, "", stock_txt.Text, "شراء");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            string after_buy = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\after_buy.txt").First();
            if (after_buy == "yes")
            {

                DialogResult re = MessageBox.Show("تم الحفظ بنجاح هل تريد طباعة الباركود", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (re == DialogResult.Yes)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
                //    else { this.Close(); }
                //}
            }
            MessageBox.Show("تم الحفظ بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (type_txt.Text != "تعديل")
            {
                numbers_tableTableAdapter1.Update_purchase_ID(stock_txt.Text);
            }

          
            //add_serial a = new add_serial();
            //a.usertxt.Text = usertxt.Text;
            //a.ShowDialog();


            this.Close();
        }
        //customers
        //-insert or no
       
        
        private void delete_fatora()
        {

            //da2n 
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
            if (dataSet11.da2n_small_reports.Rows.Count > 0)
            {

                mosta7akat_da2neen_tableTableAdapter1.FillBy_NAME_LAST_RECORD(dataSet11.mosta7akat_da2neen_table, cst_nameTXT.Text, Convert.ToInt32(salesID_TXT.Text));
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





            //ma5zoon            //products 

            purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text), stock_txt.Text);
            foreach (DataRow dr in dataSet11.Purchases_table.Rows) 
            {
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dr["Purchases_product_name"].ToString(), stock_txt.Text);

                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dr["Purchases_product_ID"].ToString(), stock_txt.Text);

                }
                if (dataSet11.products_table.Rows.Count > 0)
                {
                    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                    decimal pro_count_after = pro_count - Convert.ToDecimal(dr["Purchases_product_count"]);

                    ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(), dr["Purchases_product_ID"].ToString(), dr["Purchases_product_name"].ToString(), Convert.ToDecimal(dr["Purchases_product_count"]),
                        Convert.ToDecimal(dr["Purchases_product_count"]), pro_count, pro_count_after, "تعديل فاتورة شراء", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, stock_txt.Text);
                }
                // MessageBox.Show(dgr.Cells[1].Value.ToString());

                string pro_id = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                products_tableTableAdapter1.Update_count_BY_ID_bee3(Convert.ToDecimal(dr["Purchases_product_count"]), Convert.ToDecimal(dr["Purchases_product_count"]), pro_id, stock_txt.Text);

            }
           
            //purchases
            purchases_tableTableAdapter1.Delete_by_id(Convert.ToInt32(salesID_TXT.Text));
           


            outcome_tableTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text),stock_txt.Text);



            //safe_ upadate
            safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(madfoo3TXT.Text));

            //current
            safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(madfoo3TXT.Text));

        }


      //  string param;
        private void savebtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                string id = dgr.Cells[2].Value.ToString();
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, id, stock_txt.Text);
                decimal pro_count;
                if (dataSet11.products_table.Count <= 0 || dataSet11.products_table.Rows[0]["pro_int_code"].ToString() != dgr.Cells[1].Value.ToString())
                {
                    MessageBox.Show("بيانات الصنف " + dgr.Cells[2].Value.ToString() + " خاطئة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dgr.Selected = true;
                    return;
                }



            }


            if (type_txt.Text == "تعديل")
            {
                //salesID_TXT.Text = "";
                //salesID_TXT.Enabled = true;
                //salesID_TXT.ReadOnly = false;
                //salesID_TXT.Select();
            }
            else
            {

                try
                {
                    this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, stock_txt.Text);
                    salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["purchases_ID"].ToString();
                }
                catch { }
            }

           
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

            if (type_txt.Text == "تعديل")
            {
                delete_fatora();

                save_fatora();
            }
            else
            {
                if (discount_txt.Text == "")
                {
                    discount_txt.Text = "0";
                }
                save_fatora();
            }

           
        }

        private void buy_Load(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            // TODO: This line of code loads data into the 'dataSet11.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet11.Category);
            foreach (DataRow dr in dataSet11.Category.Rows)
            {
                category_txt.Items.Add(dr["Category_name"].ToString());
            }
            // TODO: This line of code loads data into the 'dataSet11.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
            // TODO: This line of code loads data into the 'dataSet11.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
            dateTimePicker1.Value = DateTime.Today;
            suggest_mwared_name();
            suggest_product();

            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
            label4.Text = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();



            if (type_txt.Text == "تعديل")
            {
                //salesID_TXT.Text = "";
                //salesID_TXT.Enabled = true;
                //salesID_TXT.ReadOnly = false;
                //salesID_TXT.Select();
            }
            else
            {

                try
                {
                    this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, stock_txt.Text);
                    salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["purchases_ID"].ToString();
                }
                catch { }
            }

            //try
            //{
            //    purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text),stock_txt.Text);
            //    if (dataSet11.Purchases_table.Rows.Count > 0)
            //    {
            //        numbers_tableTableAdapter1.Update_purchase_ID(stock_txt.Text);

            //        this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table, stock_txt.Text);
            //        salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["purchases_ID"].ToString();
            //    }
            //}
            //catch { }


            string gomla = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt").First();
            if (gomla == "yes")
            {
                // label24.Text = "";
                label24.Visible = true;
                bee3_gomla_txt.Visible = true;

                //  gomla_checkBox4.Checked = true;
            }
            else
            {
               // label24.Text = "سعر البيع";
                label24.Visible = false;
                bee3_gomla_txt.Visible = false;
                //label20.Visible = false;
                // gomla_checkBox4.Checked = false;
            }
        }

        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            product_nameTXT.SetSuggestions(dataSet11.products_table, "pro_name");

        }
        private void suggest_mwared_name()
        {
            this.mwardeenTableAdapter1.Fill(this.dataSet11.mwardeen);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.mwardeen.Rows)
            {
                DataCollection.Add(dr["mwared_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        decimal oldmdfoo3;
        decimal oldmatloob;

        private void salesID_TXT_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            if (type_txt.Text == "تعديل"&&salesID_TXT.Text!="")
            {

                dataGridView1.Rows.Clear();
              
                purchases_tableTableAdapter1.FillBy_ID(dataSet11.Purchases_table, Convert.ToInt32(salesID_TXT.Text), stock_txt.Text);

                cst_nameTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_name"].ToString();
                cst_phoneTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_phone"].ToString();
                cst_addressTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_mwared_address"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(dataSet11.Purchases_table.Rows[0]["Purchases_date"]);


                madfoo3TXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_madfoo3"].ToString();
                oldmdfoo3 = Convert.ToDecimal(dataSet11.Purchases_table.Rows[0]["Purchases_madfoo3"]);
                //mwazafTXT.Text = dataSet11.Purchases_table.Rows[0]["Purchases_user"].ToString();

                notesTXT.Text = dataSet11.Purchases_table.Rows[0]["sales_notes"].ToString();

                foreach (DataRow dr in dataSet11.Purchases_table.Rows)
                {
                    dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), dr["Purchases_product_ID"].ToString(), dr["Purchases_product_name"].ToString(), dr["Purchases_product_count"].ToString(), dr["Purchases_unit_price"].ToString(), dr["sales_price_for_sell"].ToString(),true, dr["Purchases_product_count"].ToString());
                }

                if (dataGridView1.Columns.Count == 8)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 75;
                    btn.Text = "حذف";
                    btn.Name = product_nameTXT.TextBox_.Text;
                    btn.UseColumnTextForButtonValue = true;


                    dataGridView1.Columns.Add(btn);
                }
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    dataGridView1.Rows[i].Cells[5].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                }

                oldmatloob = sum;
            }
            //}
            //catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void countTXT_Enter(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.TextBox_.Text);
                unit_price_txt.Text = dataSet11.products_table[0]["pro_cost_price"].ToString();
                bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                pro_limit_txt.Text = dataSet11.products_table[0]["pro_limit"].ToString();
                int_code_txt.Text = dataSet11.products_table[0]["pro_int_code"].ToString();
                old_int_code = dataSet11.products_table[0]["pro_int_code"].ToString();
                bee3_gomla_txt.Text = dataSet11.products_table[0]["pro_bee3_2"].ToString();
                id_for_updating_int_code = Convert.ToInt32(dataSet11.products_table[0]["pro_ID"]);
                //bee3_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
                //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table[0]["pro_pieces_in_packet"])).ToString();

            }
            catch
            {
                label18.Visible = true;
                //label16.Visible = true;
                //pieces_in_packet_txt.Visible = true;
                stock_txt.Visible = true;
                category_txt.Visible = true;
                label19.Visible = true;
                pro_limit_txt.Text = "0";
                unit_price_txt.Text = "";
                bee3_txt.Text = "";
                bee3_gomla_txt.Text = "";
                //bee3_txt.Text = "";
                //gmhour_txt.Text = "";

                //pieces_in_packet_txt.Text = "";
                int_code_txt.Text = "";
                category_txt.Text = "";
            }
        }

        private void countTXT_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = addbtn;
            
           
        }

        private void int_code_txt_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, int_code_txt.Text);
            //    unit_price_txt.Text = dataSet11.products_table[0]["pro_cost_price"].ToString();
            //    gomla_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_gomla_gomla"].ToString();
            //    //bee3_txt.Text = dataSet11.products_table[0]["pro_bee3"].ToString();
            //    //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table[0]["pro_pieces_in_packet"])).ToString();
            //    product_nameTXT.TextBox_.Text = dataSet11.products_table[0]["pro_name"].ToString();
            //    //pieces_in_packet_txt.Text = dataSet11.products_table[0]["pro_pieces_in_packet"].ToString();
            //}
            //catch
            //{ }
            ////    //label18.Visible = false;
            ////    //label16.Visible = false;
            ////    ////pieces_in_packet_txt.Visible = false;
            ////    //stock_txt.Visible = false;
            ////    //category_txt.Visible = false;
            ////    //label19.Visible = false;
            ////}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, selectedRow.Cells[2].Value.ToString());
                raseed_now_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                //taklefa_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                //we7dat_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
            }
            catch { }

            try
            {
                if (e.ColumnIndex == 8)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[2].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        private void product_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    this.AcceptButton = null;

                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, product_nameTXT.TextBox_.Text);
                    unit_price_txt.Text = dataSet11.products_table[0]["pro_cost_price"].ToString();
                    bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    int_code_txt.Text = dataSet11.products_table[0]["pro_int_code"].ToString();
                    product_nameTXT.TextBox_.Text = dataSet11.products_table[0]["pro_name"].ToString();
                    category_txt.Text = dataSet11.products_table[0]["pro_category"].ToString();
                    pro_limit_txt.Text = dataSet11.products_table[0]["pro_limit"].ToString();
                    bee3_gomla_txt.Text = dataSet11.products_table[0]["pro_bee3_2"].ToString();

                    countTXT.Focus();
                }
            }
            catch { }       
        }

        private void unit_price_txt_TextChanged(object sender, EventArgs e)
        {
          //  this.AcceptButton = addbtn;
            try
            {
                if (product_nameTXT.TextBox_.Focused == false)
                {
                    if (nesba_txt.Text != "")
                    {
                        decimal nesba_to_add = ((Convert.ToDecimal(nesba_txt.Text) / 100) * Convert.ToDecimal(unit_price_txt.Text)) + Convert.ToDecimal(unit_price_txt.Text);
                        decimal nesba_to_add_gomla = (((Convert.ToDecimal(nesba_txt.Text) / 2) / 100) * Convert.ToDecimal(unit_price_txt.Text)) + Convert.ToDecimal(unit_price_txt.Text);

                        bee3_txt.Text = nesba_to_add.ToString("0.00");
                        if (bee3_gomla_txt.Visible == true)
                        {
                            bee3_gomla_txt.Text = nesba_to_add_gomla.ToString("0.00");
                        }
                    }
                    else { nesba_txt.Text = ""; }
                }
            }
            catch { }
        }

        private void buy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.refresh_categories();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
            string ph_name = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
            print_barcodeTableAdapter1.DeleteQuery();
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(dgr.Cells[6].Value) == true)
                {
                    string name = dgr.Cells[2].Value.ToString();
                    products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dgr.Cells[1].Value.ToString());
                    decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3"]);
                    int count = Convert.ToInt32(dgr.Cells[7].Value);
                    string pro_code = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    for (int i = 1; i <= count; i++)
                    {
                        print_barcodeTableAdapter1.Insert("*" + pro_code + "*", name, price, ph_name);
                    }
                }
            }

            string barcode_yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt").First();
            string param = barcode_yes_or_no;
            

            this.print_barcodeTableAdapter1.Fill(this.dataSet11.print_barcode);
            if (dataSet11.print_barcode.Rows.Count > 0)
            {
                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt");
                string printer_name = srr.ReadLine();
                

                string barcode_bc__yes_or_no = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt").First();
               
                string barcode_type = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt").First();
                string decimals = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals").First();
          
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

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cst_nameTXT_Leave(object sender, EventArgs e)
        {
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
            if (dataSet11.da2n_small_reports.Rows.Count > 0)
            {
                hesab_sabek.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();
            }
            else
            {
                hesab_sabek.Text = "0";
            }
        }

        private void int_code_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.AcceptButton = null;

                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, int_code_txt.Text);
                if (product_nameTXT.TextBox_.Text != "")
                {
                    string typedName = product_nameTXT.TextBox_.Text.Trim();
                    string existingName = dataSet11.products_table.Rows[0]["pro_name"].ToString().Trim();
                    if (!string.Equals(existingName, typedName, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("هذا الكود موجود لصنف اخر  باسم " + existingName, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void nesba_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (product_nameTXT.TextBox_.Focused == false)
                {
                    if (nesba_txt.Text != "")
                    {
                        decimal nesba_to_add = ((Convert.ToDecimal(nesba_txt.Text) / 100) * Convert.ToDecimal(unit_price_txt.Text)) + Convert.ToDecimal(unit_price_txt.Text);
                        decimal nesba_to_add_gomla = (((Convert.ToDecimal(nesba_txt.Text) / 2) / 100) * Convert.ToDecimal(unit_price_txt.Text)) + Convert.ToDecimal(unit_price_txt.Text);

                        bee3_txt.Text = nesba_to_add.ToString("0.00");
                        if (bee3_gomla_txt.Visible == true)
                        {
                            bee3_gomla_txt.Text = nesba_to_add_gomla.ToString("0.00");
                        }
                    }
                    else { nesba_txt.Text = "0"; }
                }
            }
            catch { }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 7 )
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    // Attach an event handler to the TextBox.KeyPress event
                    textBox.KeyPress += new KeyPressEventHandler(DigitOnly_KeyPress);
                }
            }
        }
        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Ignore additional decimal points
            }
        }

        private void bee3_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Supported Files (*.pdf;*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.pdf;*.png;*.jpg;*.jpeg;*.gif;*.bmp|PDF Files (*.pdf)|*.pdf|Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Check if it's a PDF file
                    //if (Path.GetExtension(filePath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                    //{
                    //webBrowser1.Url = new Uri(openFileDialog.FileName);
                    //webBrowser1.ScrollBarsEnabled = true;
                    //webBrowser1.ScriptErrorsSuppressed = true;
                    //webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;

                    url_txt.Text = openFileDialog.FileName;
                    // }
                }
                else
                {
                    url_txt.Text = "";
                }
            }
        }


    }
}

