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
    public partial class edit_customer : Form
    {
        public edit_customer()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //try 
            //{
                //sales
                sales_tableTableAdapter1.FillBy_Cst_Name_IN_fatra(dataSet11.sales_table, cst_name.Text, "1/1/2000", DateTime.Today.ToShortDateString(),far3txt.Text);
                foreach (DataRow dr in dataSet11.sales_table.Rows) 
                {
                    int fatora_id = Convert.ToInt32(dr["sales_id"]);
                    sales_tableTableAdapter1.Update_cst_name_by_fatora_id(cst_nameTXT_new.Text, fatora_id,far3txt.Text);
                }
                //sales mortaga3
           
            
            sales_mortaga3TableAdapter1.FillBy_cst_name(dataSet11.sales_mortaga3,cst_name.Text);
           //MessageBox.Show(dataSet11.sales_mortaga3.Rows.Count.ToString());
             foreach (DataRow dr in dataSet11.sales_mortaga3.Rows) 
                {
                    int mortaga3_sales_id= Convert.ToInt32(dr["mortaga3_sales_id"]);
                    sales_mortaga3TableAdapter1.Update_cst_name_by_mortaga3_sales_id(cst_nameTXT_new.Text, mortaga3_sales_id);
                }
            



                //ma5zoon
             ma5zoon_movesTableAdapter1.FillBy_cst_name(dataSet11.ma5zoon_moves, cst_name.Text);
             foreach (DataRow dr in dataSet11.ma5zoon_moves.Rows)
             {
                 int ma5zoon_id = Convert.ToInt32(dr["ma5zoon_id"]);
                 ma5zoon_movesTableAdapter1.Update_cst_name_by_ma5zoon_id(cst_nameTXT_new.Text, ma5zoon_id);
             }
                //madeen_details
             madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, cst_name.Text);
             foreach (DataRow dr in dataSet11.madeen_table.Rows)
             {
                 int madeen_id = Convert.ToInt32(dr["madeen_id"]);
                 madeen_tableTableAdapter1.Update_madeen_name_by_madeen_id(cst_nameTXT_new.Text, madeen_id);
             }

                //madeen
             madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_name.Text);
             foreach (DataRow dr in dataSet11.madeen_small_report.Rows)
             {
                 int madeen_small_id = Convert.ToInt32(dr["madeen_small_id"]);
                 madeen_small_reportTableAdapter1.Update_madeen_name_by_madeen_small_id(cst_nameTXT_new.Text, madeen_small_id);
             }

             //most7kat
             mosta7akat_tableTableAdapter1.FillBy_cst_name(dataSet11.mosta7akat_table, cst_name.Text);
             foreach (DataRow dr in dataSet11.mosta7akat_table.Rows)
             {
                 int most7kat_id = Convert.ToInt32(dr["mosta7akat_id"]);

                 mosta7akat_tableTableAdapter1.Update_cst_name_by_id(cst_nameTXT_new.Text, most7kat_id);

             }

                //income
             income_tableTableAdapter1.FillBy_esm_elmashroo3(dataSet11.income_table, cst_name.Text,far3txt.Text);
             foreach (DataRow dr in dataSet11.income_table.Rows)
             {
                 int income_id = Convert.ToInt32(dr["income_id"]);
                 string details=dr["income_details"].ToString();
                 string new_details = details.Replace(cst_name.Text, cst_nameTXT_new.Text);

                 income_tableTableAdapter1.Update_esm_elmashroo3_by_income_id(cst_nameTXT_new.Text, income_id);
                 income_tableTableAdapter1.Update_details_by_income_id(new_details, income_id);
                 //لو هتعمل ريبلاس للاسم في التفاصبل

             }

             if (url_txt.Text != "")
             {
                 //  MessageBox.Show("aaaa");
                 try
                 {
                     Form1 f = new Form1();
                     f.upload_file_local("صورة بطاقة " + cst_nameTXT_new.Text, Path.GetExtension(url_txt.Text), DateTime.Today, url_txt.Text, usertxt.Text, this.Text, "", far3txt.Text, "صورة بطاقة");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
             }

             if (url_txt.Text != "")
             {
                 uploaded_files_tableTableAdapter1.FillBy_last_added_one(dataSet11.uploaded_files_table);
                 url_txt.Text = dataSet11.uploaded_files_table.Rows[0]["uploaded_file_path"].ToString();
             }

            //tas3eer
            //customer points
             customer_points_tableTableAdapter1.Update_cst_name(cst_nameTXT_new.Text, cst_phoneTXT.Text, cst_name.Text);
            //aksat
             aksat_tableTableAdapter1.Update_cst_name(cst_nameTXT_new.Text, cst_name.Text);
             aksat_tableTableAdapter1.Update_damen_1_name(cst_nameTXT_new.Text, cst_name.Text);
             aksat_tableTableAdapter1.Update_damen_2_name(cst_nameTXT_new.Text, cst_name.Text);
            //loans
             loans_requests_tableTableAdapter1.Update_cst_name(cst_nameTXT_new.Text, cst_name.Text);
             loans_requests_tableTableAdapter1.Update_damen_1_name(cst_nameTXT_new.Text, cst_name.Text);
             loans_requests_tableTableAdapter1.Update_damen_2_name(cst_nameTXT_new.Text, cst_name.Text);


             //customers
             customersTableAdapter1.Update_cst_by_id_all(cst_nameTXT_new.Text, cst_phoneTXT.Text, cst_addressTXT.Text, notesTXT.Text, price_txt.Text,national_id_txt.Text,takseet_status.Text,url_txt.Text, Convert.ToInt32(cst_id.Text));
             MessageBox.Show("تم التعديل بنجاح");
             this.Close();
            //}
            //catch { }
        }

        private void edit_customer_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);

            if (cst_id.Text != "cst id") 
            {
                customersTableAdapter1.FillBy_id(dataSet11.customers, Convert.ToInt32(cst_id.Text));
                if (dataSet11.customers.Rows.Count > 0)
                {
                    cst_nameTXT_new.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                    cst_name.Text = dataSet11.customers.Rows[0]["cst_name"].ToString();
                    cst_phoneTXT.Text = dataSet11.customers.Rows[0]["cst_phone"].ToString();
                    cst_addressTXT.Text = dataSet11.customers.Rows[0]["cst_address"].ToString();
                    notesTXT.Text = dataSet11.customers.Rows[0]["cst_notes"].ToString();
                    price_txt.Text = dataSet11.customers.Rows[0]["cst_price_category"].ToString();
                    national_id_txt.Text = dataSet11.customers.Rows[0]["cst_national_id"].ToString();
                    takseet_status.Text = dataSet11.customers.Rows[0]["cst_takseet_status"].ToString();
                    url_txt.Text = dataSet11.customers.Rows[0]["betaka_url"].ToString();
                }
            }
            if (url_txt.Text != "") 
            {
                pictureBox1.Image = Image.FromFile(url_txt.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

                    pictureBox1.Image = Image.FromFile(url_txt.Text);
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
