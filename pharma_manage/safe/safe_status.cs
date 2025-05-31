using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


using Spire.Email;
using Spire.Email.IMap;
using Spire.Email.Smtp;

using System.Net;


namespace pharma_manage
{
    public partial class safe_status : Form
    {
        public safe_status()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
         
        }
        bool TimeBetween(DateTime datetime, TimeSpan start, TimeSpan end)
        {
            // convert datetime to a TimeSpan
            TimeSpan now = datetime.TimeOfDay;
            // see if start comes before end
            if (start < end)
                return start <= now && now <= end;
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }


        public void check_date(DateTimePicker dtp)
        {
            // MessageBox.Show("aa");
            dtp.Value = DateTime.Today;
            //   MessageBox.Show(DateTime.Now.ToString());
            TimeSpan now = DateTime.Now.TimeOfDay;
            // MessageBox.Show(now.ToString());
            TimeSpan start = new TimeSpan(00, 00, 00);
            //   MessageBox.Show(start.ToString());

            string day_end;
            StreamReader srDayEnd = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\day_end");
            day_end = srDayEnd.ReadLine();
            srDayEnd.Dispose();

            TimeSpan end = TimeSpan.Parse(day_end);
            // TimeSpan end = new TimeSpan(05, 30, 00);
            // MessageBox.Show(end.ToString());

            bool silenceAlarm = TimeBetween(DateTime.Now, start, end);

            if (silenceAlarm == true)
            {
              //  MessageBox.Show("true");
                dtp.Value = DateTime.Today.AddDays(-1);
                // notes.Text = "بعد منتصف الليل";
            }
            else
            {
              //  MessageBox.Show("false");
                dtp.Value = DateTime.Today;
                //  notes.Text = "";
            }

        }
        private void safe_status_Load(object sender, EventArgs e)
        {
            check_date(dateTimePicker1);
            check_date(dateTimePicker2);
            // TODO: This line of code loads data into the 'dataSet11.user_previliges' table. You can move, or remove it, as needed.
            this.user_previligesTableAdapter.Fill(this.dataSet11.user_previliges);
           
            foreach (DataRow dr in dataSet11.user_previliges.Rows)
            {
                if (user_comboBox1.Items.Contains(dr["user_name"].ToString())) 
                {
                }
                else
                {
                    user_comboBox1.Items.Add(dr["user_name"].ToString());
                }
            }
            user_comboBox1.Text = usertxt.Text;
            user_previligesTableAdapter.FillBy_name(dataSet11.user_previliges, usertxt.Text);
            foreach (DataRow dr in dataSet11.user_previliges.Rows)
            {
                user_listbox.Items.Add(dr["user_previliges"].ToString());

            }
            if (user_listbox.Items.Contains("إضافة مستخدم"))
            {
                //dataGridView1.Columns[2].Visible = true;
                //label13.Visible = true;
                //raseed_txt.Visible = true;
                //button3.Visible = true;

                decimal total_income = 0;
                income_tableTableAdapter1.FillBy_income_total(dataSet11.income_table);
                try
                {
                    total_income = Convert.ToDecimal(dataSet11.income_table.Rows[0]["income_total"]);
                }
                catch
                {


                }

                decimal total_outcome = 0;

                try
                {
                    outcome_tableTableAdapter1.FillBy_outcome_total(dataSet11.outcome_table);
                    total_outcome = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["outcome_total"]);
                }
                catch { }
                safe_raseed.Text = (total_income - total_outcome).ToString();
            }
            else
            {

                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                user_comboBox1.Enabled = false;

                dateTimePicker1.MinDate = DateTime.Now.AddDays(-6);
                dateTimePicker1.MaxDate = DateTime.Now;

                dateTimePicker2.MinDate = DateTime.Now.AddDays(-6);
                dateTimePicker2.MaxDate = DateTime.Now;

                //label13.Visible = false;
                //raseed_txt.Visible = false;
                //button3.Visible = false;

            }

