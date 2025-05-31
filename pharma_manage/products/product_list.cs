using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace pharma_manage
{
    public partial class product_list : Form
    {
        public product_list()
        {
            InitializeComponent();
        }

        private void name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (far3_txt.Text == "")
                    {
                        products_tableTableAdapter.FillBy_name(dataSet1.products_table, name_txt.Text);
                    }
                    else 
                    {
                        products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text,far3_txt.Text);
                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        if (far3_txt.Text == "")
                        {

                            products_tableTableAdapter.FillBy_category_only(dataSet1.products_table, name_txt.Text);
                        }
                        else 
                        {
                            products_tableTableAdapter.FillBy_category_and_far3(dataSet1.products_table, name_txt.Text,far3_txt.Text);
                        }
                       
                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        if (far3_txt.Text == "")
                        {
                             products_tableTableAdapter.FillBy_pro_int_code(dataSet1.products_table, name_txt.Text);;
                        }
                        else
                        {
                            products_tableTableAdapter.FillBy_int_code_and_far3(dataSet1.products_table, name_txt.Text,far3_txt.Text);
                 
                        }
                    }
                    // MessageBox.Show(dataGridView1.Rows.Count.ToString());
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_id(dataSet1.products_table, Convert.ToInt32(name_txt.Text));
                            
                       
                    }
                    
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_mada_fa3ala(dataSet1.products_table, name_txt.Text);

                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_marad(dataSet1.products_table, name_txt.Text);

                    }
                     if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_mwared(dataSet1.products_table, name_txt.Text);

                    }
                }
                catch { }
            }
        }

        private void product_list_Load(object sender, EventArgs e)
        {
            
            
        }
        private void suggest_product()
        {
            this.products_tableTableAdapter.Fill(this.dataSet1.products_table);
            name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {
                DataCollection.Add(dr["pro_name"].ToString());
                DataCollection.Add(dr["pro_category"].ToString());
                DataCollection.Add(dr["pro_mada_fa3ala"].ToString());
                DataCollection.Add(dr["pro_marad"].ToString());
                DataCollection.Add(dr["pro_mwared"].ToString());

            }

            name_txt.AutoCompleteCustomSource = DataCollection;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (far3_txt.Text != "")
            {
                this.products_tableTableAdapter.FillBy_stock(this.dataSet1.products_table, far3_txt.Text);
            }
            else 
            {
                this.products_tableTableAdapter.Fill(this.dataSet1.products_table);
            }
        }

      

        private void delete_product_Click(object sender, EventArgs e)
        {
           
            if (list_for_IDs.Items.Count == 0)
            {
                DialogResult re = MessageBox.Show("هل تريد حذف المنتج", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    products_tableTableAdapter.Delete_by_id(local_id);
                    deleted_tableTableAdapter1.Insert(DateTime.Today, local_id.ToString(), pro_name, "", usertxt.Text, "قائمة الاصناف");
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else 
            {
                DialogResult re = MessageBox.Show("هل تريد حذف المنتجات المحددة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    foreach (var item in list_for_IDs.Items)
                    {
                        products_tableTableAdapter.Delete_by_id(Convert.ToInt32(item.ToString()));
                        deleted_tableTableAdapter1.Insert(DateTime.Today, local_id.ToString(), pro_name, "", usertxt.Text, "قائمة الاصناف");
                    }
                    MessageBox.Show("تم الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            this.products_tableTableAdapter.Fill(this.dataSet1.products_table);

        }

        private void go_to_ma5zoon(object sender, EventArgs e)
        {

            products_moves m = new products_moves();
            m.usertxt.Text = usertxt.Text;
            m.Text = "حركة الاصناف";
            m.stock_txt.Text = far3;
            m.search_text.Text = pro_name;
            m.ShowDialog();
        }
        private void ta3deel_(object sender, EventArgs e)
        {
            edit_product pe = new edit_product();
            pe.code_txt.Text = local_id.ToString();
            pe.far3txt.Text =far3;
            pe.usertxt.Text = usertxt.Text;
          //  pe.stock_txt.Text = far3;
            pe.Text = "تعديل صنف";
            pe.ShowDialog();
            if (name_txt.Text == "")
            {
                pictureBox1_Click(sender, e);
            }
            else
            {
                name_txt.Focus();
                far3_txt_TextChanged(sender, e);
                //try
                //{
                //    products_tableTableAdapter.FillBy_name(dataSet1.products_table, name_txt.Text);
                //    if (dataGridView1.Rows.Count <= 0)
                //    {
                //        products_tableTableAdapter.FillBy_pro_int_code(dataSet1.products_table, name_txt.Text);

                //    }
                //    if (dataGridView1.Rows.Count <= 0)
                //    {
                //        products_tableTableAdapter.FillBy_category(dataSet1.products_table, name_txt.Text);

                //    }
                //    // MessageBox.Show(dataGridView1.Rows.Count.ToString());
                //    if (dataGridView1.Rows.Count <= 0)
                //    {
                //        products_tableTableAdapter.FillBy_id(dataSet1.products_table, Convert.ToInt32(name_txt.Text));


                //    }

                //    if (dataGridView1.Rows.Count <= 0)
                //    {
                //        products_tableTableAdapter.FillBy_mada_fa3ala(dataSet1.products_table, name_txt.Text);

                //    }
                //    if (dataGridView1.Rows.Count <= 0)
                //    {
                //        products_tableTableAdapter.FillBy_marad(dataSet1.products_table, name_txt.Text);

                //    }
                //    if (dataGridView1.Rows.Count <= 0)
                //    {
                //        products_tableTableAdapter.FillBy_mwared(dataSet1.products_table, name_txt.Text);

                //    }
                //}
                //catch { }

                if (dataGridView1.Rows.Count <= 0)
                {
                    name_txt_TextChanged(sender, e);

                }
            }
        }

        private void show_picture_click(object sender, EventArgs e)
        {
            show_picture_form s = new show_picture_form();

           // MessageBox.Show(pro_name);
            s.name_txt.Text = pro_name;
            s.far3txt.Text = far3;
            s.Show();
        }
        private void print_barcode_click(object sender, EventArgs e)
        {
            barcode_form_single b = new barcode_form_single();
            // MessageBox.Show(pro_name);
            b.pro_name_txt.Text = pro_name;
            b.pro_code_txt.Text = int_code;
            b.count_txt.Text = pro_count.ToString();
            b.stock_txt.Text = far3;

            Form1 f = new Form1();
            f.ApplyFormStyling(b);
            f.SubscribeToLoadEvent(b);
            b.ShowDialog();
            //b.Dispose();
            //MessageBox.Show("aaa");
        }
        private void add_halek_click(object sender, EventArgs e)
        {
            add_halek a = new add_halek();
            a.user_txt.Text = usertxt.Text;
            a.name_txt.Text = pro_name;
            a.id_txt.Text = local_id.ToString();
            a.stock_txt.Text = far3;
            a.Text = "إضافة هالك";
            a.ShowDialog();
            name_txt_TextChanged(sender, e);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[selectedrowindex].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = selectedrowindex;

        }

        private void gard_click(object sender, EventArgs e)
        {
            if (list_for_IDs.Items.Count == 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                if (selectedRow.Cells[9].Value.ToString() == "")
                {
                    products_tableTableAdapter.Update_gard_status_to_done_by_id(DateTime.Today.ToShortDateString(),local_id);
                }
                else
                {
                    products_tableTableAdapter.Update_gard_status_to_null_by_id(local_id);
                }
                //name_txt.Focus();
                //name_txt.SelectAll();
                //SendKeys.Send("{ENTER}");
                name_txt_TextChanged(sender, e);
               if(dataGridView1.Rows.Count>1){
                dataGridView1.ClearSelection();
                dataGridView1.Rows[selectedrowindex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = selectedrowindex;}
            }
            else
            {
                DialogResult re = MessageBox.Show("هل انت متأكد من جرد جميع الاصناف المحددة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    foreach (var item in list_for_IDs.Items)
                    {
                        products_tableTableAdapter.Update_gard_status_to_done_by_id(DateTime.Today.ToShortDateString(),Convert.ToInt32(item.ToString()));
                    }
                    MessageBox.Show("تم جرد الاصناف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name_txt_TextChanged(sender, e);
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectedrowindex].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = selectedrowindex;
                }
            }
        }
        string pro_name = "";
        int pro_id;
        string far3;
        int local_id;
        int selectedrowindex;
        string int_code = "";
        int pro_count;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    var selectedRows = dataGridView1.SelectedRows
                     .OfType<DataGridViewRow>()
                     .Where(row => !row.IsNewRow)
                     .ToArray();
                    try
                    {
                        list_for_IDs.Items.Clear();
                    }
                    catch { }
                    if (selectedRows.Length > 1)
                    {
                        foreach (var row in selectedRows)
                        {
                            try
                            {
                                list_for_IDs.Items.Add(row.Cells[0].Value.ToString());
                            }
                            catch { }
                        }


                        if (listBox1.Items.Contains("إضافة مستخدم"))
                        {


                            var m = new ContextMenu();
                            var delete = new MenuItem("حذف الاصناف المحددة");
                            m.MenuItems.Add(delete);
                            delete.Click += delete_product_Click;


                            var gard = new MenuItem("جرد الاصناف المحددة");

                            m.MenuItems.Add(gard);
                            gard.Click += gard_click;


                            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                            m.Show(dataGridView1, new Point(e.X, e.Y));
                        }
                        //  (mi);
                        // handle menu item click event here [as required]


                    }
                    else
                    {



                        selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[selectedrowindex].Selected = true;


                        //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        local_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        int_code = selectedRow.Cells[11].Value.ToString();
                        pro_count = Convert.ToInt32(selectedRow.Cells[7].Value);
                        // MessageBox.Show(pro_id_pub.ToString());
                        pro_name = Convert.ToString(selectedRow.Cells[1].Value);
                        far3 = selectedRow.Cells[4].Value.ToString();

                        // MessageBox.Show(pro_name_pub.ToString());
                        var m = new ContextMenu();

                        var ma5zoon = new MenuItem("حركة المخزون");

                        var show_picture = new MenuItem("عرض الصورة");
                        var add_halek_ = new MenuItem("اضافة هالك");
                        var print_barcode = new MenuItem("طباعة باركود");
                        print_barcode.Click += print_barcode_click;
                        ma5zoon.Click += go_to_ma5zoon;
                        show_picture.Click += show_picture_click;
                        add_halek_.Click += add_halek_click;
                   
                        m.MenuItems.Add(ma5zoon);
                        m.MenuItems.Add(print_barcode);
                        m.MenuItems.Add(show_picture);
                        m.MenuItems.Add(add_halek_);


                        if (listBox1.Items.Contains("إضافة مستخدم"))
                        {
                            var ta3deel = new MenuItem("تعديل");
                            m.MenuItems.Add(ta3deel);
                            ta3deel.Click += ta3deel_;

                            var delete = new MenuItem("حذف");
                            m.MenuItems.Add(delete);
                            delete.Click += delete_product_Click;


                            if (selectedRow.Cells[9].Value.ToString() == "")
                            {
                                var gard = new MenuItem("تم الجرد");
                                m.MenuItems.Add(gard);
                                gard.Click += gard_click;
                            }
                            else
                            {
                                var gard = new MenuItem("الغاء الجرد");
                                m.MenuItems.Add(gard);
                                gard.Click += gard_click;
                            }
                        }
                        //  (mi);
                        // handle menu item click event here [as required]

                        int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                        m.Show(dataGridView1, new Point(e.X, e.Y));
                    }
                }
                catch { }
            }
        
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    products_crystal1.Refresh();
                    products_crystal1.SetDataSource(dataSet1);

                    if (name_txt.Text == "")
                    {
                        products_print2 p = new products_print2();
                        p.Text = "طباعة الجرد";
                        p.far3txt.Text = far3_txt.Text;
                        p.Show();
                    }
                    else
                    {
                        print_by_category_crystal pp = new print_by_category_crystal();
                        pp.textBox1.Text = name_txt.Text;
                        pp.far3txt.Text = far3_txt.Text;
                        pp.ShowDialog();
                    //    products_tableTableAdapter.FillBy_category(dataSet1.products_table, name_txt.Text);
                    }
                    //StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
                    //string printer_name = srr.ReadLine();
                    //products_crystal1.PrintOptions.PrinterName = printer_name;
                    //products_crystal1.PrintToPrinter(1, false, 0, 0);
                
            

            
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int x = 0;
           // foreach (DataGridViewRow dr in dataGridView1.Rows)
           // {
           //     //foreach (DataGridViewRow dgr in dataGridView1.Rows)
           //     //{
           //     if (dr.Cells[12].Value.ToString().Contains("171985")) 
           //         {
           //             x++;
           //         }
           //     //}
           // }
           //// MessageBox.Show(x.ToString());
           // foreach (DataGridViewRow dr in dataGridView1.Rows)
           // {
           //     //foreach (DataGridViewRow dgr in dataGridView1.Rows)
           //     //{
           //     if (dr.Cells[12].Value.ToString().Contains("171985"))
           //     {
           //         products_tableTableAdapter.Update_int_barcode_by_id(dr.Cells[0].Value.ToString(),Convert.ToInt32(dr.Cells[0].Value.ToString()));
           //     }
           //     //}
           // }
           // MessageBox.Show("done");

        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            products_tableTableAdapter.Delete_by_cat("شاى"); 
            MessageBox.Show("done");
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                products_tableTableAdapter.FillBy_like_pro_name_and_far3(dataSet1.products_table, name_txt.Text, far3_txt.Text);
            }
            catch { }
        }

        private void fatora_type_Click(object sender, EventArgs e)
        {
            nwa2s n = new nwa2s();
            n.Text = "عرض سعر";
            this.products_tableTableAdapter.Fill(this.dataSet1.products_table);
            int i = 0;
            //MessageBox.Show("جرب من بره البرنامج");
            foreach (DataRow dr in dataSet1.products_table.Rows)
            {

                try
                {


                    i += 1;
                    // MessageBox.Show(i.ToString());
                    n.dataGridView1.Rows.Add(i.ToString(), dr["pro_ID"].ToString(), dr["pro_name"].ToString(), dr["pro_category"].ToString(),"", Convert.ToDecimal(dr["pro_bee3"]));
                    //  nwa2es_tableTableAdapter1.Insert_nwa2es(dr["pro_id_company"].ToString(), dr["pro_name"].ToString(), Convert.ToDecimal(dr["pro_count"]), 0);
                }
                catch { }

            }
            n.Show();
        }

        private void far3_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (name_txt.Text == "")
            //{
            //    this.products_tableTableAdapter.Fill(this.dataSet1.products_table);
            //}
            //else 
            //{

            if (far3_txt.Text == "")
            {
                products_tableTableAdapter.FillBy_name(dataSet1.products_table, name_txt.Text);
                if (dataGridView1.Rows.Count <= 0)
                {
                    products_tableTableAdapter.FillBy_category_only(dataSet1.products_table, name_txt.Text);
                }
                if (dataGridView1.Rows.Count <= 0)
                {

                    products_tableTableAdapter.FillBy_pro_int_code(dataSet1.products_table, name_txt.Text); ;
                }

                if (dataGridView1.Rows.Count <= 0)
                {
                    products_tableTableAdapter.FillBy_id(dataSet1.products_table, Convert.ToInt32(name_txt.Text));


                }

                if (dataGridView1.Rows.Count <= 0)
                {
                    products_tableTableAdapter.FillBy_mada_fa3ala(dataSet1.products_table, name_txt.Text);

                }
                if (dataGridView1.Rows.Count <= 0)
                {
                    products_tableTableAdapter.FillBy_marad(dataSet1.products_table, name_txt.Text);

                }
                if (dataGridView1.Rows.Count <= 0)
                {
                    products_tableTableAdapter.FillBy_mwared(dataSet1.products_table, name_txt.Text);

                }

            }
            else 
            {
                if (name_txt.Text == "")
                {
                    products_tableTableAdapter.FillBy_stock(dataSet1.products_table, far3_txt.Text);
                }
                else 
                {
                    products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text, far3_txt.Text);
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_category_and_far3(dataSet1.products_table, name_txt.Text, far3_txt.Text); 
                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                            products_tableTableAdapter.FillBy_int_code_and_far3(dataSet1.products_table, name_txt.Text, far3_txt.Text);
                    }

                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_id(dataSet1.products_table, Convert.ToInt32(name_txt.Text));

                    }

                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_mada_fa3ala(dataSet1.products_table, name_txt.Text);

                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_marad(dataSet1.products_table, name_txt.Text);

                    }
                    if (dataGridView1.Rows.Count <= 0)
                    {
                        products_tableTableAdapter.FillBy_mwared(dataSet1.products_table, name_txt.Text);

                    }
                }
            }

                
           // }
        }

        private void far3_txt_TextChanged(object sender, EventArgs e)
        {
            name_txt_TextChanged(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    dgr.Cells[12].Value = (Convert.ToDecimal(dgr.Cells[7].Value) * Convert.ToDecimal(dgr.Cells[2].Value)).ToString(".00");


                }

            }
            catch { }
            try
            {
                decimal sum = 0;
                decimal sum_count = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[12].Value);
                    sum_count += Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value);
                }
                raseed_txt.Text = Convert.ToString(sum.ToString("0.00"));
                sum_count_txt.Text = Convert.ToString(sum_count.ToString("0.00"));
            }
            catch { }


            try
            {
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    try
                    {
                        if (Convert.ToDecimal(dr.Cells[7].Value)>0&&Convert.ToDecimal(dr.Cells[7].Value) <= Convert.ToDecimal(dr.Cells[8].Value))
                        {

                            dr.DefaultCellStyle.BackColor = Color.Salmon;

                        }
                        else if (Convert.ToDecimal(dr.Cells[7].Value)==0)
                        {
                            dr.DefaultCellStyle.BackColor = Color.Red;
                        }

                        if (Convert.ToDecimal(dr.Cells[7].Value) != 0 && dr.Cells[9].Value.ToString()=="تم الجرد")
                        {
                            dr.DefaultCellStyle.BackColor = Color.PowderBlue;
                        }

                    }
                    catch { }

                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult re;
          
            if (name_txt.Text == "")
            {
                  re = MessageBox.Show("هل تريد اعادة ظبط حالة الجرد لجميع الاصناف ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                  if (re == DialogResult.Yes) 
                  {
                      products_tableTableAdapter.Update_gard_status_to_null();
                      MessageBox.Show("تمت اعادة ظبط الجرد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      product_list_Load(sender, e);

                  }
            } 
            else
            {
                  re = MessageBox.Show("هل تريد اعادة ظبط حالة الجرد للاصناف المعروضه؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                  if (re == DialogResult.Yes)
                  {
                      foreach (DataGridViewRow dr in dataGridView1.Rows)
                      {
                          int id = Convert.ToInt32(dr.Cells[0].Value);
                          products_tableTableAdapter.Update_gard_status_to_null_by_id(id);
                        
                      }
                      MessageBox.Show("تمت اعادة ظبط الجرد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      product_list_Load(sender, e);
                  }
            }
            
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Apps)
            {
                var selectedRows = dataGridView1.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .ToArray();
                try
                {
                    list_for_IDs.Items.Clear();
                }
                catch { }
                if (selectedRows.Length > 1)
                {
                    foreach (var row in selectedRows)
                    {
                        try
                        {
                            list_for_IDs.Items.Add(row.Cells[0].Value.ToString());
                        }
                        catch { }
                    }


                    if (listBox1.Items.Contains("إضافة مستخدم"))
                    {


                        var m = new ContextMenu();
                        var delete = new MenuItem("حذف الاصناف المحددة");
                        m.MenuItems.Add(delete);
                        delete.Click += delete_product_Click;
                        
                            m.Show(dataGridView1, new Point(0, 0));
                      
                    }
                    //  (mi);
                    // handle menu item click event here [as required]


                }
                else
                {


                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    local_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    int_code = selectedRow.Cells[11].Value.ToString();
                    pro_count = Convert.ToInt32(selectedRow.Cells[7].Value);
                    //  MessageBox.Show(local_id.ToString());
                    pro_name = Convert.ToString(selectedRow.Cells[1].Value);
                    far3 = selectedRow.Cells[4].Value.ToString();

                    // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();

                    var ma5zoon = new MenuItem("حركة المخزون");
                   
                    var show_picture = new MenuItem("عرض الصورة");
                    var add_halek_ = new MenuItem("اضافة هالك");
                    var print_barcode = new MenuItem("طباعة باركود");
                     print_barcode.Click += print_barcode_click;
                    ma5zoon.Click += go_to_ma5zoon;
                    show_picture.Click += show_picture_click;
                    add_halek_.Click += add_halek_click;
                   

                    m.MenuItems.Add(ma5zoon);
                    m.MenuItems.Add(print_barcode);
                    m.MenuItems.Add(show_picture);
                    m.MenuItems.Add(add_halek_);
                    


                    if (listBox1.Items.Contains("إضافة مستخدم"))
                    {
                        var ta3deel = new MenuItem("تعديل");
                        m.MenuItems.Add(ta3deel);
                        ta3deel.Click += ta3deel_;

                        var delete = new MenuItem("حذف");
                        m.MenuItems.Add(delete);
                        delete.Click += delete_product_Click;
                    }
                    //  (mi);
                    // handle menu item click event here [as required]

                    // int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    // m.Show(dataGridView1, new Point(e.X, e.Y));
                    try
                    {
                        m.Show(dataGridView1, new Point(dataGridView1.Location.X + dataGridView1.Width, dataGridView1.Location.Y +
                       dataGridView1.GetCellDisplayRectangle(0, selectedrowindex + 1, true).Location.Y));
                    }
                    catch
                    {
                        m.Show(dataGridView1, new Point(0, 0));
                    }
                }
            }
            
        }

        private void product_list_Shown(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);
            foreach (DataRow dr in dataSet1.stock_table.Rows)
            {
                if (far3_txt.Items.Contains(dr["stock_name"].ToString()))
                { 
                }
                else
                {
                    far3_txt.Items.Add(dr["stock_name"].ToString());
                }
            }
            // TODO: This line of code loads data into the 'dataSet1.products_table' table. You can move, or remove it, as needed.
            this.products_tableTableAdapter.Fill(this.dataSet1.products_table);
            // this.products_tableTableAdapter.Fill(this.dataSet1.products_table);


            suggest_product();



            if (usertxt.Text != "admin")
            {
                user_previligesTableAdapter1.FillBy_name(dataSet1.user_previliges, usertxt.Text);



                foreach (DataRow dr in dataSet1.user_previliges.Rows)
                {
                    listBox1.Items.Add(dr["user_previliges"].ToString());

                }
                if (listBox1.Items.Contains("إضافة مستخدم"))
                {
                    dataGridView1.Columns[2].Visible = true;
                    label13.Visible = true;
                    raseed_txt.Visible = true;
                    button3.Visible = true;
                }
                else
                {

                    dataGridView1.Columns[2].Visible = false;
                    label13.Visible = false;
                    raseed_txt.Visible = false;
                    button3.Visible = false;

                }
                string gomla = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt").First();

                if (gomla == "no")
                {
                    // MessageBox.Show("aaa");
                    dataGridView1.Columns[5].Visible = false;
                }


            }


            far3_txt_TextChanged(sender, e);

         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dataGridView1.Columns[2].Visible = true;
            }
            else 
            {
                dataGridView1.Columns[2].Visible = false;
            }
        }

        


    }
}
