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
    public partial class syana_fatora : Form
    {
        public syana_fatora()
        {
            InitializeComponent();
            recieve_date.Value = DateTime.Today;
            deliver_date.Value = DateTime.Today;

        }

        private void suggest_cst_name()
        {
            this.customersTableAdapter1.FillBy_notes(this.dataSet1.customers, "عميل صيانة");
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.customers.Rows)
            {
                DataCollection.Add(dr["cst_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void suggest_syana_type()
        {
            syana_tableTableAdapter.Fill(dataSet1.syana_table);
            foreach (DataRow dr in dataSet1.syana_table.Rows) 
            {
                if (syana_type_txt.Items.Contains(dr["syana_type"].ToString()))
                {
                }
                else
                { 
                  syana_type_txt.Items.Add(dr["syana_type"].ToString());
                }
            }
        }
        private void syana_fatora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.syana_table' table. You can move, or remove it, as needed.
            this.syana_tableTableAdapter.Fill(this.dataSet1.syana_table);
            try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet1.Numbers_table,far3txt.Text);
                salesID_TXT.Text = dataSet1.Numbers_table.Rows[0]["syana_ID"].ToString();
            }
            catch { }

            suggest_cst_name();
            suggest_syana_type();

        }


        private void check_customer()
        {
            customersTableAdapter1.FillBy_name(dataSet1.customers, cst_nameTXT.Text);
            if (dataSet1.customers.Rows.Count <= 0)
            {
                customersTableAdapter1.Insert(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, "عميل صيانة", "","","","");
            }
            else
            {
                int id = Convert.ToInt32(dataSet1.customers.Rows[0]["cst_ID"]);
                customersTableAdapter1.Update_cst_by_id(cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, "عميل صيانة", "", id);
            }


        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (syana_type_txt.Text == "") 
            {
                MessageBox.Show("اختر نوع الصيانة");
                return;
            }
            try
            {
                check_customer();

                syana_tableTableAdapter.Insert(Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, cst_phoneTXT.Text, cst_addressTXT.Text, recieve_date.Value, deliver_date.Value,
                    device_type_txt.Text, problem_txt.Text, mol7kat_txt.Text, "", 0, Convert.ToDecimal(cost_txt.Text), Convert.ToDecimal(paid_txt.Text), notes_txt.Text, "قيد الاصلاح",
                    usertxt.Text, far3txt.Text, "",syana_type_txt.Text);


                income_tableTableAdapter1.Insert_income(recieve_date.Value.ToShortDateString(), "مبلغ من فاتورة صيانة رقم " + salesID_TXT.Text, Convert.ToDecimal(paid_txt.Text),
                    Convert.ToInt32(salesID_TXT.Text), "صيانة", cst_nameTXT.Text, usertxt.Text, notes_txt.Text, far3txt.Text,Convert.ToDecimal(cost_txt.Text)-Convert.ToDecimal(paid_txt.Text));


           decimal     income_cost = Convert.ToDecimal(paid_txt.Text);
                safeTableAdapter1.Update_add_to_safe(income_cost);


                //safe status daily
                safeTableAdapter1.Insert_safe(deliver_date.Value.ToShortDateString(), income_cost);
                numbers_tableTableAdapter1.Update_syana_id(far3txt.Text);

                DialogResult re = MessageBox.Show("تم استلام الجهاز بنجاح , هل تريد طباعة الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes) 
                {
                    pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                    estlam_syana_report1.Refresh();
                    estlam_syana_report1.SetDataSource(dataSet1);

                    string param;
                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    estlam_syana_report1.SetParameterValue("test", param);

                  syana_tableTableAdapter.FillBy_syana_no(dataSet1.syana_table,Convert.ToInt32(salesID_TXT.Text));


                  StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                  string printer_name = srr.ReadLine();

                    estlam_syana_report1.PrintOptions.PrinterName = printer_name;
                    estlam_syana_report1.PrintToPrinter(1, false, 0, 0);
                   // estlam_syana_report1.Dispose();

                    DialogResult ree = MessageBox.Show("تم استلام الجهاز بنجاح , هل تريد طباعة نسخه اخرى", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ree == DialogResult.Yes)
                    {
                        Thread.Sleep(500);
                        pharmacy_dataTableAdapter1.Fill(dataSet1.pharmacy_data);

                        estlam_syana_report1.Refresh();
                        estlam_syana_report1.SetDataSource(dataSet1);


                        estlam_syana_report1.SetParameterValue("test", param);

                        syana_tableTableAdapter.FillBy_syana_no(dataSet1.syana_table, Convert.ToInt32(salesID_TXT.Text));

                       // MessageBox.Show("aaa");
                     
                        estlam_syana_report1.PrintOptions.PrinterName = printer_name;
                        estlam_syana_report1.PrintToPrinter(1, false, 0, 0);
                        estlam_syana_report1.Dispose();


                    }
                }

               
            }
            catch { }

            this.Close();
        }

        private void paid_txt_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = savebtn;
        }
    }
}
