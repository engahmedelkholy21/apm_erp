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
    public partial class add_employee : Form
    {
        public add_employee()
        {
            InitializeComponent();
        }
        private void edit_emp() 
        {
            if (name_txt.Text == "")
            {
                MessageBox.Show("ادخل اسم الموظف");
                return;
            }
            if (daily_salary_txt.Text == "" && monthly_salary_txt.Text == "")
            {
                MessageBox.Show("يجب ادخال الراتب اليومي او الراتب الشهري");
                return;
            }

            employee_tableTableAdapter1.Update_by_employee_id(name_txt.Text, address_txt.Text, phone_txt.Text, national_id_txt.Text, job_txt.Text, last_graduation_txt.Text, notes_txt.Text,
                Convert.ToDecimal(daily_salary_txt.Text), Convert.ToDecimal(monthly_salary_txt.Text), usertxt.Text,time_to_attend_txt.Value.ToString("HH:mm"),Convert.ToInt32(id_txt.Text));

            MessageBox.Show("تم التعديل بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (type_txt.Text == "type")
            {
                add_new_emp();
            }
            else 
            {
                edit_emp();
            }
        }

        private void add_new_emp() 
        {

            if (name_txt.Text == "")
            {
                MessageBox.Show("ادخل اسم الموظف");
                return;
            }

            employee_tableTableAdapter1.FillBy_name(dataSet11.employee_table, name_txt.Text);

            if (dataSet11.employee_table.Rows.Count > 0)
            {
                MessageBox.Show("هذا الموظف موجود مسبقا ");
                return;
            }

            if (daily_salary_txt.Text == "" && monthly_salary_txt.Text == "")
            {
                MessageBox.Show("يجب ادخال الراتب اليومي او الراتب الشهري");
                return;
            }

            employee_tableTableAdapter1.FillBy_employee_national_id(dataSet11.employee_table, national_id_txt.Text);

            if (dataSet11.employee_table.Rows.Count > 0)
            {
                MessageBox.Show("الرقم القومي موجود مسبقا ");
                return;
            }

            if (daily_salary_txt.Text == "")
            {
                daily_salary_txt.Text = "0";
            } if (monthly_salary_txt.Text == "")
            {
                monthly_salary_txt.Text = "0";
            }


            employee_tableTableAdapter1.Insert(name_txt.Text, address_txt.Text, phone_txt.Text, national_id_txt.Text, job_txt.Text, last_graduation_txt.Text, notes_txt.Text,
                Convert.ToDecimal(daily_salary_txt.Text), Convert.ToDecimal(monthly_salary_txt.Text), usertxt.Text,TimeSpan.Parse(time_to_attend_txt.Value.ToString("HH:mm")));

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
        private void add_employee_Load(object sender, EventArgs e)
        {
            if (type_txt.Text != "type") 
            {
                this.Text = "تعديل بيانات موظف";
                savebtn.Text = "تعديل";

                employee_tableTableAdapter1.FillBy_name(dataSet11.employee_table, type_txt.Text);
                id_txt.Text = dataSet11.employee_table.Rows[0]["employee_id"].ToString();
                name_txt.Text = dataSet11.employee_table.Rows[0]["employee_name"].ToString();
                address_txt.Text = dataSet11.employee_table.Rows[0]["employee_address"].ToString();
                phone_txt.Text = dataSet11.employee_table.Rows[0]["employee_phone"].ToString();
                national_id_txt.Text = dataSet11.employee_table.Rows[0]["employee_national_id"].ToString();
                job_txt.Text = dataSet11.employee_table.Rows[0]["employee_job"].ToString();
                last_graduation_txt.Text = dataSet11.employee_table.Rows[0]["employee_last_graduation"].ToString();
                notes_txt.Text = dataSet11.employee_table.Rows[0]["employee_notes"].ToString();
                daily_salary_txt.Text = dataSet11.employee_table.Rows[0]["employee_daily_salary"].ToString();
                monthly_salary_txt.Text = dataSet11.employee_table.Rows[0]["employee_monthly_salary"].ToString();
                time_to_attend_txt.Text = dataSet11.employee_table.Rows[0]["emp_time_to_attend"].ToString();
             //   usertxt.Text = dataSet11.employee_table.Rows[0]["employee_user"].ToString();
         
            }
        }
    }
}
