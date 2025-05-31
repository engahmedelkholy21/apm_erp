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
    public partial class category_list : Form
    {
        public category_list()
        {
            InitializeComponent();
        }

        private void category_list_Load(object sender, EventArgs e)
        {
            suggest_category();
        }

        private void suggest_category()
        {
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.Category.Rows)
            {
                DataCollection.Add(dr["Category_name"].ToString());
            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                categoryTableAdapter.FillBy_name(dataSet1.Category, name_txt.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
        }
        private void delete_product_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف الفئة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                categoryTableAdapter.Delete_by_id(pro_id);
                deleted_tableTableAdapter1.Insert(DateTime.Today, pro_id.ToString(), pro_name, "", usertxt.Text, "فئات الاصناف");
                DialogResult ree = MessageBox.Show("هل تريد حذف جميع اصناف الفئة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ree == DialogResult.Yes)
                {
                    products_tableTableAdapter1.Delete_by_cat(pro_name);
                }
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.categoryTableAdapter.Fill(this.dataSet1.Category);

        }
        int pro_id;
        string pro_name;
        private void dataGridView8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int selectedrowindex = dataGridView8.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView8.Rows[selectedrowindex];
                pro_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(pro_id_pub.ToString());
                pro_name = Convert.ToString(selectedRow.Cells[1].Value);
                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();
                var delete = new MenuItem("حذف");
                
               
                m.MenuItems.Add(delete);
               

                //  (mi);
                // handle menu item click event here [as required]
                delete.Click += delete_product_Click;
               

                int currentMouseOverRow = dataGridView8.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView8, new Point(e.X, e.Y));

            }
        }
    }
}
