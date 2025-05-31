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
    public partial class mwardeen_show : Form
    {
        public mwardeen_show()
        {
            InitializeComponent();
        }

        private void mwardeen_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mwardeen' table. You can move, or remove it, as needed.
            this.mwardeenTableAdapter.Fill(this.dataSet1.mwardeen);
            suggest_mwared_name();


        }
        private void suggest_mwared_name()
        {
            this.mwardeenTableAdapter.Fill(this.dataSet1.mwardeen);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.mwardeen.Rows)
            {
                DataCollection.Add(dr["mwared_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void cst_nameTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cst_nameTXT.Text != "")
                {
                    mwardeenTableAdapter.FillBy_mwared_name(dataSet1.mwardeen, cst_nameTXT.Text);
                }
                else
                    this.mwardeenTableAdapter.Fill(this.dataSet1.mwardeen);

            }
        }

        private void delete_cst_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف المورد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                mwardeenTableAdapter.Delete_BY_mwared_name(cst_name);
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.mwardeenTableAdapter.Fill(this.dataSet1.mwardeen);

        }
        string cst_name;

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                //  pro_id_pub = Convert.ToInt32(selectedRow.Cells[0].Value);
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
    }
}
