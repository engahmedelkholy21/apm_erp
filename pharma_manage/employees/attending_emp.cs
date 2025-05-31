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
    public partial class attending_emp : Form
    {
        public attending_emp()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void attending_emp_Load(object sender, EventArgs e)
        {
            suggest_emp();
        }
        private void suggest_emp()
        {
            this.employee_tableTableAdapter1.Fill(this.dataSet11.employee_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.employee_table.Rows)
            {
                DataCollection.Add(dr["employee_name"].ToString());


            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try 
            {
                attending_tableTableAdapter1.FillBy_emp_in_fatra(dataSet11.attending_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());

                if (dataSet11.attending_table.Rows.Count > 0) 
                {
                    MessageBox.Show("تم تسجيل حضور الموظف مسبقا");
                    return;
                }
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


                   employee_tableTableAdapter1.FillBy_name(dataSet11.employee_table, name_txt.Text);
                 TimeSpan time_to_attend =TimeSpan.Parse(dataSet11.employee_table.Rows[0]["emp_time_to_attend"].ToString());
                // MessageBox.Show(time_to_attend.ToString());

                 TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
                 //MessageBox.Show(now.ToString());
                 double delay = now.TotalMinutes - time_to_attend.TotalMinutes; 
                
                 attending_tableTableAdapter1.Insert(name_txt.Text, dateTimePicker1.Value, "حضر", notes_txt.Text, usertxt.Text, "غير مسدد",now
                     , time_to_attend,delay, arabic_day,null);
                MessageBox.Show("تمت الاضافة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control t in this.Controls)
                {
                    if (t is TextBox)
                    {
                        t.Text = "";
                    }

                }
                name_txt.Focus();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                attending_tableTableAdapter1.FillBy_emp_in_fatra(dataSet11.attending_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());

                if (dataSet11.attending_table.Rows.Count > 0)
                {
                    MessageBox.Show("تم تسجيل حضور الموظف مسبقا");
                    return;
                }

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


                employee_tableTableAdapter1.FillBy_name(dataSet11.employee_table, name_txt.Text);
                TimeSpan time_to_attend = TimeSpan.Parse(dataSet11.employee_table.Rows[0]["emp_time_to_attend"].ToString());
                // MessageBox.Show(time_to_attend.ToString());

                TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
                //MessageBox.Show(now.ToString());
                double delay = now.TotalMinutes - time_to_attend.TotalMinutes;

                attending_tableTableAdapter1.Insert(name_txt.Text, dateTimePicker1.Value, "غياب باذن", notes_txt.Text, usertxt.Text, "غير مسدد", now
                      , time_to_attend, delay, arabic_day, null);
                MessageBox.Show("تمت الاضافة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control t in this.Controls)
                {
                    if (t is TextBox)
                    {
                        t.Text = "";
                    }

                }
                name_txt.Focus();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                attending_tableTableAdapter1.FillBy_emp_in_fatra(dataSet11.attending_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());

                if (dataSet11.attending_table.Rows.Count > 0)
                {
                    MessageBox.Show("تم تسجيل حضور الموظف مسبقا");
                    return;
                }
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


                employee_tableTableAdapter1.FillBy_name(dataSet11.employee_table, name_txt.Text);
                TimeSpan time_to_attend = TimeSpan.Parse(dataSet11.employee_table.Rows[0]["emp_time_to_attend"].ToString());
                // MessageBox.Show(time_to_attend.ToString());

                TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
                //MessageBox.Show(now.ToString());
                double delay = now.TotalMinutes - time_to_attend.TotalMinutes;

                attending_tableTableAdapter1.Insert(name_txt.Text, dateTimePicker1.Value, "اجازة", notes_txt.Text, usertxt.Text, "غير مسدد", now
                    , time_to_attend, delay, arabic_day, null);
                MessageBox.Show("تمت الاضافة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control t in this.Controls)
                {
                    if (t is TextBox)
                    {
                        t.Text = "";
                    }

                }
                name_txt.Focus();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                attending_tableTableAdapter1.FillBy_emp_in_fatra(dataSet11.attending_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());

                if (dataSet11.attending_table.Rows.Count > 0)
                {
                    MessageBox.Show("تم تسجيل حضور الموظف مسبقا");
                    return;
                }

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


                employee_tableTableAdapter1.FillBy_name(dataSet11.employee_table, name_txt.Text);
                TimeSpan time_to_attend = TimeSpan.Parse(dataSet11.employee_table.Rows[0]["emp_time_to_attend"].ToString());
                // MessageBox.Show(time_to_attend.ToString());

                TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
                //MessageBox.Show(now.ToString());
                double delay = now.TotalMinutes - time_to_attend.TotalMinutes;

                attending_tableTableAdapter1.Insert(name_txt.Text, dateTimePicker1.Value, "غياب بدون اذن", notes_txt.Text, usertxt.Text, "غير مسدد", now
                      , time_to_attend, delay, arabic_day, null); MessageBox.Show("تمت الاضافة بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control t in this.Controls)
                {
                    if (t is TextBox)
                    {
                        t.Text = "";
                    }

                }
                name_txt.Focus();
            }
            catch { }
        }
    }
}
