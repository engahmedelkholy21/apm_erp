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
    public partial class create_loan_request : Form
    {
        public create_loan_request()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }
        public string Result="cancelled";
        public decimal Result_total = 0;
       decimal masrofat_amount ;
        private void calc_masrofat(decimal requested) 
        {
            if (requested < 5000) 
            {
                masrofat_amount = 100;
            }
            if (5000 < requested && requested <= 10000) 
            {
                masrofat_amount = 200;
            }
            if (10000 < requested && requested <= 15000)
            {
                masrofat_amount = 300;
            }
            if (15000 < requested && requested <= 20000)
            {
                masrofat_amount = 350;
            }
            if (20000 < requested && requested <= 25000)
            {
                masrofat_amount = 400;
            }
            if (25000 < requested && requested <= 30000)
            {
                masrofat_amount = 500;
            }
            if (30000 < requested && requested <= 35000)
            {
                masrofat_amount = 600;
            }
            if (35000 < requested && requested <= 40000)
            {
                masrofat_amount = 700;
            }
            if (40000 < requested && requested <= 50000)
            {
                masrofat_amount = 1000;
            }
            if (50000 < requested && requested <= 75000)
            {
                masrofat_amount = 1500;
            }
            if (75000 < requested && requested <= 100000)
            {
                masrofat_amount = 2000;
            }
            if (100000 < requested && requested <= 150000)
            {
                masrofat_amount = 3000;
            }
            if (150000 < requested && requested <= 200000)
            {
                masrofat_amount = 4000;
            }
            if (200000 < requested)
            {
                masrofat_amount = 5000;
            }

           // masrofat_txt.Text = masrofat_amount.ToString();
            masrofat_txt.Text = "0";
        }


        private void requested_amount_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calc_kest(Convert.ToDecimal(months_num_txt.Text), Convert.ToDecimal(requested_amount_txt.Text), Convert.ToDecimal(nesba_cost.Text));
            }
            catch { }

            //try
            //{
            //    if (masrofat_txt.Text == "") 
            //    {
            //        masrofat_txt.Text = "0";
            //    }
            //    calc_masrofat(Convert.ToDecimal(requested_amount_txt.Text));


            //    decimal requested = Convert.ToDecimal(requested_amount_txt.Text) + Convert.ToDecimal(masrofat_txt.Text);
            //    decimal finalfor12 =requested +requested * (Convert.ToDecimal(nesba_cost.Text) / Convert.ToDecimal("100"));
               
                
            //   // //decimal nesba_mablagh_all = (finalfor12 - Convert.ToDecimal(requested)) / 12;

            //    decimal nesba_mablagh_month = finalfor12 / Convert.ToDecimal(months_num_txt.Text);
            //    //final_amount.Text = (Convert.ToDecimal(kest_cost.Text) * Convert.ToDecimal(months_num_txt.Text)).ToString();
            //    //kest_cost.Text = (Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text)).ToString();

                
                
            //    months_num_txt_TextChanged(sender, e);
            //    final_amount.Text = (Convert.ToDecimal(kest_cost_txt.Text) * Convert.ToDecimal(months_num_txt.Text)).ToString();
                
            //}
            //catch { }
        }

        private void nesba_cost_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (masrofat_txt.Text == "")
            //    {
            //        masrofat_txt.Text = "0";
            //    }
            //    decimal requested = Convert.ToDecimal(requested_amount_txt.Text) + Convert.ToDecimal(masrofat_txt.Text);
               
            //    decimal finalfor12 = requested + requested * (Convert.ToDecimal(nesba_cost.Text) / Convert.ToDecimal("100"));
               
            //    //decimal nesba_mablagh_all = (finalfor12 - requested) / 12;
               
            //    decimal nesba_mablagh_month = nesba_mablagh_all * Convert.ToDecimal(months_num_txt.Text);
            //  //  final_amount.Text = (nesba_mablagh_month + Convert.ToDecimal(requested_amount_txt.Text)).ToString();
            //  //  kest_cost.Text = (Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text)).ToString();


            //    final_amount.Text = (Convert.ToDecimal(kest_cost_txt.Text) * Convert.ToDecimal(months_num_txt.Text)).ToString();

            //}
            //catch { months_num_txt.Clear(); }

            months_num_txt_TextChanged( sender, e);

           
        }


       

        private void months_num_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calc_kest(Convert.ToDecimal(months_num_txt.Text), Convert.ToDecimal(requested_amount_txt.Text), Convert.ToDecimal(nesba_cost.Text));
            }
            catch { }
            //try
            //{
            //    if (masrofat_txt.Text == "")
            //    {
            //        masrofat_txt.Text = "0";
            //    }

            //    calc_masrofat(Convert.ToDecimal(requested_amount_txt.Text));
                
            //    decimal requested = Convert.ToDecimal(requested_amount_txt.Text) + Convert.ToDecimal(masrofat_txt.Text);

            //    decimal finalfor12 = requested + requested * (Convert.ToDecimal(nesba_cost.Text) / Convert.ToDecimal("100"));
               
            //    //decimal nesba_mablagh_all = (finalfor12 - Convert.ToDecimal(requested)) / 12;

            //    decimal nesba_mablagh_month = finalfor12 / Convert.ToDecimal(months_num_txt.Text);
            //  //  decimal nesba_mablagh_month = nesba_mablagh_all * Convert.ToDecimal(months_num_txt.Text);
            //    final_amount.Text = (nesba_mablagh_month + Convert.ToDecimal(requested)).ToString();
            //    kest_cost_txt.Text = (Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text)).ToString();



            //    string original_num = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000.00");
            //    //  MessageBox.Show(original_num.ToString());
            //    string originalnum_after_int = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000");
            //    if (Convert.ToDecimal(originalnum_after_int) < Convert.ToDecimal(original_num))
            //    {
            //        decimal new_original = Convert.ToDecimal(originalnum_after_int) + 1;
            //        kest_cost_txt.Text = new_original.ToString();
            //    }
            //    else
            //    {
            //        kest_cost_txt.Text = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000");

            //    }

            //    final_amount.Text = (Convert.ToDecimal(kest_cost_txt.Text) * Convert.ToDecimal(months_num_txt.Text)).ToString();

            //}
            //catch { }
            ////try
            ////{
            ////    //  kest_cost.Text=(Convert.ToInt32(months_num_txt.Text)).ToString();

            ////    string original_num = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000.00");
            ////  //  MessageBox.Show(original_num.ToString());
            ////    string originalnum_after_int = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000");
            ////    if (Convert.ToDecimal(originalnum_after_int) < Convert.ToDecimal(original_num))
            ////    {
            ////        decimal new_original = Convert.ToDecimal(originalnum_after_int) + 1;
            ////        kest_cost.Text = new_original.ToString();
            ////    }
            ////    else 
            ////    {
            ////        kest_cost.Text = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000");
               
            ////    }

            ////}
            ////catch { }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void cst_code_txt_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void cst_name_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void damen_awel_name_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void damen_awel_code_txt_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void damen_tany_name_txt_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void damen_tany_code_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void create_loan_request_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1);

            if (this.Text == "نموذج معرفة الاقساط")
            {
                button1.Visible = false;
                requested_amount_txt.Select();
                requested_amount_txt.Focus();

                groupBox3.Visible = false;
                cancel_btn.Visible = false;
                button1.Visible = false;
                //groupBox1.Height = groupBox1.Height - groupBox3.Height - cancel_btn.Height ;
                //this.Height = groupBox1.Height +50;
                //this.StartPosition = FormStartPosition.Manual;
                //this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                //                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
            else 
            {
                employee_tableTableAdapter.Fill(dataSet11.employee_table);
                check_customer();
                cst_code_txt.Select();
            }

            suggest_cst_name();
        }
        private void suggest_cst_name()
        {
            this.customersTableAdapter1.Fill(this.dataSet11.customers);
            cst_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cst_code_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_code_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.customers.Rows)
            {
                DataCollection.Add(dr["cst_name"].ToString());
                DataCollection2.Add(dr["cst_ID"].ToString());
            }


            cst_name_txt.AutoCompleteCustomSource = DataCollection;

            cst_code_txt.AutoCompleteCustomSource = DataCollection2;

        }
        private void check_customer()
        {
            customersTableAdapter1.FillBy_name(dataSet11.customers, cst_name_txt.Text);
            if (dataSet11.customers.Rows.Count <= 0)
            {
                Form1 f = new Form1();
                add_customer ac = new add_customer();
                ac.usertxt.Text = user_txt.Text;
                ac.far3txt.Text = far3_txt.Text;
                ac.Text = "إضافة عميل جديد";
                ac.cst_nameTXT.Text = damen_awel_name_txt.Text;
                f.SubscribeToLoadEvent(ac);
                f.ApplyFormStyling(ac);
                ac.ShowDialog();
            }
            else
            {
                if (dataSet11.customers.Rows[0]["cst_national_id"].ToString() == "" || dataSet11.customers.Rows[0]["betaka_url"].ToString() == "")
                {
                    DialogResult re = MessageBox.Show("بيانات العميل غير كاملة برجاء اضافة البيانات ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataSet11.customers.Rows[0]["cst_ID"]);
                        edit_customer ee = new edit_customer();
                        ee.cst_id.Text = id.ToString();
                        //ee.cst_name.Text = selectedRow.Cells[1].Value.ToString();
                        //ee.cst_nameTXT_new.Text = selectedRow.Cells[1].Value.ToString();
                        //ee.cst_phoneTXT.Text = selectedRow.Cells[2].Value.ToString();
                        //ee.cst_addressTXT.Text = selectedRow.Cells[3].Value.ToString();
                        //ee.notesTXT.Text = selectedRow.Cells[5].Value.ToString();
                        //ee.price_txt.Text = selectedRow.Cells[4].Value.ToString();
                        //ee.national_id_txt.Text = selectedRow.Cells[6].Value.ToString();
                        //ee.takseet_status.Text = selectedRow.Cells[7].Value.ToString();

                        //ee.url_txt.Text = selectedRow.Cells[8].Value.ToString();
                        ee.usertxt.Text = user_txt.Text;
                        ee.far3txt.Text = far3_txt.Text;
                        ee.ShowDialog();

                    }
                }

            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

            if (requested_amount_txt.Text == "") 
            {
                MessageBox.Show("أدخل قيمة التقسيط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                requested_amount_txt.Focus();
                return;
            }

            if (months_num_txt.Text == "")
            {
                MessageBox.Show("ادخل عدد الشهور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                months_num_txt.Focus();
                return;
            }

            if (damen_tany_code_txt.Text == "")
            {
                if (cst_code_txt.Text == damen_awel_code_txt.Text || cst_code_txt.Text == damen_tany_code_txt.Text)
                {
                    MessageBox.Show("لا يمكن ان يكون العميل ضامن لنفسه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                DialogResult re = MessageBox.Show("هل تريد اضافة التقسيط بدون ضامن ثاني ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    if (mandoob_1_txt.Text != mandoob_txt.Text)
                    {

                        MessageBox.Show("المندوب مختلف برجاء المراجعه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        damen_tany_code_txt.Clear();
                        cst_code_txt.SelectAll();
                        cst_code_txt.Focus();
                        return;

                    }
                    if (estkmal_combox.Checked == false)
                    {
                        //// Check status_1_txt
                        //if (status_1_txt.Text != "لا توجد التزامات" && status_1_txt.Text != " ")
                        //{
                        //    MessageBox.Show("احد الضمّان مرتبط بتمويل اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    cst_name_txt.Focus();
                        //    cst_name_txt.SelectAll();
                        //    return;
                        //}

                        //// Check cst_status_txt
                        //if (cst_status_txt.Text != "لا توجد التزامات" && cst_status_txt.Text != " ")
                        //{
                        //    MessageBox.Show("العميل مرتبط بتمويل اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    cst_name_txt.Focus();
                        //    cst_name_txt.SelectAll();
                        //    return;
                        //}


                        //if ((status_1_txt.Text != "لا توجد التزامات" || status_1_txt.Text != " ") ||
                        //    (cst_status_txt.Text != "لا توجد التزامات" || cst_status_txt.Text != " "))
                        //{
                        //    MessageBox.Show("العميل او احد الضمّان مرتبط بتمويل اخر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    cst_name_txt.Focus();
                        //    cst_name_txt.SelectAll();

                        //    return;
                        //}
                    }


                    if (cst_name_txt.Text != "" || damen_awel_name_txt.Text != "")
                    {
                        loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);
                        //MessageBox.Show(dataSet11.loans_requests_table.Rows.Count.ToString());
                        if (dataSet11.loans_requests_table.Rows.Count > 0)
                        {
                            MessageBox.Show("عملية التقسيط بنفس بيانات العميل موجوده مسبقا برجاء المراجعة", "تم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        if (estkmal_combox.Checked == true)
                        {

                            // decimal sum_most7kat = 0;
                            int previous = Convert.ToInt32(tamweel_dawra_txt.Text) - 1;
                            aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, cst_code_txt.Text + "/" + previous.ToString(), far3_txt.Text);
                            if (dataSet11.aksat_table.Rows.Count <= 0)
                            {
                                aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);

                            }

                            string loan_code = dataSet11.aksat_table.Rows[0]["kest_loan_code"].ToString();
                            foreach (DataRow dr in dataSet11.aksat_table.Rows)
                            {
                                aksat_tableTableAdapter1.Update_for_estkmal(DateTime.Today.ToShortDateString(), Convert.ToDecimal(dr["kest_amount"]), 0, user_txt.Text, 0, 0, "استكمال"
                                    , Convert.ToInt32(dr["kest_number"]), dr["kest_loan_code"].ToString(), dr["kest_cst_name"].ToString(), far3_txt.Text);

                            }

                            loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, loan_code, far3_txt.Text);
                            try
                            {
                                string damen_1 = dataSet11.loans_requests_table.Rows[0]["loan_1st_damen_code"].ToString();
                                customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات",Convert.ToInt32(damen_1));
                            }
                            catch { }
                            try
                            {
                                string damen_2 = dataSet11.loans_requests_table.Rows[0]["loan_2nd_damen_code"].ToString();
                                customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات",Convert.ToInt32( damen_2));
                            }
                            catch { }


                            customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات",Convert.ToInt32( cst_code_txt.Text));

                            loans_requests_tableTableAdapter1.Update_mandoob_and_status_by_loan_code("متسرب", "متسرب", loan_code);

                        }
                        //   
                        if (masrofat_txt.Text == "")
                        {
                            masrofat_txt.Text = "0";
                        }
                        decimal requested = Convert.ToDecimal(requested_amount_txt.Text) + Convert.ToDecimal(masrofat_txt.Text);

                        loans_requests_tableTableAdapter1.Insert(cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, cst_name_txt.Text, cst_code_txt.Text, Convert.ToDecimal(requested), Convert.ToDecimal(final_amount.Text) - Convert.ToDecimal(requested), damen_awel_name_txt.Text, damen_awel_code_txt.Text
                            , damen_tany_name_txt.Text, damen_tany_code_txt.Text, nesba_cost.Text, "تم الصرف", mandoob_txt.Text, Convert.ToInt32(months_num_txt.Text), user_txt.Text, Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), user_txt.Text, user_txt.Text, user_txt.Text, far3_txt.Text, Convert.ToDecimal(masrofat_txt.Text),Convert.ToInt32(fatora_num_txt.Text));


                        //loans_requests_tableTableAdapter1.Fill(dataSet11.loans_requests_table);
                        //MessageBox.Show(dataSet11.loans_requests_table.Rows.Count.ToString());

                        try
                        {
                            customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("عميل تمويل رقم " + cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, Convert.ToInt32(cst_code_txt.Text));
                        }
                        catch { }

                        try
                        {
                            customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("ضامن تمويل رقم " + cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, Convert.ToInt32(damen_awel_code_txt.Text));
                        }
                        catch { }
                        try
                        {
                            customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("ضامن تمويل رقم " + cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, Convert.ToInt32(damen_tany_code_txt.Text));
                        }
                        catch { }
                        MessageBox.Show("تمت إضافة التقسيط بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Result = "done";
                        Result_total = Convert.ToDecimal(final_amount.Text);
                        this.Close();


                    }

                }
                else if (re == DialogResult.No)
                {
                    damen_tany_name_txt.Focus();
                    return;
                }
            }
            else
            {
                if (mandoob_1_txt.Text != mandoob_2_txt.Text || mandoob_1_txt.Text != mandoob_txt.Text)
                {

                    MessageBox.Show("المندوب مختلف برجاء المراجعه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    damen_tany_code_txt.Clear();
                    cst_code_txt.SelectAll();
                    cst_code_txt.Focus();
                    return;

                }
                loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);
                if (dataSet11.loans_requests_table.Rows.Count > 0)
                {
                    MessageBox.Show("عملية التقسيط بنفس بيانات العميل موجوده مسبقا برجاء المراجعة", "تم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (estkmal_combox.Checked == true)
                {

                    // decimal sum_most7kat = 0;
                    int previous = Convert.ToInt32(tamweel_dawra_txt.Text) - 1;
                    aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, cst_code_txt.Text + "/" + previous.ToString(), far3_txt.Text);
                    if (dataSet11.aksat_table.Rows.Count <= 0)
                    {
                        aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);

                    }

                    string loan_code = dataSet11.aksat_table.Rows[0]["kest_loan_code"].ToString();
                    foreach (DataRow dr in dataSet11.aksat_table.Rows)
                    {
                        aksat_tableTableAdapter1.Update_for_estkmal(DateTime.Today.ToShortDateString(), Convert.ToDecimal(dr["kest_amount"]), 0, user_txt.Text, 0, 0, "استكمال"
                            , Convert.ToInt32(dr["kest_number"]), dr["kest_loan_code"].ToString(), dr["kest_cst_name"].ToString(), far3_txt.Text);

                    }

                    loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, loan_code, far3_txt.Text);
                    try
                    {
                        string damen_1 = dataSet11.loans_requests_table.Rows[0]["loan_1st_damen_code"].ToString();

                        customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات",Convert.ToInt32( damen_1));
                    }
                    catch { }
                    try
                    {
                        string damen_2 = dataSet11.loans_requests_table.Rows[0]["loan_2nd_damen_code"].ToString();

                        customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات",Convert.ToInt32( damen_2));
                    }
                    catch { }

                    customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("لا توجد التزامات",Convert.ToInt32( cst_code_txt.Text));

                    loans_requests_tableTableAdapter1.Update_mandoob_and_status_by_loan_code("متسرب", "متسرب", loan_code);

                }

                loans_requests_tableTableAdapter1.Insert(cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, cst_name_txt.Text, cst_code_txt.Text, Convert.ToDecimal(requested_amount_txt.Text), Convert.ToDecimal(final_amount.Text) - Convert.ToDecimal(requested_amount_txt.Text), damen_awel_name_txt.Text, damen_awel_code_txt.Text
                       , damen_tany_name_txt.Text, damen_tany_code_txt.Text, nesba_cost.Text, "انتظار المراجعه", mandoob_txt.Text, Convert.ToInt32(months_num_txt.Text), user_txt.Text, Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), null, null, null, "", "", "", far3_txt.Text, 0, Convert.ToInt32(fatora_num_txt.Text));

                customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("عميل تمويل رقم " + cst_code_txt.Text + "/" + tamweel_dawra_txt.Text,Convert.ToInt32( cst_code_txt.Text));
                customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("ضامن تمويل رقم " + cst_code_txt.Text + "/" + tamweel_dawra_txt.Text,Convert.ToInt32( damen_awel_code_txt.Text));
                customers_tableTableAdapter1.Update_Customer_status_by_Customer_code("ضامن تمويل رقم " + cst_code_txt.Text + "/" + tamweel_dawra_txt.Text,Convert.ToInt32( damen_tany_code_txt.Text));
                MessageBox.Show("تمت إضافة التقسيط بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Result = "done";
                Result_total = Convert.ToDecimal(final_amount.Text);
                this.Close();
            }

            //gadwala hena
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                aksat_tableTableAdapter1.Insert(Convert.ToInt32(dgr.Cells[0].Value), cst_code_txt.Text, cst_name_txt.Text, damen_awel_code_txt.Text, damen_awel_name_txt.Text, damen_tany_code_txt.Text, damen_tany_name_txt.Text
                    , Convert.ToDecimal(dgr.Cells[2].Value),Convert.ToDateTime(dgr.Cells[1].Value), null, "", user_txt.Text, "غير مسدد", 0, mandoob_txt.Text, "", far3_txt.Text, months_num_txt.Text, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, null, null);
            }


            cst_code_txt.Clear(); cst_name_txt.Clear(); requested_amount_txt.Clear(); nesba_cost.Clear(); damen_awel_code_txt.Clear(); months_num_txt.Clear(); final_amount.Clear(); kest_cost_txt.Clear();
            damen_awel_name_txt.Clear(); damen_tany_code_txt.Clear(); damen_tany_name_txt.Clear(); mandoob_txt.ResetText(); notes_txt.Clear();
            masrofat_txt.Clear();
            //}
            //catch { }
        }

        private void damen_awel_code_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                customers_tableTableAdapter1.FillBy_id(dataSet11.customers,Convert.ToInt32(damen_awel_code_txt.Text));
              //  string mandoob = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                string cst_name = dataSet11.customers.Rows[0]["cst_name"].ToString();
                //if (mandoob_txt.Text != mandoob)
                //{
                //    MessageBox.Show("المندوب مختلف برجاء المراجعه", "تم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    damen_awel_code_txt.Clear();
                //    damen_awel_name_txt.Clear();

                //    cst_code_txt.SelectAll();
                //    cst_code_txt.Focus();
                //}
                if (cst_name == cst_name_txt.Text)
                {
                    MessageBox.Show("الكود الذي تم ادخاله كود العميل نفسه", "تم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    damen_awel_code_txt.Clear();
                    damen_awel_name_txt.Clear();
                    cst_code_txt.SelectAll();
                    cst_code_txt.Focus();
                }
            }
            catch { }
               
        }

        private void damen_tany_code_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                customers_tableTableAdapter1.FillBy_id(dataSet11.customers,Convert.ToInt32(damen_tany_code_txt.Text));
               // string mandoob = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                string cst_name = dataSet11.customers.Rows[0]["cst_name"].ToString();
                //if (mandoob_txt.Text != mandoob)
                //{
                //    MessageBox.Show("المندوب مختلف برجاء المراجعه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    damen_tany_code_txt.Clear();
                //    damen_tany_name_txt.Clear();
                //    cst_code_txt.SelectAll();
                //    cst_code_txt.Focus();
                //} if (cst_name == cst_name_txt.Text)
                //{
                //    MessageBox.Show("الكود الذي تم ادخاله كود العميل نفسه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    damen_tany_code_txt.Clear();
                //    damen_tany_name_txt.Clear();
                //    cst_code_txt.SelectAll();
                //    cst_code_txt.Focus();
                //}
            }
            catch { }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Result = "cancelled";
        }

         private void calc_kest(decimal period, decimal requested, decimal nesba) 
        {
            try
            {
                decimal final_amount_calc = requested * (Convert.ToDecimal("1." + nesba.ToString()));

                final_amount.Text = final_amount_calc.ToString();

                decimal kest = final_amount_calc / period;

                string original_num = kest.ToString("0,000.00");
                //  MessageBox.Show(original_num.ToString());
                string originalnum_after_int = (final_amount_calc / period).ToString("0,000");
                if (Convert.ToDecimal(originalnum_after_int) < Convert.ToDecimal(original_num))
                {
                    decimal new_original = Convert.ToDecimal(originalnum_after_int) + 1;
                    kest_cost_txt.Text = new_original.ToString();
                }
                else
                {
                    kest_cost_txt.Text = (final_amount_calc / period).ToString("0,000");

                }
            }
            catch { }
             
           // MessageBox.Show(final_amount.ToString());
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                calc_kest(Convert.ToDecimal(months_num_txt.Text), Convert.ToDecimal(requested_amount_txt.Text), Convert.ToDecimal(nesba_cost.Text));
            }
            catch { }
            //try 
            //{
            //    if (masrofat_txt.Text == "")
            //    {
            //        masrofat_txt.Text = "0";
            //    }
            //    decimal requested = Convert.ToDecimal(requested_amount_txt.Text) + Convert.ToDecimal(masrofat_txt.Text);
            //       decimal finalfor12 = requested +requested * (Convert.ToDecimal(nesba_cost.Text) /Convert.ToDecimal("100"));
            //        MessageBox.Show(finalfor12.ToString());

            //        //decimal nesba_mablagh_all = (finalfor12 -requested)/12;
            //       // MessageBox.Show(nesba_mablagh_all.ToString());

            //        decimal nesba_mablagh_month = finalfor12 / Convert.ToDecimal(months_num_txt.Text); MessageBox.Show(nesba_mablagh_month.ToString());
            //    final_amount.Text=(nesba_mablagh_month+Convert.ToDecimal(requested)).ToString();
            //    kest_cost_txt.Text = (Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text)).ToString();

            //}
            //catch { }
        }

        private void cst_code_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                
                try
                {
                    //safe_income_tableTableAdapter1.FillBy_last_est3lam_loan_code_far3(dataSet11.income_table, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);
                    //if (dataSet11.income_table.Rows.Count <= 0)
                    //{
                    //    income_tableTableAdapter1.FillBy_last_est3lam_loan_code_far3(dataSet11.income_table, cst_code_txt.Text, far3_txt.Text);
                    //}
                   
                    //if (dataSet11.income_table.Rows.Count <= 0)
                    //{
                    //    MessageBox.Show("تأكد من سداد الاستعلام", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    //else 


                    //if (dataSet11.income_table.Rows.Count > 0)
                    //{
                    //    DateTime safeIncomeDate = Convert.ToDateTime(dataSet11.income_table.Rows[0]["safe_income_date"]);

                    //    // Calculate the difference in days between today and safeIncomeDate
                    //    TimeSpan difference = DateTime.Today - safeIncomeDate;

                    //    // Check if the difference is more than 30 days
                    //    if (difference.TotalDays > 30)
                    //    {
                    //        MessageBox.Show("يجب ان لا تزيد الفترة بين الاستعلام و انشاء التقسيط عن 30 يوما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                    //}

                    customers_tableTableAdapter1.FillBy_id(dataSet11.customers,Convert.ToInt32(cst_code_txt.Text));

                    cst_name_txt.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                    //mandoob_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                    //cst_status_txt.Text = dataSet11.customers.Rows[0]["Customer_status"].ToString();
                    if (estkmal_combox.Checked == true) 
                    {
                        decimal sum_most7kat=0;
                        int previous=Convert.ToInt32(tamweel_dawra_txt.Text)-1;
                        aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, cst_code_txt.Text + "/" + previous.ToString(), far3_txt.Text);
                        if (dataSet11.aksat_table.Rows.Count <= 0) 
                        {
                            aksat_tableTableAdapter1.FillBy_kest_cst_code_not_paid(dataSet11.aksat_table, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);
                       
                        }
                        foreach (DataRow dr in dataSet11.aksat_table.Rows) 
                        {
                            sum_most7kat += Convert.ToDecimal(dr["kest_amount"]);
                        }

                        masrofat_txt.Text = sum_most7kat.ToString();
                        
                    }
                    requested_amount_txt.Focus();
                }
                catch { }
            }
        }

       // bool paid_est3lam = false;

        private void nesba_cost_Leave(object sender, EventArgs e)
        {
            try
            {
                nesba_cost.ReadOnly = true;
            
            }
            catch { }
        }

        private void nesba_cost_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                nesba_cost.ReadOnly = false;
             
            }
            catch { }
        }

        private void estkmal_combox_CheckedChanged(object sender, EventArgs e)
        {
            if (estkmal_combox.Checked == true)
            {
                label18.Visible = true;
                masrofat_txt.Visible = true;
            }
            else 
            {
                label18.Visible = false; 
                masrofat_txt.Visible = false;
            }
        }
        //
        private void mosta7kat_txt_TextChanged(object sender, EventArgs e)
        {
            requested_amount_txt_TextChanged(sender, e);
        }

        private void tamweel_dawra_txt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void damen_awel_name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    customers_tableTableAdapter1.FillBy_name(dataSet11.customers, damen_awel_name_txt.Text);
                    if (dataSet11.customers.Rows.Count > 0)
                    {
                        damen_awel_code_txt.Text = dataSet11.customers.Rows[0]["cst_ID"].ToString();
                        //mandoob_1_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                        status_1_txt.Text = dataSet11.customers.Rows[0]["cst_takseet_status"].ToString();
                    }
                    else 
                    {
                        Form1 f = new Form1();
                        add_customer ac = new add_customer();
                        ac.usertxt.Text = user_txt.Text;
                        ac.far3txt.Text = far3_txt.Text;
                        ac.Text = "إضافة عميل جديد";
                        ac.cst_nameTXT.Text = damen_awel_name_txt.Text;
                        f.SubscribeToLoadEvent(ac);
                        f.ApplyFormStyling(ac);
                        ac.ShowDialog();

                        customers_tableTableAdapter1.FillBy_name(dataSet11.customers, damen_awel_name_txt.Text);
                        damen_awel_code_txt.Text = dataSet11.customers.Rows[0]["cst_ID"].ToString();
                        //mandoob_1_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                        status_1_txt.Text = dataSet11.customers.Rows[0]["cst_takseet_status"].ToString();
                    }
                }
            }
            catch { }
        }

        private void damen_awel_code_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        customers_tableTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(damen_awel_code_txt.Text));
                        if (dataSet11.customers.Rows.Count > 0)
                        {
                            damen_awel_name_txt.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                            //mandoob_1_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                            status_1_txt.Text = dataSet11.customers.Rows[0]["cst_takseet_status"].ToString();
                        }
                        else 
                        {
                            Form1 f = new Form1();
                            add_customer ac = new add_customer();
                            ac.usertxt.Text = user_txt.Text;
                            ac.far3txt.Text = far3_txt.Text;
                            ac.Text = "إضافة عميل جديد";
                            ac.cst_nameTXT.Text = damen_awel_name_txt.Text;
                            f.SubscribeToLoadEvent(ac);
                            f.ApplyFormStyling(ac);
                            ac.ShowDialog();

                            customers_tableTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(damen_awel_code_txt.Text));
                            damen_awel_name_txt.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                            //mandoob_1_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                            status_1_txt.Text = dataSet11.customers.Rows[0]["cst_takseet_status"].ToString();
                        }

                    }
                    catch { }

                    if (damen_awel_name_txt.Text != "")
                    {
                        this.AcceptButton = button1;
                    }
                }
            }
            catch { }
        }

        private void damen_tany_code_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    customers_tableTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(damen_tany_code_txt.Text));
                    if (dataSet11.customers.Rows.Count > 0)
                    {
                        damen_tany_name_txt.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                        //mandoob_2_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                        status_2_txt.Text = dataSet11.customers.Rows[0]["Customer_status"].ToString();
                    }
                    else
                    {
                        Form1 f = new Form1();
                        add_customer ac = new add_customer();
                        ac.usertxt.Text = user_txt.Text;
                        ac.far3txt.Text = far3_txt.Text;
                        ac.Text = "إضافة عميل جديد";
                        ac.cst_nameTXT.Text = damen_awel_name_txt.Text;
                        f.SubscribeToLoadEvent(ac);
                        f.ApplyFormStyling(ac);
                        ac.ShowDialog();

                        customers_tableTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(damen_tany_code_txt.Text));
                        damen_tany_name_txt.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                        //mandoob_2_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                        status_2_txt.Text = dataSet11.customers.Rows[0]["Customer_status"].ToString();

                    }
                }
                catch { }
            }
        }

        private void damen_tany_name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    customers_tableTableAdapter1.FillBy_name(dataSet11.customers, damen_tany_name_txt.Text);
                    if (dataSet11.customers.Rows.Count > 0)
                    {
                        damen_tany_code_txt.Text = dataSet11.customers.Rows[0]["cst_ID"].ToString();
                        //mandoob_2_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                        status_2_txt.Text = dataSet11.customers.Rows[0]["Customer_status"].ToString();
                    }
                    else 
                    {
                        Form1 f = new Form1();
                        add_customer ac = new add_customer();
                        ac.usertxt.Text = user_txt.Text;
                        ac.far3txt.Text = far3_txt.Text;
                        ac.Text = "إضافة عميل جديد";
                        ac.cst_nameTXT.Text = damen_awel_name_txt.Text;
                        f.SubscribeToLoadEvent(ac);
                        f.ApplyFormStyling(ac);
                        ac.ShowDialog();


                        customers_tableTableAdapter1.FillBy_name(dataSet11.customers, damen_tany_name_txt.Text);
                        damen_tany_code_txt.Text = dataSet11.customers.Rows[0]["cst_ID"].ToString();
                        //mandoob_2_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                        status_2_txt.Text = dataSet11.customers.Rows[0]["Customer_status"].ToString();

                    }
                }
                catch { }
                if (damen_tany_name_txt.Text != "")
                {
                    this.AcceptButton = button1;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void final_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cst_name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    customers_tableTableAdapter1.FillBy_name(dataSet11.customers, cst_name_txt.Text);
                    cst_code_txt.Text = dataSet11.customers.Rows[0]["cst_ID"].ToString();
                    // mandoob_txt.Text = dataSet11.customers.Rows[0]["Customer_mandoob"].ToString();
                    cst_status_txt.Text = dataSet11.customers.Rows[0]["cst_takseet_status"].ToString();

                    requested_amount_txt.Focus();
                }

                catch { }
            }
        }

        private void ba2y_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                requested_amount_txt.Text = ba2y_txt.Text;
            }
            catch { }
        }

        private void total_fatora_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                ba2y_txt.Text = (Convert.ToDecimal(total_fatora_txt.Text) - Convert.ToDecimal(mo2dema_text.Text)).ToString();
            }
            catch { }
        }

        private void mo2dema_text_TextChanged(object sender, EventArgs e)
        {
            total_fatora_txt_TextChanged(sender, e);
        }

        private void kest_cost_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (kest_cost_txt.Focused == true && months_num_txt.Text != "")
                {
                    final_amount.Text = (Convert.ToDecimal(kest_cost_txt.Text) * Convert.ToDecimal(months_num_txt.Text)).ToString();

                    nesba_cost.Text = ((Convert.ToDecimal(final_amount.Text) - Convert.ToDecimal(requested_amount_txt.Text)) / Convert.ToDecimal(requested_amount_txt.Text)).ToString();
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int count = 0;
            string kest_cost;//=Convert.ToDecimal(final_amount.Text)/Convert.ToDecimal(months_num_txt.Text);
            string original_num = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000.00");
            string originalnum_after_int = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000");
            if (Convert.ToDecimal(originalnum_after_int) < Convert.ToDecimal(original_num))
            {
                decimal new_original = Convert.ToDecimal(originalnum_after_int) + 1;
                kest_cost = new_original.ToString();
            }
            else
            {
                kest_cost = ((Convert.ToDecimal(final_amount.Text) / Convert.ToDecimal(months_num_txt.Text))).ToString("0,000");

            }
            DateTime est7kak = dateTimePicker2.Value.AddMonths(-1);//DateTime.Today.AddMonths(-1);
            for (int i = 0; i < Convert.ToInt32(months_num_txt.Text); i++)
            {
                count += 1;
                est7kak = est7kak.AddMonths(1);
                aksat_tableTableAdapter1.FillBy_last_est7kak_date(dataSet11.aksat_table, cst_code_txt.Text, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, far3_txt.Text);
                DayOfWeek day = est7kak.DayOfWeek;
                try
                {
                    while (Convert.ToDateTime(dataSet11.aksat_table.Rows[0]["kest_est7kak_date"]).Month == est7kak.Month)
                    {
                        if (day == DayOfWeek.Friday)
                        {
                            est7kak.AddDays(2);
                        }
                        else
                        {
                            est7kak.AddDays(1);
                        }
                    }
                }
                catch
                {

                    if (day == DayOfWeek.Friday)
                    {
                        est7kak = est7kak.AddDays(-1);
                    }
                }

                //else if (day == DayOfWeek.Saturday)
                //{
                //    est7kak = est7kak.AddDays(-2);
                //}

                dataGridView1.Rows.Add(count, est7kak, Convert.ToDecimal(kest_cost));
                //aksat_tableTableAdapter1.Insert(count, cst_code_txt.Text, cst_name_txt.Text, damen_awel_code_txt.Text, damen_awel_name_txt.Text, damen_tany_code_txt.Text, damen_tany_name_txt.Text
                //    , Convert.ToDecimal(kest_cost), est7kak, null, "", user_txt.Text, "غير مسدد", 0, mandoob_txt.Text, "", far3_txt.Text, months_num_txt.Text, cst_code_txt.Text + "/" + tamweel_dawra_txt.Text, null, null);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                decimal sum = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                {
                    sum += Convert.ToDecimal(dgr.Cells[2].Value);
                }
                total_txt.Text = sum.ToString();
            }
            catch { }
        }
        decimal originalValue = 0m;
        bool adjusting = false;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                object val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                decimal result;
                if (val != null && decimal.TryParse(val.ToString(), out result))
                {
                    originalValue = result;
                }
                else
                {
                    originalValue = 0m;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (adjusting) return;

            int costColIndex = dataGridView1.Columns.Count - 1;
            if (e.ColumnIndex != costColIndex) return;

            object val = dataGridView1.Rows[e.RowIndex].Cells[costColIndex].Value;
            decimal newValue;
            if (!decimal.TryParse(Convert.ToString(val), out newValue)) return;

            decimal difference = newValue - originalValue;
            if (difference == 0m) return;

            decimal total;
            if (!decimal.TryParse(final_amount.Text, out total)) return;

            // Step 1: Count how many rows originally had the same value (excluding the current one)
            int countSameOriginal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == e.RowIndex || dataGridView1.Rows[i].IsNewRow) continue;

                object cellVal = dataGridView1.Rows[i].Cells[costColIndex].Value;
                decimal cellDec;
                if (decimal.TryParse(Convert.ToString(cellVal), out cellDec))
                {
                    if (cellDec == originalValue)
                        countSameOriginal++;
                }
            }

            if (countSameOriginal == 0) return;

            decimal share = difference / countSameOriginal;
            adjusting = true;

            // Step 2: Subtract share only from rows that matched the original value
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == e.RowIndex || dataGridView1.Rows[i].IsNewRow) continue;

                object cellVal = dataGridView1.Rows[i].Cells[costColIndex].Value;
                decimal cellDec;
                if (decimal.TryParse(Convert.ToString(cellVal), out cellDec))
                {
                    if (cellDec == originalValue)
                    {
                        dataGridView1.Rows[i].Cells[costColIndex].Value = Math.Round(cellDec - share, 2);
                    }
                }
            }

            adjusting = false;
        }
        

        

        
        
    }
}
