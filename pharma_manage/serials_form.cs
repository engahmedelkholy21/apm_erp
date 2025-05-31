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
    public partial class serials_form : Form
    {
        public serials_form()
        {
            InitializeComponent();
        }

        private void serials_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.serial_table' table. You can move, or remove it, as needed.
            this.serial_tableTableAdapter.Fill(this.dataSet1.serial_table);
            suggest_product();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);

            
        }
        private void suggest_product()
        {
            this.products_tableTableAdapter1.Fill(this.dataSet1.products_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
                //DataCollection.Add(dr["pro_category"].ToString());
                //DataCollection.Add(dr["pro_mada_fa3ala"].ToString());
                //DataCollection.Add(dr["pro_marad"].ToString());
                //DataCollection.Add(dr["pro_mwared"].ToString());

            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.serial_tableTableAdapter.Fill(this.dataSet1.serial_table);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try 
            {
                raseed_txt.Text = dataGridView1.Rows.Count.ToString();
            }
            catch { }
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف السيريال", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                serial_tableTableAdapter.Delete_by_serial_serial_no(serial);
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.serial_tableTableAdapter.Fill(this.dataSet1.serial_table);
            }
        }
        string serial;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                serial = selectedRow.Cells[3].Value.ToString();
                
                var m = new ContextMenu();
                var delete = new MenuItem("حذف");
                
                m.MenuItems.Add(delete);
               
                //  (mi);
                // handle menu item click event here [as required]
                delete.Click += delete_product_Click;
                
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }

        private void name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                serial_tableTableAdapter.FillBy_serial_pro_name(dataSet1.serial_table, name_txt.Text);
                if (dataSet1.serial_table.Rows.Count <= 0)
                {
                    serial_tableTableAdapter.FillBy_serial_pro_id(dataSet1.serial_table, name_txt.Text);
                }
                if (dataSet1.serial_table.Rows.Count <= 0)
                {
                    serial_tableTableAdapter.FillBy_serial_no(dataSet1.serial_table, name_txt.Text);
                }
                
            }
        }
    }
}
