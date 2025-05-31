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
    public partial class resp_list : Form
    {
        public resp_list()
        {
            InitializeComponent();
        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if (cst_nameTXT.Text == "") 
                {
                    resp_tableTableAdapter.Fill(dataSet1.resp_table);
                }
                else
                {
                    resp_tableTableAdapter.FillBy_NAME_OR_PHONE(dataSet1.resp_table, cst_nameTXT.Text, cst_nameTXT.Text);
                }
            }
            catch { }
        }

        private void resp_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.resp_table' table. You can move, or remove it, as needed.
            this.resp_tableTableAdapter.Fill(this.dataSet1.resp_table);
            suggest_cst_name();


            if (usertxt.Text != "admin")
            {
                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
            }
        }
        private void suggest_cst_name()
        {
            this.resp_tableTableAdapter.Fill(this.dataSet1.resp_table);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            // AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.resp_table.Rows)
            {
                DataCollection.Add(dr["resp_name"].ToString());
                DataCollection.Add(dr["resp_phone"].ToString());
            }


            cst_nameTXT.AutoCompleteCustomSource = DataCollection;



        }
        private void da2n_details_move_click(object sender, EventArgs e)
        {
            most7kat_mas2ooleen md = new most7kat_mas2ooleen();

            md.usertxt.Text = usertxt.Text;
            md.Text = "تفاصيل حساب مسئول";
            md.cst_name_txt.Text = da2n_name;
            md.ShowDialog();
        }


        private void da2n_pay_click(object sender, EventArgs e)
        {
            pay_mas2ool pm = new pay_mas2ool();
            pm.far3txt.Text = far3txt.Text;
            pm.usertxt.Text = usertxt.Text;
            pm.Text = "دفع لمسئول من الحساب";
            pm.da2n_nameTXT.Text = da2n_name;
            pm.ShowDialog();
            cst_nameTXT_TextChanged(sender, e);


        }

        private void ta3deel_click(object sender, EventArgs e)
        {
            da2n_edit pm = new da2n_edit();

            pm.textBox1.Text = da2n_name;

            pm.ShowDialog();

        }

        private void delete_Click(object sender, EventArgs e)
        {


            DialogResult re = MessageBox.Show("هل تريد حذف المسئول  ؟ " + da2n_name + " ?  سيتم حذف كشف الحساب نهائيا", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                resp_tableTableAdapter.Delete_by_resp_name(da2n_name);
                mosta7akat_mas2oleen_tableTableAdapter1.Delete_by_name(da2n_name);
                deleted_tableTableAdapter1.Insert(DateTime.Today, "", da2n_name, byan, usertxt.Text, "قائمة الدائنين");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cst_nameTXT_TextChanged(sender, e);
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
                var da2n_details_move = new MenuItem("تفاصيل حساب مسئول");
                var da2n_pay_ = new MenuItem("دفع مبلغ إلى مسئول");
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




                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
    }
}
