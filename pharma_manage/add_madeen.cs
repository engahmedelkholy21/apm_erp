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
    public partial class add_madeen : Form
    {
        public add_madeen()
        {
            InitializeComponent();
        }

        private void add_madeen_Load(object sender, EventArgs e)
        {
            suggest_cst_name();
        }

        private void suggest_cst_name()
        {


            customersTableAdapter1.Fill(dataSet11.customers);
            madeen_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            madeen_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.customers.Rows)
            {
                DataCollection.Add(dr["cst_name"].ToString());
            }

            madeen_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        private void check_customer()
        {
            this.customersTableAdapter1.Fill(this.dataSet11.customers);
            DataTable tbl = (DataTable)dataSet11.customers;

            bool contains = tbl.AsEnumerable()
               .Any(row => madeen_nameTXT.Text == row.Field<String>("cst_name"));

            DataRow[] foundAuthors = tbl.Select("cst_name = '" + madeen_nameTXT.Text + "'");
            if (foundAuthors.Length == 0)
            {
                customersTableAdapter1.Insert(madeen_nameTXT.Text, "0", "0", "","","","","");
            }

        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            //check if exist
            this.madeen_small_reportTableAdapter1.FillBy_madeen_small_name(this.dataSet11.madeen_small_report, madeen_nameTXT.Text);
            if (dataSet11.madeen_small_report.Rows.Count > 0)
            {
                DialogResult re = MessageBox.Show("يوجد مدين بنفس الاسم , هل تريد اضافة المبلغ للحساب ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {

                    decimal cost = Convert.ToDecimal(matloobtxt.Text);

                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, madeen_nameTXT.Text);
                    decimal old_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal old_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);


                    //madeen small report update
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(cost, Convert.ToDecimal(madfoo3txt.Text), madeen_nameTXT.Text);


                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, madeen_nameTXT.Text);
                    decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                    //  decimal baky = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                    //madeen details insert


                    string madeen_byan = notes_txt.Text; //"مبلغ مضاف علي الحساب ";
                    mosta7akat_tableTableAdapter1.Insert(madeen_nameTXT.Text, DateTime.Today, new_matloob, new_madfoo3, cost, Convert.ToDecimal(madfoo3txt.Text), usertxt.Text
                        , old_matloob - old_madfoo3, new_matloob - new_madfoo3, madeen_byan, "مدين", Convert.ToInt32(0));
               //     MessageBox.Show("تمت اضافة المبلغ بنجاح ؟", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
            }
            else
            {

                //check if customer exist
                check_customer();
                //try
                //{
                    //insert to small madeen
                    madeen_small_reportTableAdapter1.Insert_madeen_small(madeen_nameTXT.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text));

                    //insert to madeen details
                    //تعديل هنا
                    // madeen_tableTableAdapter1.Insert_madeen_details(DateTime.Today.ToShortDateString(), madeen_nameTXT.Text, "مبلغ مدفوع عند إضافة المدين", Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), "", usertxt.Text, "", Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                    mosta7akat_tableTableAdapter1.Insert(madeen_nameTXT.Text, DateTime.Today, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), usertxt.Text
                              , 0, Convert.ToDecimal(matloobtxt.Text) - Convert.ToDecimal(madfoo3txt.Text), notes_txt.Text, "دائن", Convert.ToInt32(0));

                    //madeen_tableTableAdapter1.Insert_madeen_details(DateTime.Today.ToShortDateString(), madeen_nameTXT.Text, "مبلغ مدفوع عند إضافة المدين", Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), "", usertxt.Text, ""
                    //   , Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0, 1, DateTime.Today.ToShortDateString(), Convert.ToDecimal(madfoo3txt.Text), "paid", DateTime.Today.ToShortDateString(), "");

                    //madeen_tableTableAdapter1.Insert_madeen_details(DateTime.Today.ToShortDateString(), madeen_nameTXT.Text, "", Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(matloobtxt.Text) - Convert.ToDecimal(madfoo3txt.Text), "", usertxt.Text, ""
                    //           , Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), Convert.ToInt32(0), 2, DateTime.Today.AddDays(3).ToString(), Convert.ToDecimal(matloobtxt.Text) - Convert.ToDecimal(madfoo3txt.Text), "not paid", "", "");

                //}
                //catch { }
            }

            DialogResult d = MessageBox.Show("تمت الاضافة بنجاح هل تريد صرف المبلغ المطلوب من الخزينة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {

                try
                {

                   
                    outcome_tableTableAdapter1.Insert_outcome(DateTime.Today.ToShortDateString(), "صرف مبلغ لمدين " + madeen_nameTXT.Text, Convert.ToDecimal(matloobtxt.Text), 0, "مدينين", madeen_nameTXT.Text, usertxt.Text,"",far3_txt.Text);

                    //safe_ upadate
                    safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(matloobtxt.Text));

                    //current
                    safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), -Convert.ToDecimal(matloobtxt.Text));

                }
                catch { }
            }

            madeen_nameTXT.Clear(); matloobtxt.Clear(); madfoo3txt.Clear(); notes_txt.Clear();
            madeen_nameTXT.Focus();
            //clear textboxs

            this.Close();

        }

    }

}