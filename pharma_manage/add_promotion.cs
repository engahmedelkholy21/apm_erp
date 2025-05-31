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
    public partial class add_promotion : Form
    {
        public add_promotion()
        {
            InitializeComponent();
            start_date_txt.Value = DateTime.Today;
            end_date_txt.Value = DateTime.Today;
        }
        private void suggest_product()
        {
            try
            {
                this.products_tableTableAdapter1.FillBy_stock_and_not_5amat(this.dataSet11.products_table, far3txt.Text);
                product_code_TXT.AutoCompleteMode = AutoCompleteMode.Suggest;
                product_code_TXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection1 = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet11.products_table.Rows)
                {
                    DataCollection1.Add(dr["pro_name"].ToString());
                }
                //mo3adalat_tasnee3_tableTableAdapter1.Fill(dataSet11.mo3adalat_tasnee3_table);
                //foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                //{
                //    DataCollection1.Add(dr["mo3adalat_tasnee3_pro_name"].ToString());
                //}

                product_code_TXT.AutoCompleteCustomSource = DataCollection1;
            }
            catch { }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_promotion_Load(object sender, EventArgs e)
        {
            suggest_product();

            if (type_txt.Text == "add")
            {
                button1.Text = "إضافة العرض";

            }
            else if (type_txt.Text == "edit")
            {
                button1.Text = "تعديل العرض";

                promo_tableTableAdapter1.FillBy_promo_name(dataSet11.promo_table, old_name_txt.Text);
                promo_name_txt.Text = dataSet11.promo_table.Rows[0]["promo_name"].ToString();
                start_date_txt.Value = Convert.ToDateTime(dataSet11.promo_table.Rows[0]["promo_start_date"]);
                end_date_txt.Value = Convert.ToDateTime(dataSet11.promo_table.Rows[0]["promo_end_date"]);

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.Width = 65;
                btn.Text = "حذف";
                btn.DefaultCellStyle.BackColor = Color.Red;
                // btn.Name = "الحذف";
                btn.UseColumnTextForButtonValue = true;


                dataGridView1.Columns.Add(btn);
                foreach (DataRow dr in dataSet11.promo_table.Rows) 
                {
                    dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), dr["promo_item_code"].ToString(), dr["promo_item_name"].ToString(), dr["promo_item_price"].ToString(), btn);
                     
                }

            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (product_code_TXT.Text == "")
            {
                MessageBox.Show("ادخل اسم اوكود المنتج");
                product_code_TXT.Focus();
                return;
            }

            if (pro_name_txt.Text == "")
            {
                MessageBox.Show("ادخل اسم اوكود المنتج");
                product_code_TXT.Focus();
                return;
            }
            if (promo_price_txt.Text == "")
            {
                MessageBox.Show("ادخل السعر في العرض");
                promo_price_txt.Focus();
                return;
            }

            products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_code_TXT.Text, far3txt.Text);
            if (dataSet11.products_table.Rows.Count <= 0)
            {
                products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_code_TXT.Text, far3txt.Text);
            }
            string pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
            string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
            //string pro_name = dataSet11.products_table.Rows[0][""].ToString();
            //string pro_name = dataSet11.products_table.Rows[0][""].ToString();

            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.Width = 65;
                btn.Text = "حذف";
                btn.DefaultCellStyle.BackColor = Color.Red;
               // btn.Name = "الحذف";
                btn.UseColumnTextForButtonValue = true;


                dataGridView1.Columns.Add(btn);

            dataGridView1.Rows.Add((dataGridView1.Rows.Count + 1).ToString(), pro_code, pro_name,promo_price_txt.Text,btn );

            product_code_TXT.Text = "";
            original_price_txt.Text = "";
            promo_price_txt.Text = "";
            pro_name_txt.Text = "";
            product_code_TXT.Focus();


        }

        private void product_code_TXT_TextChanged(object sender, EventArgs e)
        {
            if (product_code_TXT.Focused == true)
            {
                if (product_code_TXT.Text != "")
                {
                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, product_code_TXT.Text, far3txt.Text);
                    if (dataSet11.products_table.Rows.Count <= 0)
                    {
                        products_tableTableAdapter1.FillBy_name_and_far3(dataSet11.products_table, product_code_TXT.Text, far3txt.Text);
                    }
                    if (dataSet11.products_table.Rows.Count > 0)
                    {
                        pro_name_txt.Text = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                        original_price_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    }
                    else 
                    {
                        pro_name_txt.Text = "";
                        original_price_txt.Text = "";
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    DialogResult re = MessageBox.Show("هل تريد حذف الصنف  " + selectedRow.Cells[2].Value.ToString() + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (promo_name_txt.Text == "")
                {
                    MessageBox.Show("أدخل اسم العرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    promo_name_txt.SelectAll();
                    promo_name_txt.Focus();
                    return;
                }

                if (type_txt.Text == "add")
                {
                    promo_tableTableAdapter1.FillBy_promo_name(dataSet11.promo_table, promo_name_txt.Text);
                    if (dataSet11.promo_table.Rows.Count > 0)
                    {
                        MessageBox.Show("العرض موجود مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        promo_name_txt.SelectAll();
                        promo_name_txt.Focus();
                        return;
                    }
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        string pro_code = dgr.Cells[1].Value.ToString();
                        string pro_name = dgr.Cells[2].Value.ToString();
                        decimal pro_price = Convert.ToDecimal(dgr.Cells[3].Value);
                        promo_tableTableAdapter1.Insert(promo_name_txt.Text, start_date_txt.Value, end_date_txt.Value, pro_name, pro_code, pro_price, "", "متاح");
                    }
                    MessageBox.Show("تمت اضافة العرض بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                else if (type_txt.Text == "edit")
                {
                    promo_tableTableAdapter1.Delete_by_promo_name(old_name_txt.Text);
                    promo_tableTableAdapter1.FillBy_promo_name(dataSet11.promo_table, promo_name_txt.Text);
                    if (dataSet11.promo_table.Rows.Count > 0)
                    {
                        MessageBox.Show("العرض موجود مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        promo_name_txt.SelectAll();
                        promo_name_txt.Focus();
                        return;
                    }
                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        string pro_code = dgr.Cells[1].Value.ToString();
                        string pro_name = dgr.Cells[2].Value.ToString();
                        decimal pro_price = Convert.ToDecimal(dgr.Cells[3].Value);
                        promo_tableTableAdapter1.Insert(promo_name_txt.Text, start_date_txt.Value, end_date_txt.Value, pro_name, pro_code, pro_price, "", "متاح");
                    }
                    MessageBox.Show("تم تعديل العرض بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                
             
                product_code_TXT.Text = "";
                original_price_txt.Text = "";
                promo_price_txt.Text = "";
                promo_name_txt.Text = "";
                promo_name_txt.Text = "";
                start_date_txt.Value = DateTime.Today;
                end_date_txt.Value = DateTime.Today;
                dataGridView1.Rows.Clear();
                promo_name_txt.Focus();

            }
            catch { }
        }
    }
}
