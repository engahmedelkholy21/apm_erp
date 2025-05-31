using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.IO;

using System.ServiceProcess;

using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Net;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Globalization;


namespace pharma_manage
{
    public partial class login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );



        public login()
        {
            InitializeComponent();

           
            try
            {
                //  string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icon.ico";
                this.Icon = Properties.Resources.icon;// new Icon(path);
            }
            catch { }

            this.customersTableAdapter1.Fill(this.dataSet11.customers);
            foreach (DataRow dr in dataSet11.customers.Rows)
            {
               // apm_txt_box1.SRC_LIST.Items.Add(dr["cst_name"].ToString());
            }


            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 35;
            int borderWidth = 5;
            Rectangle panelBounds = new Rectangle(borderWidth, borderWidth, this.Width - 2 * borderWidth, this.Height - 2 * borderWidth);
            path.AddArc(panelBounds.Left, panelBounds.Top, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panelBounds.Right - cornerRadius, panelBounds.Top, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panelBounds.Right - cornerRadius, panelBounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(panelBounds.Left, panelBounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            

            //ControlStyler.ApplyModernStyle(textBox2);
            //ControlStyler.ApplyModernStyle(button2);
            //ControlStyler.ApplyModernStyle(comboBox1);
        }

        public void ApplyModernStyle(TextBox textBox, Color borderColor, Color shadowColor, bool flatAppearance = true)
        {
            // Set corner radius and border width based on TextBox dimensions
            int cornerRadius = Math.Min(textBox.Width, textBox.Height) / 5; // 20% of smaller dimension
            int borderWidth = textBox.Height / 10; // 10% of height

            // Create rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(borderWidth, borderWidth, textBox.Width - 2 * borderWidth, textBox.Height - 2 * borderWidth);

            // Add arcs for rounded corners
            path.AddArc(bounds.Left, bounds.Top, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Top, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(bounds.Right - cornerRadius, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            // Set the path as the region for the TextBox to get rounded corners
            textBox.Region = new Region(path);

            // Apply shadow effect (optional)
            textBox.Paint += (sender, e) =>
            {
                using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                {
                    e.Graphics.FillPath(shadowBrush, path);
                    e.Graphics.TranslateTransform(3, 3); // Offset for shadow
                }
            };

            // Draw border
            textBox.Paint += (sender, e) =>
            {
                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            };

            // Set flat appearance if applicable
            if (flatAppearance)
            {
                textBox.BorderStyle = BorderStyle.None; // Remove default border for flat look
                textBox.BackColor = Color.WhiteSmoke; // Light background color for modern look
            }
        }

       // ListBox l = new ListBox();

        private void check_server()
        {
            ServiceController service = new ServiceController("MSSQL$SQLEXPRESS");

            TimeSpan timeout = TimeSpan.FromMilliseconds(5000);
            //  MessageBox.Show(service.Status.ToString());
            if (service.Status.ToString() == "Stopped")
            {
                try
                {
                    service.Refresh();
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }
                catch { }
            }
        }

        private void restart_server()
        {
            ServiceController service = new ServiceController("MSSQL$SQLEXPRESS");

            TimeSpan timeout = TimeSpan.FromMilliseconds(5000);


            try
            {
                service.Refresh();
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);



                service.Refresh();
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);



            }
            catch { }

        }

        private void check_db_tables()
        {
            try
            {

                string un = "";
                string pw = "";
                string ip = "";
                string db_name="";
                try
                {
                    un = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                    pw = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                    ip = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
                    db_name = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();

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
                    c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog="+db_name+";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                  //  db_name = "my_data";

                }
                SqlCommand cmd = new SqlCommand();


                try
                {
                    cmd = new SqlCommand("alter table [products_table] add [gard_status] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [products_table] add [last_gard_date] [date] NULL", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                  //  MessageBox.Show("Added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   //MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("alter table [pharmacy_data] alter COLUMN [pharmacy_phone] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
              c.Close();

              try
              {

                  cmd = new SqlCommand("alter table [products_table] alter COLUMN [pro_mwared] [varchar](200)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();


              try
              {

                  cmd = new SqlCommand("alter table [products_table] alter COLUMN [pro_bee3_2] decimal(18, 2)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();

              try
              {

                  cmd = new SqlCommand("alter table [pharmacy_data] add [qr_pic] [image]", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();

              

              try
              {

                  cmd = new SqlCommand("alter table [pharmacy_data] add [pharmacy_mail] [varchar](100)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();


              try
              {

                  cmd = new SqlCommand("alter table [pharmacy_data] add [pharmacy_sender_mail] [varchar](100)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();

              try
              {

                  cmd = new SqlCommand("alter table [pharmacy_data] add [pharmacy_sender_password] [varchar](100)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();


              try
              {

                  cmd = new SqlCommand("alter table [mo3adalat_tasnee3_table] alter COLUMN [mo3adalat_tasnee3_material_count] decimal(18, 3)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();

              try
              {

                  cmd = new SqlCommand("alter table [products_table] alter COLUMN [pro_count] decimal(18, 3)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();


              try
              {

                  cmd = new SqlCommand("ALTER TABLE [ma5zoon_moves] ALTER COLUMN [ma5zoon_count] decimal(18, 3);" +
                      "ALTER TABLE [ma5zoon_moves] ALTER COLUMN [ma5zoon_before] decimal(18, 3);" +
                      "ALTER TABLE [ma5zoon_moves] ALTER COLUMN [ma5zoon_after] decimal(18, 3);", c); c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                // MessageBox.Show(ex.Message);
              }
              c.Close();
              try
              {

                  cmd = new SqlCommand("alter table [pharmacy_data]  add [phone_2] [varchar](100)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();

              try
              {

                  cmd = new SqlCommand(@"
                    ALTER TABLE [sales_table] 
                    ADD 
                    [sales_fatora_type] VARCHAR(50) NULL, 
                    [sales_pro_stock] VARCHAR(50) NULL, 
                    [sales_mandoob] VARCHAR(150) NULL, 
                    [sales_serial] VARCHAR(100) NULL", c);


                  c.Open();
                  cmd.ExecuteNonQuery();

                  //   MessageBox.Show("added");
                  c.Close();
              }
              catch (Exception ex)
              {
                  //  MessageBox.Show(ex.Message);
              }
              c.Close();



              try
              {

                  cmd = new SqlCommand("alter table [sales_table]  add [discount_nesba] decimal(18, 2)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();


              

              try
              {

                  cmd = new SqlCommand("alter table [sales_table]  add [sales_day_num] int", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                 // MessageBox.Show("added");
                  c.Close();
              }
              catch (Exception ex)
              {
                 // MessageBox.Show(ex.Message);
              }
              c.Close();

              try
              {

                  cmd = new SqlCommand("alter table [sales_table]  add [price_before_discount_nesba] decimal(18, 2)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
              }
              catch (Exception ex)
              {
                  //MessageBox.Show(ex.Message);
              }
              c.Close();


              try
              {

                  cmd = new SqlCommand("alter table [sales_table]  add [sales_time] time(7)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();
                 
              }
              catch (Exception ex)
              {
             //  MessageBox.Show(ex.Message);
              }
              c.Close();



              try
              {

                  cmd = new SqlCommand("alter table [sales_table]  add [sales_cat_extra] decimal(18, 2)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();

              }
              catch (Exception ex)
              {
                  //  MessageBox.Show(ex.Message);
              }
              c.Close();


              try
              {

                  cmd = new SqlCommand("alter table [Category]  add [cat_extra] decimal(18, 2)", c);
                  c.Open();
                  cmd.ExecuteNonQuery();
                  c.Close();

              }
              catch (Exception ex)
              {
                  //  MessageBox.Show(ex.Message);
              }
              c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [ras_mal_products] add [far3] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();
                try
                {
                    cmd = new SqlCommand(@"
                    CREATE TABLE [employee_table] (
                        [employee_id] INT IDENTITY(1,1) NOT NULL,
                        [employee_name] VARCHAR(150) NULL,
                        [employee_address] VARCHAR(200) NULL,
                        [employee_phone] VARCHAR(30) NULL,
                        [employee_national_id] VARCHAR(14) NULL,
                        [employee_job] VARCHAR(150) NULL,
                        [employee_last_graduation] VARCHAR(150) NULL,
                        [employee_notes] VARCHAR(200) NULL,
                        [employee_daily_salary] DECIMAL(18, 2) NULL,
                        [employee_monthly_salary] DECIMAL(18, 2) NULL,
                        [employee_user] VARCHAR(50) NULL,
                        [emp_time_to_attend] TIME(7) NULL
                    )", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch
                {
                   
                }
                c.Close();


                try
                {
                    cmd = new SqlCommand(@"
                    ALTER TABLE [outcome_table] 
                    ADD 
                    [outcome_far3] VARCHAR(50) NULL", c); 
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();

                try
                {
                    cmd = new SqlCommand(@"
                    ALTER TABLE [income_table] 
                    ADD 
                    [income_far3] VARCHAR(50) NULL", c); c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [income_table] add [ba2y_fatora] decimal(18, 2)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [Purchases_table] add [stock] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [Purchases_table] add [price_before_discount] decimal(18, 2)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [Purchases_table] add [discount_nesba] decimal(18, 2)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [sales_mortaga3] add [fatora_discount] decimal(18, 2)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }
                c.Close();


                try
                {
                    string checkIdentityQuery = @"
        SELECT COLUMNPROPERTY(OBJECT_ID('sales_mortaga3'), 'mortaga3_sales_id', 'IsIdentity') AS IsIdentity";

                    cmd = new SqlCommand(checkIdentityQuery, c);
                    c.Open();
                    object result = cmd.ExecuteScalar();
                    c.Close();

                    if (result != null && Convert.ToInt32(result) == 1)
                    {
                        // Identity is set, so we need to drop and recreate the column
                        c.Open();

                        // Step 1: Add new column without identity
                        cmd = new SqlCommand("ALTER TABLE sales_mortaga3 ADD new_mortaga3_sales_id INT;", c);
                        cmd.ExecuteNonQuery();

                        // Step 2: Copy data
                        cmd = new SqlCommand("UPDATE sales_mortaga3 SET new_mortaga3_sales_id = mortaga3_sales_id;", c);
                        cmd.ExecuteNonQuery();

                        // Step 3: Drop original column
                        cmd = new SqlCommand("ALTER TABLE sales_mortaga3 DROP COLUMN mortaga3_sales_id;", c);
                        cmd.ExecuteNonQuery();

                        // Step 4: Rename new column to original name
                        cmd = new SqlCommand("EXEC sp_rename 'sales_mortaga3.new_mortaga3_sales_id', 'mortaga3_sales_id', 'COLUMN';", c);
                        cmd.ExecuteNonQuery();
                       // MessageBox.Show("done");
                        c.Close();
                    }
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }

                c.Close();


                try
                {

                    cmd = new SqlCommand("ALTER TABLE mortaga3_purchases ALTER COLUMN mortaga3_purchases_productID Varchar(100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {
                    cmd = new SqlCommand(@"
                    ALTER TABLE [arba7] 
                    ADD 
                    [basic_reb7] DECIMAL(18,2) NULL,
                    [safy_reb7] AS ([arba7_cost] - [basic_reb7])", c); c.Open();
                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [arba7] add [takelfa_fatora] decimal(18, 2) default 0 NOT NULL", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }

                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [Numbers_table] add [stock] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();

                    c.Close();


                }
                catch { }

                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [arba7] add [stock] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();

                try
                {
                    cmd = new SqlCommand(@"
                    CREATE TABLE [dbo].[arba7_cat_table](
                        [arba7_cat_id] INT IDENTITY(1,1) NOT NULL ,
                        [arba7_cat_date] DATE ,
                        [arba7_cat_details] VARCHAR(300) ,
                        [arba7_cat_cost] DECIMAL(18,2) ,
                        [arba7_cat_category] VARCHAR(50) ,
                        [arba7_cat_fatora_id] INT ,
                        [arba7_cat_src] VARCHAR(50) ,
                        [stock] VARCHAR(100) 
                    )", c);
                    c.Open();
                    cmd.ExecuteNonQuery();

                       //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [arba7_cat_table] add [stock] [varchar](100)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [halek_table] add [halek_stock] [varchar](50)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [numbers_table] add [mas7obat_ID] [int],[amr_sh3l_id] [int],[tawreedat_ID] [int]", c);
                    c.Open();//tst hena
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [numbers_table] add [syana_ID] [int],[ta7weel_ID] [int]", c);
                    c.Open();//tst hena
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [numbers_table] add [tas3eer_ID] [int]", c);
                    c.Open();//tst hena
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();



                try
                {

                    cmd = new SqlCommand("CREATE TABLE [stock_table]([stock_id] [int] IDENTITY(1,1) NOT NULL ,[stock_name] [varchar](50) ,[stock_notes] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                     //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand("CREATE TABLE [freq_table]([freq_id] [int] IDENTITY(1,1) NOT NULL ,[freq_control_name] [varchar](50) ,[freq_control_event_name] [varchar](50) ,[freq_control_type] [varchar](50),[freq_control_count] [int] ,[freq_control_txt] [varchar](50) NULL,[freq_user] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                  //   MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                  // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [dbo].[resp_table]([resp_id] [int] IDENTITY(1,1) NOT NULL,[resp_name] [varchar](100) ,[resp_phone] [varchar](50) ,[resp_address] [varchar](100) ,[resp_bonus] [decimal](18, 2) ,[resp_notes] [varchar](100)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                   // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand("CREATE TABLE [tas3eer_table]([tas3eer_id] [int] NOT NULL,[tas3eer_date] [date] NULL,[tas3eer_cst_name] [varchar](100) ,[tas3eer_cst_phone] [varchar](100) ,[tas3eer_cst_address] [varchar](max) ,[tas3eer_profit] [decimal](18, 2) ,[tas3eer_madfoo3] [decimal](18, 2) NULL,[tas3eer_user] [varchar](50) NULL,[tas3eer_discount] [decimal](18, 2) NULL,[tas3eer_7esab_sabe2] [decimal](18, 2) NULL,[tas3eer_ba2y_el7esab] [decimal](18, 2) NULL,[tas3eer_product_ID] [varchar](100) NULL,[tas3eer_product_name] [varchar](max) NULL,[tas3eer_product_count] [decimal](18, 2) NULL,[tas3eer_unit_price] [decimal](18, 2) NULL,[tas3eer_price_for_sell]  AS ([tas3eer_product_count]*[tas3eer_unit_price]),[tas3eer_notes] [varchar](150) ,	[tas3eer_nesba_discount] [float] ,[tas3eer_dariba] [decimal](18, 2) ,[tas3eer_pro_category] [varchar](100) ,[tas3eer_egmaly_kest_cost] [decimal](18, 2) ,[tas3eer_fatora_type] [varchar](50) ,[tas3eer_pro_stock] [varchar](50) ,[tas3eer_mandoob] [varchar](150) ,[tas3eer_serial] [varchar](100)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();





                try
                {

                    cmd = new SqlCommand("CREATE TABLE [final_report_table]( [ID] [int] IDENTITY(1,1) NOT NULL,[date] [date] NULL,[stock] [varchar](100) ,[TOTAL_SALES] [decimal](18, 2) NULL ,[TOTAL_PURCHASES] [decimal](18, 2) NULL ,[TOTAL_MADEEN] [decimal](18, 2) NULL ,[TOTAL_DA2N] [decimal](18, 2) NULL ,[TOTAL_PRODUCTS] [decimal](18, 2) NULL,[TOTAL_ASSETS] [decimal](18, 2) NULL,[TOTAL_ARBA7] [decimal](18, 2) NULL,[TOTAL_INCOME] [decimal](18, 2) NULL,[TOTAL_OUTCOME_ALL] [decimal](18, 2) NULL,[outcome_nathryat] [decimal](18, 2) NULL,[arba7_after_masrofat] [decimal](18, 2) NULL,[pro_start] [decimal](18, 2) NULL,[pro_end] [decimal](18, 2) NULL,[pro_far2] [decimal](18, 2) NULL,[final_reb7] [decimal](18, 2) NULL,[user] [varchar](100)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();



                try
                {

                    cmd = new SqlCommand("alter table [final_report_table] add [TOTAL_MAS7OBAT] decimal(18, 2)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                    //  MessageBox.Show("aa");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [tawreedat_table]([tawreedat_id] [int] IDENTITY(1,1) NOT NULL,[tawreedat_no] [int] ,[tawreedat_date] [date],[tawreedat_responsible] [varchar](50),[tawreedat_material_id] [varchar](50),[tawreedat_material_name] [varchar](100) ,[tawreedat_material_count] [decimal](18, 2) ,[tawreedat_material_category] [varchar](50) ,[tawreedat_amr_sho3l_no] [varchar](50) ,[tawreedat_user] [varchar](50) ,[tawreedat_stock] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();



                try
                {

                    cmd = new SqlCommand("CREATE TABLE [temp_gard]([id] [varchar](50) ,[count] [decimal] (18,2),[far3] [varchar](50) ) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [day_numbers] ([day_id] int IDENTITY(1,1) NOT NULL,[day_date] [date],[day_num] int ) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   //  MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [mo3adalat_tasnee3_table]([mo3adalat_tasnee3_id] int IDENTITY(1,1) NOT NULL,[mo3adalat_tasnee3_pro_name] [varchar](150),[mo3adalat_tasnee3_material_name] [varchar](150),[mo3adalat_tasnee3_material_count] [decimal](18, 2) ,[mo3adalat_tasnee3_notes] [varchar](150) ,[mo3adalat_tasnee3_user] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand("CREATE TABLE [mas7obat_table]([mas7obat_id] [int] IDENTITY(1,1) NOT NULL,	[mas7obat_no] [int],[mas7obat_date] [date] ,[mas7obat_responsible] [varchar](50),[mas7obat_material_id] [varchar](50),[mas7obat_material_name] [varchar](100),[mas7obat_material_count] [decimal](18, 2) ,[mas7obat_material_category] [varchar](50),[mas7obat_amr_sho3l_no] [varchar](50),[mas7obat_user] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [mas7obat_table] add [mas7obat_unit_price] [decimal](18,2)", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [mas7obat_table] add [mas7obat_price_total] AS ([mas7obat_unit_price]*[mas7obat_material_count]) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   //  MessageBox.Show(ex.Message);
                }

                c.Close();
                try
                {

                    cmd = new SqlCommand("CREATE TABLE [amr_table]([amr_id] [int] IDENTITY(1,1) NOT NULL,[amr_num] [int] ,[amr_date] [date] ,[amr_pro_name] [varchar](100) ,[amr_amount] [decimal](18, 2) ,[amr_user] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand("CREATE TABLE [amr_material_table]([amr_material_id] [int] IDENTITY(1,1) NOT NULL,[amr_material_amr_num] [int] ,[amr_material_pro_name] [varchar](100) ,[amr_material_material_name] [varchar](100) ,[amr_material_material_amount] [decimal](18, 2) ,[amr_material_notes] [varchar](100) ,[amr_material_user] [varchar](50) ,[amr_material_unit_cost] [decimal](18, 2) ,[amr_material_total_cost]  AS ([amr_material_unit_cost]*[amr_material_material_amount])) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [amr_masrofat_table]([amr_masrofat_id] [int] IDENTITY(1,1) NOT NULL,[amr_masrofat_amr_num] [int] ,[amr_masrofat_byan] [varchar](150) ,[amr_masrofat_cost] [decimal](18, 2) ,[amr_masrofat_user] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [halek_table]([halek_id] int IDENTITY(1,1) NOT NULL,[halek_material_name] [varchar](100),[halek_material_id] [int],[halek_material_count] [decimal](18, 2) ,[halek_material_date] [date] ,[halek_material_notes] [varchar](50) ,[halek_material_user] [varchar](50),[halek_stock] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }

                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [assets_table]([asset_id] int IDENTITY(1,1) NOT NULL,[asset_date] [date] ,[asset_name] [varchar](150) ,[asset_cost] [decimal](18, 2) ,[asset_notes] [varchar](150) ,[asset_user] [varchar](50)) ", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch { }

                c.Close();
                try
                {

                    cmd = new SqlCommand("CREATE TABLE [dbo].[partners_share_table]([partner_id] int IDENTITY(1,1) NOT NULL,	[partner_name] [varchar](100) ,	[partner_amount] [decimal](18, 2) ,	[parnter_notes] [varchar](100) ) ", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("done");
                    c.Close();
                }
                catch { }
                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [partners_share_table] add [start_date] [date] ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                     //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

                c.Close();

                try
                {
                    cmd = new SqlCommand("alter table [partners_share_table] add [end_date] [date] ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }

                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [dbo].[ta2feel_table]([ta2feel_id] int IDENTITY(1,1) NOT NULL,	[ta2feel_date] [date] ,	[ta2feel_amount] [decimal](18, 2)) ", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("done");
                    c.Close();
                }
                catch { }
                c.Close();


                try
                {

                    //cmd = new SqlCommand("CREATE TABLE [dbo].[ta2feel_table]([ta2feel_id] int IDENTITY(1,1) NOT NULL,	[ta2feel_date] [date] ,	[ta2feel_amount] [decimal](18, 2)) ", c);
                    cmd = new SqlCommand("CREATE TABLE [dbo].[uploaded_files_table]([uploaded_id] [int] IDENTITY(1,1) NOT NULL, [uploaded_file_name] [varchar](50)  , [uploaded_file_extension] [varchar](10)  , [uploaded_file_date] [date]  , [uploaded_file_path] [varchar](250)  , [uploaded_file_user] [varchar](50)  , [uploaded_file_from] [varchar](50)  , [uploaded_file_notes] [nvarchar](100)  , [uploaded_warehouse] [varchar](50),[uploaded_type] [varchar](50))", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                  //   MessageBox.Show("done");
                    c.Close();
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message); 
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [dbo].[deleted_table]([deleted_id] int IDENTITY(1,1) NOT NULL,[deleted_date] [date] ,[deleted_code] [varchar](50) ,[deleted_details] [varchar](300) ,[deleted_notes] [varchar](300),[deleted_user] [varchar](50) ,[deleted_source] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                }
                catch (Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                }

                c.Close();

                try
                {

                    cmd = new SqlCommand("CREATE TABLE [dbo].[mosta7akat_da2neen_table]([mosta7akat_da2neen_id] int IDENTITY(1,1) NOT NULL,[mosta7akat_da2neen_cst_name] [varchar](150) ,[mosta7akat_da2neen_date] [date] ,[mosta7akat_da2neen_total_mosta7ak] [decimal](18, 2) ,[mosta7akat_da2neen_total_paid] [decimal](18, 2) ,[mosta7akat_da2neen_total_ba2y]  AS ([mosta7akat_da2neen_total_mosta7ak]-[mosta7akat_da2neen_total_paid]) ,[matloob_fatora] [decimal](18, 2) ,[mosta7akat_da2neen_dof3ah_amount] [decimal](18, 2) ,[mosta7akat_da2neen_user] [varchar](50) ,[mosta7akat_da2neen_matloob_before] [decimal](18, 2) ,[mosta7akat_da2neen_matloob_after] [decimal](18, 2) ,[mosta7akat_da2neen_notes] [varchar](150) ,[mosta7kat_type] [varchar](50) ,[fatora_number] [int] NULL)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("done");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

                c.Close();



                try
                {

                    cmd = new SqlCommand("CREATE TABLE [dbo].[mosta7akat_mas2oleen_table]([mosta7akat_mas2oleen_id] int IDENTITY(1,1) NOT NULL,[mosta7akat_mas2oleen_cst_name] [varchar](150) ,[mosta7akat_mas2oleen_date] [date] ,[mosta7akat_mas2oleen_total_mosta7ak] [decimal](18, 2) ,[mosta7akat_mas2oleen_total_paid] [decimal](18, 2) ,[mosta7akat_mas2oleen_total_ba2y]  AS ([mosta7akat_mas2oleen_total_mosta7ak]-[mosta7akat_mas2oleen_total_paid]) ,[matloob_fatora] [decimal](18, 2) ,[mosta7akat_mas2oleen_dof3ah_amount] [decimal](18, 2) ,[mosta7akat_mas2oleen_user] [varchar](50) ,[mosta7akat_mas2oleen_matloob_before] [decimal](18, 2) ,[mosta7akat_mas2oleen_matloob_after] [decimal](18, 2) ,[mosta7akat_mas2oleen_notes] [varchar](150) ,[mosta7kat_type] [varchar](50) ,[fatora_number] [int] NULL)", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("done");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

                c.Close();
                //  MessageBox.Show("done");



                try
                {
                    cmd = new SqlCommand("alter table [resp_table] add [mas2ool_matloob]  [decimal](18, 2),[mas2ool_madfoo3]  [decimal](18, 2),[mas2ool_ba2y] AS([mas2ool_matloob]-[mas2ool_madfoo3])", c);
                    c.Open();//tst hena
                    cmd.ExecuteNonQuery();

                    c.Close();
                }
                catch { }

                c.Close();


                try
                {
                    cmd = new SqlCommand("alter table [customers] add [cst_national_id]  [varchar](15), [cst_takseet_status]  [varchar](150),[betaka_url]  [varchar](200)", c);
                    c.Open();//tst hena
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("added");
                    c.Close();
                }
                catch { }

                c.Close();

                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [dbo].[aksat_table]([kest_id] [int] IDENTITY(1,1) NOT NULL ,[kest_number] [int] ,[kest_cst_code] [varchar](50) ,
	                    [kest_cst_name] [varchar](150) ,[kest_1st_damen_code] [varchar](50) ,[kest_1st_damen_name] [varchar](150) ,[kest_2nd_damen_code] [varchar](50) ,
	                    [kest_2nd_damen_name] [varchar](150) ,[kest_amount] [decimal](18, 2) ,[kest_est7kak_date] [date] ,
	                    [kest_pay_date] [date] ,[kest_notes] [varchar](200) ,[kest_user] [varchar](50) ,[kest_status] [varchar](50) ,[kest_delay_days] [decimal](18, 0) ,
                        [kest_mandoob_name] [varchar](100) ,[kest_mandoob_code] [varchar](15) ,[kest_far3] [varchar](15) ,[kest_modat_eltamweel] [varchar](50) ,
	                    [kest_loan_code] [varchar](50) ,[kest_delay_penalty_all] [decimal](18, 0) ,[kest_delay_penalty_mosadad] [decimal](18, 0) ,
	                    [kest_delay_penalty_ba2y]  AS ([kest_delay_penalty_all]-[kest_delay_penalty_mosadad]))", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                     //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


               

                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [loans_requests_table]([loan_id] [int] IDENTITY(1,1) NOT NULL,[loan_code] [varchar](50),[loan_cst_name] [varchar](150),
	                        [loan_cst_code] [varchar](50) ,[loan_amount] [decimal](18, 2) ,[loan_extra_amount] [decimal](18, 2) ,
                            [loan_final_amount]  AS ([loan_extra_amount]+[loan_amount]),[loan_1st_damen_name] [varchar](150) ,[loan_1st_damen_code] [varchar](50) ,
	                        [loan_2nd_damen_name] [varchar](150) ,[loan_2nd_damen_code] [varchar](50) ,[loan_notes] [varchar](150) ,[loan_agreed_or_not] [varchar](50) ,
	                        [loan_mandoob] [varchar](150) ,[loan_period] [int] NOT NULL ,[loan_user] [varchar](50) ,[loan_insert_date] [date] ,[loan_revision_date] [date] ,
	                        [loan_accepted_date] [date] ,[loan_sarf_date] [date] ,[loan_revised_by] [varchar](50) ,[loan_accepted_by] [varchar](50) ,
	                        [loan_delivered_by] [varchar](50) ,[loan_far3] [varchar](15) ,[loans_msareef] [decimal](18, 2) )", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                    //  MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand("alter table [loans_requests_table] add [fatora_num]  [int]", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                   // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                     //MessageBox.Show(ex.Message);
                }
                c.Close();



                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [dbo].[promo_table](
	                    [promo_id] [int] IDENTITY(1,1) NOT NULL,
                        [promo_name] [varchar](150) ,
	                    [promo_start_date] [datetime] ,
	                    [promo_end_date] [datetime] ,
	                    [promo_item_name] [varchar](150) ,
	                    [promo_item_code] [varchar](50) ,
	                    [promo_item_price] [decimal](18, 2) ,
	                    [promo_notes] [varchar](100) ,
	                    [promo_status] [varchar](50)) ", c);

                    c.Open();
                    cmd.ExecuteNonQuery();

                   //  MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [sales_temp_table] (
                    [sales_temp_cst_name] varchar(100),
                    [sales_temp_cst_phone] varchar(100),
                    [sales_temp_cst_address] varchar(200),
                    [sales_temp_discount] decimal(18, 2),
                    [sales_temp_product_ID] varchar(100),
                    [sales_temp_product_name] varchar(200),
                    [sales_temp_product_count] decimal(18, 2),
                    [sales_temp_unit_price] decimal(18, 2),
                    [sales_temp_notes] varchar(150),
                    [sales_temp_nesba_discount] float,
                    [sales_temp_dariba] decimal(18, 2),
                    [sales_temp_pro_category] varchar(100),
                    [sales_temp_fatora_type] varchar(50),
                    [sales_temp_pro_stock] varchar(50),
                    [sales_temp_mandoob] varchar(150),
                    [discount_nesba] decimal(18, 2),
                    [price_before_discount_nesba] decimal(18, 2),
                    [sales_temp_cat_extra] decimal(18, 2) )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
                c.Close();



                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [sales_temp_tas3eer_table] (
                    [sales_temp_tas3eer_cst_name] varchar(100),
                    [sales_temp_tas3eer_cst_phone] varchar(100),
                    [sales_temp_tas3eer_cst_address] varchar(200),
                    [sales_temp_tas3eer_discount] decimal(18, 2),
                    [sales_temp_tas3eer_product_ID] varchar(100),
                    [sales_temp_tas3eer_product_name] varchar(200),
                    [sales_temp_tas3eer_product_count] decimal(18, 2),
                    [sales_temp_tas3eer_unit_price] decimal(18, 2),
                    [sales_temp_tas3eer_notes] varchar(150),
                    [sales_temp_tas3eer_nesba_discount] float,
                    [sales_temp_tas3eer_dariba] decimal(18, 2),
                    [sales_temp_tas3eer_pro_category] varchar(100),
                    [sales_temp_tas3eer_fatora_type] varchar(50),
                    [sales_temp_tas3eer_pro_stock] varchar(50),
                    [sales_temp_tas3eer_mandoob] varchar(150),
                    [discount_nesba] decimal(18, 2),
                    [price_before_discount_nesba] decimal(18, 2),
                    [sales_temp_tas3eer_cat_extra] decimal(18, 2) )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [customer_points_table](
	                    [cst_points_id] [int] IDENTITY(1,1) NOT NULL,
	                    [cst_points_cst_name] [varchar](150) ,
	                    [cst_points_cst_phone] [varchar](50) ,
	                    [cst_total_points] [int] ,
	                    [cst_redeemed_points] [int] ,
	                    [cst_valid_points]  AS ([cst_total_points]-[cst_redeemed_points]),
	                    [cst_last_updated] [timestamp] )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    // MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand(@"CREATE TABLE [points_definition_table](
	                [points_def_id] [int] IDENTITY(1,1) NOT NULL,
                    [points_def_point_cost_in_fatora] [decimal](18, 2) ,
	                [points_def_point_value] [decimal](18, 2) ,
	                [points_def_expiry_days] [int] ,
	                [points_def_minimum_to_redeem] [int] ,
	                [points_def_notes] [varchar](150) )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                 //   MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                   //  MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand(@"
                    ALTER TABLE [products_table] 
                    ADD 
                    [pro_stock] VARCHAR(50) NULL, 
                    [pro_bee3_2] DECIMAL(18,2) NULL, 
                    [pro_count_in_pieces] DECIMAL(18,2) NULL, 
                    [pro_gomla_gomla] DECIMAL(18,2) NULL, 
                    [pro_pieces_in_packet] DECIMAL(18,2) NULL", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //   MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                }
                c.Close();



                try
                {

                    cmd = new SqlCommand(@"
                    ALTER TABLE [customers] 
                    ADD 
                    [cst_price_category] VARCHAR(50) NULL", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                       //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                     // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand(@"
                    ALTER TABLE [ma5zoon_moves] 
                    ADD 
                    [stock] VARCHAR(50) NULL", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                     cmd = new SqlCommand( @"
                CREATE TABLE [solfa_table] (
                    [solfa_id] INT IDENTITY(1,1) NOT NULL,
                    [solfa_date] DATE NULL,
                    [solfa_emp_name] VARCHAR(150) NULL,
                    [solfa_cost] DECIMAL(18,2) NULL,
                    [solfa_notes] VARCHAR(150) NULL,
                    [solfa_user] VARCHAR(50) NULL,
                    [solfa_paid_or_not] VARCHAR(50) NULL)", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                /////////////////////////
                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [mokaf2at_table] (
                        [mokaf2at_id] INT IDENTITY(1,1) NOT NULL,
                        [mokaf2at_date] DATE NULL,
                        [mokaf2at_emp_name] VARCHAR(150) NULL,
                        [mokaf2at_cost] DECIMAL(18,2) NULL,
                        [mokaf2at_notes] VARCHAR(150) NULL,
                        [mokaf2at_user] VARCHAR(50) NULL,
                        [mokaf2at_paid_or_not] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [halek_table] (
                        [halek_id] INT IDENTITY(1,1) NOT NULL,
                        [halek_material_name] VARCHAR(100) NULL,
                        [halek_material_id] INT NULL,
                        [halek_material_count] DECIMAL(18,2) NULL,
                        [halek_material_date] DATE NULL,
                        [halek_material_notes] VARCHAR(50) NULL,
                        [halek_material_user] VARCHAR(50) NULL,
                        [halek_stock] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [extra_table] (
                        [extra_id] INT IDENTITY(1,1) NOT NULL,
                        [extra_date] DATE NULL,
                        [extra_emp_name] VARCHAR(150) NULL,
                        [extra_cost] DECIMAL(18,2) NULL,
                        [extra_notes] VARCHAR(150) NULL,
                        [extra_user] VARCHAR(50) NULL,
                        [extra_paid_or_not] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [disocunts] (
                        [disocunts_id] INT IDENTITY(1,1) NOT NULL,
                        [disocunts_date] DATE NULL,
                        [disocunts_emp_name] VARCHAR(150) NULL,
                        [disocunts_cost] DECIMAL(18,2) NULL,
                        [disocunts_notes] VARCHAR(150) NULL,
                        [disocunts_user] VARCHAR(50) NULL,
                        [disocunts_paid_or_not] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();

                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [deleted_table] (
                        [deleted_id] INT IDENTITY(1,1) NOT NULL,
                        [deleted_date] DATE NULL,
                        [deleted_code] VARCHAR(50) NULL,
                        [deleted_details] VARCHAR(300) NULL,
                        [deleted_notes] VARCHAR(300) NULL,
                        [deleted_user] VARCHAR(50) NULL,
                        [deleted_source] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();


                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [syana_table] (
                        [syana_id] INT IDENTITY(1,1) NOT NULL,
                        [syana_no] INT NOT NULL,
                        [syana_cst_name] VARCHAR(150) NULL,
                        [syana_cst_phone] VARCHAR(50) NULL,
                        [syana_address] VARCHAR(150) NULL,
                        [syana_recieve_date] DATE NULL,
                        [syana_deliver_date] DATE NULL,
                        [syana_device_type] VARCHAR(150) NULL,
                        [syana_problem] VARCHAR(150) NULL,
                        [syana_mol7kat] VARCHAR(150) NULL,
                        [syana_ket3_gheiar] VARCHAR(100) NULL,
                        [syana_ket3_gheiar_cost] DECIMAL(18,2) NULL,
                        [syana_cost] DECIMAL(18,2) NULL,
                        [syana_total_cost] AS ([syana_cost] + [syana_ket3_gheiar_cost]),
                        [syana_paid] DECIMAL(18,2) NULL,
                        [syana_ba2y] AS (([syana_cost] + [syana_ket3_gheiar_cost]) - [syana_paid]),
                        [syana_notes] VARCHAR(150) NULL,
                        [syana_status] VARCHAR(50) NULL,
                        [syana_user] VARCHAR(100) NULL,
                        [syana_far3] VARCHAR(50) NULL,
                        [syana_usert_delivered] VARCHAR(100) NULL,
                        [syana_type] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();



                try
                {

                    cmd = new SqlCommand(@"
                    CREATE TABLE [syana_ket3_gheiar] (
                        [syana_no] INT NOT NULL,
                        [syana_ket3_gheiar] VARCHAR(100) NULL,
                        [syana_ket3_gheiar_cost] DECIMAL(18,2) NULL,
                        [syana_ket3_gheiar_count] DECIMAL(18,2) NULL,
                        [syana_ket3_gheiar_user] VARCHAR(50) NULL,
                        [syana_ket3_gheiar_far3] VARCHAR(50) NULL,
                        [syana_ket3_gheiar_int_code] VARCHAR(50) NULL
                    )", c);


                    c.Open();
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("added");
                    c.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                c.Close();



                
                
            }
            catch { }
            


        }

        private void check_files()
        {

            try
            {
            // Check if file already exists. If yes, delete it.     
            if (Directory.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic"))
            {
                // MessageBox.Show("exist");
            }
            else
            {
                Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pic");

            }
            }
            catch
            { }

            try
            {
            // Check if file already exists. If yes, delete it.     
            if (Directory.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\files"))
            {
                // MessageBox.Show("exist");
            }
            else
            {
                Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\files");

            }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tk_active"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tk_active"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\day_end"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\day_end"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("02:00 ص");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_default"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_default"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("فاتورة عادية");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup_path"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup_path"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(@"D:\");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\lang"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\lang"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("en");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\last_fatora_type"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\last_fatora_type"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("قطاعي");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\1tim"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\1tim"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

           
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\auto_print"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\auto_print"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }
           
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gomla.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("ex");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("1433");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }



            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\page_size.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\page_size.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("apm");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\l"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\l"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\shorts.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\shorts.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("اختصارات متغيرة");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("my_data");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try 
            {
                string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\apm_qr.txt";
                File.WriteAllText(fileName, String.Empty);
                FileStream stream = null;


                //string back_color_name_new = 
                // sr.WriteLine(cd.Color.Name);

                stream = new FileStream(fileName, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                        writer.Write("no");
                }
            }
            catch { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\after_buy.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\after_buy.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\avg_or_new.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\avg_or_new.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("اخر سعر");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cst_qr_txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\cst_qr_txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }



            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\decimals"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }



            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("عادي");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("عادي");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\dates_ed.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\dates_ed.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }



            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ape"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ape"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\price.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("عادي");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\logo_name.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\logo_name.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("الشعار");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mortaga3_type.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mortaga3_type.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("باسم العميل");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_bc.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return_purchases.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return_purchases.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("1");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\return.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("1");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\apm_qr.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\apm_qr.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\main_printer.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\main_printer.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("فواتيـــــر");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_fwateer.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(" ");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }



            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(" ");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes(" ");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ezn_type.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("الفئة");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tax.txt"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tax.txt"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("no");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pieces_param"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\pieces_param"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\matloob_param"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\matloob_param"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\safy_param"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\safy_param"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }


            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mosadad_param"))
                {
                    // MessageBox.Show("exist");
                }
                else
                {
                    //  File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\barcode_type.txt");
                    using (FileStream fs = File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\mosadad_param"))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("yes");
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch
            { }

        }

        private void check_windows_version()
        {
            //try
            //{
            //if (Environment.Is64BitOperatingSystem == true)
            //{
            //   // MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\x64\\" + "X Manage.exe");
            //    Process.Start(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\x64\\" + "X Manage.exe");

            //}
            //else
            //{
            //    Process.Start(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\x32\\" + "X Manage.exe");
            //}
            //}
            //catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }


        public static bool IsInternetAvailable()
    {
        try
        {
            using (var ping = new Ping())
            {
                // Ping a reliable and fast remote server, such as Google's DNS server
                PingReply reply = ping.Send("8.8.8.8", 2000); // Timeout set to 2000 milliseconds

                return (reply != null && reply.Status == IPStatus.Success);
            }
        }
        catch (PingException)
        {
            return false;
        }
    }

        public static void UpdateDateTimeFromInternet()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;

            process.Start();

            // Run w32tm command to update the date and time from an internet-based time server
            string command = "w32tm /resync /nowait";
            process.StandardInput.WriteLine(command);
            process.StandardInput.Flush();
            process.StandardInput.Close();

            process.WaitForExit();
            //MessageBox.Show("aa");
        }

        public static string GetIPAddress()
        {
            string ipAddress = string.Empty;

            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                // Consider only operational network interfaces
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    foreach (UnicastIPAddressInformation ipInfo in ipProperties.UnicastAddresses)
                    {
                        // Check for IPv4 addresses and exclude loopback and link-local addresses
                        if (ipInfo.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork &&
                            !IPAddress.IsLoopback(ipInfo.Address) &&
                            !ipInfo.Address.IsIPv6LinkLocal)
                        {
                            ipAddress = ipInfo.Address.ToString();
                            break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(ipAddress))
                    break;
            }

            return ipAddress;
        }


        private const int WM_INPUTLANGCHANGEREQUEST = 0x50;
        private static IntPtr HWND_BROADCAST = new IntPtr(0xFFFF);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public static void SetKeyboardLanguage(string lang)
        {
            InputLanguage arabicLang = InputLanguage.InstalledInputLanguages
                .Cast<InputLanguage>()
                .FirstOrDefault(l => l.Culture.TwoLetterISOLanguageName == "ar");

            InputLanguage englishLang = InputLanguage.InstalledInputLanguages
                .Cast<InputLanguage>()
                .FirstOrDefault(l => l.Culture.TwoLetterISOLanguageName == "en");

            IntPtr newLanguage = IntPtr.Zero;

            if (lang == "ar" && arabicLang != null)
            {
                newLanguage = arabicLang.Handle;
            }
            else if (englishLang != null)
            {
                newLanguage = englishLang.Handle;
            }

            if (newLanguage != IntPtr.Zero)
            {
                SendMessage(HWND_BROADCAST, WM_INPUTLANGCHANGEREQUEST, IntPtr.Zero, newLanguage);
            }
            else
            {
                MessageBox.Show("Language not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void Form2_Load(object sender, EventArgs e)
        {


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
            if (un != "") 
            {
                string ipAddress = GetIPAddress();
                if (ip == ipAddress ||ip==".")
                {

                }
                else if(ipAddress=="") 
                {
                    MessageBox.Show("تأكد من اتصال الشبكة");
                    Application.Exit();
                }

            }


          
         
            backgroundWorker1.RunWorkerAsync();
    
            
            //  check_windows_version();

            //GetLocalIPAddress();

            // check_pc();
            encrypt();
            check_server();

            check_files();

            string filePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lang");
            string lang = File.ReadLines(filePath).First().Trim();

          //  MessageBox.Show("Language Read: " + lang, "Debug"); // Debugging

            SetKeyboardLanguage(lang);

            check_db_tables();



            if (comboBox1.Text == "")
            {
                comboBox1.Text = "admin";

            }

            comboBox1.Select();

            try
            {

                this.user_previligesTableAdapter3.Fill(this.dataSet11.user_previliges);
                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {
                    if (comboBox1.Items.Contains(dr["user_name"].ToString()))
                    {
                    }
                    else
                    {
                        comboBox1.Items.Add(dr["user_name"].ToString());

                        try
                        {
                            comboBox1.Text = comboBox1.Items[0].ToString();
                        }
                        catch { }

                        comboBox1.Select();
                    }
                }


                //  intro();

                comboBox1.SelectAll();
                comboBox1.Focus();
            }
            catch
            {
                restart_server();
            }

            //button5.ForeColor = Color.White;
            //button6.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "admin")
                {

                    user_previligesTableAdapter3.Fill(this.dataSet11.user_previliges);

                    foreach (DataRow dr in dataSet11.user_previliges.Rows)
                    {

                    }
                    user_previligesTableAdapter3.FillBy_name(dataSet11.user_previliges, comboBox1.Text);

                    if (textBox1.Text == Convert.ToString(dataSet11.user_previliges.Rows[0]["password"]))// && textBox3.Text == "aassdd")
                    {

                        Form1 F1 = new Form1();

                        this.Hide();
                        F1.usertxt.Text = comboBox1.Text;
                        //F1.permissiontxt.Text = dataSet11.users.Rows[0]["user_permission"].ToString();
                        F1.Show();


                    }
                    else
                    {
                        MessageBox.Show("تأكد من الاسم وكلمة السر");
                        textBox1.SelectAll();
                        textBox1.Focus();
                    }
                }
                else
                {
                    if (textBox1.Text == "xmanage")
                    {
                        Form1 F1 = new Form1();
                        this.Hide();
                        F1.usertxt.Text = comboBox1.Text;
                        //F1.permissiontxt.Text = dataSet11.users.Rows[0]["user_permission"].ToString();
                        F1.Show();
                    }
                }
            }
            catch { }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Focus();
        }


        private void boardserial()
        {
            try
            {
                ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_BaseBoard");
                foreach (ManagementObject getserial in MOS.Get())
                {
                    board_n = getserial["SerialNumber"].ToString();
                }
            }
            catch
            {
                board_n = "";
            }

        }


        string sdf;
        string HDD_Serial;


        private void CPU_ID()
        {

            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            cpu_n = cpuInfo;
        }

        string board_n;
        string cpu_n;



        static string Encrypt_static(string text)
        {
            try
            {

                string textToEncrypt = text;
                string ToReturn = "";
                string publickey = "joodhoor";
                string secretkey = "aelkholy";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {

                //  MessageBox.Show(ex.Message);
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        private void encrypt()
        {
            try
            {
                boardserial();
                string encrypted_board = Encrypt_static(board_n);
                StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\b");
                string b_txt = sr.ReadLine();
                sr.Close();
                CPU_ID();
                string encrypted_cpu = Encrypt_static(cpu_n);
                sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\c");
                string c_txt = sr.ReadLine();
                // MessageBox.Show(c_txt);
                if (b_txt != encrypted_board || c_txt != encrypted_cpu)
                {
                  //  timer1.Stop();
                    MessageBox.Show("You are not licensed to use this application . please contact us at +(2)01015065484", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("https://www.facebook.com/a7medelkholy");


                    Application.Exit();
                }


            }
            catch
            {

             //   timer1.Stop();
                MessageBox.Show("something Wrong Contact Us");
                Application.Exit();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool isInternetAvailable = IsInternetAvailable();

            if (isInternetAvailable)
            {
                UpdateDateTimeFromInternet();
            }
            else
            {
                //  MessageBox.Show("No internet connection.");
            }
        }


    }
}
