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
    public partial class add_da2n : Form
    {
        public add_da2n()
        {
            InitializeComponent();
        }
        private void check_mwared()
        {
            this.mwardeenTableAdapter1.Fill(this.dataSet11.mwardeen);
            DataTable tbl = (DataTable)dataSet11.mwardeen;

            bool contains = tbl.AsEnumerable()
               .Any(row => madeen_nameTXT.Text == row.Field<String>("mwared_name"));

            DataRow[] foundAuthors = tbl.Select("mwared_name = '" + madeen_nameTXT.Text + "'");
            if (foundAuthors.Length == 0)
            {
                mwardeenTableAdapter1.Insert(madeen_nameTXT.Text, "0", "0", "0");
            }
        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;  // Set the cursor to indicate loading
            this.Enabled = false;              // Disable form to prevent interaction


            //check if exist
            this.da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(this.dataSet11.da2n_small_reports, madeen_nameTXT.Text);
            if (dataSet11.da2n_small_reports.Rows.Count > 0)
            {
                DialogResult re = MessageBox.Show("يوجد دائن بنفس الاسم , هل تريد اضافة المبلغ للحساب ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {

                    da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, madeen_nameTXT.Text);

                    decimal matloob_before = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                    decimal madfoo3_before = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);
                    decimal ba2y_before = matloob_before - madfoo3_before;

                    decimal matloob_all = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"])+Convert.ToDecimal(matloobtxt.Text);
                    decimal madfoo3_all = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]) + Convert.ToDecimal(madfoo3txt.Text);
                    decimal ba2y_all = matloob_all - madfoo3_all;






                    //insert madeen details
                    // da2n_tableTableAdapter1.Insert_da2n_details(dateTimePicker1.Value.ToShortDateString(), da2n_nameTXT.Text, details, 0, Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);

                    //insert most7kat da2neen
                    mosta7akat_da2neen_tableTableAdapter1.Insert(madeen_nameTXT.Text, DateTime.Today, matloob_all, madfoo3_all, 0, Convert.ToDecimal(madfoo3txt.Text), usertxt.Text
                        , ba2y_before, ba2y_all, notes_txt.Text, "مدين", 0);

                    //da2n small report update
                    da2n_small_reportsTableAdapter1.Update_matloob_AND_madfoo3_BY_name(Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), madeen_nameTXT.Text);
                    da2n_small_reportsTableAdapter1.FillBy_da2n_small_name(dataSet11.da2n_small_reports, madeen_nameTXT.Text);
                    decimal new_matloob = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.da2n_small_reports.Rows[0]["da2n_small_madfoo3"]);

                    
                    //da2n details insert
                    //string da2n_byan = notes_txt.Text;// "مبلغ مضاف علي الحساب ";
                    //da2n_tableTableAdapter1.Insert_da2n_details(DateTime.Today.ToShortDateString(), madeen_nameTXT.Text, da2n_byan, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), da2n_byan, usertxt.Text,
                    //     new_matloob, new_madfoo3, 0);

                    ////da2n details update matlob and madfo93
                    //da2n_tableTableAdapter1.Update_matloob_AND_madfoo3_By_da2n_name(Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), madeen_nameTXT.Text);
                    MessageBox.Show("تمت اضافة المبلغ بنجاح ؟", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                }

            }
            else
            {
                //check if mwared exist
                check_mwared();

                try
                {
                    //insert to small madeen
                    da2n_small_reportsTableAdapter1.Insert_da2n(madeen_nameTXT.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text));

                    //insert to madeen details
                    //da2n_tableTableAdapter1.Insert_da2n_details(DateTime.Today.ToShortDateString(), madeen_nameTXT.Text, "مبلغ مدفوع عند إضافة الدائن", Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), "", usertxt.Text, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text), 0);


                    decimal matloob_before =0;
                    decimal madfoo3_before = 0;
                    decimal ba2y_before =0;

                    decimal matloob_all = Convert.ToDecimal(matloobtxt.Text);
                    decimal madfoo3_all = Convert.ToDecimal(madfoo3txt.Text);
                    decimal ba2y_all = matloob_all - madfoo3_all;
                   
                    //insert most7kat da2neen
                    mosta7akat_da2neen_tableTableAdapter1.Insert(madeen_nameTXT.Text, DateTime.Today, matloob_all, madfoo3_all, 0, Convert.ToDecimal(madfoo3txt.Text), usertxt.Text
                       , ba2y_before, ba2y_all, notes_txt.Text, "مدين", 0);
                }
                catch { }
            }
            DialogResult d = MessageBox.Show("تمت الاضافة بنجاح هل تريد اضافة المبلغ للخزينة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                try
                {
                    income_tableTableAdapter1.Insert_income(DateTime.Today.ToShortDateString(), "مبلغ من دائن " + madeen_nameTXT.Text, Convert.ToDecimal(matloobtxt.Text),
                    0, "دائنين", madeen_nameTXT.Text, usertxt.Text, notes_txt.Text, far3txt.Text,0);

                    //update current safe
                    safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(matloobtxt.Text));

                    //update day safe
                    safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), Convert.ToDecimal(matloobtxt.Text));


                   


                    //clear textboxs
                    madeen_nameTXT.Clear(); matloobtxt.Clear(); madfoo3txt.Clear();
                    madeen_nameTXT.Focus();
                }
                catch { }
            }
            this.Cursor = Cursors.Arrow;  // Set the cursor to indicate loading
            this.Enabled = true;              // Disable form to prevent interaction
            this.Close();
        }
        private void add_da2n_Load(object sender, EventArgs e)
        {
            suggest_cst_name();
        }
        private void suggest_cst_name()
        {

            da2n_small_reportsTableAdapter1.Fill(dataSet11.da2n_small_reports);
            madeen_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            madeen_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.da2n_small_reports.Rows)
            {
                DataCollection.Add(dr["da2n_small_name"].ToString());
            }


            madeen_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
    }
}
