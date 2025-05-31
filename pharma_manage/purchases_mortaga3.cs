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
    public partial class purchases_mortaga3 : Form
    {
        public purchases_mortaga3()
        {
            InitializeComponent();
        }

        private void product_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table,product_nameTXT.Text);
                if (dataSet11.products_table.Rows.Count <= 0) 
                {
                    products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
                }
                if (dataSet11.products_table.Rows.Count > 0)
                {
                    unit_price_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    raseed_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                }
                else
                {
                    unit_price_txt.Text = "";
                    raseed_txt.Text = "";
                }
               
                this.AcceptButton = addbtn;
            }
            catch { }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            save_mortaga3();
        }
        private void save_mortaga3()
        {


            //da2n 
            da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

            try
            {
                //if da2n exist


                //if el ba2y akbar mn el madfoo3
                //if (old_7esab >= Convert.ToDecimal(matloobTXT.Text))
                //{



                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                decimal matloob_before2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                decimal madfoo3_before2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);
                decimal ba2y_before2 = matloob_before2 - madfoo3_before2;





                decimal matloob_all2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);// +Convert.ToDecimal(matloobTXT.Text);
                decimal madfoo3_all2 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]) + Convert.ToDecimal(matloobTXT.Text);
                decimal ba2y_all2 = matloob_all2 - madfoo3_all2;


                string da2n_byan;
                int fatora_ID;
                if (salesID_TXT.Text != "")
                {
                    da2n_byan = "مبلغ ناتج عن عملية مرتجع شراء رقم  " + salesID_TXT.Text;
                    fatora_ID = Convert.ToInt32(salesID_TXT.Text);
                }
                else
                {
                    da2n_byan = "مبلغ ناتج عن عملية مرتجع شراء بتاريخ     " + dateTimePicker1.Value.ToShortDateString();
                    fatora_ID = 0;
                }





                //insert madeen details
               
                mosta7akat_da2neen_tableTableAdapter1.Insert(cst_nameTXT.Text, dateTimePicker1.Value, matloob_all2, madfoo3_all2, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(matloobTXT.Text), usertxt.Text
                    , ba2y_before2, ba2y_all2, da2n_byan, "دائن", Convert.ToInt32(fatora_ID));


                //da2n small report update
                da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);
                da2n_small_reportsTableAdapter1.FillBy_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                decimal new_matloob = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                decimal new_madfoo3 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);


                //madeen details insert

              
                da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, da2n_byan, Convert.ToDecimal(matloobTXT.Text), Convert.ToDecimal(matloobTXT.Text), notesTXT.Text, usertxt.Text, new_matloob, new_madfoo3, fatora_ID);


                //madeen details update matlob and madfo93
                da2n_tableTableAdapter1.Update_matloob_AND_madfoo3_By_da2n_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);

                //////}
                //////else
                //////{
                //////    madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);
                //////    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(0, Convert.ToDecimal(matloobTXT.Text), cst_nameTXT.Text);

                //////    madeen_small_reportTableAdapter1.Delete_when0();
                //////    madeen_tableTableAdapter1.Delete_when0();
                //////    DialogResult re = MessageBox.Show("المبلغ المستحق على المدين أفل من قيمة المرتجع. هل تريد دفع باقي المبلغ الان ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ////    //if (re == DialogResult.Yes)
                ////    //{


                ////    //    decimal far2 = Convert.ToDecimal(matloobTXT.Text) - old_7esab;



                ////////////////////////////////**
                ////        //insert outcome
                ////       income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), da2n_byan,Convert.ToDecimal(matloobTXT.Text), fator_ID, "مرتجع شراء", "", usertxt.Text, notesTXT.Text);

                ////        //safe insert daily
                ////       safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(matloobTXT.Text));


                ////        //safe update current
                ////       safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(matloobTXT.Text));

                ////    //else
                ////    //{
                ////    //    //اضافة مدين هنا
                ////    //}
            }

            catch
            {
                //if madeen doesn't exist
                string da2n_byan;
                int fatora_ID;
                if (salesID_TXT.Text != "")
                {
                    da2n_byan = "مبلغ ناتج عن عملية مرتجع شراء لفاتورة رقم  " + salesID_TXT.Text;
                    fatora_ID = Convert.ToInt32(salesID_TXT.Text);
                }
                else
                {
                    da2n_byan = "مبلغ ناتج عن عملية مرتجع شراء بتاريخ     " + dateTimePicker1.Value.ToShortDateString();
                    fatora_ID = 0;
                }
                //insert outcome
                income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), da2n_byan, Convert.ToDecimal(matloobTXT.Text), fatora_ID, "مرتجع شراء", cst_nameTXT.Text, usertxt.Text, notesTXT.Text,far3txt.Text,0);

                //safe insert daily
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(matloobTXT.Text));


                //safe update current
                safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(matloobTXT.Text));


            }


            //ma5zoon

            if (salesID_TXT.Text == "") 
            {
                salesID_TXT.Text = "0";
            }

            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table,dgr.Cells[1].Value.ToString());
                string pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                decimal pro_count_after = pro_count - Convert.ToDecimal(dgr.Cells[3].Value);
                ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(dateTimePicker1.Value.ToShortDateString(),dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(dgr.Cells[3].Value),
                    Convert.ToDecimal(dgr.Cells[5].Value), pro_count, pro_count_after, "مرتجع شراء", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text,far3txt.Text);
            }
            //products
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                products_tableTableAdapter1.Update_count_BY_ID_buy(-Convert.ToDecimal(dgr.Cells[3].Value), -Convert.ToDecimal(dgr.Cells[3].Value), dgr.Cells[1].Value.ToString(),far3txt.Text);
            }



            int purchases_num=0;
             try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table,far3txt.Text);
               purchases_num =Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["purchases_ID"]);//.ToString();
            }
            catch { }
             foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                purchases_tableTableAdapter1.Insert_Purchases(purchases_num, dateTimePicker1.Value.ToShortDateString(), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text,
                    Convert.ToDecimal(matloobTXT.Text), usertxt.Text, dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), -Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), notesTXT.Text, 0, far3txt.Text, Convert.ToDecimal(dgr.Cells[4].Value),0);


            // insert to mortaga3at
           
                 mortaga3_purchasesTableAdapter1.Insert_mortaga3_purchases(Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dgr.Cells[1].Value.ToString(), dgr.Cells[2].Value.ToString(), Convert.ToDecimal(dgr.Cells[3].Value), Convert.ToDecimal(dgr.Cells[4].Value), usertxt.Text, notesTXT.Text);
            }


            numbers_tableTableAdapter1.Update_purchase_ID(far3txt.Text);

            int num = Convert.ToInt32(salesID_TXT.Text) + 1;

            System.IO.File.WriteAllText(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return_purchases.txt", num.ToString());


            DialogResult ree = MessageBox.Show("تم الحفظ بنجاح , هل تريد طباعة المرتجع ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ree == DialogResult.Yes)
            {

              
                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);

                mortaga3_purchases_crystal1.Refresh();
                mortaga3_purchases_crystal1.SetDataSource(dataSet11);
                string param;


                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";

                mortaga3_purchases_crystal1.SetParameterValue("test", param);


                mortaga3_purchasesTableAdapter1.FillBy_mortaga3_id(dataSet11.mortaga3_purchases, Convert.ToInt32(salesID_TXT.Text));

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                mortaga3_purchases_crystal1.PrintOptions.PrinterName = printer_name;
                mortaga3_purchases_crystal1.PrintToPrinter(1, false, 0, 0);



            }
            this.Close();

        }




        private void timer1_Tick(object sender, EventArgs e)
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
            matloobTXT.Text = egmalyTXT.Text;

            items_count_txt.Text = dataGridView1.Rows.Count.ToString();
            keta3_txt.Text = sum_keta3.ToString();

            try 
            {
                try
                {
                    total_txt.Text = (Convert.ToDecimal(da2n_matloob_txt.Text) - Convert.ToDecimal(matloobTXT.Text)).ToString();
                }
                catch { }
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
                try 
                {
                    da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, cst_nameTXT.Text);
                    if (dataSet11.da2n_small_reports.Rows.Count > 0)
                    {
                        da2n_matloob_txt.Text = dataSet11.da2n_small_reports.Rows[0]["da2n_small_ba2y"].ToString();
                    } 
                    else 
                    {
                        da2n_matloob_txt.Text = "0";
                    }
                }
                catch { }

            }
            catch { }
        }

        private void purchases_mortaga3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            suggest_mwared_name();
            suggest_product();
            read_num();
        }
        private void read_num()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return_purchases.txt", Encoding.Default, true);
            while ((line = file.ReadLine()) != null)
            {
                salesID_TXT.Text = line.ToString();
                counter++;
            }

            file.Close();
        }

        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            product_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            product_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
            }

            product_nameTXT.AutoCompleteCustomSource = DataCollection;

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

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == product_nameTXT.Text || dataGridView1.Rows[i].Cells[2].Value.ToString() == product_nameTXT.Text)
                    {
                        products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, dataGridView1.Rows[i].Cells[1].Value.ToString());

                        // unit_price_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                        raseed_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                        if (Convert.ToDecimal(countTXT.Text) + Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) <= Convert.ToDecimal(raseed_txt.Text))
                        {
                            dataGridView1.Rows[i].Cells[3].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToDecimal(countTXT.Text);
                            //MessageBox.Show("المنتج موجود بالفعل");
                            product_nameTXT.Clear();
                            product_nameTXT.Select();
                            return;
                        }
                        else 
                        {
                            MessageBox.Show("المنتج موجود بالفعل والكمية المضافة اليه اكبر من الموجود في المخزن");
                            return;
                        }
                    }


                }
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
                //  try 
                //{
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table,product_nameTXT.Text);
                if (dataSet11.products_table.Rows.Count <= 0) 
                {
                    products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
                   
                }

                string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();

                decimal count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);

                if (Convert.ToDecimal(countTXT.Text) <= count)
                {

                   
                }
                else
                {
                    MessageBox.Show("الكمية غير متاحه في المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1,pro_code, product_name, countTXT.Text, unit_price_txt.Text);

                if (dataGridView1.Columns.Count == 6)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 100;
                    btn.Text = "حذف";
                    btn.DefaultCellStyle.BackColor = Color.Red;
                    btn.Name = "الحذف";
                    btn.UseColumnTextForButtonValue = true;


                    dataGridView1.Columns.Add(btn);

                }
                    product_nameTXT.Clear();
                    product_nameTXT.Focus();
                    unit_price_txt.Clear();
                

            }
            catch
            {
                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == product_nameTXT.Text)
                //    {
                //        MessageBox.Show("المنتج موجود بالفعل");
                //        product_nameTXT.Select();
                //        return;
                //    }


                //}
                //if (countTXT.Text == "")
                //{
                //    MessageBox.Show("أدخل الكمية");
                //    countTXT.Select();
                //    return;
                //}

                //if (unit_price_txt.Text == "")
                //{
                //    MessageBox.Show("أدخل سعر الوحدة");
                //    unit_price_txt.Select();
                //    return;
                //}
                //try
                //{
                //    products_tableTableAdapter1.FillBy_name(dataSet11.products_table, product_nameTXT.Text);
                //    string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                //    string product_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();

                //    dataGridView1.Rows.Add(pro_code, product_name, countTXT.Text, unit_price_txt.Text);
                //    if (dataGridView1.Columns.Count == 5)
                //    {
                //        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                //        btn.Width = 100;
                //        btn.Text = "حذف";
                //        btn.DefaultCellStyle.BackColor = Color.Red;
                //        btn.Name = "الحذف";
                //        btn.UseColumnTextForButtonValue = true;


                //        dataGridView1.Columns.Add(btn);
                //    }
                //    product_nameTXT.Clear();
                //    product_nameTXT.Focus();
                //    unit_price_txt.Clear();
                //}
                //catch
                //{
                //}
            }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            try
            {
                products_tableTableAdapter1.FillBy_pro_int_code(dataSet11.products_table, selectedRow.Cells[1].Value.ToString());
                if (dataSet11.products_table.Rows.Count > 0)
                {
                    raseed_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                }
                else 
                {
                    raseed_txt.Text = "";
                }

            }
            catch { }
            try
            {

                if (e.ColumnIndex == 6)
                {
                   
                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[2].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
