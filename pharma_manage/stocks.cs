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
    public partial class stocks : Form
    {
        public stocks()
        {
            InitializeComponent();
        }

        private void stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);

        }

        private void save_brn_Click(object sender, EventArgs e)
        {
            try
            {
                stock_tableTableAdapter.FillBy_name(dataSet1.stock_table, name_txt.Text);
                foreach (DataRow dr in dataSet1.stock_table.Rows)
                {
                    if (dr["stock_name"].ToString() == name_txt.Text)
                    {
                        MessageBox.Show("المخزن موجودة مسبقا", "توقف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

                stock_tableTableAdapter.Insert(name_txt.Text, notes_txt.Text);
                numbers_tableTableAdapter1.Insert(1, 1, 1, 1, name_txt.Text,1,1,1,1);
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_txt.Clear(); notes_txt.Clear(); name_txt.Focus();
                this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void delete_product_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف المخزن", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                stock_tableTableAdapter.Delete_by_id(pro_id);
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);

        }
        int pro_id;

        private void dataGridView8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int selectedrowindex = dataGridView8.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView8.Rows[selectedrowindex];
                pro_id = Convert.ToInt32(selectedRow.Cells[0].Value);
               
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
