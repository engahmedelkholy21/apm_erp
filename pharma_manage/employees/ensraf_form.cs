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
    public partial class ensraf_form : Form
    {
        public ensraf_form()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void ensraf_form_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                if (name_txt.Text == "") 
                {
                    MessageBox.Show("ادخل اسم الموظف");
                    return;
                }
                TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
                attending_tableTableAdapter1.Update_ensraf_by_name_and_date(now.ToString(), name_txt.Text, dateTimePicker1.Value.ToShortDateString());
                MessageBox.Show("تم الانصراف بنجاح");
                name_txt.Text = "";
            }
            catch { }
        }

    }
}
