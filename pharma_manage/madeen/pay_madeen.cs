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
    public partial class pay_madeen : Form
    {
        public pay_madeen()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void pay_madeen_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            if (madeen_nameTXT.Text != "")
            {
                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, madeen_nameTXT.Text);
                try
                {
                    matloobtxt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"].ToString();
                    madfoo3txt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"].ToString();
                    ba2ytxt.Text = dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"].ToString();
                }
                catch { }
            }

            morad_daf3ohTXT.KeyPress += DigitOnly_KeyPress;
        }


        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
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
        private void savebtn_Click(object sender, EventArgs e)
        {
            //try 
            //{
            if (this.Text.Contains("اضافة"))
            {
                if (morad_daf3ohTXT.Text == "")
                {
                    morad_daf3ohTXT.Focus();
                    MessageBox.Show("المبلغ المدفوع فارغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Cursor = Cursors.Default;  // Set the cursor to indicate loading
                    this.Enabled = true;              // Disable form to prevent interaction

                    return;
                }
                //   string details="مبلغ قسط رقم "+kest_num_txt.Text +" للعميل "+madeen_nameTXT.Text;

                //update matloob and madfoo3 madeen details




                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, madeen_nameTXT.Text);

                //update madeen small report
              //  madeen_small_reportTableAdapter1.Update_madfoo3_by_name(Convert.ToDecimal(morad_daf3ohTXT.Text), madeen_nameTXT.Text);

                madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(Convert.ToDecimal(morad_daf3ohTXT.Text), 0, madeen_nameTXT.Text);

                mosta7akat_tableTableAdapter1.Insert(madeen_nameTXT.Text, dateTimePicker1.Value, Convert.ToDecimal(matloobtxt.Text) + Convert.ToDecimal(morad_daf3ohTXT.Text), Convert.ToDecimal(madfoo3txt.Text), Convert.ToDecimal(morad_daf3ohTXT.Text), 0
                    , usertxt.Text, Convert.ToDecimal(ba2ytxt.Text), Convert.ToDecimal(ba2ytxt.Text) + Convert.ToDecimal(morad_daf3ohTXT.Text), notesTXT.Text, "مدين", 0);

                mosta7akat_tableTableAdapter1.FillBy_date_last_record(dataSet11.mosta7akat_table, dateTimePicker1.Value.ToShortDateString());
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Arrow;  // Set the cursor to indicate loading
                this.Enabled = true;              // Disable form to prevent interaction

                this.Close();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;  // Set the cursor to indicate loading
                this.Enabled = false;              // Disable form to prevent interaction


                if (morad_daf3ohTXT.Text == "")
                {
                    morad_daf3ohTXT.Focus();
                    MessageBox.Show("المبلغ المدفوع فارغ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Cursor = Cursors.Default;  // Set the cursor to indicate loading
                    this.Enabled = true;              // Disable form to prevent interaction

                    return;
                }
                //   string details="مبلغ قسط رقم "+kest_num_txt.Text +" للعميل "+madeen_nameTXT.Text;

                //update matloob and madfoo3 madeen details




                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, madeen_nameTXT.Text);

                //update madeen small report
                madeen_small_reportTableAdapter1.Update_madfoo3_by_name(Convert.ToDecimal(morad_daf3ohTXT.Text), madeen_nameTXT.Text);



                mosta7akat_tableTableAdapter1.Insert(madeen_nameTXT.Text, dateTimePicker1.Value, Convert.ToDecimal(matloobtxt.Text), Convert.ToDecimal(madfoo3txt.Text) + Convert.ToDecimal(morad_daf3ohTXT.Text), 0, Convert.ToDecimal(morad_daf3ohTXT.Text)
                    , usertxt.Text, Convert.ToDecimal(ba2ytxt.Text), Convert.ToDecimal(ba2ytxt.Text) - Convert.ToDecimal(morad_daf3ohTXT.Text), "سداد من الحساب", "دائن", 0);

                mosta7akat_tableTableAdapter1.FillBy_date_last_record(dataSet11.mosta7akat_table, dateTimePicker1.Value.ToShortDateString());

                int most7kat_id = Convert.ToInt32(dataSet11.mosta7akat_table.Rows[0]["mosta7akat_id"]);

                //insert to income
                income_tableTableAdapter1.Insert_income(dateTimePicker1.Value.ToShortDateString(), "سداد من الحساب للعميل " + madeen_nameTXT.Text, Convert.ToDecimal(morad_daf3ohTXT.Text), 0, "دفعات مدينين", madeen_nameTXT.Text, usertxt.Text, notesTXT.Text, far3txt.Text, 0);

                //update current safe
                safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(morad_daf3ohTXT.Text));

                //update day safe
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), Convert.ToDecimal(morad_daf3ohTXT.Text));



                // customersTableAdapter1.Update_notes_by_name(notesTXT.Text, madeen_nameTXT.Text);



                DialogResult d = MessageBox.Show("تم الدفع بنجاح , هل تريد طباعة ايصال ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt");
                    string printer_name = srr.ReadLine();

                    string param;


                    param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                    pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);



                    try
                    {



                        pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                        sadad_print_reset1.Refresh();
                        sadad_print_reset1.SetDataSource(dataSet11);

                        //string param;

                        // param = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\";
                        // MessageBox.Show(param);
                        sadad_print_reset1.SetParameterValue("test", param);


                        // string title = "عن الفترة من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " الى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");
                        // sadad_print_reset1.SetParameterValue("title", title);
                        mosta7akat_tableTableAdapter1.FillBy_id(dataSet11.mosta7akat_table, most7kat_id);

                        sadad_print_reset1.PrintOptions.PrinterName = printer_name;

                        sadad_print_reset1.PrintToPrinter(1, false, 0, 0);
                        sadad_print_reset1.Dispose();
                        sadad_print_reset1.Close();

                    }
                    catch { }
                }




                this.Cursor = Cursors.Arrow;  // Set the cursor to indicate loading
                this.Enabled = true;              // Disable form to prevent interaction

                this.Close();
            }
            
            //}
            //catch { }
        }

        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void morad_daf3ohTXT_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
