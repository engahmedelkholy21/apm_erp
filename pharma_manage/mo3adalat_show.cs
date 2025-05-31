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
    public partial class mo3adalat_show : Form
    {
        public mo3adalat_show()
        {
            InitializeComponent();
        }

        private void mo3adalat_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mo3adalat_tasnee3_table' table. You can move, or remove it, as needed.
            dataGridView1.Rows.Clear();
            this.mo3adalat_tasnee3_tableTableAdapter.Fill(this.dataSet1.mo3adalat_tasnee3_table);
            ListBox l = new ListBox();
            foreach (DataRow dr in dataSet1.mo3adalat_tasnee3_table.Rows) 
            {
                if (l.Items.Contains(dr["mo3adalat_tasnee3_pro_name"].ToString()))
                {

                }
                else
                {
                    l.Items.Add(dr["mo3adalat_tasnee3_pro_name"].ToString());
                    dataGridView1.Rows.Add(dr["mo3adalat_tasnee3_id"].ToString(), dr["mo3adalat_tasnee3_pro_name"].ToString());
                }
            }
            suggest_pro();
        }
        private void suggest_pro()
        {
            try
            {
                this.mo3adalat_tasnee3_tableTableAdapter.Fill(this.dataSet11.mo3adalat_tasnee3_table);
                pro_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                pro_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                {
                    DataCollection.Add(dr["mo3adalat_tasnee3_pro_name"].ToString());
                }

                pro_name_txt.AutoCompleteCustomSource = DataCollection;



            }
            catch { }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                dataGridView2.Rows.Clear();
                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, selectedRow.Cells[1].Value.ToString());

                foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                {
                    dataGridView2.Rows.Add(dr["mo3adalat_tasnee3_material_name"].ToString(), dr["mo3adalat_tasnee3_material_count"].ToString(), dr["mo3adalat_tasnee3_notes"].ToString(), dr["mo3adalat_tasnee3_user"].ToString());
                }
            }
            catch { }
        }

        
        private void pro_name_txt_TextChanged(object sender, EventArgs e)
        {
            if (pro_name_txt.Text == "") 
            {
                this.mo3adalat_tasnee3_tableTableAdapter.Fill(this.dataSet11.mo3adalat_tasnee3_table);
            }
            else
            {
               
                try
                {
                    mo3adalat_tasnee3_tableTableAdapter.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, pro_name_txt.Text);

                    dataGridView2.Rows.Clear();
                   
                    foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                    {
                        dataGridView2.Rows.Add(dr["mo3adalat_tasnee3_material_name"].ToString(), dr["mo3adalat_tasnee3_material_count"].ToString(), dr["mo3adalat_tasnee3_notes"].ToString(), dr["mo3adalat_tasnee3_user"].ToString());
                    }
                    foreach(DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        if (dgr.Cells[1].Value.ToString() == dataSet11.mo3adalat_tasnee3_table.Rows[0]["mo3adalat_tasnee3_pro_name"].ToString()) 
                        {
                            dgr.Selected = true;
                        }
                    }
                }
                catch { }
            }
        }
        private void delete_product_Click(object sender, EventArgs e)
        {


            DialogResult re = MessageBox.Show("هل تريد حذف المعادلة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                mo3adalat_tasnee3_tableTableAdapter1.Delete_by_name(pro_name);
                deleted_tableTableAdapter1.Insert(DateTime.Today, pro_name, "معادلات انتاج"+ pro_name, "", usertxt.Text, "معادلات انتاج");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void ta3deel_Click(object sender, EventArgs e)
        {
            mo3adalat_form m = new mo3adalat_form();
            m.id_txt.Text = local_id.ToString();
            m.Text = "تعديل معادلة انتاج";
            m.far3txt.Text = far3txt.Text;
            m.user_txt.Text = usertxt.Text;
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(m);
            f1.ApplyFormStyling(m);
            m.ShowDialog();
            mo3adalat_show_Load(sender, e);
        }

        int local_id;
        string pro_name;
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
                local_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                pro_name = selectedRow.Cells[1].Value.ToString();
                // MessageBox.Show(pro_id_pub.ToString());


                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();


                var delete = new MenuItem("حذف");
                m.MenuItems.Add(delete);
                delete.Click += delete_product_Click;

                var ta3deel = new MenuItem("تعديل");
                m.MenuItems.Add(ta3deel);
                ta3deel.Click += ta3deel_Click;



                //  (mi);
                // handle menu item click event here [as required]

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }
    }
}
