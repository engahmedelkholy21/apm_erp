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
    public partial class edit_category : Form
    {
        public edit_category()
        {
            InitializeComponent();
        }

        private void edit_category_Load(object sender, EventArgs e)
        {
            suggest_category();
        }

        private void suggest_category()
        {
            this.categoryTableAdapter1.Fill(this.dataSet11.Category);
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.Category.Rows)
            {
                DataCollection.Add(dr["Category_name"].ToString());
               

            }

            textBox1.AutoCompleteCustomSource = DataCollection;

        }

        

        private void save_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                //products_tableTableAdapter1.FillBy_category_stock(dataSet11.products_table, textBox1.Text,far3txt.Text);
                //foreach (DataRow dr in dataSet11.products_table.Rows) 
                //{
                //   string pro_id = dr["pro_ID"].ToString();

                //   products_tableTableAdapter1.Update_category_by_id(name_txt.Text, Convert.ToInt32(pro_id));

                //}

            products_tableTableAdapter1.Update_pro_cat_by_old_pro_cat(name_txt.Text, textBox1.Text);

            sales_tableTableAdapter1.Update_pro_cat_by_old_cat(name_txt.Text, textBox1.Text);
                //sales_tableTableAdapter1.FillBy_category_in_fatra(dataSet11.sales_table, textBox1.Text, Convert.ToDateTime("1/1/2000").ToShortDateString(), DateTime.Today.ToShortDateString(),far3txt.Text);
                //foreach (DataRow dr in dataSet11.sales_table.Rows)
                //{
                //    string prod_id = dr["sales_product_ID"].ToString();

                //    sales_tableTableAdapter1.Update_category_by_pro_id(name_txt.Text, prod_id,far3txt.Text);

                //}

            if (cat_extra_txt.Text == "") 
            {
                cat_extra_txt.Text = "0";
            }
                categoryTableAdapter1.Update_by_Category_ID(name_txt.Text,Convert.ToDouble(dariba_txt.Text), notes_txt.Text,Convert.ToDecimal(cat_extra_txt.Text),Convert.ToInt32(cat_id.Text));

                

                name_txt.Clear(); notes_txt.Clear(); dariba_txt.Clear(); textBox1.Clear(); textBox1.Focus();
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                categoryTableAdapter1.FillBy_name(dataSet11.Category, textBox1.Text);
                name_txt.Text = dataSet11.Category.Rows[0]["Category_name"].ToString();
                dariba_txt.Text = dataSet11.Category.Rows[0]["Category_dariba"].ToString();
                notes_txt.Text = dataSet11.Category.Rows[0]["Category_notes"].ToString();
                cat_extra_txt.Text = dataSet11.Category.Rows[0]["cat_extra"].ToString();
                cat_id.Text = dataSet11.Category.Rows[0]["Category_ID"].ToString();
            }
            catch { }
        }

        private void edit_category_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.refresh_categories();
        }
    }
}
