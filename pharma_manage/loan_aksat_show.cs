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
    public partial class loan_aksat_show : Form
    {
        public loan_aksat_show()
        {
            InitializeComponent();
        }
        private List<string> GetUniqueCustomerNamesInTableOrder()
        {
            var seen = new HashSet<string>();
            var result = new List<string>();
            aksat_tableTableAdapter1.FillBy_far3(dataSet11.aksat_table, far3_txt.Text);
            foreach (DataRow row in dataSet11.aksat_table.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    string name = row["kest_cst_name"].ToString().Trim();

                    if (!string.IsNullOrEmpty(name) && !seen.Contains(name))
                    {
                        seen.Add(name);
                        result.Add(name);
                    }
                }
            }

            return result;
        }

        private void loan_aksat_show_Load(object sender, EventArgs e)
        {
          // loans_requests_tableTableAdapter1.Update_fatora_num_null();
            loans_requests_tableTableAdapter1.FillBy_if_fatora_null(dataSet11.loans_requests_table);
            foreach (DataRow dr in dataSet11.loans_requests_table.Rows)
            {
                try
                {
                    int id = Convert.ToInt32(dr["loan_id"]);
                    DateTime loan_date = Convert.ToDateTime(dr["loan_sarf_date"]);
                    decimal loan_amount = Convert.ToDecimal(dr["loan_amount"]);
                    string far3_in = dr["loan_far3"].ToString();
                    string cst_name = dr["loan_cst_name"].ToString();
                    sales_tableTableAdapter1.FillBy_for_loan_fatora(dataSet11.sales_table, loan_date.ToShortDateString(), cst_name, loan_amount, far3_in);
                    if (dataSet11.sales_table.Rows.Count > 0)
                    {
                        int sales_num = Convert.ToInt32(dataSet11.sales_table.Rows[0]["sales_id"]);

                        //  MessageBox.Show(
                        loans_requests_tableTableAdapter1.Update_fatora_num_by_id(sales_num, id);
                    }
                }
                catch
                {
                    //string cst_name = dr["loan_cst_name"].ToString();
                    //MessageBox.Show(cst_name);

                }
            }

            //dataSet11.Clear();
          
            if (user_txt.Text != "admin")
            {
                user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, user_txt.Text);

                ListBox listbox_users = new ListBox() ;

                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {

                    listbox_users.Items.Add(dr["user_previliges"].ToString());

                }
                if (listbox_users.Items.Contains("إضافة مستخدم"))
                {
                    label4.Visible = true;
                    label5.Visible = true;
                    taklefa_txt.Visible = true;
                    reb7_txt.Visible = true;

                }
            }
            aksat_tableTableAdapter1.FillBy_far3(dataSet11.aksat_table, far3_txt.Text);//, substringAutoCompleteTextBox1.TextBox_.Text);

            if (substringAutoCompleteTextBox1.TextBox_.Text != "") 
            {
                try
                {
                    dataSet11.Clear();
                    customers_tableTableAdapter1.Fill(dataSet11.customers);
                    try
                    {
                        crystalReportViewer1.Visible = true;
                        groupBox1.Visible = true;
                        aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);

                        string kest_loan_code = dataSet11.aksat_table.Rows[0]["kest_loan_code"].ToString();
                        // loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, kest_loan_code, far3_txt.Text);

                        string damen_for_test = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();

                        byan_7ala_tableTableAdapter1.FillBy_loan_code(dataSet11.byan_7ala_table, kest_loan_code);

                        aksat_show_for_all_report1.SetDataSource(dataSet11);
                        aksat_show_for_all_report1.Refresh();
                        crystalReportViewer1.RefreshReport();
                        try
                        {
                            int fatora_num = Convert.ToInt32(dataSet11.byan_7ala_table.Rows[0]["fatora_num"]);
                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, fatora_num, far3_txt.Text);

                            mo2dema_txt.Text = dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();
                            nesba_txt.Text = dataSet11.byan_7ala_table.Rows[0]["loan_notes"].ToString();
                            reb7_txt.Text = dataSet11.byan_7ala_table.Rows[0]["arba7_cost"].ToString();
                            taklefa_txt.Text = dataSet11.byan_7ala_table.Rows[0]["takelfa_fatora"].ToString();
                        }
                        catch { }
                    }
                    catch
                    {
                        crystalReportViewer1.Visible = true;
                        aksat_tableTableAdapter1.FillBy_kest_cst_name_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text, far3_txt.Text);

                        string kest_loan_code = dataSet11.aksat_table.Rows[0]["kest_loan_code"].ToString();
                        // loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, kest_loan_code, far3_txt.Text);
                        byan_7ala_tableTableAdapter1.FillBy_loan_code(dataSet11.byan_7ala_table, kest_loan_code);
                        string damen_for_test = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                        aksat_show_for_all_report1.SetDataSource(dataSet11);
                        aksat_show_for_all_report1.Refresh();
                        crystalReportViewer1.RefreshReport();

                        try
                        {
                            int fatora_num = Convert.ToInt32(dataSet11.byan_7ala_table.Rows[0]["fatora_num"]);
                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, fatora_num, far3_txt.Text);

                            mo2dema_txt.Text = dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();

                            nesba_txt.Text = dataSet11.byan_7ala_table.Rows[0]["loan_notes"].ToString();
                            reb7_txt.Text = dataSet11.byan_7ala_table.Rows[0]["arba7_cost"].ToString();
                            taklefa_txt.Text = dataSet11.byan_7ala_table.Rows[0]["takelfa_fatora"].ToString();
                        }
                        catch { }
                    }
                }
                catch
                {
                    crystalReportViewer1.Visible = false;
                    groupBox1.Visible = false;
                    MessageBox.Show("تأكد من اسم العميل او كود التقسيط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            suggest_cst_name();
            substringAutoCompleteTextBox1.TextBox_.KeyDown += substringAutoCompleteTextBox1_textbox_KeyDown;
            substringAutoCompleteTextBox1.Listbox_.KeyDown += substringAutoCompleteTextBox1_textbox_KeyDown;
            substringAutoCompleteTextBox1.AttachListBoxToParent(this);
        }

        private void suggest_cst_name()
        {
            this.aksat_tableTableAdapter1.FillBy_far3(this.dataSet11.aksat_table, far3_txt.Text);

            substringAutoCompleteTextBox1.SetSuggestions(dataSet11.aksat_table, "kest_cst_name");

        }

        private void substringAutoCompleteTextBox1_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    dataSet11.Clear();
                    customers_tableTableAdapter1.Fill(dataSet11.customers);
                    try
                    {
                        crystalReportViewer1.Visible = true;
                        groupBox1.Visible = true;
                       // crystalReportViewer2.Visible = true;
                        aksat_tableTableAdapter1.FillBy_kest_cst_code_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text,far3_txt.Text);
                        cst_name_txt.Text= dataSet11.aksat_table.Rows[0]["kest_cst_name"].ToString();
                        string kest_loan_code = dataSet11.aksat_table.Rows[0]["kest_loan_code"].ToString();
                       // loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, kest_loan_code, far3_txt.Text);
                        byan_7ala_tableTableAdapter1.FillBy_loan_code(dataSet11.byan_7ala_table, kest_loan_code);
                        
                        string damen_for_test = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                        aksat_show_for_all_report1.SetDataSource(dataSet11);
                        aksat_show_for_all_report1.Refresh();
                        crystalReportViewer1.RefreshReport();


                        try
                        {
                            int fatora_num = Convert.ToInt32(dataSet11.byan_7ala_table.Rows[0]["fatora_num"]);
                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, fatora_num, far3_txt.Text);

                            mo2dema_txt.Text = dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();
                            nesba_txt.Text = dataSet11.byan_7ala_table.Rows[0]["loan_notes"].ToString();
                            reb7_txt.Text = dataSet11.byan_7ala_table.Rows[0]["arba7_cost"].ToString();
                            taklefa_txt.Text = dataSet11.byan_7ala_table.Rows[0]["takelfa_fatora"].ToString();
                        }
                        catch { }
                            //a5_fatora_crystal_report1.SetDataSource(dataSet12);
                        //a5_fatora_crystal_report1.Refresh();
                        //crystalReportViewer2.RefreshReport();

                        savebtn.Visible = true;

                        substringAutoCompleteTextBox1.Listbox_.Visible = false;
                    }
                    catch
                    {
                        crystalReportViewer1.Visible = true;
                        groupBox1.Visible = true;
                        aksat_tableTableAdapter1.FillBy_kest_cst_name_for_all(dataSet11.aksat_table, substringAutoCompleteTextBox1.TextBox_.Text,far3_txt.Text);
                        cst_name_txt.Text = dataSet11.aksat_table.Rows[0]["kest_cst_name"].ToString();
                       
                        string kest_loan_code = dataSet11.aksat_table.Rows[0]["kest_loan_code"].ToString();
                       // loans_requests_tableTableAdapter1.FillBy_loan_code_and_far3(dataSet11.loans_requests_table, kest_loan_code, far3_txt.Text);
                        byan_7ala_tableTableAdapter1.FillBy_loan_code(dataSet11.byan_7ala_table, kest_loan_code);
                        string damen_for_test = dataSet11.aksat_table.Rows[0]["kest_1st_damen_code"].ToString();
                        aksat_show_for_all_report1.SetDataSource(dataSet11);
                        aksat_show_for_all_report1.Refresh();
                        crystalReportViewer1.RefreshReport();

                        try
                        {
                            int fatora_num = Convert.ToInt32(dataSet11.byan_7ala_table.Rows[0]["fatora_num"]);
                            sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, fatora_num, far3_txt.Text);

                            mo2dema_txt.Text = dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();
                            nesba_txt.Text = dataSet11.byan_7ala_table.Rows[0]["loan_notes"].ToString();
                            reb7_txt.Text = dataSet11.byan_7ala_table.Rows[0]["arba7_cost"].ToString();
                            taklefa_txt.Text = dataSet11.byan_7ala_table.Rows[0]["takelfa_fatora"].ToString();
                        }
                        catch { }
                            //a5_fatora_crystal_report1.SetDataSource(dataSet12);
                        //a5_fatora_crystal_report1.Refresh();
                        //crystalReportViewer2.RefreshReport();


                        savebtn.Visible = true;
                        substringAutoCompleteTextBox1.Listbox_.Visible = false;
                    }
                }
                catch
                {
                    crystalReportViewer1.Visible = false ;
                    groupBox1.Visible = false;
                    MessageBox.Show("تأكد من اسم العميل او كود التقسيط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (substringAutoCompleteTextBox1.TextBox_.Text == "") 
            {
                MessageBox.Show("ادخل اسم العميل او كوده");
                return;
            }
            loan_aksat_show l = new loan_aksat_show();
            l.substringAutoCompleteTextBox1.TextBox_.ReadOnly = true;
            l.substringAutoCompleteTextBox1.TextBox_.Text = cst_name_txt.Text;
            l.far3_txt.Text = far3_txt.Text;
            l.savebtn.Visible = false;
            Form1 f = new Form1();
            f.ApplyFormStyling(l);
            f.SubscribeToLoadEvent(l);

            l.WindowState = FormWindowState.Maximized;
            l.ShowDialog();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var names = GetUniqueCustomerNamesInTableOrder();
            string currentName = substringAutoCompleteTextBox1.TextBox_.Text.Trim();

            int currentIndex = names.IndexOf(currentName);

            if (currentIndex > 0)
            {
                string newName = names[currentIndex - 1];
                substringAutoCompleteTextBox1.TextBox_.Text = newName;
                // Optionally simulate Enter key or call your customer load logic
                substringAutoCompleteTextBox1_textbox_KeyDown(substringAutoCompleteTextBox1.TextBox_, new KeyEventArgs(Keys.Return));
                substringAutoCompleteTextBox1.Listbox_.Visible = false;
            }
            else
            {
                MessageBox.Show("لا يوجد عميل سابق.");
                substringAutoCompleteTextBox1.Listbox_.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var names = GetUniqueCustomerNamesInTableOrder();
            string currentName = substringAutoCompleteTextBox1.TextBox_.Text.Trim();

            int currentIndex = names.IndexOf(currentName);

            if (currentIndex != -1 && currentIndex < names.Count - 1)
            {
                string newName = names[currentIndex + 1];
                substringAutoCompleteTextBox1.TextBox_.Text = newName;
                // Optionally simulate Enter key or call your customer load logic
                substringAutoCompleteTextBox1_textbox_KeyDown(substringAutoCompleteTextBox1.TextBox_, new KeyEventArgs(Keys.Return));
                substringAutoCompleteTextBox1.Listbox_.Visible = false;
            }
            else
            {
                MessageBox.Show("لا يوجد عميل تالي.");
                substringAutoCompleteTextBox1.Listbox_.Visible = false;
            }
        }

        private void substringAutoCompleteTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
