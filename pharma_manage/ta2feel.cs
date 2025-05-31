using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace pharma_manage
{
    public partial class ta2feel : Form
    {
        public ta2feel()
        {
            InitializeComponent();

            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (before_txt.Text == "")
            {
                MessageBox.Show("ادخل رصيد ما قبله");
                before_txt.Focus();
                return;
            }

            //if (first_person_txt.Text == "" || second_person_txt.Text == "")
            //{
            //    MessageBox.Show("ادخل الحاضرون");
            //    return;
            //}


            decimal tafkeet_sum = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                tafkeet_sum += Convert.ToDecimal(dgr.Cells[2].Value);


            }

            if (tafkeet_sum != Convert.ToDecimal(all_now_txt.Text))
            {
                MessageBox.Show("برجاء مراجعة التفقيط");
                return;
            }




            string address = "تقفيل خزينة يوم " + date_time_to_txt.Value.ToString("yyyy/MM/dd");
            ta2feel_crystal1.SetParameterValue("address", address);

            decimal before = Convert.ToDecimal(before_txt.Text);
            ta2feel_crystal1.SetParameterValue("before", before);

            // string param = "الوارد للخزينة في الفترة من " + dateTimePicker1.Value.ToShortDateString() + " إلى " + dateTimePicker2.Value.ToShortDateString();


            decimal sum_income = 0;
            decimal sum_ba2y_fatora = 0;
            decimal sum_for_fatora_agel = 0;
            decimal visa_sum = 0;
            decimal kash_sum = 0;
            decimal dof3at = 0;
            decimal quick = 0;
            decimal mortag3at = 0;
            decimal syana = 0;
            decimal other_income = 0;

            safe_income_tableTableAdapter1.FillBy_fatra_far3(dataSet11.income_table, date_time_from_txt.Value.AddDays(1).ToShortDateString(), date_time_to_txt.Value.ToShortDateString(), far3_txt.Text);

            foreach (DataRow dr in dataSet11.income_table.Rows)
            // for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum_income += Convert.ToDecimal(dr["income_cost"]);


                try
                {
                     if (dr["income_source"].ToString().Contains("مرتجع"))
                    {
                        // MessageBox.Show("1");
                        mortag3at += Convert.ToDecimal(dr["income_cost"]);

                    }

                    else if (dr["income_source"].ToString().Contains("آجل"))
                    {
                        // MessageBox.Show("1");
                        visa_sum += Convert.ToDecimal(dr["income_cost"]);
                        sum_ba2y_fatora += Convert.ToDecimal(dr["ba2y_fatora"]);
                        sum_for_fatora_agel += visa_sum + sum_ba2y_fatora;

                    }

                    else if (dr["income_source"].ToString().Contains("دفعات"))
                    {
                        // MessageBox.Show("1");
                        dof3at += Convert.ToDecimal(dr["income_cost"]);

                    }

                    else if (dr["income_source"].ToString().Contains("عمليات"))
                    {
                        // MessageBox.Show("1");
                        quick += Convert.ToDecimal(dr["income_cost"]);

                    }

                    else if (dr["income_source"].ToString().Contains("كاش"))
                    {
                        kash_sum += Convert.ToDecimal(dr["income_cost"]);
                    }

                     else if (dr["income_source"].ToString().Contains("صيانة"))
                     {
                         // MessageBox.Show("1");
                         syana += Convert.ToDecimal(dr["income_cost"]);

                     }
                     else
                     {
                         other_income += Convert.ToDecimal(dr["income_cost"]);

                     }
                }
                catch { }

            }

            // MessageBox.Show(sum.ToString());



            ta2feel_crystal1.SetParameterValue("aksat", kash_sum);
            ta2feel_crystal1.SetParameterValue("gharamat", visa_sum);
            ta2feel_crystal1.SetParameterValue("est3lam", dof3at);
            ta2feel_crystal1.SetParameterValue("hesab_banky", quick);

            ta2feel_crystal1.SetParameterValue("sum_ba2y_fatora", sum_ba2y_fatora);
            ta2feel_crystal1.SetParameterValue("sum_for_fatora_agel", sum_for_fatora_agel);


            ta2feel_crystal1.SetParameterValue("far2_se3r", mortag3at);
            ta2feel_crystal1.SetParameterValue("syana_income", syana);
            ta2feel_crystal1.SetParameterValue("other_income", other_income);


            //   income_tableTableAdapter.FillBy_cst_code_far3_src_date(dataSet2.income_table, cst_code, far3_txt.Text, src, date);

            //  income_tableTableAdapter.Fill(dataSet2.income_table);


            decimal sum = 0;
            decimal mortabat = 0;
            decimal nathryat = 0;
            decimal pay_orders = 0;
            decimal dof3at_da2neen = 0;
            decimal buy_total = 0;
            decimal others = 0;

            safe_outcome_tableTableAdapter1.FillBy_fatra_far3(dataSet11.outcome_table, date_time_from_txt.Value.AddDays(1).ToShortDateString(), date_time_to_txt.Value.ToShortDateString(), far3_txt.Text);

            foreach (DataRow dr in dataSet11.outcome_table.Rows)
            {
                if (dr["outcome_source"].ToString().Contains("مرتبات"))
                {
                    mortabat += Convert.ToDecimal(dr["outcome_cost"]);
                }
                else if (dr["outcome_source"].ToString().Contains("نثريات"))
                {
                    nathryat += Convert.ToDecimal(dr["outcome_cost"]);
                }
                else if (dr["outcome_source"].ToString().Contains("ادارة"))
                {
                    pay_orders += Convert.ToDecimal(dr["outcome_cost"]);
                }
                else if (dr["outcome_source"].ToString().Contains("دفعات"))
                {
                    dof3at_da2neen += Convert.ToDecimal(dr["outcome_cost"]);
                }
                else if (dr["outcome_source"].ToString().Contains("شراء"))
                {
                    buy_total += Convert.ToDecimal(dr["outcome_cost"]);
                }
                else
                {
                    others += Convert.ToDecimal(dr["outcome_cost"]);
                }
            }

            ta2feel_crystal1.SetParameterValue("salary", mortabat);


            ta2feel_crystal1.SetParameterValue("nathryat", nathryat);

            ta2feel_crystal1.SetParameterValue("pay_orders", pay_orders);

            ta2feel_crystal1.SetParameterValue("dof3at_da2neen", dof3at_da2neen);

            ta2feel_crystal1.SetParameterValue("buy_total", buy_total);

            ta2feel_crystal1.SetParameterValue("others", others);


            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
            string printer_name = srr.ReadLine();


            ta2feel_crystal1.PrintOptions.PrinterName = printer_name;
            ta2feel_crystal1.PrintToPrinter(1, false, 0, 0);
            ta2feel_crystal1.Dispose();



            // daily_gard1.SetDataSource(dataSet11);
            //daily_gard1.Refresh();

            //madeen_small_reportTableAdapter1.FillBy_SUM_MADEEN(dataSet11.madeen_small_report);
            //daily_gard1.SetParameterValue("madeenen", dataSet11.madeen_small_report.Rows[0]["SUM_MADEEN"].ToString());

            //da2n_small_reportsTableAdapter1.FillBy_SUM_DA2N(dataSet11.da2n_small_reports);
            //daily_gard1.SetParameterValue("da2neen", dataSet11.da2n_small_reports.Rows[0]["SUM_DA2N"].ToString());


            //daily_gard1.SetParameterValue("1st_person", "السيد / " + first_person_txt.Text);
            //daily_gard1.SetParameterValue("2nd_person", "السيد / " + second_person_txt.Text);

            //daily_gard1.SetParameterValue("sabek", before_txt.Text);
            //daily_gard1.SetParameterValue("current", all_now_txt.Text);
            //daily_gard1.SetParameterValue("date_before", date_time_from_txt.Value.ToShortDateString());
            //string pic_param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
            //daily_gard1.SetParameterValue("test", pic_param);

            //try
            //{
            //    daily_gard1.SetParameterValue("200", dataGridView1.Rows[0].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("200", 0);
            //}
            //try
            //{
            //    daily_gard1.SetParameterValue("100", dataGridView1.Rows[1].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("100", 0);
            //}
            //try
            //{
            //    daily_gard1.SetParameterValue("50", dataGridView1.Rows[2].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("50", 0);
            //}
            //try
            //{
            //    daily_gard1.SetParameterValue("20", dataGridView1.Rows[3].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("20", 0);
            //}
            //try
            //{
            //    daily_gard1.SetParameterValue("10", dataGridView1.Rows[4].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("10", 0);
            //}
            //try
            //{
            //    daily_gard1.SetParameterValue("5", dataGridView1.Rows[5].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("5", 0);
            //}

            //try
            //{
            //    daily_gard1.SetParameterValue("1", dataGridView1.Rows[6].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("1", 0);
            //}
            //try
            //{
            //    daily_gard1.SetParameterValue("0.5", dataGridView1.Rows[7].Cells[1].Value.ToString());
            //}
            //catch
            //{
            //    daily_gard1.SetParameterValue("0.5", 0);
            //}




            //daily_gard1.PrintOptions.PrinterName = printer_name;
            //daily_gard1.PrintToPrinter(1, false, 0, 0);
            //daily_gard1.Dispose();


            ta2feel_tableTableAdapter1.Insert(date_time_to_txt.Value, Convert.ToDecimal(all_now_txt.Text));
            this.Close();

        }





        private void outcome_print() 
        {
            try
            {
                outcome_report1.Refresh();
                outcome_report1.SetDataSource(dataSet1);

                string param = "الصادر من الخزينة في الفترة من " + date_time_to_txt.Value.ToString("yyyy/MM/dd") + " إلى " + date_time_to_txt.Value.ToString("yyyy/MM/dd");

                outcome_report1.SetParameterValue("date_param", param);

            }
            catch
            {
                outcome_report1.Refresh();
                outcome_report1.SetDataSource(dataSet1);

                string param = "الصادر من الخزينة في الفترة من " + date_time_to_txt.Value.ToString("yyyy/MM/dd") + " إلى " + date_time_to_txt.Value.ToString("yyyy/MM/dd");


                outcome_report1.SetParameterValue("date_param", param);

            }


            safe_outcome_tableTableAdapter1.FillBy_fatra_far3(dataSet1.outcome_table, date_time_from_txt.Value.AddDays(1).ToShortDateString(), date_time_to_txt.Value.ToShortDateString(), far3_txt.Text);

            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\a4_printer.txt");
            string printer_name = srr.ReadLine();


            outcome_report1.PrintOptions.PrinterName = printer_name;
            outcome_report1.PrintToPrinter(1, false, 0, 0);

            outcome_report1.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void sum() 
        {
            decimal sum_masroof = 0;
           
            safe_outcome_tableTableAdapter1.FillBy_fatra_far3(dataSet11.outcome_table, date_time_from_txt.Value.AddDays(1).ToShortDateString(), date_time_to_txt.Value.ToShortDateString(), far3_txt.Text);

            foreach (DataRow dr in dataSet11.outcome_table.Rows)
            {
                sum_masroof += Convert.ToDecimal(dr["outcome_cost"]);
            }
          

            decimal sum_income = 0;

            safe_income_tableTableAdapter1.FillBy_fatra_far3(dataSet11.income_table, date_time_from_txt.Value.AddDays(1).ToShortDateString(), date_time_to_txt.Value.ToShortDateString(), far3_txt.Text);

            foreach (DataRow dr in dataSet11.income_table.Rows)
            {
                sum_income += Convert.ToDecimal(dr["income_cost"]);
            }

            decimal current = sum_income - sum_masroof;
            today_raseed_txt.Text = current.ToString();

        }

        private void ta2feel_Load(object sender, EventArgs e)
        {
            ta2feel_tableTableAdapter1.FillBy_LAST_TA2FEEL(dataSet11.ta2feel_table);

            if (Convert.ToDateTime(dataSet11.ta2feel_table.Rows[0]["ta2feel_date"]).ToShortDateString() == DateTime.Today.ToShortDateString())
            {
                DialogResult d = MessageBox.Show("تم تقفيل هذا اليوم مسبقا . هل تريد الغاء التقفيل السابق ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    ta2feel_tableTableAdapter1.Delete_by_date(Convert.ToDateTime(dataSet11.ta2feel_table.Rows[0]["ta2feel_date"]).ToShortDateString());
                    ta2feel_tableTableAdapter1.FillBy_LAST_TA2FEEL(dataSet11.ta2feel_table);
                }
                else
                {
                    this.Close();
                }

            }
            if (dataSet11.ta2feel_table.Rows.Count > 0)
            {
                try
                {
                    before_txt.Text = dataSet11.ta2feel_table.Rows[0]["ta2feel_amount"].ToString();
                }
                catch
                {
                    before_txt.Text = "0";
                }
                date_time_to_txt.Value = DateTime.Today;
                date_time_from_txt.Value = Convert.ToDateTime(dataSet11.ta2feel_table.Rows[0]["ta2feel_date"]);
            }
            sum();

            dataGridView1.Rows.Add("200");
            dataGridView1.Rows.Add("100");
            dataGridView1.Rows.Add("50");
            dataGridView1.Rows.Add("20");
            dataGridView1.Rows.Add("10");
            dataGridView1.Rows.Add("5");
            dataGridView1.Rows.Add("1");
            dataGridView1.Rows.Add("0.5");

            //emp_tableTableAdapter1.FillBy_job_and_far3(dataSet11.emp_table,"مدير الفرع",far3_txt.Text);
            //try
            //{
            //    first_person_txt.Text = dataSet11.emp_table.Rows[0]["emp_name"].ToString();
            //}
            //catch { }

            //emp_tableTableAdapter1.FillBy_job_and_far3(dataSet11.emp_table, "محاسب", far3_txt.Text);
            //try
            //{
            //    second_person_txt.Text = dataSet11.emp_table.Rows[0]["emp_name"].ToString();
            //}
            //catch { }

            before_txt_TextChanged(sender, e);

        }

        private void suggest()
        {
            //try
            //{
            //    this.emp_tableTableAdapter1.Fill(this.dataSet11.emp_table);
            //    first_person_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            //    first_person_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //    second_person_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            //    second_person_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();
            //    foreach (DataRow dr in dataSet11.emp_table.Rows)
            //    {
            //        DataCollection1.Add(dr["emp_name"].ToString());
            //    }

            //    first_person_txt.AutoCompleteCustomSource = DataCollection1;
            //    second_person_txt.AutoCompleteCustomSource = DataCollection1;
            //}
            //catch { }
        }

        private void before_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                all_now_txt.Text = (Convert.ToDecimal(before_txt.Text) + Convert.ToDecimal(today_raseed_txt.Text)).ToString();

            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                {
                    dgr.Cells[2].Value = (Convert.ToDecimal(dgr.Cells[0].Value) * Convert.ToDecimal(dgr.Cells[1].Value)).ToString();
                }


                decimal tafkeet_sum = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    tafkeet_sum += Convert.ToDecimal(dgr.Cells[2].Value);

                }

                textBox1.Text = tafkeet_sum.ToString();
            }
            catch { }
        }
    }
}
