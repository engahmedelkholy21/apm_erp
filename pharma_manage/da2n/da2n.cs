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
    public partial class da2n : Form
    {
        public da2n()
        {
            InitializeComponent();
        }

        private void da2n_Load(object sender, EventArgs e)
        {
            this.da2n_small_reportsTableAdapter.Fill(this.dataSet1.da2n_small_reports);
            da2n_small_reportsTableAdapter.Delete_when0();
            // TODO: This line of code loads data into the 'dataSet1.da2n_small_reports' table. You can move, or remove it, as needed.
            this.da2n_small_reportsTableAdapter.Fill(this.dataSet1.da2n_small_reports);

            //suggest
            try
            {
                search_text.AutoCompleteMode = AutoCompleteMode.Suggest;
                search_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet1.da2n_small_reports.Rows)
                {
                    DataCollection.Add(dr["da2n_small_name"].ToString());
                }

                search_text.AutoCompleteCustomSource = DataCollection;
            }
            catch { }


            if (usertxt.Text != "admin")
            {
                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                egmalyTXT.Text = sum.ToString();

                da2n_small_reportsTableAdapter.Delete_when0();

            }
            catch { }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (search_text.Text != "")
            {
                da2n_small_reportsTableAdapter.FillBy_da2n_small_name(dataSet1.da2n_small_reports, search_text.Text);
            }
            else 
            {
                this.da2n_small_reportsTableAdapter.Fill(this.dataSet1.da2n_small_reports);
            }
        }


        private void da2n_details_move_click(object sender, EventArgs e)
        {
            most7kat_da2neen_show md = new most7kat_da2neen_show();

            md.usertxt.Text = usertxt.Text;
            md.Text = "تفاصيل حساب دائن";
            md.cst_name_txt.Text = da2n_name;
            md.ShowDialog();
        }


        private void da2n_pay_click(object sender, EventArgs e)
        {
            pay_da2n pm = new pay_da2n();
            pm.far3txt.Text = far3txt.Text;
            pm.usertxt.Text = usertxt.Text;
            pm.Text = "دفع لدائن من الحساب";
            pm.da2n_nameTXT.Text = da2n_name;
            pm.ShowDialog();
            searchbtn_Click(sender, e);


        }

        private void da2n_add_click(object sender, EventArgs e)
        {
            pay_da2n pm = new pay_da2n();
            pm.far3txt.Text = far3txt.Text;
            pm.usertxt.Text = usertxt.Text;
            pm.Text = "اضافة مبلغ لحساب دائن";
            pm.da2n_nameTXT.Text = da2n_name;
            pm.ShowDialog();
            searchbtn_Click(sender, e);


        }

        private void ta3deel_click(object sender, EventArgs e)
        {
            da2n_edit pm = new da2n_edit();

            pm.textBox1.Text = da2n_name;
            
            pm.ShowDialog();

        }

        private void delete_Click(object sender, EventArgs e)
        {


            DialogResult re = MessageBox.Show("هل تريد حذف الدائن ؟ " + da2n_name + " ?  سيتم حذف كشف الحساب نهائيا", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                da2n_small_reportsTableAdapter.Delete_by_name(da2n_name);
                mosta7akat_da2neen_tableTableAdapter1.Delete_by_name(da2n_name);
                deleted_tableTableAdapter1.Insert(DateTime.Today, "", da2n_name, byan, usertxt.Text, "قائمة الدائنين");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchbtn_Click(sender, e);
            }
        }
        string da2n_name;

        string byan;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedrowindex].Selected = true;


                //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                da2n_name = selectedRow.Cells[1].Value.ToString();
                byan = "المبلغ المستحق وقتها" + Convert.ToString(selectedRow.Cells[4].Value);
                //  pro_name_pub = Convert.ToString(selectedRow.Cells[2].Value);
                var m = new ContextMenu();
                var da2n_details_move = new MenuItem("تفاصيل حساب دائن");
                var da2n_pay_ = new MenuItem("دفع مبلغ إلى دائن");

              
                m.MenuItems.Add(da2n_details_move);
                m.MenuItems.Add(da2n_pay_);
               


                da2n_details_move.Click += da2n_details_move_click;
                da2n_pay_.Click += da2n_pay_click;


                var da2n_add = new MenuItem("اضافة مبلغ لحساب دائن");
                m.MenuItems.Add(da2n_add);
                da2n_add.Click += da2n_add_click;


                if (listBox1.Items.Contains("إضافة مستخدم"))
                {

                    var delete = new MenuItem("حذف");

                    m.MenuItems.Add(delete);
                    delete.Click += delete_Click;


                    var ta3deel = new MenuItem("تعديل");
                    m.MenuItems.Add(ta3deel);
                    ta3deel.Click += ta3deel_click;

                }




                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.da2n_small_reportsTableAdapter.Fill(this.dataSet1.da2n_small_reports);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            da2n_print d = new da2n_print();
            d.ShowDialog();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Apps)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                da2n_name = selectedRow.Cells[1].Value.ToString();
                byan = "المبلغ المستحق وقتها" + Convert.ToString(selectedRow.Cells[4].Value);
                //  pro_name_pub = Convert.ToString(selectedRow.Cells[2].Value);
                var m = new ContextMenu();
                var da2n_details_move = new MenuItem("تفاصيل حساب دائن");
                var da2n_pay_ = new MenuItem("دفع مبلغ إلى دائن");
                var ta3deel = new MenuItem("تعديل");
                m.MenuItems.Add(da2n_details_move);
                m.MenuItems.Add(da2n_pay_);
                m.MenuItems.Add(ta3deel);


                da2n_details_move.Click += da2n_details_move_click;
                da2n_pay_.Click += da2n_pay_click;
                ta3deel.Click += ta3deel_click;

                if (listBox1.Items.Contains("إضافة مستخدم"))
                {

                    var delete = new MenuItem("حذف");

                    m.MenuItems.Add(delete);
                    delete.Click += delete_Click;


                }

                try
                {
                    m.Show(dataGridView1, new Point(dataGridView1.Location.X + dataGridView1.Width, dataGridView1.Location.Y +
                   dataGridView1.GetCellDisplayRectangle(0, selectedrowindex + 1, true).Location.Y));
                }
                catch
                {
                    m.Show(dataGridView1, new Point(0, 0));
                }
                //int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                //m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
    }
}
