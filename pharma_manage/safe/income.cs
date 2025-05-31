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
    public partial class income : Form
    {
        public income()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                decimal sum_ba2y_fatora = 0;
                decimal sum_for_fatora_agel = 0;
                decimal visa_sum = 0;
                decimal kash_sum = 0;
                decimal dof3at = 0;
                decimal quick = 0;
                decimal mortag3at = 0;
                decimal syana = 0;

               // for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    foreach(DataGridViewRow dgr in dataGridView1.Rows)
                {
                    sum += Convert.ToDecimal(dgr.Cells[3].Value);

                    if (dgr.Cells[5].Value.ToString().Contains("مرتجع"))
                    {
                        // MessageBox.Show("1");
                        mortag3at += Convert.ToDecimal(dgr.Cells[3].Value);

                    }
                    if (dgr.Cells[5].Value.ToString().Contains("آجل"))
                    {
                        // MessageBox.Show("1");
                        visa_sum += Convert.ToDecimal(dgr.Cells[3].Value);
                        try
                        {
                            sum_ba2y_fatora += Convert.ToDecimal(dgr.Cells[9].Value);
                            sum_for_fatora_agel = visa_sum + sum_ba2y_fatora;
                        }
                        catch { }
                    }


                    if (dgr.Cells[5].Value.ToString().Contains("دفعات"))
                    {
                        // MessageBox.Show("1");
                        dof3at += Convert.ToDecimal(dgr.Cells[3].Value);


                    }
                    if (dgr.Cells[5].Value.ToString().Contains("عمليات"))
                    {
                        // MessageBox.Show("1");
                        quick += Convert.ToDecimal(dgr.Cells[3].Value);

                    }

                    if (dgr.Cells[5].Value.ToString().Contains("كاش"))
                    {
                        kash_sum += Convert.ToDecimal(dgr.Cells[3].Value);
                    }

                    if (dgr.Cells[5].Value.ToString().Contains("صيانة"))
                    {
                        // MessageBox.Show("1");
                        syana += Convert.ToDecimal(dgr.Cells[3].Value);

                    }


                }
                textBox1.Text = sum.ToString();
                mortaga3at_txt.Text = mortag3at.ToString();
               
                visa_txt.Text = visa_sum.ToString();
                dof3at_txt.Text = dof3at.ToString();
                quick_txt.Text = quick.ToString();
                kash_txt.Text = kash_sum.ToString();
                syana_txt.Text = syana.ToString();

                visa_txt.Text = visa_sum.ToString();
                
                ba2y_agel_sales_txt.Text = sum_ba2y_fatora.ToString();
                agel_sales_txt.Text = sum_for_fatora_agel.ToString();
               
                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("مرتجع"))
                //    {
                //        // MessageBox.Show("1");
                //        mortag3at += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                //    }
                //}

                //mortaga3at_txt.Text = mortag3at.ToString();

                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("آجل"))
                //    {
                //        // MessageBox.Show("1");
                //        visa_sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                //    }
                //}
                  
                //visa_txt.Text = visa_sum.ToString();

                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("دفعات"))
                //    {
                //        // MessageBox.Show("1");
                //        dof3at += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                //    }
                //}
                //dof3at_txt.Text = dof3at.ToString();

                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("عمليات"))
                //    {
                //        // MessageBox.Show("1");
                //        quick += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                //    }
                //}
                //quick_txt.Text = quick.ToString();
                
                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("كاش"))
                //    {
                //        kash_sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                //    }
                //}
                //kash_txt.Text = kash_sum.ToString();

                //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                //{
                //    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Contains("صيانة"))
                //    {
                //        // MessageBox.Show("1");
                //        syana += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);

                //    }
                //}
                //syana_txt.Text = syana.ToString();
               
                // MessageBox.Show(sum.ToString());
            }
            catch { }
            //try
            //{
                
                 //foreach (DataGridViewRow dgr in dataGridView1.Rows)
                 //{
                 //    if (dgr.Cells[5].Value.ToString()=="بيع كاش")
                 //    {

                        
                 //            kash_sum += Convert.ToDecimal(dgr.Cells[3]);
                 //            //MessageBox.Show(kash_sum.ToString());
                         

                 //    }
                 //    if (dgr.Cells[5].Value.ToString()=="بيع فيزا")
                 //    {
                 //        visa_sum += Convert.ToDecimal(dgr.Cells[3]);
                 //    }

                 //}
               
                
            //}
            //catch { }
        }
        private void suggest_cst_name()
        {
            this.customersTableAdapter1.Fill(this.dataSet1.customers);
            cst_nameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_nameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.customers.Rows)
            {
                DataCollection.Add(dr["cst_name"].ToString());
            }

            user_previligesTableAdapter1.Fill(dataSet1.user_previliges);
            foreach (DataRow dr in dataSet1.user_previliges.Rows)
            {
                DataCollection.Add(dr["user_name"].ToString());
            }

            cst_nameTXT.AutoCompleteCustomSource = DataCollection;

        }
        private void income_Load(object sender, EventArgs e)
        {
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cst_nameTXT_TextChanged(sender, e);
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cst_nameTXT_TextChanged(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            income_print i = new income_print();
            i.Text = "طباعة الوارد للخزينة";
            i.dateTimePicker1.Value = dateTimePicker1.Value;
            i.dateTimePicker2.Value = dateTimePicker2.Value;
            i.textBox1.Text = cst_nameTXT.Text;
            i.far3_txt.Text = far3_txt.Text;
            i.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cst_nameTXT_TextChanged(object sender, EventArgs e)
        {
            //if (far3_txt.Text != "")
            //{
            //    income_tableTableAdapter1.FillBy_fatra_far3(dataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

            //}
            //else
            //{

                if (dateTimePicker1.Value == dateTimePicker2.Value && cst_nameTXT.Text == "")
                {
                    income_tableTableAdapter1.FillBy_date(dataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), far3_txt.Text);
                }
                else if (dateTimePicker1.Value != dateTimePicker2.Value && cst_nameTXT.Text == "")
                {
                    income_tableTableAdapter1.FillBy_fatra(dataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }

                else if (dateTimePicker1.Value != dateTimePicker2.Value && cst_nameTXT.Text != "")
                {

                    income_tableTableAdapter1.FillBy_FATRA_AND_ESM_ELMASHROO3(dataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), cst_nameTXT.Text, far3_txt.Text);
                }
                else if (dateTimePicker1.Value == dateTimePicker2.Value && cst_nameTXT.Text != "")
                {

                    income_tableTableAdapter1.FillBy_FATRA_AND_ESM_ELMASHROO3(dataSet1.income_table, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), cst_nameTXT.Text, far3_txt.Text);
                }
                if (dataGridView1.Rows.Count <= 0)
                {
                    income_tableTableAdapter1.FillBy_user_in_fatra(dataSet1.income_table, cst_nameTXT.Text, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
           // }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            if (selectedRow.Cells[4].Value.ToString() != "0")
            
            {
                sales_fatora s = new sales_fatora();
                s.Text = "مراجعة فاتورة مبيعات";
                s.salesID_TXT.Text = selectedRow.Cells[4].Value.ToString();
                s.far3txt.Text = far3_txt.Text;
                s.ShowDialog();
            }
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cst_nameTXT_TextChanged(sender, e);
        }

        private void far3_txt_TextChanged(object sender, EventArgs e)
        {
            cst_nameTXT_TextChanged(sender, e);
        }
        private void delete_Click(object sender, EventArgs e)
        {


            DialogResult re = MessageBox.Show("هل تريد حذف البيان "+byan+" ?", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                income_tableTableAdapter1.Delete_by_id(local_id);
                deleted_tableTableAdapter1.Insert(DateTime.Today, local_id.ToString(), byan, "", usertxt.Text, "الوارد للخزينة");
                MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1_ValueChanged(sender, e);
            }
        }
        int local_id;
        int selectedrowindex;
        string byan;
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
                // MessageBox.Show(pro_id_pub.ToString());
                byan = Convert.ToString(selectedRow.Cells[2].Value) + "بقيمة " + selectedRow.Cells[3].Value.ToString();
                //far3 = selectedRow.Cells[4].Value.ToString();

                // MessageBox.Show(pro_name_pub.ToString());
                var m = new ContextMenu();

                //var ma5zoon = new MenuItem("حركة المخزون");
                //var show_picture = new MenuItem("عرض الصورة");
                //var add_halek_ = new MenuItem("اضافة هالك");
                //ma5zoon.Click += go_to_ma5zoon;
                //show_picture.Click += show_picture_click;
                //add_halek_.Click += add_halek_click;

                //m.MenuItems.Add(ma5zoon);
                //m.MenuItems.Add(show_picture);
                //m.MenuItems.Add(add_halek_);


                if (listBox1.Items.Contains("إضافة مستخدم"))
                {
                    if (selectedRow.Cells[5].Value.ToString() != "كاش" && selectedRow.Cells[5].Value.ToString() != "آجل" && selectedRow.Cells[5].Value.ToString() != "دفعات مدينين" && selectedRow.Cells[5].Value.ToString() != "مرتجع شراء")
                    {
                        var delete = new MenuItem("حذف");
                        m.MenuItems.Add(delete);
                        delete.Click += delete_Click;
                    }
                    
                }
                //  (mi);
                // handle menu item click event here [as required]

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void income_Shown(object sender, EventArgs e)
        {
            suggest_cst_name();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;


            this.stock_tableTableAdapter1.Fill(this.dataSet1.stock_table);
            foreach (DataRow dr in dataSet1.stock_table.Rows)
            {
                if (far3_txt.Items.Contains(dr["stock_name"].ToString()))
                { }
                else
                {
                    far3_txt.Items.Add(dr["stock_name"].ToString());
                }
            }
            dateTimePicker1_ValueChanged(sender, e);

            if (usertxt.Text != "admin")
            {
                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
            }
        }


        
    }
}
