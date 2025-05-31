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
    public partial class add_assets : Form
    {
        public add_assets()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void add_assets_Load(object sender, EventArgs e)
        {
            suggest_asl();
        }

        private void suggest_asl()
        {
            this.assets_tableTableAdapter.Fill(this.dataSet1.assets_table);
            nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.assets_table.Rows)
            {
                DataCollection.Add(dr["asset_name"].ToString());
                
            }

            nameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    sum += Convert.ToDecimal(dgr.Cells[3].Value);
                }
                textBox1.Text = sum.ToString();
            }
            catch { }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                assets_tableTableAdapter.FillBy_name(dataSet1.assets_table, nameTXT.Text);
                if (dataSet1.assets_table.Rows.Count <= 0)
                {
                    assets_tableTableAdapter.Insert(dateTimePicker1.Value, nameTXT.Text, Convert.ToDecimal(cost_txt.Text), notes_txt.Text, usertxt.Text);
                     DialogResult re = MessageBox.Show("تمت الاضافة بنجاح . هل تريد صرف قيمة الأصل من الخزينة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (re == DialogResult.Yes)
                     {
                         //safe_users_tableTableAdapter1.FillBy_user(dataSet1.safe_users_table, usertxt.Text);

                         //if (Convert.ToDecimal(dataSet1.safe_users_table.Rows[0]["safe_users_amount"]) >= Convert.ToDecimal(cost_txt.Text))
                         //{
                         //    safe_users_tableTableAdapter1.Update_sarf_from_safe_users(Convert.ToDecimal(cost_txt.Text), usertxt.Text);
                         //}
                         //else
                         //{
                         //    MessageBox.Show("رصيد خزينتك لا يسمح برجاء المراجعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         //    return;
                         //}
                         string details = "قيمة أصل " + nameTXT.Text;
                         outcome_tableTableAdapter1.Insert_outcome(dateTimePicker1.Value.ToShortDateString(), details, Convert.ToDecimal(cost_txt.Text), 0,"اصول","اصول", usertxt.Text, notes_txt.Text,far3txt.Text);
                         safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(cost_txt.Text));
                         decimal tarh = Convert.ToDecimal(cost_txt.Text) * -1;
                         safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), tarh);
 
                     }
                    nameTXT.Clear(); cost_txt.Clear(); notes_txt.Clear();
                    this.assets_tableTableAdapter.Fill(this.dataSet1.assets_table);
                    suggest_asl();
                }
                else
                {
                    MessageBox.Show("الاصل مضاف مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }


            }
            catch { }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف الاصل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                assets_tableTableAdapter.Delete_by_id(id);
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.assets_tableTableAdapter.Fill(this.dataSet1.assets_table);

        }
        int id;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(pro_id_pub.ToString());
                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();
                var delete = new MenuItem("حذف");

                m.MenuItems.Add(delete);

                //  (mi);
                // handle menu item click event here [as required]
                delete.Click += delete_Click;

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
    }
}
