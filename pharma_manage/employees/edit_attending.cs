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
    public partial class edit_attending : Form
    {
        public edit_attending()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void edit_attending_Load(object sender, EventArgs e)
        {
            attending_tableTableAdapter1.FillBy_id(dataSet11.attending_table, Convert.ToInt32(id_txt.Text));

            dateTimePicker1.Value = Convert.ToDateTime(dataSet11.attending_table.Rows[0]["attending_emp_date"].ToString());
            status_txt.Text = dataSet11.attending_table.Rows[0]["attending_status"].ToString();
            sadad_txt.Text = dataSet11.attending_table.Rows[0]["attending_paid_or_not"].ToString();
            day_txt.Text = dataSet11.attending_table.Rows[0]["attending_day"].ToString();
            hdoor_txt.Text = dataSet11.attending_table.Rows[0]["attending_hour"].ToString();
            ensraf_txt.Text = dataSet11.attending_table.Rows[0]["ensraf"].ToString();
            notes_txt.Text = dataSet11.attending_table.Rows[0]["attending_notes"].ToString();
            delay_txt.Text = dataSet11.attending_table.Rows[0]["delay_time"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    attending_tableTableAdapter1.Update_attending_all_by_id(
                        dateTimePicker1.Value.ToShortDateString(),
                        status_txt.Text,
                        notes_txt.Text,
                        user_txt.Text,
                        sadad_txt.Text,
                     //   hdoor_txt.Text,
                        Convert.ToDouble(delay_txt.Text), // Use TimeSpan.Parse for converting to TimeSpan
                        day_txt.Text,
                        Convert.ToInt32(id_txt.Text)
                    );

                    MessageBox.Show("تم التعديل بنجاح");
                     this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try 
            {
                string english_day = dateTimePicker1.Value.DayOfWeek.ToString();

                string arabic_day = "";
                if (english_day == "Saturday")
                {
                    arabic_day = "السبت";
                }
                else if (english_day == "Sunday")
                {
                    arabic_day = "الاحد";
                }
                else if (english_day == "Monday")
                {
                    arabic_day = "الاثنين";
                }
                else if (english_day == "Tuesday")
                {
                    arabic_day = "الثلاثاء";
                }
                else if (english_day == "Wednesday")
                {
                    arabic_day = "الاربعاء";
                }
                else if (english_day == "Thursday")
                {
                    arabic_day = "الخميس";
                }
                else if (english_day == "Friday")
                {
                    arabic_day = "الجمعة";
                }

                day_txt.Text = arabic_day;
            }
            catch { }
        }
    }
}
