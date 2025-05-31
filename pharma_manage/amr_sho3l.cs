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
    public partial class amr_sho3l : Form
    {
        public amr_sho3l()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void amr_sho3l_Load(object sender, EventArgs e)
        {
            try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table,far3txt.Text);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["amr_sh3l_id"].ToString();
            }
            catch { }


            this.mo3adalat_tasnee3_tableTableAdapter1.Fill(this.dataSet11.mo3adalat_tasnee3_table);
            foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows) 
            {
                if (mo3adalat_combo_box.Items.Contains(dr["mo3adalat_tasnee3_pro_name"].ToString()))
                {
                }
                else 
                {
                    mo3adalat_combo_box.Items.Add(dr["mo3adalat_tasnee3_pro_name"].ToString());
                }
            }
        }

        private void mo3adalat_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, mo3adalat_combo_box.Text);
            try
            {
                foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                {
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, dr["mo3adalat_tasnee3_material_name"].ToString(),far3txt.Text);
                    decimal unit_price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                    
                    
                    dataGridView1.Rows.Add(dr["mo3adalat_tasnee3_material_name"].ToString(), Convert.ToDecimal(dr["mo3adalat_tasnee3_material_count"]) * Convert.ToDecimal(countTXT.Text),unit_price,"", dr["mo3adalat_tasnee3_notes"].ToString());

                    if (dataGridView1.Columns.Count == 5)
                    {
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                        btn.Width = 75;
                        btn.Text = "حذف";
                        btn.DefaultCellStyle.BackColor = Color.Red;
                        btn.Name = "الحذف";
                        btn.UseColumnTextForButtonValue = true;


                        dataGridView1.Columns.Add(btn);
                    }
                }
            }
            catch { }
        }

        private void mo3adalat_combo_box_TextChanged(object sender, EventArgs e)
        {
            mo3adalat_combo_box_SelectedIndexChanged(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف   " + selectedRow.Cells[0].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.numbers_tableTableAdapter1.FillBy_stock(this.dataSet11.Numbers_table,far3txt.Text);
                salesID_TXT.Text = dataSet11.Numbers_table.Rows[0]["amr_sh3l_id"].ToString();
            }
            catch { }

            try 
            {
                decimal sum_material= 0;

                foreach (DataGridViewRow dgr in dataGridView1.Rows) 
                {
                    dgr.Cells[3].Value = Convert.ToDecimal(dgr.Cells[1].Value) * Convert.ToDecimal(dgr.Cells[2].Value);
                    sum_material += Convert.ToDecimal(dgr.Cells[3].Value);
                }
                materials_total_txt.Text = sum_material.ToString();
            }
            catch { }

            try
            {
                decimal sum = 0;


                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView2.Rows[i].Cells[1].Value);


                }
                masrofat_total_txt.Text = sum.ToString();
            }
            catch { }

            try 
            {
                total_all_txt.Text = (Convert.ToDecimal(masrofat_total_txt.Text) + Convert.ToDecimal(materials_total_txt.Text)).ToString("0.00");

            }
            catch { }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                string amr_num_txt = salesID_TXT.Text;


                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, mo3adalat_combo_box.Text,far3txt.Text);
                if (dataSet11.products_table.Rows.Count <= 0)
                {
                    decimal book_cost = (Convert.ToDecimal(masrofat_total_txt.Text) + Convert.ToDecimal(materials_total_txt.Text)) / Convert.ToDecimal(countTXT.Text);
                    products_tableTableAdapter1.Insert_product(mo3adalat_combo_box.Text, "", book_cost, 0, 0, 0, DateTime.Today.ToShortDateString(), "", "", ""
                        , "", user_txt.Text, 0, far3txt.Text, 1, 0, 0, 0, "", "تم الجرد", dateTimePicker1.Value.ToShortDateString());

                    // products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text,stock_txt.Text);
                    products_tableTableAdapter1.FillBy_last_id(dataSet11.products_table);
                    int intcode = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"].ToString());
                    //   MessageBox.Show(intcode.ToString());
                    products_tableTableAdapter1.Update_int_code_by_id(intcode.ToString(), intcode);

                }
                else 
                {
                    int id= Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"]);
                    decimal book_cost = (Convert.ToDecimal(masrofat_total_txt.Text) + Convert.ToDecimal(materials_total_txt.Text)) / Convert.ToDecimal(countTXT.Text);
                    products_tableTableAdapter1.Update_cost_price_5_by_id(book_cost, id);
                }


                //amr table
                amr_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), dateTimePicker1.Value, mo3adalat_combo_box.Text, Convert.ToDecimal(countTXT.Text), user_txt.Text);
                //amr materials
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    amr_material_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), mo3adalat_combo_box.Text, dgr.Cells[0].Value.ToString(), Convert.ToDecimal(dgr.Cells[1].Value),
                        dgr.Cells[4].Value.ToString(), user_txt.Text, Convert.ToDecimal(dgr.Cells[2].Value));
                }


                //amr masrofat
                //  dataGridView2.Rows.Remove(dataGridView2.Rows[dataGridView1.Rows.Count - 1]);
                this.dataGridView2.AllowUserToAddRows = false;

                foreach (DataGridViewRow dgr in dataGridView2.Rows)
                {
                    // MessageBox.Show(dgr.Cells[0].Value.ToString());
                    //  هنا مشكله
                    // MessageBox.Show(dgr.Cells[0].Value.ToString());
                    try
                    {
                        string byan;
                        string notes;
                        decimal amount;
                        if (dgr.Cells[0].Value.ToString() == "")
                        {
                            byan = "";
                            notes = "";
                            amount = 0;
                        }
                        else
                        {

                            byan = dgr.Cells[0].Value.ToString();
                            //notes = dgr.Cells[2].Value.ToString();
                            amount = Convert.ToDecimal(dgr.Cells[1].Value);
                        }


                        // MessageBox.Show(dgr.Cells[1].Value.ToString());

                        if (byan != "")
                        {
                            amr_masrofat_tableTableAdapter1.Insert(Convert.ToInt32(salesID_TXT.Text), byan, amount, user_txt.Text);
                        }
                    }
                    catch { }
                }
                //numbers 
                numbers_tableTableAdapter1.Update_amr_sho3l(far3txt.Text);
                DialogResult r = MessageBox.Show("تم الحفظ بنجاح هل تريد سحب الخامات الان ؟", "تم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (r == DialogResult.OK)
                {
                    mas7obat_fatora m = new mas7obat_fatora();
                    m.user_txt.Text = user_txt.Text;
                    m.Text = "فاتورة مسحوبات";
                    m.far3txt.Text = far3txt.Text;
                    m.amr_sho3l_txt.Text = amr_num_txt;
                    m.cst_nameTXT.Focus();
                    m.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            //}
            //catch { }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = this.dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.dataGridView2.Rows[rowIndex];

                int column_index = this.dataGridView2.SelectedCells[0].ColumnIndex;

                if (dataGridView2.Columns.Count == 2)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                    btn.Width = 75;
                    btn.Text = "حذف";
                    btn.DefaultCellStyle.BackColor = Color.Red;
                    btn.Name = "الحذف";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView2.Columns.Add(btn);
                }
            }
            catch { }
        }

        private void countTXT_TextChanged(object sender, EventArgs e)
        {
            mo3adalat_combo_box_SelectedIndexChanged(sender, e);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف   " + selectedRow.Cells[0].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView2.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

       
    }
}
