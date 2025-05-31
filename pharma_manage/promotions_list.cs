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
    public partial class promotions_list : Form
    {
        public promotions_list()
        {
            InitializeComponent();
        }

        private void promotions_list_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.promo_tableTableAdapter1.Fill(this.dataSet11.promo_table);
            ListBox l = new ListBox();
            foreach (DataRow dr in dataSet11.promo_table.Rows)
            {
                if (l.Items.Contains(dr["promo_name"].ToString()))
                {

                }
                else
                {
                    l.Items.Add(dr["promo_name"].ToString());
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["promo_name"].ToString(),Convert.ToDateTime(dr["promo_start_date"]).ToShortDateString(), Convert.ToDateTime(dr["promo_end_date"]).ToShortDateString());
                }
            }
            suggest_promo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
               // MessageBox.Show(selectedRow.Cells[1].Value.ToString());
                
                promo_tableTableAdapter1.FillBy_promo_name(dataSet11.promo_table, selectedRow.Cells[1].Value.ToString());
                //MessageBox.Show(dataSet11.promo_table.Rows.Count.ToString());
                foreach (DataRow dr in dataSet11.promo_table.Rows)
                {
                    dataGridView2.Rows.Add(dataGridView2.Rows.Count + 1, dr["promo_item_code"].ToString(), dr["promo_item_name"].ToString(), dr["promo_item_price"].ToString());
                }
            }
            catch { }
        }

        private void prom_edit_click(object sender, EventArgs e)
        {
            add_promotion a = new add_promotion();
            a.old_name_txt.Text = prom_name;
            a.Text = "تعديل عرض";
            a.type_txt.Text = "edit";
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(a);
            f.ApplyFormStyling(a);
            a.ShowDialog();
        }

        private void prom_delete_click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف العرض " + prom_name + " نهائيا ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                promo_tableTableAdapter1.Delete_by_promo_name(prom_name);
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
             

                promotions_list_Load(sender, e);
            }
        }
        string prom_name;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedrowindex].Selected = true;


                //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                prom_name = selectedRow.Cells[1].Value.ToString();
              //  byan = "المبلغ المستحق وقتها" + Convert.ToString(selectedRow.Cells[4].Value);
                var m = new ContextMenu();
                var prom_edit = new MenuItem("تعديل");
                var prom_delete = new MenuItem("حذف العرض");
                // var ta3deel = new MenuItem("تعديل");
                m.MenuItems.Add(prom_edit);
                m.MenuItems.Add(prom_delete);
                // m.MenuItems.Add(ta3deel);


                prom_edit.Click += prom_edit_click;
                prom_delete.Click += prom_delete_click;
               

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void suggest_promo()
        {
            try
            {
                this.promo_tableTableAdapter1.Fill(this.dataSet11.promo_table);
                promo_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                promo_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataSet11.promo_table.Rows)
                {
                    DataCollection.Add(dr["promo_name"].ToString());
                }

                promo_name_txt.AutoCompleteCustomSource = DataCollection;



            }
            catch { }

        }
        private void pro_name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                if (promo_name_txt.Text == "")
                {
                    this.promo_tableTableAdapter1.Fill(this.dataSet11.promo_table);
                }
                else
                {

                    try
                    {
                        promo_tableTableAdapter1.FillBy_promo_name(dataSet11.promo_table , promo_name_txt.Text);
                        if (dataSet11.promo_table.Rows.Count > 0)
                        {
                            dataGridView2.Rows.Clear();

                            foreach (DataRow dr in dataSet11.promo_table.Rows)
                            {
                                dataGridView2.Rows.Add(dataGridView2.Rows.Count + 1, dr["promo_item_code"].ToString(), dr["promo_item_name"].ToString(), dr["promo_item_price"].ToString());
                            }
                            foreach (DataGridViewRow dgr in dataGridView1.Rows)
                            {
                                if (dgr.Cells[1].Value.ToString() == dataSet11.promo_table.Rows[0]["promo_name"].ToString())
                                {
                                    dgr.Selected = true;
                                }
                            }
                        }
                        else 
                        {
                            dataGridView1.ClearSelection();
                            dataGridView2.Rows.Clear();


                        }
                    }
                    catch { }
                }
            }
        }
    }
}
