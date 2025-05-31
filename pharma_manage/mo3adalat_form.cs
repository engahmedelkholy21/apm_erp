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
    public partial class mo3adalat_form : Form
    {
        public mo3adalat_form()
        {
            InitializeComponent();
        }
        string value_before_change = "";
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                value_before_change = selectedRow.Cells[2].Value.ToString();
                //  dariba_before_change = selectedRow.Cells[5].Value.ToString();
            }
            catch { }

            try 
            {
                if (this.dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                   // DigitOnly_KeyPress(sender, e);
                }
            }
            catch { }
        }

        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            pro_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            pro_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;


            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());


            }

            pro_name_txt.AutoCompleteCustomSource = DataCollection;
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox control = e.Control as TextBox;
                this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
                control.AutoCompleteMode = AutoCompleteMode.Suggest;
                control.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
                foreach (DataRow row in this.dataSet11.products_table.Rows)
                {
                    strings.Add(row["pro_name"].ToString());
                }
                control.AutoCompleteCustomSource = strings;

            }

            
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
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[rowIndex];

            //int column_index = this.dataGridView1.SelectedCells[0].ColumnIndex;
            //try
            //{
            //    row.Cells[0].Value = this.dataSet11.materials_table.Rows[0]["materials_id"].ToString();
            //}
            //catch
            //{
            //    //  row.Cells[1].Value = "0";
            //}

            if (dataGridView1.Columns.Count == 3)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف منتج  " + selectedRow.Cells[0].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //try 
            //{

            if (pro_name_txt.Text == "")
            {

                MessageBox.Show("ادخل اسم المنتج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pro_name_txt.Focus();
                return;
            }

            if (gomla_gomla_txt.Text == "")
            {

                MessageBox.Show("ادخل اسم سعر البيع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gomla_gomla_txt.Focus();
                return;
            }
            if (this.Text == "معادلة انتاج جديدة")
            {
                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, pro_name_txt.Text);
                if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                {
                    MessageBox.Show("معادلة هذا المنتج موجودة مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pro_name_txt.Focus();
                    return;
                }
                else
                {
                   

                    //foreach (DataRow dr in dataSet11.products_table.Rows)
                    //{
                    //    if (dr["pro_name"].ToString() == pro_name_txt.Text)
                    //    {
                    //        MessageBox.Show("المنتج موجود مسبقا", "توقف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //        return;
                    //    }
                    //}

                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        decimal count = 0;
                        string notes = "";
                        string material_name = "";
                        string pro_name = pro_name_txt.Text;
                        try
                        {
                            material_name = dgr.Cells[0].Value.ToString();
                            count = Convert.ToDecimal(dgr.Cells[1].Value)/Convert.ToDecimal(count_txt.Text);
                            notes = dgr.Cells[2].Value.ToString();
                        }
                        catch { }

                        if (material_name != "")
                        {
                            mo3adalat_tasnee3_tableTableAdapter1.Insert(pro_name, material_name, count, notes, user_txt.Text);
                        }
                    }
                }

                decimal sum_material = 0;
                try
                {
                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, pro_name_txt.Text);
                if (dataSet11.mo3adalat_tasnee3_table.Rows.Count <= 0) 
                {
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, old_name_txt.Text);
                }
                    foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                    {
                        string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                        foreach (DataGridViewRow dgr in dataGridView1.Rows)
                        {
                            try
                            {
                                if (material_name == dgr.Cells[0].Value.ToString())
                                {
                                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);
                                    sum_material += Convert.ToDecimal(dgr.Cells[1].Value) * Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                                }
                            }
                            catch { }
                        }

                    }
                }
                catch { }
                

                 products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name_txt.Text, far3txt.Text);

                 if (dataSet11.products_table.Rows.Count > 0)
                 {
                     products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(sum_material, Convert.ToDecimal(gomla_gomla_txt.Text), Convert.ToDecimal(gomla_gomla_txt.Text), Convert.ToDecimal(gomla_gomla_txt.Text), pro_name_txt.Text);
                 }
                 else
                 {
                     products_tableTableAdapter1.Insert_product(pro_name_txt.Text, category_txt.Text, sum_material, Convert.ToDecimal(gomla_gomla_txt.Text), 0, 0, DateTime.Today.ToShortDateString(), "", ""
                    , "", "", user_txt.Text, 0, far3txt.Text, 1, 0, Convert.ToDecimal(gomla_gomla_txt.Text), Convert.ToDecimal(gomla_gomla_txt.Text), "", "","");

                     products_tableTableAdapter1.FillBy_last_id(dataSet11.products_table);
                     int intcode = Convert.ToInt32(dataSet11.products_table.Rows[0]["pro_ID"].ToString());
                     //   MessageBox.Show(intcode.ToString());
                     products_tableTableAdapter1.Update_int_code_by_id(intcode.ToString(), intcode);
                 }
              
                MessageBox.Show("تمت اضافة المعادلة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pro_name_txt.Clear();
                dataGridView1.Rows.Clear();
                pro_name_txt.Focus();

                //}
                //catch { }
            }
            else 
            {
                mo3adalat_tasnee3_tableTableAdapter1.Delete_by_name(old_name_txt.Text);
             foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    decimal count = 0;
                    string notes = "";
                    string material_name = "";
                    string pro_name = pro_name_txt.Text;
                    try
                    {
                        material_name = dgr.Cells[0].Value.ToString();
                        count = Convert.ToDecimal(dgr.Cells[1].Value);
                        notes = dgr.Cells[2].Value.ToString();
                    }
                    catch { }

                    if (material_name != "")
                    {
                        mo3adalat_tasnee3_tableTableAdapter1.Insert(pro_name, material_name, count, notes, user_txt.Text);
                    }
                }

                decimal sum_material = 0;
                try
                {
                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, pro_name_txt.Text);
                    if (dataSet11.mo3adalat_tasnee3_table.Rows.Count <= 0)
                    {
                        mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, old_name_txt.Text);
                    }
                    foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                    {
                        string material_name = dr["mo3adalat_tasnee3_material_name"].ToString();
                        foreach (DataGridViewRow dgr in dataGridView1.Rows)
                        {
                            try
                            {
                                if (material_name == dgr.Cells[0].Value.ToString())
                                {
                                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, material_name, far3txt.Text);
                                    sum_material += Convert.ToDecimal(dgr.Cells[1].Value) * Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                                }
                            }
                            catch { }
                        }

                    }
                }
                catch { }

                //products_tableTableAdapter1.Update_cost_and_bee3_and_gmhour_and_gomla_gomla(sum_material, Convert.ToDecimal(gomla_gomla_txt.Text), Convert.ToDecimal(gomla_gomla_txt.Text), Convert.ToDecimal(gomla_gomla_txt.Text), old_name_txt.Text);
                products_tableTableAdapter1.Update_pro_name_by_old_name(pro_name_txt.Text, old_name_txt.Text);
               
                MessageBox.Show("تم تعديل المعادلة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
        private void mo3adalat_form_Load(object sender, EventArgs e)
        {
            suggest_product();
            this.categoryTableAdapter1.Fill(dataSet11.Category);
            foreach (DataRow dr in dataSet11.Category.Rows)
            {
                category_txt.Items.Add(dr["Category_name"].ToString());
            }

            if (this.Text == "معادلة انتاج جديدة")
            {

            }
            else 
            {
                mo3adalat_tasnee3_tableTableAdapter1.FillBy_id(dataSet11.mo3adalat_tasnee3_table, Convert.ToInt32(id_txt.Text));
                if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                {
                    pro_name_txt.Text = dataSet11.mo3adalat_tasnee3_table.Rows[0]["mo3adalat_tasnee3_pro_name"].ToString();

                    old_name_txt.Text = dataSet11.mo3adalat_tasnee3_table.Rows[0]["mo3adalat_tasnee3_pro_name"].ToString();

                    mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, old_name_txt.Text);

                    foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                    {
                        dataGridView1.Rows.Add(dr["mo3adalat_tasnee3_material_name"].ToString(), dr["mo3adalat_tasnee3_material_count"].ToString(), dr["mo3adalat_tasnee3_notes"].ToString());
                    }
                    products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name_txt.Text, far3txt.Text);
                    if (dataSet11.products_table.Rows.Count > 0)
                    {
                        category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                        gomla_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    }
                    save_btn.Text = "تعديل";
                }
                else 
                {
                    MessageBox.Show("تأكد من البيانات");
                    this.Close();
                }
            }

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 1)
            //{
            //    TextBox textBox = dataGridView1.EditingControl as TextBox;

            //    if (textBox != null)
            //    {
            //        // Detach the event handler when leaving the column
            //        textBox.KeyPress -= DigitOnly_KeyPress;
            //    }
            //}
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pro_name_txt_TextChanged(object sender, EventArgs e)
        {
            products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, pro_name_txt.Text, far3txt.Text);
            if (dataSet11.products_table.Rows.Count > 0)
            {
                category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                gomla_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                //category_txt.Text = dataSet11.products_table.Rows[0][""].ToString();
            }
            else 
            {
                category_txt.Text = "";
                gomla_gomla_txt.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        


    }
}
