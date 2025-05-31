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
    public partial class add_category : Form
    {
        public add_category()
        {
            InitializeComponent();
        }

        private void add_category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.dataSet1.Category);

        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            try 
            {
                categoryTableAdapter.FillBy_name(dataSet1.Category, name_txt.Text);
                foreach (DataRow dr in dataSet1.Category.Rows)
                {
                    if (dr["Category_name"].ToString() == name_txt.Text)
                    {
                        MessageBox.Show("الفئة موجودة مسبقا", "توقف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                if (cat_extra_txt.Text == "") 
                {
                    cat_extra_txt.Text = "0";
                }

                categoryTableAdapter.Insert(name_txt.Text, Convert.ToDouble(dariba_txt.Text)/100, notes_txt.Text,Convert.ToDecimal(cat_extra_txt.Text));
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_txt.Clear(); notes_txt.Clear(); name_txt.Focus(); cat_extra_txt.Clear();
                dariba_txt.Text = "0";
                this.categoryTableAdapter.Fill(this.dataSet1.Category);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
