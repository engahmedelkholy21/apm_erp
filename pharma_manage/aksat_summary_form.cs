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
    public partial class aksat_summary_form : Form
    {
        public aksat_summary_form()
        {
            InitializeComponent();
        }

        private void aksat_summary_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.aksat_summary' table. You can move, or remove it, as needed.
              suggest_cst_name();
            substringAutoCompleteTextBox1.TextBox_.KeyDown += substringAutoCompleteTextBox1_textbox_KeyDown;
            substringAutoCompleteTextBox1.Listbox_.KeyDown += substringAutoCompleteTextBox1_textbox_KeyDown;
            substringAutoCompleteTextBox1.AttachListBoxToParent(this);


            decimal sum_paid = 0;
            decimal sum_not_paid = 0;
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                sum_paid += Convert.ToDecimal(dgr.Cells[10].Value);
                sum_not_paid += Convert.ToDecimal(dgr.Cells[12].Value);
            }
            total_not_paid_txt.Text = sum_not_paid.ToString();
            total_paid.Text = sum_paid.ToString();
        }
        private void suggest_cst_name()
        {
            this.aksat_summaryTableAdapter.Fill_all(this.dataSet1.aksat_summary);

            substringAutoCompleteTextBox1.SetSuggestions(dataSet1.aksat_summary, "kest_cst_name");

        }
        private void substringAutoCompleteTextBox1_textbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    if (substringAutoCompleteTextBox1.TextBox_.Text == "")
                    {
                        aksat_summaryTableAdapter.Fill_all(this.dataSet1.aksat_summary);
                    }
                    else
                    {
                        aksat_summaryTableAdapter.FillBy_kest_cst_code(dataSet1.aksat_summary, substringAutoCompleteTextBox1.TextBox_.Text);
                        if (dataSet1.aksat_summary.Rows.Count <= 0)
                        {
                            aksat_summaryTableAdapter.FillBy_loan_code(dataSet1.aksat_summary, substringAutoCompleteTextBox1.TextBox_.Text);
                        }
                        if (dataSet1.aksat_summary.Rows.Count <= 0)
                        {
                            aksat_summaryTableAdapter.FillBy_like_cst_name(dataSet1.aksat_summary, substringAutoCompleteTextBox1.TextBox_.Text);
                        }
                    }

                    decimal sum_paid = 0;
                    decimal sum_not_paid = 0;
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        sum_paid += Convert.ToDecimal(dgr.Cells[10].Value);
                        sum_not_paid += Convert.ToDecimal(dgr.Cells[12].Value);
                    }
                    total_not_paid_txt.Text = sum_not_paid.ToString();
                    total_paid.Text = sum_paid.ToString();

                }
                catch { }
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                loan_aksat_show l = new loan_aksat_show();
                l.user_txt.Text = user_txt.Text;
                l.far3_txt.Text = far3txt.Text;
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                l.substringAutoCompleteTextBox1.TextBox_.Text = selectedRow.Cells[0].Value.ToString();
                Form1 f = new Form1();
                f.SubscribeToLoadEvent(l);
                f.ApplyFormStyling(l);
                l.ShowDialog();
            }
            catch { }
        }
       
    }
}
