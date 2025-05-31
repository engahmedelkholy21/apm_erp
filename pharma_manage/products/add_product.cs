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
    public partial class add_product : Form
    {
        public add_product()
        {
            InitializeComponent();

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
        private void add_product_Load(object sender, EventArgs e)
        {
            string buy_type_txt = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt").First();
            if (buy_type_txt == "نسبة")
            {
                label29.Visible = true;
                discount_nesba_txt.Visible = true;

                //// Save the current location of label1
                //Point tempLocation_label = label1.Location;

                //// Set the location of label1 to the location of label2
                //label5.Location = label29.Location;

                //// Set the location of label2 to the original location of label1
                //label29.Location = tempLocation_label;
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
                //label10.Visible = true;
                bee3_gomla_txt.Visible = true;
                label20.Visible = true;
                label24.Visible = true;
              //  gomla_checkBox4.Checked = true;
            }
            else
            {
                label10.Text = "سعر البيع";
               // label10.Visible = false;
                bee3_gomla_txt.Visible = false;
                label20.Visible = false;
                label24.Visible = false;
               // gomla_checkBox4.Checked = false;
            }
            //if ("gomla") 
            //{ } 
            //else { }

            this.stock_tableTableAdapter.Fill(this.dataSet1.stock_table);
            foreach (DataRow dr in dataSet1.stock_table.Rows)
            {
                if (stock_txt.Items.Contains(dr["stock_name"].ToString()))
                { }
                else
                {
                    stock_txt.Items.Add(dr["stock_name"].ToString());
                }
            }


            // TODO: This line of code loads data into the 'dataSet1.Category' table. You can move, or remove it, as needed.
            category_txt.Items.Clear();
            this.categoryTableAdapter.Fill(this.dataSet1.Category);
            foreach (DataRow dr in dataSet1.Category.Rows)
            {
                category_txt.Items.Add(dr["Category_name"].ToString());
            }
            
            this.products_tableTableAdapter.Fill(this.dataSet1.products_table);
             name_txt.Focus();


             suggest_product();

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


            }

            name_txt.AutoCompleteCustomSource = DataCollection;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (limit_txt.Text == "")
                {
                    limit_txt.Text = "0";
                }
                products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text, stock_txt.Text);
                foreach (DataRow dr in dataSet1.products_table.Rows)
                {
                    if (dr["pro_name"].ToString() == name_txt.Text)
                    {
                        MessageBox.Show("المنتج موجود مسبقا", "توقف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }

                if (int_code_txt.Text != "")
                {
                    products_tableTableAdapter.FillBy_int_code_and_far3(dataSet1.products_table, int_code_txt.Text, stock_txt.Text);
                    foreach (DataRow dr in dataSet1.products_table.Rows)
                    {
                        if (dr["pro_int_code"].ToString() == int_code_txt.Text)
                        {
                            MessageBox.Show("الكود موجود مسبقا", "توقف", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                }
                // this.products_tableTableAdapter.Fill(this.dataSet1.products_table);

                if (Convert.ToDecimal(bee3_txt.Text) < Convert.ToDecimal(cost_txt.Text))
                {
                    MessageBox.Show("تأكد من سعر الشراء وسعر البيع");

                    bee3_txt.SelectAll();
                    bee3_txt.Focus();
                    return;

                }
                categoryTableAdapter.FillBy_name(dataSet1.Category, category_txt.Text);
                if (dataSet1.Category.Rows.Count <= 0)
                {
                    categoryTableAdapter.Insert(category_txt.Text, 0, "", 0);
                }

                if (basic_profit_txt.Text == "")
                {
                    basic_profit_txt.Text = "0";
                }


                // الشركة mada_fa3ala
                //المكان marad
                //الصوره mwared_name
                //ملاحظات mwared phone
                //insert product
                if (bee3_gomla_txt.Text == "")
                {
                    bee3_gomla_txt.Text = bee3_txt.Text;
                }
                if (int_code_txt.Text == "")
                {
                    products_tableTableAdapter.Insert_product(name_txt.Text, category_txt.Text, Convert.ToDecimal(cost_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(count_txt.Text),
                   Convert.ToDecimal(limit_txt.Text), DateTime.Today.ToShortDateString(), company_txt.Text, site_txt.Text, picture_txt.Text, notes_txt.Text, usertxt.Text, Convert.ToDecimal(basic_profit_txt.Text), stock_txt.Text, Convert.ToDecimal(pieces_in_packet_txt.Text)
                   , Convert.ToDecimal(pieces_in_packet_txt.Text) * Convert.ToDecimal(count_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text) * Convert.ToDecimal(pieces_in_packet_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text), "", "تم الجرد", DateTime.Today.ToShortDateString());

                    // products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text,stock_txt.Text);
                    products_tableTableAdapter.FillBy_last_id(dataSet1.products_table);
                    int intcode = Convert.ToInt32(dataSet1.products_table.Rows[0]["pro_ID"].ToString());
                    //   MessageBox.Show(intcode.ToString());
                    products_tableTableAdapter.Update_int_code_by_id(intcode.ToString(), intcode);


                }
                else
                {
                    // الشركة mada_fa3ala
                    //المكان marad
                    //الصوره mwared_name
                    //ملاحظات mwared phone
                    //insert product

                    //insert product
                    products_tableTableAdapter.Insert_product(name_txt.Text, category_txt.Text, Convert.ToDecimal(cost_txt.Text), Convert.ToDecimal(bee3_txt.Text), Convert.ToDecimal(count_txt.Text),
                   Convert.ToDecimal(limit_txt.Text), DateTime.Today.ToShortDateString(), company_txt.Text, site_txt.Text, picture_txt.Text, notes_txt.Text, usertxt.Text, Convert.ToDecimal(0), stock_txt.Text, Convert.ToDecimal(pieces_in_packet_txt.Text)
                   , Convert.ToDecimal(pieces_in_packet_txt.Text) * Convert.ToDecimal(count_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text) * Convert.ToDecimal(pieces_in_packet_txt.Text), Convert.ToDecimal(bee3_gomla_txt.Text), int_code_txt.Text, "تم الجرد", DateTime.Today.ToShortDateString());
                }

                //insert ma5zoon

                //insert similar

                products_tableTableAdapter.FillBy_name_and_far3(dataSet1.products_table, name_txt.Text, stock_txt.Text);
                int id = Convert.ToInt32(dataSet1.products_table.Rows[0]["pro_ID"].ToString());



                name_txt.Clear(); cost_txt.Clear(); count_txt.Clear(); bee3_gomla_txt.Clear();
                limit_txt.Clear();
                int_code_txt.Clear(); bee3_txt.Clear();
                basic_profit_txt.Clear();
                picture_txt.Clear(); notes_txt.Clear(); company_txt.Clear(); site_txt.Clear();
                pictureBox1.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic\\no image.jpg";
                //pieces_in_packet_txt.Clear();
                MessageBox.Show("تمت الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //add_serial a = new add_serial();
                //a.usertxt.Text = usertxt.Text;
                //a.ShowDialog();
                name_txt.Select();
                products_tableTableAdapter.Fill(dataSet1.products_table);
                add_product_Load(sender, e);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


       // }
        //private void create_image(string data1) 
        //{
        //    Linear barcode = new Linear();
        //    // Set barcode symbology type to Code-39
        //    barcode.Type = BarcodeType.CODE39;
        //    // Set barcode data to encode
        //    barcode.Data = data1;
        //    // Set barcode bar width (X dimension) in pixel
        //    barcode.X = 2;
        //    // Set barcode bar height (Y dimension) in pixel
        //    barcode.Y = 20;
        //    // Draw & print generated barcode to png image file
        //    Bitmap MyBarcodeBitmap = barcode.drawBarcode();
        //    pictureBox1.Image = MyBarcodeBitmap;

        //}
        private void button1_Click(object sender, EventArgs e)
        {

            //foreach (DataRow dr in dataSet1.products_table.Rows)
            //{
            //    // Create linear barcode object

            //    create_image(dr["pro_ID"].ToString());
            //    var points = new List<Point>();
            //    Bitmap imgg = new Bitmap(pictureBox1.Image);

            //    int c = Color.Red.ToArgb();
            //    //for (int i = 0; i <= 4; i++)
            //    //{
            //        for (int x = 0; x < imgg.Width; x++)
            //        {
            //            for (int y = 0; y < imgg.Height; y++)
            //            {
            //                if (c.Equals(imgg.GetPixel(x, y).ToArgb()))
            //                {
            //                    create_image(dr["pro_ID"].ToString());
            //                }

            //            }
            //        }
            //   // }




            //    //barcode.drawBarcode("D://barcode//" + dataSet1.product_2.Rows[0]["pro2_name"].ToString()+ ".png");
                
            //        System.IO.MemoryStream defaultImageStream = new System.IO.MemoryStream();
            //        Bitmap img = new Bitmap(pictureBox1.Image);
            //        Image b = (Image)img;
            //        b.Save(defaultImageStream, System.Drawing.Imaging.ImageFormat.Bmp);
            //        byte[] defaultImageData = new byte[defaultImageStream.Length];
            //        //assign byte array the content of image
            //        defaultImageData = defaultImageStream.ToArray();
            //        int pro_code = Convert.ToInt32(dr["pro_ID"]);
            //        products_tableTableAdapter.Update_barcode_image(defaultImageData, pro_code);
            //}
            //MessageBox.Show("done");


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
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
            }
            catch { MessageBox.Show("مسارالملف غير صالح"); }
        }

        private void similar_txt_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void similar_txt_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = save_btn;
        }

       

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void add_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.refresh_categories();
        }

        private void discount_nesba_txt_TextChanged(object sender, EventArgs e)
        {
            if (discount_nesba_txt.Focused == true)
            {
                if (discount_nesba_txt.Text != "")
                {
                    decimal cost_price = Convert.ToDecimal(bee3_txt.Text) - (Convert.ToDecimal(bee3_txt.Text) * (Convert.ToDecimal(discount_nesba_txt.Text) / 100));
                    cost_txt.Text = cost_price.ToString("0.00");
                }
            }
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

       
    }
}
