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
    public partial class edit_aksat : Form
    {
        public edit_aksat()
        {
            InitializeComponent();
        }

        private void edit_aksat_Load(object sender, EventArgs e)
        {
            search_method();

        }
        private void search_method() 
        {
            aksat_tableTableAdapter1.FillBy_loan_code_not_paid(dataSet11.aksat_table, loan_code_txt.Text, far3_txt.Text);
            decimal sum=0;

            foreach (DataRow dr in dataSet11.aksat_table.Rows)
            {
                if (dr["kest_status"].ToString() != "مسدد")
                {
                    dataGridView1.Rows.Add(dr["kest_number"].ToString(),Convert.ToDateTime(dr["kest_est7kak_date"]).ToShortDateString(), dr["kest_amount"].ToString());
                    sum += Convert.ToDecimal(dr["kest_amount"]);
                }
            }
           most7ak_txt.Text=sum.ToString();
        }

        decimal originalValue = 0m;
        bool adjusting = false;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1)
            {
                object val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                decimal result;
                if (val != null && decimal.TryParse(val.ToString(), out result))
                {
                    originalValue = result;
                }
                else
                {
                    originalValue = 0m;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (adjusting) return;

            int costColIndex = dataGridView1.Columns.Count - 1;
            if (e.ColumnIndex != costColIndex) return;

            object val = dataGridView1.Rows[e.RowIndex].Cells[costColIndex].Value;
            decimal newValue;
            if (!decimal.TryParse(Convert.ToString(val), out newValue)) return;

            decimal difference = newValue - originalValue;
            if (difference == 0m) return;

            decimal total;
            if (!decimal.TryParse(most7ak_txt.Text, out total)) return;

            // Step 1: Count how many rows originally had the same value (excluding the current one)
            int countSameOriginal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == e.RowIndex || dataGridView1.Rows[i].IsNewRow) continue;

                object cellVal = dataGridView1.Rows[i].Cells[costColIndex].Value;
                decimal cellDec;
                if (decimal.TryParse(Convert.ToString(cellVal), out cellDec))
                {
                    if (cellDec == originalValue)
                        countSameOriginal++;
                }
            }

            if (countSameOriginal == 0) return;

            decimal share = difference / countSameOriginal;
            adjusting = true;

            // Step 2: Subtract share only from rows that matched the original value
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == e.RowIndex || dataGridView1.Rows[i].IsNewRow) continue;

                object cellVal = dataGridView1.Rows[i].Cells[costColIndex].Value;
                decimal cellDec;
                if (decimal.TryParse(Convert.ToString(cellVal), out cellDec))
                {
                    if (cellDec == originalValue)
                    {
                        dataGridView1.Rows[i].Cells[costColIndex].Value = Math.Round(cellDec - share, 2);
                    }
                }
            }

            adjusting = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(most7ak_txt.Text) == Convert.ToDecimal(total_txt.Text))
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    aksat_tableTableAdapter1.Update_loan_code_not_paid_far3_kest_num(Convert.ToDecimal(dgr.Cells[2].Value), loan_code_txt.Text, far3_txt.Text, Convert.ToInt32(dgr.Cells[0].Value));
                }
                MessageBox.Show("تم التعديل بنجاح");
                this.Close();
            }
            else 
            {
                MessageBox.Show("تأكد أن قيمة الاجمالي مطابقة لقيمة المبلغ المستحق","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    sum += Convert.ToDecimal(dgr.Cells[2].Value);
                }
                total_txt.Text = sum.ToString();
            }
            catch { }
        }
        
    }
}
