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
    public partial class employees_show : Form
    {
        public employees_show()
        {
            InitializeComponent();
        }

        private void employees_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.employee_table' table. You can move, or remove it, as needed.
            this.employee_tableTableAdapter.Fill(this.dataSet1.employee_table);
            suggest_emp();
        }
        private void suggest_emp()
        {
            this.employee_tableTableAdapter.Fill(this.dataSet1.employee_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.employee_table.Rows)
            {
                DataCollection.Add(dr["employee_name"].ToString());
               

            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            employee_tableTableAdapter.Fill(dataSet1.employee_table);
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                employee_tableTableAdapter.FillBy_name(dataSet1.employee_table, name_txt.Text);
                if (dataSet1.employee_table.Rows.Count <= 0) 
                {
                    employee_tableTableAdapter.FillBy_employee_national_id(dataSet1.employee_table, name_txt.Text);
                
                }
            }
            catch { }
        }

        private void ta3deel_(object sender, EventArgs e)
        {
            try
            {

                add_employee a = new add_employee();
                a.type_txt.Text = emp_name;
                a.usertxt.Text = usertxt.Text;
                Form1 f = new Form1();
                f.SubscribeToLoadEvent(a);
                f.ApplyFormStyling(a);
                a.ShowDialog();
            }
            catch { }
        }
         private void delete_product_Click(object sender, EventArgs e)
        {
           
           
                DialogResult re = MessageBox.Show("هل تريد حذف الموظف ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    employee_tableTableAdapter.Delete_by_id(emp_id);
                    deleted_tableTableAdapter1.Insert(DateTime.Today, emp_id.ToString(), emp_name, "", usertxt.Text, "قائمة الموظفين");
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name_txt_TextChanged(sender, e);
                }
            }
          string emp_name = "";
        string far3;
        int emp_id;
        int selectedrowindex;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {

                    selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectedrowindex].Selected = true;


                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    emp_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    // MessageBox.Show(pro_id_pub.ToString());
                    emp_name = Convert.ToString(selectedRow.Cells[1].Value);
                    // far3 = selectedRow.Cells[4].Value.ToString();

                    // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();


                    var ta3deel = new MenuItem("تعديل");
                    m.MenuItems.Add(ta3deel);
                    ta3deel.Click += ta3deel_;

                    var delete = new MenuItem("حذف");
                    m.MenuItems.Add(delete);
                    delete.Click += delete_product_Click;




                    //  (mi);
                    // handle menu item click event here [as required]

                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
                catch { }
            }
        }
        
        
    }
}