            stock_tableTableAdapter.Fill(dataSet11.stock_table);
            foreach (DataRow dr in dataSet11.stock_table.Rows) 
            {
                listBox1.Items.Add(dr["stock_name"].ToString());
            }
            //far3_txt.Text = dataSet11.stock_table.Rows[0]["stock_name"].ToString();
            dateTimePicker2_ValueChanged(sender, e);

            //try
            //{
            //    ras_mal_productsTableAdapter1.FillBy_date(dataSet11.ras_mal_products, DateTime.Today.ToShortDateString());
            //    ras_mal_7aly_txt.Text = (Convert.ToDecimal(dataSet11.ras_mal_products.Rows[0]["egmaly_ras_mal"]) - Convert.ToDecimal(da2neen_txt.Text)).ToString();
            //}
            //catch { }

           

        }




      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        string arba7_total;
        string nathryat;
        string wared;
        string sader;
        string safe_current;
        string safy_arba7;
        string start_pro;
        string end_pro;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listBox1.Items)
            {
               
                //arba7 
                try
                {

                    ras_mal_productsTableAdapter1.FillBy_date_far3(dataSet11.ras_mal_products, dateTimePicker1.Value.ToShortDateString(), item.ToString());
                    start_pro = dataSet11.ras_mal_products.Rows[0]["ras_mal_products_cost"].ToString();

                    ras_mal_productsTableAdapter1.FillBy_last_record(dataSet11.ras_mal_products, item.ToString());
                    end_pro = dataSet11.ras_mal_products.Rows[0]["ras_mal_products_cost"].ToString();
                }
                catch { }
                try
                {
                    this.arba7_tableTableAdapter1.FillBy_fatra_stock(dataSet11.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString());

                    decimal sum = 0;

                    for (int i = 0; i < dataSet11.arba7_table.Rows.Count; ++i)
                    {
                        decimal profit = Convert.ToDecimal(dataSet11.arba7_table.Rows[i]["arba7_cost"]);
                        sum += profit;
                    }
                    arba7_total = Convert.ToString(sum.ToString("0.00"));

                }
                catch { }

                //nathryat
                if (user_comboBox1.Text == "")
                {
                    outcome_tableTableAdapter1.FillBy_TOTAL_in_fatra_far3(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString());
                }
                else 
                {
                    outcome_tableTableAdapter1.FillBy_TOTAL_in_fatra_far3_user(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString(),user_comboBox1.Text);
               
                }
                try
                {
                    nathryat = dataSet11.outcome_table.Rows[0]["TOTAL"].ToString();

                    if (nathryat == "")
                    {
                        nathryat = "0";
                    }
                }
                catch { }

                try
                {
                    safy_arba7 = (Convert.ToDecimal(arba7_total) - Convert.ToDecimal(nathryat)).ToString();
                }
                catch { }

                //income
                try
                {
                    if (user_comboBox1.Text == "")
                    {
                        income_tableTableAdapter1.FillBy_fatra_far3(dataSet11.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString());
                    }
                    else
                    {
                        income_tableTableAdapter1.FillBy_user_in_fatra(dataSet11.income_table,user_comboBox1.Text,dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString());
                    }
                    decimal sum = 0;
                    for (int i = 0; i < dataSet11.income_table.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataSet11.income_table.Rows[i]["income_cost"]);
                    }
                    wared = Convert.ToString(sum.ToString("0.00"));

                }
                catch { }

             

                //outcome
                try
                {
                    if (user_comboBox1.Text == "")
                    {
                        outcome_tableTableAdapter1.FillBy_fatra_far3(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString());
                    }
                    else
                    {
                        outcome_tableTableAdapter1.FillBy_user_in_fatra_far3(dataSet11.outcome_table, user_comboBox1.Text,dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), item.ToString());
                    }
                    decimal sum = 0;
                    //  decimal sum_nathryat = 0;
                    for (int i = 0; i < dataSet11.outcome_table.Rows.Count; ++i)
                    {
                        sum += Convert.ToDecimal(dataSet11.outcome_table.Rows[i]["outcome_cost"]);



                    }
                    sader= Convert.ToString(sum.ToString("0.00"));


                }
                catch { }


               
                try
                {
                    if (user_comboBox1.Text == "")
                    {
                        income_tableTableAdapter1.FillBy_income_total_by_far3(dataSet11.income_table, item.ToString());
                    }
                    else
                    {
                        income_tableTableAdapter1.FillBy_income_total_by_far3_user(dataSet11.income_table, item.ToString(),user_comboBox1.Text);
                    }
                    decimal total_income = Convert.ToDecimal(dataSet11.income_table.Rows[0]["income_total"]);

                    outcome_tableTableAdapter1.FillBy_outcome_total_by_far3(dataSet11.outcome_table,item.ToString());
                    decimal total_outcome = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["outcome_total"]);

                    safe_current = (total_income - total_outcome).ToString();
                }
                catch { }

                string safy=(Convert.ToDecimal(wared)-Convert.ToDecimal(sader)).ToString();
                string pro_far2 = (Convert.ToDecimal(end_pro) - Convert.ToDecimal(start_pro)).ToString();
                string reb7_after_all;
                //if (Convert.ToDecimal(pro_far2) >= 0)
                //{
                    reb7_after_all = (Convert.ToDecimal(safy_arba7) - Convert.ToDecimal(pro_far2)).ToString();

                //}
                //else 
                //{
                //    reb7_after_all = (Convert.ToDecimal(safy_arba7)).ToString();
                //    pro_far2 = "0";

                //}
                dataGridView1.Rows.Add(item.ToString(), wared, sader, safy, arba7_total, nathryat, safy_arba7,start_pro,end_pro,pro_far2,reb7_after_all);
            }

            decimal sum_wared=0; decimal sum_sader=0; decimal sum_safy=0; decimal sum_arba7_total=0; decimal sum_nathryat=0; decimal sum_safy_arba7=0; decimal sum_start_pro=0;
            decimal sum_end_pro=0; decimal sum_pro_far2=0; decimal sum_reb7_after_all=0;

            string name = "الاجمالي";
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
              
                sum_wared += Convert.ToDecimal(dgr.Cells[1].Value);
                sum_sader += Convert.ToDecimal(dgr.Cells[2].Value);
                sum_safy += Convert.ToDecimal(dgr.Cells[3].Value);
                sum_arba7_total += Convert.ToDecimal(dgr.Cells[4].Value);
                sum_nathryat += Convert.ToDecimal(dgr.Cells[5].Value);
                sum_safy_arba7 += Convert.ToDecimal(dgr.Cells[6].Value);
                sum_start_pro += Convert.ToDecimal(dgr.Cells[7].Value);
                sum_end_pro += Convert.ToDecimal(dgr.Cells[8].Value);
                sum_pro_far2 += Convert.ToDecimal(dgr.Cells[9].Value);
                sum_reb7_after_all += Convert.ToDecimal(dgr.Cells[10].Value);
            }
            dataGridView1.Rows.Add(name, sum_wared, sum_sader, sum_safy, sum_arba7_total, sum_nathryat, sum_safy_arba7, sum_start_pro, sum_end_pro, sum_pro_far2, sum_reb7_after_all);
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////safy
            //try
            //{
            //    safytxt.Text = (Convert.ToDecimal(wared_txt.Text) - Convert.ToDecimal(sader_txt.Text)).ToString();
            //}
            //catch { }

            ////colors
            //try
            //{
            //    if (Convert.ToDecimal(safytxt.Text) <= 0)
            //    {
            //        safytxt.ForeColor = Color.Red;
            //    }
            //    else
            //    {
            //        safytxt.ForeColor = Color.Green;
            //    }
            //}
            //catch { }
        }

        private void chart_btn_Click(object sender, EventArgs e)
        {
            //chart_form c = new chart_form();
            //c.dateTimePicker1.Value = dateTimePicker1.Value;
            //c.dateTimePicker2.Value = dateTimePicker2.Value;
            //c.far3txt.Text = far3_txt.Text;
            //c.ShowDialog();
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void far3_txt_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void user_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void user_comboBox1_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker2_ValueChanged(sender, e);
        }
        string title;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                string param;


                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

                //string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\CrystalReport1.rpt";
              //  CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                //doc.Load(path);
              //  doc = wardia_CrystalReport1;
                // MessageBox.Show(printer_name);
                try
                {
                    wardia_CrystalReport1.Refresh();
                    wardia_CrystalReport1.SetDataSource(dataSet11);
                }
                catch
                {
                    wardia_CrystalReport1.Refresh();
                    wardia_CrystalReport1.SetDataSource(dataSet11);
                }

                // crystalReport11.PrintOptions.PrinterName = "BIXOLON SRP-350II";
                //  crystalReport11.PrintToPrinter(1, false, 0, 0);
                if (user_comboBox1.Text == "")
                {
                    title = "تقرير يوم " + dateTimePicker1.Value.ToShortDateString();
                }
                else
                {
                    title = "تقرير يوم " + dateTimePicker1.Value.ToShortDateString() + " للمستخدم " + user_comboBox1.Text;
                }
               string wared_txt= dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value.ToString();
               string sader_txt = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value.ToString();
               wardia_CrystalReport1.SetParameterValue("test", param);
               wardia_CrystalReport1.SetParameterValue("title_param", title);
               wardia_CrystalReport1.SetParameterValue("income_param", wared_txt);
               wardia_CrystalReport1.SetParameterValue("outcome_param", sader_txt);

               wardia_CrystalReport1.PrintOptions.PrinterName = printer_name;
               wardia_CrystalReport1.PrintToPrinter(1, false, 0, 0);
               wardia_CrystalReport1.Dispose();
               wardia_CrystalReport1.Close();
               wardia_CrystalReport1.Refresh();
                //CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions p = new CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions();
                //wardia_CrystalReport1.PrintOptions.PrinterName = printer_name;
                //wardia_CrystalReport1.ReportClientDocument.PrintOutputController.PrintReport(p);
            }
            catch { }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                string printer_name = srr.ReadLine();

                string param;


                param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);

                //string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\CrystalReport1.rpt";
                //CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                ////doc.Load(path);
                //doc = wardia_CrystalReport1;
                // MessageBox.Show(printer_name);
                try
                {
                    wardia_CrystalReport1.Refresh();
                    wardia_CrystalReport1.SetDataSource(dataSet11);
                }
                catch
                {
                    wardia_CrystalReport1.Refresh();
                    wardia_CrystalReport1.SetDataSource(dataSet11);
                }

                // crystalReport11.PrintOptions.PrinterName = "BIXOLON SRP-350II";
                //  crystalReport11.PrintToPrinter(1, false, 0, 0);
                if (user_comboBox1.Text == "")
                {
                    title = "تقرير يوم " + dateTimePicker1.Value.ToShortDateString();
                }
                else
                {
                    title = "تقرير يوم " + dateTimePicker1.Value.ToShortDateString() + " للمستخدم " + user_comboBox1.Text;
                }
                string wared_txt = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value.ToString();
                string sader_txt = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value.ToString();
                wardia_CrystalReport1.SetParameterValue("test", param);
                wardia_CrystalReport1.SetParameterValue("title_param", title);
                wardia_CrystalReport1.SetParameterValue("income_param", wared_txt);
                wardia_CrystalReport1.SetParameterValue("outcome_param", sader_txt);


                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "PDF (*.pdf)|*.pdf";
                title = title.Replace("/", "-"); sf.FileName = title;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    FileInfo path_file = new FileInfo(sf.FileName);
                    string name = sf.FileName;
                  

                    //MessageBox.Show(name);
                    wardia_CrystalReport1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                    System.Diagnostics.Process.Start(path_file.ToString());
                }

                //CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions p = new CrystalDecisions.ReportAppServer.Controllers.PrintReportOptions();
                //doc.PrintOptions.PrinterName = printer_name;
                //doc.ReportClientDocument.PrintOutputController.PrintReport(p);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string old_user = user_comboBox1.Text;
            user_comboBox1.Text = "";
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[0].Value.ToString() != "الاجمالي")
                {
                    string param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    string title = "تقرير عن الفترة من " + dateTimePicker1.Value.ToShortDateString() + " الى " + dateTimePicker2.Value.ToShortDateString();

                
                 

                    //string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\CrystalReport1.rpt";
                    //CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    ////doc.Load(path);
                    //doc = final_report_tst1;

                    try
                    {
                        final_report_tst1.Refresh();
                        final_report_tst1.SetDataSource(dataSet11);
                    }
                    catch
                    {
                        final_report_tst1.Refresh();
                        final_report_tst1.SetDataSource(dataSet11);
                    }

                    final_report_tst1.SetParameterValue("title", title);
                    final_report_tst1.SetParameterValue("test", param);

                    sales_tableTableAdapter1.FillBy_SALES_TOTAL_fatra_far3(dataSet11.sales_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dgr.Cells[0].Value.ToString());
                      decimal SALES_TOTAL=0;
                      try
                      {
                          SALES_TOTAL = Convert.ToDecimal(dataSet11.sales_table.Rows[0]["SALES_TOTAL"]);
                      }
                      catch { }

                    purchases_tableTableAdapter1.FillBy_fatra_TOTAL_PURCHASES(dataSet11.Purchases_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dgr.Cells[0].Value.ToString());
                    decimal TOTAL_PURCHASES = 0;
                    try
                    {
                        TOTAL_PURCHASES = Convert.ToDecimal(dataSet11.Purchases_table.Rows[0]["TOTAL_PURCHASES"]);
                    }
                    catch { }

                    madeen_small_reportTableAdapter1.FillBy_TOTAL_MADEEN(dataSet11.madeen_small_report);
                    decimal TOTAL_MADEEN = 0;
                    try
                    {
                        TOTAL_MADEEN = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["TOTAL_MADEEN"]);
                    }
                    catch { }

                    da2n_small_reportsTableAdapter1.FillBy_TOTAL_DA2N(dataSet11.da2n_small_reports);
                    decimal TOTAL_DA2N = 0;
                    try
                    {
                        TOTAL_DA2N = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["TOTAL_DA2N"]);
                    }
                    catch { }

                    products_tableTableAdapter1.FillBy_TOTAL_PRODUCTS_stock(dataSet11.products_table, dgr.Cells[0].Value.ToString());
                    decimal TOTAL_PRODUCTS = 0;
                    try
                    {
                        TOTAL_PRODUCTS = Convert.ToDecimal(dataSet11.products_table.Rows[0]["TOTAL_PRODUCTS"]);
                    }
                    catch { }

                    assets_tableTableAdapter1.FillBy_TOTAL_ASSETS_FATRA(dataSet11.assets_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    decimal TOTAL_ASSETS = 0;
                    try
                    {
                         TOTAL_ASSETS = Convert.ToDecimal(dataSet11.assets_table.Rows[0]["TOTAL_ASSETS"]);
                    }catch{}

                    arba7_tableTableAdapter1.FillBy_TOTAL_ARBA7_FATRA_FAR3(dataSet11.arba7_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dgr.Cells[0].Value.ToString());
                    decimal TOTAL_ARBA7 = 0;
                    try
                    {
                        TOTAL_ARBA7 = Convert.ToDecimal(dataSet11.arba7_table.Rows[0]["TOTAL_ARBA7"]);
                    }
                    catch { }

                    income_tableTableAdapter1.FillBy_TOTAL_INCOME_FATRA_FAR3(dataSet11.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dgr.Cells[0].Value.ToString());
                    decimal TOTAL_INCOME = 0;
                    try
                    {
                        TOTAL_INCOME = Convert.ToDecimal(dataSet11.income_table.Rows[0]["TOTAL_INCOME"]);
                    }
                    catch { }


                    outcome_tableTableAdapter1.FillBy_TOTAL_OUTCOME_ALL_FATRA_FAR3(dataSet11.outcome_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), dgr.Cells[0].Value.ToString());
                    decimal TOTAL_OUTCOME_ALL = 0;
                    try
                    {
                        TOTAL_OUTCOME_ALL = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["TOTAL_OUTCOME_ALL"]);
                    }
                    catch { }


                    decimal outcome_nathryat = Convert.ToDecimal(dgr.Cells[5].Value.ToString());
                    
                    decimal arba7_after_masrofat = Convert.ToDecimal(dgr.Cells[6].Value.ToString());
                   
                    decimal pro_start = Convert.ToDecimal(dgr.Cells[7].Value.ToString());
                    
                    decimal pro_end = Convert.ToDecimal(dgr.Cells[8].Value.ToString());
                   
                    decimal pro_far2 = Convert.ToDecimal(dgr.Cells[9].Value.ToString());
                    
                    decimal final_reb7 = Convert.ToDecimal(dgr.Cells[10].Value.ToString());

                    
                    mas7obat_tableTableAdapter1.FillBy_TOTAL_MAS7OBAT_in_fatra(dataSet11.mas7obat_table,dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

                    decimal TOTAL_MAS7OBAT=0;
                    try
                    {
                        TOTAL_MAS7OBAT = Convert.ToDecimal(dataSet11.mas7obat_table.Rows[0]["TOTAL_MAS7OBAT"]);
                    }
                    catch { }
                    final_report_tableTableAdapter1.Insert(DateTime.Today, dgr.Cells[0].Value.ToString(), SALES_TOTAL, TOTAL_PURCHASES, TOTAL_MADEEN, TOTAL_DA2N, TOTAL_PRODUCTS,
                        TOTAL_ASSETS, TOTAL_ARBA7, TOTAL_INCOME, TOTAL_OUTCOME_ALL, outcome_nathryat, arba7_after_masrofat, pro_start, pro_end, pro_far2, final_reb7, usertxt.Text, TOTAL_MAS7OBAT);


                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                    final_report_tableTableAdapter1.FillBy_last_one(dataSet11.final_report_table);

                    SaveFileDialog sf = new SaveFileDialog();
                    sf.Filter = "PDF (*.pdf)|*.pdf";
                    title = title.Replace("/", "-"); sf.FileName = title;
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo path_file = new FileInfo(sf.FileName);
                        string name = sf.FileName;


                        //MessageBox.Show(name);
                        final_report_tst1.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path_file.ToString());
                        System.Diagnostics.Process.Start(path_file.ToString());
                        final_report_tst1.Close();
                        final_report_tst1.Dispose();

                        string mail = "";
                        string sender_mail = "";
                        string sender_password = "";
                        pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                        try
                        {
                            mail = dataSet11.pharmacy_data.Rows[0]["pharmacy_mail"].ToString();
                            sender_mail = dataSet11.pharmacy_data.Rows[0]["pharmacy_sender_mail"].ToString();
                            sender_password = dataSet11.pharmacy_data.Rows[0]["pharmacy_sender_password"].ToString();
                        }
                        catch { }

                        if (mail != "" && sender_mail != "" && sender_password != "")
                        {

                            DialogResult re = MessageBox.Show("هل تريد ارسال التقرير للميل ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (re == DialogResult.Yes)
                            {
                                try
                                {



                                    MailAddress addressFrom = "midoahly9@outlook.com";
                                    MailAddress addressTo = mail;
                                    // MailAddress adressCC = "Shawn_Smithhh@outlook.com";

                                    MailMessage message = new MailMessage(addressFrom, addressTo);

                                    message.Subject = title + " " + dgr.Cells[0].Value.ToString();
                                    message.BodyText = title + " " + dgr.Cells[0].Value.ToString();
                                    message.Date = DateTime.Now;

                                    message.Attachments.Add(new Attachment(sf.FileName));
                                    // message.Cc.Add(adressCC.Address);

                                    SmtpClient smtp = new SmtpClient();
                                    smtp.Host = "smtp.outlook.com";
                                    smtp.ConnectionProtocols = ConnectionProtocols.Ssl;
                                    smtp.Username = addressFrom.Address;
                                    smtp.Password = "ahmed2010";
                                    smtp.Port = 587;
                                    //  smtp.TimeOut = 60;

                                    smtp.SendOne(message);
                                    MessageBox.Show("تم ارسال التقرير بنجاح");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                }
            }

            user_comboBox1.Text = old_user;
        }
    }
}
