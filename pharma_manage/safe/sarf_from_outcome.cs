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
    public partial class sarf_from_outcome : Form
    {
        public sarf_from_outcome()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (src_txt.Text == "")
            {
                MessageBox.Show("ادخل المصدر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                src_txt.Focus();
                return;
            }
            DialogResult r = MessageBox.Show("هل تريد صرف مبلغ "+cost_txt.Text+" من الخزينة علي مصدر "+src_txt.Text+" ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                //safe_users_tableTableAdapter1.FillBy_user(dataSet11.safe_users_table, usertxt.Text);

                //if (Convert.ToDecimal(dataSet11.safe_users_table.Rows[0]["safe_users_amount"]) >= Convert.ToDecimal(cost_txt.Text))
                //{
                //    safe_users_tableTableAdapter1.Update_sarf_from_safe_users(Convert.ToDecimal(cost_txt.Text), usertxt.Text);
                //}
                //else
                //{
                //    MessageBox.Show("رصيد خزينتك لا يسمح برجاء المراجعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), details_txt.Text, Convert.ToDecimal(cost_txt.Text), 0, src_txt.Text, person_name_txt.Text, usertxt.Text, notes_txt.Text,far3txt.Text);
                safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(cost_txt.Text));
                decimal tarh = Convert.ToDecimal(cost_txt.Text) * -1;
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), tarh);

                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, person_name_txt.Text);

                if (url_txt.Text != "")
                {
                    //  MessageBox.Show("aaaa");
                    try
                    {
                        Form1 f = new Form1();
                        f.upload_file_local(this.Text + details_txt.Text+" "+cost_txt.Text+" "+person_name_txt.Text, Path.GetExtension(url_txt.Text), dateTimePicker1.Value, url_txt.Text, usertxt.Text, this.Text, "", far3txt.Text, "صرف من الخزينة");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dataSet11.madeen_small_report.Rows.Count > 0)
                {


                    DialogResult re = MessageBox.Show("يوجد مدين بنفس الاسم , هل تريد اضافة المبلغ للحساب ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {

                        decimal cost = Convert.ToDecimal(cost_txt.Text);

                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, person_name_txt.Text);
                        decimal old_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                        decimal old_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);


                        //madeen small report update
                        madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(cost, 0, person_name_txt.Text);
                      
                        
                        madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, person_name_txt.Text);
                        decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                        decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                      //  decimal baky = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                        //madeen details insert


                        string madeen_byan = "مبلغ منصرف من الخزينة";
                        mosta7akat_tableTableAdapter1.Insert(person_name_txt.Text, dateTimePicker1.Value, old_matloob+cost, 0, cost,0, usertxt.Text
                            , old_matloob - old_madfoo3, new_matloob - new_madfoo3, madeen_byan, "مدين", Convert.ToInt32(0));

                    }


                }


                ezn_sarfTableAdapter1.Insert(dateTimePicker1.Value, Convert.ToDecimal(cost_txt.Text), details_txt.Text, notes_txt.Text, usertxt.Text, person_name_txt.Text);

                DialogResult rr = MessageBox.Show("تم الصرف بنجاح . هل تريد طباعة اذن الصرف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rr == DialogResult.Yes)
                {
                    ezn_crystal1.Refresh();
                    ezn_crystal1.SetDataSource(dataSet11);
                    string param;

                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    // MessageBox.Show(param);
                    ezn_crystal1.SetParameterValue("test", param);

                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);


                    ezn_sarfTableAdapter1.FillBy_date_cost_details_mostalem(dataSet11.ezn_sarf, dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(cost_txt.Text), details_txt.Text, person_name_txt.Text);



                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();

                    ezn_crystal1.PrintOptions.PrinterName = printer_name;
                    ezn_crystal1.PrintToPrinter(1, false, 0, 0);
                    ezn_crystal1.Dispose();

                }
                details_txt.Clear(); cost_txt.Clear(); dateTimePicker1.Value = DateTime.Today; notes_txt.Clear(); person_name_txt.Clear();
                cost_txt.Focus(); src_txt.ResetText();
                suggest_cst_name();
            }
        }

        private void sarf_from_outcome_Load(object sender, EventArgs e)
        {
            suggest_cst_name();

            string dates_ed = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\dates_ed.txt").First();
            if (dates_ed == "yes")
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
            src_txt.SelectedIndex = 0;

            cost_txt.KeyPress += DigitOnly_KeyPress;
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
        private void suggest_cst_name()
        {
            this.outcome_tableTableAdapter1.Fill(this.dataSet11.outcome_table);

            person_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            person_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            src_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            src_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();

            HashSet<string> uniqueSources = new HashSet<string>(); // to avoid duplicates

            foreach (DataRow dr in dataSet11.outcome_table.Rows)
            {
                // Add to person_name_txt suggestions
                DataCollection.Add(dr["outcome_esm_elmashroo3"].ToString());

              
            }

            person_name_txt.AutoCompleteCustomSource = DataCollection;

            outcome_tableTableAdapter1.FillBy_for_srcs(this.dataSet11.outcome_table);
            foreach (DataRow dr in dataSet11.outcome_table.Rows)
            {
                // Add to src_txt suggestions only if not already added
               
                string source = dr["outcome_source"].ToString();

                if (uniqueSources.Add(source)) // returns false if already exists
                {
                    DataCollection1.Add(source);
                }
            }
            // Set the AutoComplete list (without duplicates)
            src_txt.AutoCompleteCustomSource = DataCollection1;

            // If you still want a dropdown list (e.g., ComboBox-like behavior), bind the unique list
            src_txt.DataSource = uniqueSources.ToList();
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
