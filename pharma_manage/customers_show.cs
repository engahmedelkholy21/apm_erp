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
    public partial class customers_show : Form
    {
        public customers_show()
        {
            InitializeComponent();
        }

        private void customers_show_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.dataSet1.customers);
            suggest_cst_name();
            total_txt.Text = dataSet1.customers.Rows.Count.ToString();
        }

        private void suggest_cst_name()
        {
            this.customersTableAdapter.Fill(this.dataSet1.customers);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.customers.Rows)
            {
                DataCollection.Add(dr["cst_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void cst_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cst_nameTXT.Text != "")
                {
                    customersTableAdapter.FillBy_name(dataSet1.customers, cst_nameTXT.Text);
                }
                else
                    this.customersTableAdapter.Fill(this.dataSet1.customers);

            }
        }

        private void delete_cst_Click(object sender, EventArgs e)
        {

            madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet1.madeen_small_report, cst_name);

            aksat_tableTableAdapter1.FillBy_kest_cst_name_and_not_paid(dataSet1.aksat_table, cst_name,far3txt.Text);
            if (dataSet1.madeen_small_report.Rows.Count > 0||dataSet1.aksat_table.Rows.Count>0) 
            {
                MessageBox.Show("لا يمكن حذف العميل قبل سداد باقي حسابه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult re = MessageBox.Show("هل تريد حذف العميل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    customersTableAdapter.Delete_cst_ID(id);
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.customersTableAdapter.Fill(this.dataSet1.customers);
            }
        }
        string cst_name;
        int id;
        int selectedrowindex;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedrowindex].Selected = true;


                //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                id = Convert.ToInt32(selectedRow.Cells[0].Value);
                cst_name = Convert.ToString(selectedRow.Cells[1].Value);
                var m = new ContextMenu();
                var delete = new MenuItem("حذف");
                // m.MenuItems.Add(ma5zoon);
                m.MenuItems.Add(delete);
                //  m.MenuItems.Add(ta3deel);

                //  (mi);
                // handle menu item click event here [as required]
                delete.Click += delete_cst_Click;


                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }

        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            customersTableAdapter.FillBy_NAME_LIKE(dataSet1.customers, cst_nameTXT.Text);
            total_txt.Text = dataSet1.customers.Rows.Count.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            edit_customer ee = new edit_customer();
            ee.cst_id.Text = selectedRow.Cells[0].Value.ToString();
            ee.cst_name.Text = selectedRow.Cells[1].Value.ToString();
            ee.cst_nameTXT_new.Text = selectedRow.Cells[1].Value.ToString();
            ee.cst_phoneTXT.Text = selectedRow.Cells[2].Value.ToString();
            ee.cst_addressTXT.Text = selectedRow.Cells[3].Value.ToString();
            ee.notesTXT.Text = selectedRow.Cells[5].Value.ToString();
            ee.price_txt.Text = selectedRow.Cells[4].Value.ToString();
            ee.national_id_txt.Text = selectedRow.Cells[6].Value.ToString();
            ee.takseet_status.Text = selectedRow.Cells[7].Value.ToString();
            
            ee.url_txt.Text = selectedRow.Cells[8].Value.ToString();
            ee.usertxt.Text = usertxt.Text;
            ee.far3txt.Text = far3txt.Text;
            ee.ShowDialog();
            cst_nameTXT_TextChanged(sender, e);
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cards_form cf = new cards_form();
            cf.ShowDialog();
        }

        

      
    }
}
