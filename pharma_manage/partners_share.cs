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
    public partial class partners_share : Form
    {
        public partners_share()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                partners_share_tableTableAdapter1.FillBy_name(dataSet11.partners_share_table, name_txt.Text);
                if (dataSet11.partners_share_table.Rows.Count > 0) 
                {
                    return;
                }

                partners_share_tableTableAdapter1.Insert(name_txt.Text, Convert.ToDecimal(amount_txt.Text), notes_txt.Text,dateTimePicker1.Value,null);
                MessageBox.Show("تمت الاضافة بنجاح" + " ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                name_txt.Clear(); name_txt.Focus(); amount_txt.Clear(); notes_txt.Clear();

                partners_share_tableTableAdapter1.Fill(dataSet11.partners_share_table);
               // partners_share_tableTableAdapter1.FillBy_SUM_TOTAL(dataSet11.partners_share_table);


            }
            catch { }
        }

        private void partners_share_Load(object sender, EventArgs e)
        {
            partners_share_tableTableAdapter1.Fill(dataSet11.partners_share_table);
            dateTimePicker1.Value = DateTime.Today;
          
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            if (name_txt.Text == "")
            {
                partners_share_tableTableAdapter1.Fill(dataSet11.partners_share_table);
            }
            else 
            {
                partners_share_tableTableAdapter1.FillBy_name(dataSet11.partners_share_table,name_txt.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                decimal sum = 0;
             

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                }
                total_txt.Text = sum.ToString();
            }
            catch { }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف حصة الشريك "+name+" ?", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                partners_share_tableTableAdapter1.Delete_by_id(id);
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.partners_share_tableTableAdapter1.Fill(this.dataSet11.partners_share_table);

        }

        private void leave_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد تحديد تاريخ مغادرة الشريك  " + name + " ?", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                partners_share_tableTableAdapter1.Update_end_date_by_name(DateTime.Today.ToShortDateString(),name);
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.partners_share_tableTableAdapter1.Fill(this.dataSet11.partners_share_table);

        }
        int id;
        string name;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(pro_id_pub.ToString());
                name = Convert.ToString(selectedRow.Cells[1].Value);
                //stock = selectedRow.Cells[3].Value.ToString();
                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();

                user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, usertxt.Text);
                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {


                    if (dr["user_previliges"].ToString() == "إضافة مستخدم")
                    {
                        var delete = new MenuItem("حذف");
                        m.MenuItems.Add(delete);
                        delete.Click += delete_Click;


                        var leave = new MenuItem("تحديد تاريخ المغادرة بتاريخ اليوم");
                        m.MenuItems.Add(leave);
                        leave.Click += leave_Click;
                    }
                }

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ta2feel_arba7 t = new ta2feel_arba7();
            t.user_txt.Text = usertxt.Text;
            t.far3_txt.Text = far3_txt.Text;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(t);
            f.ApplyFormStyling(t);

            t.ShowDialog();
        }
    }
}
