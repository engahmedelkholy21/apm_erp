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
    public partial class add_solaf : Form
    {
        public add_solaf()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void add_solaf_Load(object sender, EventArgs e)
        {
            if (this.Text == "عمل سلفه")
            {
                button1.Text = "صرف السلفه";
            }
            if (this.Text == "عمل خصم")
            {
                label2.Text = "قيمة الخصم";
                button1.Text = "حفظ الخصم";
            }
            else if (this.Text == "اضافي موظف")
            {
                button1.Text = "حفظ الاضافي";
                label2.Text = "قيمة الاضافي";
                button1.BackColor = Color.Green;
            }
            else if (this.Text == "عمل مكافأة")
            {
                button1.Text = "حفظ المكاقأة";
                label2.Text = "قيمة المكاقأة";
                button1.BackColor = Color.Green;
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "") 
            {
                MessageBox.Show("ادخل اسم الموظف");
                name_txt.Focus();
                return;
            }

            if (this.Text == "عمل سلفه")
            {
                try
                {
                    solfa_tableTableAdapter1.FillBy_emp_and_fatra(dataSet11.solfa_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());
                    if (dataSet11.solfa_table.Rows.Count > 0)
                    {
                        DialogResult re = MessageBox.Show("لا يمكن عمل السلفة اكثر من مرة في نفس اليوم هل تريد حذف السلفة السابقة ؟", "خطأ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (re == DialogResult.Yes)
                        {
                            outcome_tableTableAdapter1.Delete_details_src_ID_date("سلفه " + name_txt.Text, "سلف", 0, dateTimePicker1.Value.ToShortDateString());
                            safeTableAdapter1.Update_add_to_safe(Convert.ToDecimal(cost_txt.Text));
                            safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), Convert.ToDecimal(cost_txt.Text));
                            solfa_tableTableAdapter1.Delete_by_date_emp_name(dateTimePicker1.Value.ToShortDateString(), name_txt.Text);

                            button1_Click(sender, e);
                        }
                        else if (re == DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    else
                    {
                        outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), "سلفه " + name_txt.Text, Convert.ToDecimal(cost_txt.Text),
                            0, "سلف", name_txt.Text, usertxt.Text, notes_txt.Text, far3txt.Text);

                        safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(cost_txt.Text));
                        decimal tarh = Convert.ToDecimal(cost_txt.Text) * -1;
                        safeTableAdapter1.Insert_safe(DateTime.Today.ToShortDateString(), tarh);


                        solfa_tableTableAdapter1.Insert(dateTimePicker1.Value, name_txt.Text, Convert.ToDecimal(cost_txt.Text), notes_txt.Text, usertxt.Text, "غير مسدد");

                        MessageBox.Show("تم الصرف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        name_txt.Clear(); cost_txt.Clear(); notes_txt.Clear();
                    }
                }
                catch { }
            }
            else if (this.Text == "اضافي موظف")
            {
                extra_tableTableAdapter1.FillBy_emp_name_and_fatra(dataSet11.extra_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());
                if (dataSet11.extra_table.Rows.Count > 0)
                {
                    MessageBox.Show("لا يمكن عمل اضافي اكثر من مرة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    extra_tableTableAdapter1.Insert(dateTimePicker1.Value, name_txt.Text, Convert.ToDecimal(cost_txt.Text), notes_txt.Text, usertxt.Text, "غير مسدد");

                    MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name_txt.Clear(); cost_txt.Clear(); notes_txt.Clear();
                }
            }
            else if (this.Text == "عمل مكافأة")
            {
                mokaf2at_tableTableAdapter1.FillBy_emp_name_and_fatra(dataSet11.mokaf2at_table, name_txt.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());
            if (dataSet11.mokaf2at_table.Rows.Count > 0)
            {
                MessageBox.Show("لا يمكن عمل مكافأة اكثر من مرة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                mokaf2at_tableTableAdapter1.Insert(dateTimePicker1.Value, name_txt.Text, Convert.ToDecimal(cost_txt.Text), notes_txt.Text, usertxt.Text, "غير مسدد");

                MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_txt.Clear(); cost_txt.Clear(); notes_txt.Clear();
            }
            }

            else if (this.Text == "عمل خصم")
            {
                disocuntsTableAdapter1.Insert(dateTimePicker1.Value, name_txt.Text, Convert.ToDecimal(cost_txt.Text), notes_txt.Text, usertxt.Text, "غير مسدد");

                MessageBox.Show("تم الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_txt.Clear(); cost_txt.Clear(); notes_txt.Clear();
            }
        }
    }
}
