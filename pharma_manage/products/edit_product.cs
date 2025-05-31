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
    public partial class edit_product : Form
    {
        public edit_product()
        {
            InitializeComponent();

            Form1 f1 = new Form1(); 
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);

            count_txt.KeyPress += DigitOnly_KeyPress;
            cost_txt.KeyPress += DigitOnly_KeyPress;
            bee3_txt.KeyPress += DigitOnly_KeyPress;
            bee3_gomla_txt.KeyPress += DigitOnly_KeyPress;
            limit_txt.KeyPress += DigitOnly_KeyPress;
            discount_nesba_txt.KeyPress += DigitOnly_KeyPress;
            //countTXT.KeyPress += DigitOnly_KeyPress;
            //madfoo3TXT.KeyPress += DigitOnly_KeyPress;
        }


        private void DigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }

            // Allow only one decimal point
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // Ignore additional decimal points
            }
        }

        private void code_txt_TextChanged(object sender, EventArgs e)
        {
           this.AcceptButton = null;
           //edit_product_Load(sender, e);
        }



        string pro_old_count="";
        private void save_btn_Click(object sender, EventArgs e)
        {
            //try 
            //{
                //if (Convert.ToDecimal(//gmhour_txt.Text) < Convert.ToDecimal(//bee3_txt.Text) || Convert.ToDecimal(//gmhour_txt.Text) < Convert.ToDecimal(cost_txt.Text) || Convert.ToDecimal(//bee3_txt.Text) < Convert.ToDecimal(cost_txt.Text)) 
                //{
                //    MessageBox.Show("تأكد من ترتيب الاسعار");
                //    return;
                //}

            try
            {
                if (int_code_txt.Text == "")
                {
                    int_code_txt.Text = code_txt.Text;
                }
                if (bee3_gomla_txt.Text == "")
                {
                    bee3_gomla_txt.Text = bee3_txt.Text;
                }
              //  string gard_date="";
                if (gard_status_txt.Text == "")
                {
                    products_tableTableAdapter1.Update_gard_status_to_null_by_id(Convert.ToInt32(code_txt.Text));
                }
                else 
                {
                    products_tableTableAdapter1.Update_gard_status_to_done_by_id(DateTime.Today.ToShortDateString(), Convert.ToInt32(code_txt.Text));
                
                }

                products_tableTableAdapter1.Update_by_id(name_txt.Text, category_txt.Text, Convert.ToDecimal(cost_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(count_txt.Text),
                    Convert.ToDecimal(limit_txt.Text), Convert.ToString(dateTimePicker1.Value), company_txt.Text, site_txt.Text, picture_txt.Text, notes_txt.Text, "عُدل بواسطة " + usertxt.Text, Convert.ToDecimal(basic_profit_txt.Text)
                    , stock_txt.Text, Convert.ToDecimal(count_txt.Text), 1, Convert.ToDecimal(bee3_gomla_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text), int_code_txt.Text, gard_status_txt.Text, Convert.ToInt32(code_txt.Text));



                if (Convert.ToDecimal(count_txt.Text) != Convert.ToDecimal(pro_old_count))
                {

                    if (Convert.ToDecimal(count_txt.Text) > Convert.ToDecimal(pro_old_count))
                    {
                        decimal pro_count = Convert.ToDecimal(pro_old_count);
                        decimal count_to_handle = Convert.ToDecimal(count_txt.Text) - pro_count;
                        decimal pro_count_after = pro_count + count_to_handle;

                        ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(DateTime.Today.ToShortDateString(), int_code_txt.Text, name_txt.Text, count_to_handle,
                       Convert.ToDecimal(0), pro_count, pro_count_after, "تعديل صنف", Convert.ToInt32(0), "تعديل صنف", usertxt.Text,stock_txt.Text);

                    }
                    else if (Convert.ToDecimal(count_txt.Text) < Convert.ToDecimal(pro_old_count))
                    {
                        decimal pro_count = Convert.ToDecimal(pro_old_count);
                        decimal count_to_handle = Convert.ToDecimal(pro_old_count) - Convert.ToDecimal(count_txt.Text);
                        decimal pro_count_after = pro_count - count_to_handle;

                        ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(DateTime.Today.ToShortDateString(), int_code_txt.Text, name_txt.Text, count_to_handle,
                       Convert.ToDecimal(0), pro_count, pro_count_after, "تعديل صنف", Convert.ToInt32(0), "تعديل صنف", usertxt.Text, stock_txt.Text);

                    }
                }


                sales_tableTableAdapter1.Update_pro_id_by_old_id(int_code_txt.Text,name_txt.Text,old_int_code,stock_txt.Text);
                ma5zoon_movesTableAdapter1.Update_pro_code(int_code_txt.Text, name_txt.Text, old_int_code);
                purchases_tableTableAdapter1.Update_pro_id(int_code_txt.Text, name_txt.Text, old_int_code,stock_txt.Text);
               // mortaga3_purchasesTableAdapter1.Update_pro_id(Convert.ToInt32(int_code_txt.Text), name_txt.Text, Convert.ToInt32(old_int_code));
                sales_mortaga3TableAdapter1.Update_pro_id(int_code_txt.Text, name_txt.Text, old_int_code);
               
                products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(code_txt.Text));


                mo3adalat_tasnee3_tableTableAdapter1.FillBy_material_name(dataSet11.mo3adalat_tasnee3_table, old_pro_name);
                if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0) 
                {
                    foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows) 
                    {
                        
                        int id = Convert.ToInt32(dr["mo3adalat_tasnee3_id"]);
                        mo3adalat_tasnee3_tableTableAdapter1.Update_material_name_by_id(name_txt.Text, id);
                    }
                }

                mo3adalat_tasnee3_tableTableAdapter1.FillBy_pro_name(dataSet11.mo3adalat_tasnee3_table, old_pro_name);
                if (dataSet11.mo3adalat_tasnee3_table.Rows.Count > 0)
                {
                    foreach (DataRow dr in dataSet11.mo3adalat_tasnee3_table.Rows)
                    {

                        int id = Convert.ToInt32(dr["mo3adalat_tasnee3_id"]);
                        mo3adalat_tasnee3_tableTableAdapter1.Update_pro_name(name_txt.Text, id);
                    }
                }


                name_txt.Clear(); category_txt.ResetText(); cost_txt.Clear(); count_txt.Clear();
                limit_txt.Clear(); dateTimePicker1.ResetText(); mada_fa3ala_txt.Clear(); marad_txt.Clear(); code_txt.Clear();
                stock_txt.ResetText(); pieces_in_packet_txt.Clear(); bee3_txt.Clear(); int_code_txt.Clear(); bee3_gomla_txt.Clear();
                gard_status_txt.Text = "";
                MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                code_txt.Select();
                stock_tableTableAdapter1.Fill(dataSet11.stock_table);
                foreach (DataRow dr in dataSet11.stock_table.Rows)
                {
                    stock_txt.Items.Add(dr["stock_name"].ToString());
                   // this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          
        }


        string old_pro_name;
        string old_int_code;
        private void edit_product_Load(object sender, EventArgs e)
        {
            string buy_type_txt = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt").First();
            if (buy_type_txt == "نسبة")
            {
                label29.Visible = true;
                discount_nesba_txt.Visible = true;
            }
            else 
            {
                label29.Visible = false;
                discount_nesba_txt.Visible = false;
            }

            string gomla = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt").First();
            if (gomla == "yes")
            {
                // label24.Text = "";
                label30.Visible = true;
                bee3_gomla_txt.Visible = true;

                //  gomla_checkBox4.Checked = true;
            }
            else
            {
              
                label30.Visible = false;
                bee3_gomla_txt.Visible = false;
                
                // gomla_checkBox4.Checked = false;
            }

            this.AcceptButton = save_btn;
            suggest_product();
            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            stock_tableTableAdapter1.Fill(dataSet11.stock_table);
            foreach (DataRow dr in dataSet11.stock_table.Rows) 
            {
                stock_txt.Items.Add(dr["stock_name"].ToString());
            }


            this.categoryTableAdapter.Fill(this.dataSet11.Category);
            foreach (DataRow dr in dataSet11.Category.Rows)
            {
                category_txt.Items.Add(dr["Category_name"].ToString());
            }
            try
            {
                products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(code_txt.Text));
                name_txt.Text = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                old_pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                //bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                count_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                limit_txt.Text = dataSet11.products_table.Rows[0]["pro_limit"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataSet11.products_table.Rows[0]["pro_expiration_date"]);
                company_txt.Text = dataSet11.products_table.Rows[0]["pro_mada_fa3ala"].ToString();
                site_txt.Text = dataSet11.products_table.Rows[0]["pro_marad"].ToString();
                notes_txt.Text = dataSet11.products_table.Rows[0]["pro_mwared_phone"].ToString();
                pictureBox1.ImageLocation = dataSet11.products_table.Rows[0]["pro_mwared"].ToString();
                nesba_saydaly_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                int_code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                old_int_code= dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                id.Text = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                pieces_in_packet_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
                stock_txt.Text = dataSet11.products_table.Rows[0]["pro_stock"].ToString();
                //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
                pro_old_count = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                bee3_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                basic_profit_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                gard_status_txt.Text = dataSet11.products_table.Rows[0]["gard_status"].ToString();

                decimal nesba_discount = (Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(bee3_txt.Text)) * 100;
                discount_nesba_txt.Text = nesba_discount.ToString("0.000");

            }
            catch { }

          
        }

        private void code_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    products_tableTableAdapter1.FillBy_id(dataSet11.products_table, Convert.ToInt32(code_txt.Text));
                    if (dataSet11.products_table.Rows.Count <= 0) 
                    {
                        products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, code_txt.Text,far3txt.Text);
                    }
                    code_txt.Text = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    name_txt.Text = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    old_pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    //bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    count_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    limit_txt.Text = dataSet11.products_table.Rows[0]["pro_limit"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataSet11.products_table.Rows[0]["pro_expiration_date"]);
                    company_txt.Text = dataSet11.products_table.Rows[0]["pro_mada_fa3ala"].ToString();
                    site_txt.Text = dataSet11.products_table.Rows[0]["pro_marad"].ToString();
                    notes_txt.Text = dataSet11.products_table.Rows[0]["pro_mwared_phone"].ToString();
                    pictureBox1.ImageLocation = dataSet11.products_table.Rows[0]["pro_mwared"].ToString();
                    nesba_saydaly_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                    int_code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    old_int_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    id.Text = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    pieces_in_packet_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
                    stock_txt.Text = dataSet11.products_table.Rows[0]["pro_stock"].ToString();
                    //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
                    pro_old_count = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    bee3_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                    basic_profit_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                    gard_status_txt.Text = dataSet11.products_table.Rows[0]["gard_status"].ToString();

                    gard_status_txt.Focus();
                    decimal nesba_discount = (Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(bee3_txt.Text)) * 100;
                    discount_nesba_txt.Text = nesba_discount.ToString("0.000");
                }
                catch
                {
                    try
                    {
                        products_tableTableAdapter1.FillBy_pro_int_code(dataSet1.products_table,code_txt.Text);
                        name_txt.Text = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                        old_pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                        category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                        cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                        //bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                        count_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                        limit_txt.Text = dataSet11.products_table.Rows[0]["pro_limit"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dataSet11.products_table.Rows[0]["pro_expiration_date"]);
                        company_txt.Text = dataSet11.products_table.Rows[0]["pro_mada_fa3ala"].ToString();
                        site_txt.Text = dataSet11.products_table.Rows[0]["pro_marad"].ToString();
                        notes_txt.Text = dataSet11.products_table.Rows[0]["pro_mwared_phone"].ToString();
                        pictureBox1.ImageLocation = dataSet11.products_table.Rows[0]["pro_mwared"].ToString();
                        nesba_saydaly_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                        int_code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        old_int_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        id.Text = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                        pieces_in_packet_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
                        stock_txt.Text = dataSet11.products_table.Rows[0]["pro_stock"].ToString();
                        //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
                        pro_old_count = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                        bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                        bee3_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                        basic_profit_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                        gard_status_txt.Text = dataSet11.products_table.Rows[0]["gard_status"].ToString();
                        decimal nesba_discount = (Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(bee3_txt.Text)) * 100;
                        discount_nesba_txt.Text = nesba_discount.ToString("0.000");
                    }
                    catch
                    {

                        MessageBox.Show("تأكد من الكود");
                    }
                }
            }
        }

        private void count_txt_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = save_btn;
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            
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
            }

            name_txt.AutoCompleteCustomSource = DataCollection;
         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (name_txt.Text == "")
                {
                    MessageBox.Show("ادخل اسم الصنف اولا");
                    return;
                }
                openFileDialog1.Filter = "images files |*.jpg";
                // openFileDialog1.ShowDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ppath = openFileDialog1.FileName;
                    picture_txt.Text = ppath;

                    File.Copy(ppath, System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg", true);
                    pictureBox1.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg";
                    picture_txt.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\" + name_txt.Text + ".jpg";
                    //MessageBox.Show(openFileDialog1.FileName);

                }
            //}
            //catch { MessageBox.Show("مسارالملف غير صالح"); }
        }

        private void name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try 
            {
                if (e.KeyCode == Keys.Return) 
                {
                    products_tableTableAdapter1.FillBy_name(dataSet11.products_table, name_txt.Text);
                    old_pro_name = dataSet11.products_table.Rows[0]["pro_name"].ToString();
                    code_txt.Text = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    category_txt.Text = dataSet11.products_table.Rows[0]["pro_category"].ToString();
                    cost_txt.Text = dataSet11.products_table.Rows[0]["pro_cost_price"].ToString();
                    //bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    count_txt.Text = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    limit_txt.Text = dataSet11.products_table.Rows[0]["pro_limit"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dataSet11.products_table.Rows[0]["pro_expiration_date"]);
                    company_txt.Text = dataSet11.products_table.Rows[0]["pro_mada_fa3ala"].ToString();
                    site_txt.Text = dataSet11.products_table.Rows[0]["pro_marad"].ToString();
                    notes_txt.Text = dataSet11.products_table.Rows[0]["pro_mwared_phone"].ToString();
                    pictureBox1.ImageLocation = dataSet11.products_table.Rows[0]["pro_mwared"].ToString();
                    nesba_saydaly_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                    int_code_txt.Text = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    old_int_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                    id.Text = dataSet11.products_table.Rows[0]["pro_ID"].ToString();
                    pieces_in_packet_txt.Text = dataSet11.products_table.Rows[0]["pro_pieces_in_packet"].ToString();
                    stock_txt.Text = dataSet11.products_table.Rows[0]["pro_stock"].ToString();
                    //gmhour_txt.Text = (Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_bee3_2"]) / Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_pieces_in_packet"])).ToString();
                    pro_old_count = dataSet11.products_table.Rows[0]["pro_count"].ToString();
                    bee3_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                    bee3_gomla_txt.Text = dataSet11.products_table.Rows[0]["pro_bee3_2"].ToString();
                    basic_profit_txt.Text = dataSet11.products_table.Rows[0]["nesba_saydaly"].ToString();
                    gard_status_txt.Text = dataSet11.products_table.Rows[0]["gard_status"].ToString();
                    decimal nesba_discount = (Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(bee3_txt.Text)) * 100;
                    discount_nesba_txt.Text = nesba_discount.ToString("0.000");
                }
            }
            catch { }
        }

        private void name_txt_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void name_txt_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = save_btn;
        }

        private void similar_txt_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void similar_txt_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = save_btn;
        }

        private void edit_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.refresh_categories();
        }

        private void code_txt_Leave(object sender, EventArgs e)
        {
            AcceptButton = save_btn;
        }

        private void discount_nesba_txt_TextChanged(object sender, EventArgs e)
        {
            if (discount_nesba_txt.Focused == true) 
            {
                if (discount_nesba_txt.Text != "" )
                {
                    decimal cost_price = Convert.ToDecimal(bee3_txt.Text) - (Convert.ToDecimal(bee3_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                    cost_txt.Text = cost_price.ToString("0.00");
                }
            }
        }

        private void gomla_gomla_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bee3_txt.Focused == true&&discount_nesba_txt.Visible==true)
                {
                    if (discount_nesba_txt.Text != "" && discount_nesba_txt.Text != "0")
                    {
                        decimal cost_price = Convert.ToDecimal(bee3_txt.Text) - (Convert.ToDecimal(bee3_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                        cost_txt.Text = cost_price.ToString("0.00");
                    }
                }
            }
            catch { }
        }

        private void cost_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cost_txt.Focused == true && discount_nesba_txt.Visible == true)
                {
                    if (cost_txt.Text != "" && discount_nesba_txt.Text != "0")
                    {
                        decimal nesba = 100 - ((Convert.ToDecimal(cost_txt.Text) / Convert.ToDecimal(bee3_txt.Text)) * 100);
                        discount_nesba_txt.Text = nesba.ToString("0.00");
                        // decimal cost_price = Convert.ToDecimal(unit_price_txt.Text) - (Convert.ToDecimal(unit_price_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                        // cost_txt.Text = cost_price.ToString();
                    }
                }

            }
            catch { }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void picture_txt_TextChanged(object sender, EventArgs e)
        {

        }

        

       
    }
}
