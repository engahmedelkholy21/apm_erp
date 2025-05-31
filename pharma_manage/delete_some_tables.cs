using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace pharma_manage
{
    public partial class delete_some_tables : Form
    {
        public delete_some_tables()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e,Button b)
        {
            if (b.BackColor == Color.Green)
            {
                b.BackColor = Color.Red;
            }
            else 
            {
                b.BackColor = Color.Green;
            }
        }

        private void delete_some_tables_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            {
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.Green;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Location = new System.Drawing.Point(544, 8);
                btn.Name = s.ToString();
                btn.Size = new System.Drawing.Size(167, 69);
                btn.TabIndex = 1;
                btn.Text = s.ToString();
                btn.UseVisualStyleBackColor = false;
                btn.Cursor = Cursors.Hand;
                btn.Click += new EventHandler(delegate(object ss, EventArgs ee) { btn_Click(sender, e,btn); });
                flowLayoutPanel1.Controls.Add(btn);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox list = new ListBox();

            string un = "";
            string pw = "";
            string ip = "";
            string db_name;
            try
            {
                un = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                pw = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                ip = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
            }
            catch
            {

            }


            SqlConnection c = new SqlConnection();
            if (un == "")
            {
                c.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

                db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";
            }
            else
            {
                c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=my_data;Integrated Security=false;User ID=" + un + ";Password=" + pw;
                db_name = "my_data";
            }



            SqlCommand cmd = new SqlCommand();




            c.Open();
            SqlCommand com = new SqlCommand("SELECT   TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG='" + db_name + "'", c);
            DataTable t = c.GetSchema("Tables");
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            adapter.Fill(t);
            foreach (DataRow dr in t.Rows)
            {
                list.Items.Add(dr[2].ToString());
            }

            foreach (Button b in flowLayoutPanel1.Controls) 
            {
                MessageBox.Show(b.Name.ToString());
            }
           


            ////  string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + ".bak";
            //// MessageBox.Show(path);
            //ListBox mabe3at_list = new ListBox();
            //foreach (var item in list.Items)
            //{
            //    if (item.ToString() == "mwardeen")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "mwardeen";
            //        cb.Text = "الموردين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "Numbers_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "Numbers_table";
            //        cb.Text = "ارقام الفواتير";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "da2n_small_reports")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "da2n_small_reports";
            //        cb.Text = "الدائنين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "customers")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "customers";
            //        cb.Text = "العملاء";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }

            //    if (item.ToString() == "ta2feel_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "ta2feel_table";
            //        cb.Text = "التقفيل";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }

            //    if (item.ToString() == "pharmacy_data")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "pharmacy_data";
            //        cb.Text = "بيانات الصيدلية";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }

            //    if (item.ToString() == "mortaga3_purchases")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "mortaga3_purchases";
            //        cb.Text = "مرتجعات الشراء";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }



            //    if (item.ToString() == "nwa2es")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "nwa2es";
            //        cb.Text = "النواقص";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "Category")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "Category";
            //        cb.Text = "الفئات";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "income_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "income_table";
            //        cb.Text = "الوارد للخزينة";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "outcome_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "outcome_table";
            //        cb.Text = "الصادر من الخزينة";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "ma5zoon_moves")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "ma5zoon_moves";
            //        cb.Text = "حركة المخزون";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "madeen_small_report")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "sales_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "sales_table";
            //        cb.Text = "المبيعات";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "Purchases_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "Purchases_table";
            //        cb.Text = "المشتريات";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "ras_mal_products")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "ras_mal_products";
            //        cb.Text = "رأس المال";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "stock_table ")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "stock_table ";
            //        cb.Text = "الفروع";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "deleted_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "deleted_table";
            //        cb.Text = "المحذوفات";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "solfa_table ")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "solfa_table ";
            //        cb.Text = "السلف";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "extra_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "extra_table";
            //        cb.Text = "اضافي الموظفين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "arba7")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "arba7";
            //        cb.Text = "الارباح";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "ta7weel_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "ta7weel_table";
            //        cb.Text = "التحويلات";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "mokaf2at_table")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "madeen_small_report")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "madeen_small_report")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "madeen_small_report")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "madeen_small_report")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }
            //    if (item.ToString() == "madeen_small_report")
            //    {
            //        CheckBox cb = new CheckBox();
            //        cb.Name = "madeen_small_report";
            //        cb.Text = "المدينين";
            //        flowLayoutPanel1.Controls.Add(cb);
            //    }



            //}
            //c.Close();

            //  numbers_tableTableAdapter1.Insert(1, 1,1,1,"الرئيسي");
            //MessageBox.Show("تم مسح جميع البيانات ستتم اعادة تشغيل النظام");
            //Application.Restart();
        }


        }
    }

