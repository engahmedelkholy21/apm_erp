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

using System.IO.Compression;

//using Spire.Email;
//using Spire.Email.IMap;
//using Spire.Email.Smtp;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;

using System.Globalization;
using Microsoft.Win32;
using System.ServiceProcess;
using System.Reflection;

using System.Threading.Tasks;



using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Upload;
using Google.Apis.Util.Store;

namespace pharma_manage
{
    public partial class Form1 : Form
    {   private ServiceController sqlServiceController;


        public Form1()
        {
            InitializeComponent();
            // Set the service name for the SQL Server service
            string sqlServiceName = "MSSQL$SQLEXPRESS"; // Change this to your SQL Server service name
            sqlServiceController = new ServiceController(sqlServiceName);

            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;


          colors();

            SubscribeToLoadEvent(this);
            ApplyFormStyling(this);

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Visible = false;

        }


        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
            {
                if (e.Mode == PowerModes.Resume)
                {
                    CheckAndRestartSqlService();
                }
            }

        private void CheckAndRestartSqlService()
        {
            Task.Run(() =>
            {
                try
                {
                    if (sqlServiceController.Status == ServiceControllerStatus.Stopped)
                    {
                        sqlServiceController.Start();
                        sqlServiceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));

                        this.Invoke(new Action(() =>
                            MessageBox.Show("SQL Server service has been restarted.")));
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                        MessageBox.Show("Error restarting SQL Server service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                }
            });
        }
       

        private void ادخالفئةجديدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_category ac = new add_category();
            ac.Text = "ادخال فئة جديدة";
            ac.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(ac);
            ApplyFormStyling(ac);
            ac.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_list p = new product_list();
            p.Text = "قائمة الاصناف";
            p.far3_txt.Text = far3txt.Text;
            p.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تعديلصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_product ep = new edit_product();
            ep.Text = "تعديل صنف";
            ep.usertxt.Text = usertxt.Text;
            ep.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(ep);
            ApplyFormStyling(ep);
            ep.Show();            Control_Clicks_for_label(sender, e);
        }

        private void النواقصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nwa2s n = new nwa2s();
            n.Text = "قائمة النواقص";
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            int i = 0;
            //MessageBox.Show("جرب من بره البرنامج");
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {

                try
                {
                    if (Convert.ToDecimal(dr["pro_count"]) <= Convert.ToDecimal(dr["pro_limit"]))
                    {

                        i += 1;
                        // MessageBox.Show(i.ToString());
                        n.dataGridView1.Rows.Add(i.ToString(), dr["pro_ID"].ToString(), dr["pro_name"].ToString(), dr["pro_category"].ToString(), Convert.ToDecimal(dr["pro_count"]), 0,null,Convert.ToDecimal(dr["pro_cost_price"]));
                        //  nwa2es_tableTableAdapter1.Insert_nwa2es(dr["pro_id_company"].ToString(), dr["pro_name"].ToString(), Convert.ToDecimal(dr["pro_count"]), 0);
                    }
                }
                catch { }
                
            }

            SubscribeToLoadEvent(n);
            ApplyFormStyling(n);
            n.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تعديلفئةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_category ec = new edit_category();
            ec.Text = "تعديل فئة";
            ec.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(ec);
            ApplyFormStyling(ec);
            ec.Show();            Control_Clicks_for_label(sender, e);
           
        }

        private void فئاتالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category_list c = new category_list();
            c.Text = "فئات الاصناف";
            c.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(c);
            ApplyFormStyling(c);
            c.Show();            Control_Clicks_for_label(sender, e);
        }



        protected void btn_click(object sender, EventArgs e, Form f)
        {
            if (f.Text.Contains("فاتورة شراء") || f.Text.Contains("فاتورة بيع"))
            {
                DialogResult re = MessageBox.Show(" هل تريد اغلاق الفاتورة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    f.Close();
                }
            }
            else if (f.Text == this.Text)
            {
                DialogResult re = MessageBox.Show(" هل تريد اغلاق البرنامج نهائيا؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    f.Close();
                }
            }
            else
            {
                f.Close();
            }
        }

        public void SubscribeToLoadEvent(Form form)
        {
            form.Load += Form_Load;

            // Optionally, you can also subscribe to other events like button click if needed

            Button btn_test = new Button();
            btn_test.Click += (s, e) => btn_click(s, e, form);

            form.CancelButton = btn_test;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            Form currentForm = sender as Form;
            if (currentForm != null)
            {
                ApplyFormStyling(currentForm);
            }
        }

        public void ApplyFormStyling(Form f)
        {
            f.BackColor = bc_color;
            //Image myimage = new Bitmap(Application.ExecutablePath+"\\mot.gif");

            //f.BackgroundImage = myimage;
            f.Icon = Properties.Resources.icon;
            f.KeyPreview = true;

            //Button btn_test = new Button();
            //btn_test.Click += new EventHandler(delegate(object ss, EventArgs ee) { btn_click(sender, e, f); });
            //f.CancelButton = btn_test;

            foreach (Button b in f.Controls.OfType<Button>())
            {
                // MessageBox.Show(b.Text);
                b.Cursor = Cursors.Hand;

            }

            foreach (DateTimePicker b in f.Controls.OfType<DateTimePicker>())
            {
                b.RightToLeft = RightToLeft.Yes;
                b.RightToLeftLayout = true; 
                if (f.Name != "add_employee" && f.Name != "settings_form")
                {
                    b.Format = DateTimePickerFormat.Short;
                    //b.CustomFormat = "yyyy/MM/dd";
                }
            }
            foreach (System.Windows.Forms.Label b in f.Controls.OfType<System.Windows.Forms.Label>())
            {
                if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
                { }
                else
                {
                    if (dataSet11.stock_table.Rows.Count <= 1)
                    {
                        if (b.Text.Contains("مخزن") || b.Text.Contains("فرع"))
                        {
                            b.Visible = false;
                        }
                    }
                }
                b.ForeColor = label_clr;
                b.BackColor = bc_color;
                // b.BackColor = ccolor;
            }


            foreach (ComboBox b in f.Controls.OfType<ComboBox>())
            {
                if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
                { }
                else
                {
                    if (dataSet11.stock_table.Rows.Count <= 1)
                    {
                        if (b.Name.Contains("stock") || b.Name.Contains("far3_txt"))
                        {
                            b.Visible = false;
                        }
                    }
                }
            }

            foreach (DataGridView bb in f.Controls.OfType<DataGridView>())
            {

                bb.ForeColor = dgv_fore_clr;
                bb.BackColor = Color.White;

                foreach (DataGridViewColumn column in bb.Columns)
                {
                    if (column.ValueType == typeof(DateTime))
                    {
                        column.DefaultCellStyle.Format = "yyyy/MM/dd"; // Custom date format
                    }
                }

                bb.RightToLeft = RightToLeft.Yes; // Right-to-left layout

            }

            foreach (GroupBox g in f.Controls.OfType<GroupBox>())
            {
                g.BackColor = bc_color;
                g.ForeColor = label_clr;
                foreach (Button b in g.Controls.OfType<Button>())
                {
                    b.Cursor = Cursors.Hand;
                }

                foreach (DateTimePicker b in g.Controls.OfType<DateTimePicker>())
                {
                    b.RightToLeft = RightToLeft.Yes;
                    b.RightToLeftLayout = true;
                   if (f.Name != "add_employee" && f.Name != "settings_form")
                    {
                        b.Format = DateTimePickerFormat.Short;
                        //b.CustomFormat = "yyyy/MM/dd";
                    }
                }

                foreach (DataGridView bb in g.Controls.OfType<DataGridView>())
                {
                    bb.ForeColor = dgv_fore_clr;
                    bb.BackColor = Color.White;

                    foreach (DataGridViewColumn column in bb.Columns)
                    {
                        if (column.ValueType == typeof(DateTime))
                        {
                            column.DefaultCellStyle.Format = "yyyy/MM/dd"; // Custom date format
                        }
                    }

                    bb.RightToLeft = RightToLeft.Yes; // Right-to-left layout
                }


                foreach (System.Windows.Forms.Label b in g.Controls.OfType<System.Windows.Forms.Label>())
                {

                    if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
                    { }
                    else
                    {
                        if (dataSet11.stock_table.Rows.Count <= 1)
                        {
                            if (b.Text.Contains("مخزن") || b.Text.Contains("فرع"))
                            {
                                b.Visible = false;
                            }
                        }
                    }
                    b.ForeColor = label_clr;
                    b.BackColor = bc_color;
                    // b.BackColor = ccolor;
                }
                foreach (GroupBox group in g.Controls.OfType<GroupBox>())
                {
                    foreach (DataGridView bb in group.Controls.OfType<DataGridView>())
                    {

                        bb.ForeColor = dgv_fore_clr;
                        bb.BackColor = Color.White;

                        foreach (DataGridViewColumn column in bb.Columns)
                        {
                            if (column.ValueType == typeof(DateTime))
                            {
                                column.DefaultCellStyle.Format = "yyyy/MM/dd"; // Custom date format
                            }
                        }

                        bb.RightToLeft = RightToLeft.Yes; // Right-to-left layout

                    }
                }

                if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
                { }

                else
                {
                    foreach (ComboBox b in g.Controls.OfType<ComboBox>())
                    {
                        if (dataSet11.stock_table.Rows.Count <= 1)
                        {
                            if (b.Name.Contains("stock") || b.Name.Contains("far3_txt"))
                            {
                                b.Visible = false;
                            }
                        }
                    }
                }


            }
        }
       // Color ccolor = Color.FromArgb(10, 25, 70);
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (CultureInfo.CurrentCulture.Calendar.ToString() == "System.Globalization.HijriCalendar")
            //{
            //    if (DateTime.Today > Convert.ToDateTime("20/11/1441"))
            //    {
            //        Application.Restart();
            //    }
            //}
            //else if (CultureInfo.CurrentCulture.Calendar.ToString() == "System.Globalization.UmAlQuraCalendar")
            //{
            //    if (DateTime.Today > Convert.ToDateTime("19/11/1441"))
            //    {

            //        Application.Restart();
            //    }
            //}
            //else
            //{

            //    if (DateTime.Now > Convert.ToDateTime("2025/02/18 10:25:15 AM"))
            //        Application.Restart();
            //}






            //try
            //{
            //    foreach (Form f in Application.OpenForms)
            //    {
            //        f.BackColor = bc_color;
            //        //Image myimage = new Bitmap(Application.ExecutablePath+"\\mot.gif");

            //        //f.BackgroundImage = myimage;
            //        f.Icon = Properties.Resources.icon;
            //        f.KeyPreview = true;

            //        Button btn_test = new Button();
            //        btn_test.Click += new EventHandler(delegate(object ss, EventArgs ee) { btn_click(sender, e, f); });
            //        f.CancelButton = btn_test;

            //        foreach (Button b in f.Controls.OfType<Button>())
            //        {
            //            // MessageBox.Show(b.Text);
            //            b.Cursor = Cursors.Hand;

            //        }

            //        foreach (DateTimePicker b in f.Controls.OfType<DateTimePicker>())
            //        {
            //            b.RightToLeft = RightToLeft.Yes;
            //            b.RightToLeftLayout = true; if (f.Name != "add_employee")
            //            {
            //                b.Format = DateTimePickerFormat.Short;
            //                //b.CustomFormat = "yyyy/MM/dd";
            //            }
            //        }
            //        foreach (Label b in f.Controls.OfType<Label>())
            //        {
            //            if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
            //            { }
            //            else
            //            {
            //                if (dataSet11.stock_table.Rows.Count <= 1)
            //                {
            //                    if (b.Text.Contains("مخزن") || b.Text.Contains("فرع"))
            //                    {
            //                        b.Visible = false;
            //                    }
            //                }
            //            }
            //            b.ForeColor = label_clr;
            //            b.BackColor = bc_color;
            //            // b.BackColor = ccolor;
            //        }


            //        foreach (ComboBox b in f.Controls.OfType<ComboBox>())
            //        {
            //            if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
            //            { }
            //            else
            //            {
            //                if (dataSet11.stock_table.Rows.Count <= 1)
            //                {
            //                    if (b.Name.Contains("stock") || b.Name.Contains("far3_txt"))
            //                    {
            //                        b.Visible = false;
            //                    }
            //                }
            //            }
            //        }

            //        foreach (DataGridView bb in f.Controls.OfType<DataGridView>())
            //        {

            //            bb.ForeColor = dgv_fore_clr;
            //            bb.BackColor = Color.White;

            //            foreach (DataGridViewColumn column in bb.Columns)
            //            {
            //                if (column.ValueType == typeof(DateTime))
            //                {
            //                    column.DefaultCellStyle.Format = "yyyy/MM/dd"; // Custom date format
            //                }
            //            }

            //            bb.RightToLeft = RightToLeft.Yes; // Right-to-left layout

            //        }

            //        foreach (GroupBox g in f.Controls.OfType<GroupBox>())
            //        {
            //            g.BackColor = bc_color;
            //            g.ForeColor = label_clr;
            //            foreach (Button b in g.Controls.OfType<Button>())
            //            {
            //                b.Cursor = Cursors.Hand;
            //            }

            //            foreach (DateTimePicker b in g.Controls.OfType<DateTimePicker>())
            //            {
            //                b.RightToLeft = RightToLeft.Yes;
            //                b.RightToLeftLayout = true;
            //                if (f.Name != "add_employee")
            //                {
            //                    b.Format = DateTimePickerFormat.Short;
            //                    //b.CustomFormat = "yyyy/MM/dd";
            //                }
            //            }

            //            foreach (DataGridView bb in g.Controls.OfType<DataGridView>())
            //            {
            //                bb.ForeColor = dgv_fore_clr;
            //                bb.BackColor = Color.White;

            //                foreach (DataGridViewColumn column in bb.Columns)
            //                {
            //                    if (column.ValueType == typeof(DateTime))
            //                    {
            //                        column.DefaultCellStyle.Format = "yyyy/MM/dd"; // Custom date format
            //                    }
            //                }

            //                bb.RightToLeft = RightToLeft.Yes; // Right-to-left layout
            //            }


            //            foreach (Label b in g.Controls.OfType<Label>())
            //            {

            //                if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
            //                { }
            //                else
            //                {
            //                    if (dataSet11.stock_table.Rows.Count <= 1)
            //                    {
            //                        if (b.Text.Contains("مخزن") || b.Text.Contains("فرع"))
            //                        {
            //                            b.Visible = false;
            //                        }
            //                    }
            //                }
            //                b.ForeColor = label_clr;
            //                b.BackColor = bc_color;
            //                // b.BackColor = ccolor;
            //            }
            //            foreach (GroupBox group in g.Controls.OfType<GroupBox>())
            //            {
            //                foreach (DataGridView bb in group.Controls.OfType<DataGridView>())
            //                {

            //                    bb.ForeColor = dgv_fore_clr;
            //                    bb.BackColor = Color.White;

            //                    foreach (DataGridViewColumn column in bb.Columns)
            //                    {
            //                        if (column.ValueType == typeof(DateTime))
            //                        {
            //                            column.DefaultCellStyle.Format = "yyyy/MM/dd"; // Custom date format
            //                        }
            //                    }

            //                    bb.RightToLeft = RightToLeft.Yes; // Right-to-left layout

            //                }
            //            }

            //            if (f.Name == "add_product" || f.Name == "edit_product" || f.Name == "add_user" || f.Name == "ta7weel" || f.Name == "ta7weelat_show")
            //            { }

            //            else
            //            {
            //                foreach (ComboBox b in g.Controls.OfType<ComboBox>())
            //                {
            //                    if (dataSet11.stock_table.Rows.Count <= 1)
            //                    {
            //                        if (b.Name.Contains("stock") || b.Name.Contains("far3_txt"))
            //                        {
            //                            b.Visible = false;
            //                        }
            //                    }
            //                }
            //            }


            //        }



            //    }
            //}
            //catch { }

            
        }

        private void فاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bee3_type_txt = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt").First();
            if (bee3_type_txt == "نسبة")
            {
                sell_nesba s = new sell_nesba();
                s.Text = "فاتورة بيع";
                s.far3txt.Text = far3txt.Text;
                // s.fatora_type.Text = "جمله";
                s.usertxt.Text = usertxt.Text;
                //foreach (var item in category_list.Items) 
                //{
                //    s.category_list.Items.Add(item.ToString());
                //}

                SubscribeToLoadEvent(s);
                ApplyFormStyling(s);
                s.Show();            Control_Clicks_for_label(sender, e);
            }
            else
            {
                sell s = new sell();
                s.Text = "فاتورة بيع";
                s.far3txt.Text = far3txt.Text;
                // s.fatora_type.Text = "جمله";
                s.usertxt.Text = usertxt.Text;
                //foreach (var item in category_list.Items) 
                //{
                //    s.category_list.Items.Add(item.ToString());
                //}

                SubscribeToLoadEvent(s);
                ApplyFormStyling(s);
                s.Show();            Control_Clicks_for_label(sender, e);
            }

            Control_Clicks_for_label(sender, e);
        }

        private void pحركةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products_moves pl = new products_moves();
            pl.Text = "حركة الاصناف";
            pl.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(pl);
            ApplyFormStyling(pl);
            pl.Show();            Control_Clicks_for_label(sender, e);
        }

        private void الارباحToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void عرضالارباحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arba7 a = new arba7();
            a.Text = "إدارة الأرباح";
            a.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.Show();            Control_Clicks_for_label(sender, e);
        }

        private void الواردللخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            income i = new income();
            i.Text = "إدارة الوارد للخزينة";
            i.far3_txt.Text = far3txt.Text;
            i.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(i);
            ApplyFormStyling(i);
            i.Show();            Control_Clicks_for_label(sender, e);
        }

        private void حالةالخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ras_mal_method();
            safe_status s = new safe_status();
            s.Text = "حالة الخزينة";
            s.usertxt.Text = usertxt.Text;
           // s.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void الصادرمنالخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            outcome o = new outcome();
            o.far3_txt.Text = far3txt.Text;
            o.Text = "إدارة الصادر من الخزينة";
            o.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(o);
            ApplyFormStyling(o);
            o.Show();            Control_Clicks_for_label(sender, e);
        }

        private void إضافةمبلغللخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_to_income ai = new add_to_income();
            ai.Text = "إضافة مبلغ للخزينة";
            ai.far3txt.Text = far3txt.Text;
            ai.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(ai);
            ApplyFormStyling(ai);
            ai.Show();            Control_Clicks_for_label(sender, e);
        }

        private void صرفمبلغمنالخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sarf_from_outcome s = new sarf_from_outcome();
            s.Text = "صرف مبلغ من الخزينة";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void إضافةمدينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_madeen m = new add_madeen();
            m.Text = "إضافة مدين سابق";
            m.usertxt.Text = usertxt.Text;
            m.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالمدينينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            madeen m = new madeen();
            m.Text = "جميع المدينين";
            m.far3txt.Text = far3txt.Text;
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تفاصيلمدينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mosta7kat_show md = new mosta7kat_show();

            md.usertxt.Text = usertxt.Text;
            md.Text = "تفاصيل حساب مدين";
            // md.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(md);
            ApplyFormStyling(md);
            md.Show();            Control_Clicks_for_label(sender, e);
        }

        private void إضافةدائنسابقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_da2n m = new add_da2n();
            m.Text = "إضافة دائن سابق";
            m.far3txt.Text = far3txt.Text;
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تفاصيلدائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            da2n_details m = new da2n_details();
            m.Text = "تفاصيل حساب دائن";
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالدائنينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            da2n m = new da2n();
            m.Text = "جميع الدائنين";
            m.far3txt.Text = far3txt.Text;
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void buttons_colors() 
        {
            foreach (FlowLayoutPanel f in this.Controls.OfType <FlowLayoutPanel>())
            {
                foreach (ePOSOne.btnProduct.Button_WOC b in f.Controls.OfType<ePOSOne.btnProduct.Button_WOC>())
                {
                    //MessageBox.Show(b.Text);
                    // b.Cursor = Cursors.Hand;
                    b.ButtonColor = b.BackColor;
                    b.BackColor = Color.Transparent;
                    
                    b.OnHoverBorderColor = Color.Transparent;
                    b.OnHoverButtonColor = Color.White;
                    b.OnHoverTextColor = Color.Black;
                    b.FlatAppearance.BorderSize = 0;
                  //  b.BorderColor = System.Drawing.Color.Transparent;


                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                  
                    b.UseVisualStyleBackColor = true;
                }
            }
        }

        //private void check_pro_codes() 
        //{
        //    ListBox l = new ListBox();
        //    products_tableTableAdapter1.Fill(dataSet11.products_table);
        //    foreach (DataRow dr in dataSet11.products_table.Rows)
        //    {
        //        if (l.Items.Contains(dr["pro_name"].ToString()))
        //        {
        //        }
        //        else
        //        {
        //            l.Items.Contains(dr["pro_name"].ToString());
        //        }

        //    }

        //    foreach (var pro_name in l.Items) 
        //    {
        //        products_tableTableAdapter1.FillBy_name(dataSet11.products_table,pro_name.ToString());
        //        string int_code=dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
        //        foreach(DataRow dr in dataSet11.products_table.Rows)
        //        {
        //            int pro_id = Convert.ToInt32(dr["pro_ID"]);
        //            products_tableTableAdapter1.Update_int_barcode_by_id(int_code, pro_id);
        //        }
        //    }
        //}

        Color bc_color;
        Color dgv_fore_clr;
        Color label_clr;

        private void colors() 
        {
            StreamReader sr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\back_color");
            string back_color_name = sr.ReadLine();
            var splitString = back_color_name.Split(',');
            var splitInts = splitString.Select(item => int.Parse(item)).ToArray();

            //takes each element of the array of 3 and passes it in to the correct slot
             bc_color = System.Drawing.Color.FromArgb(splitInts[0], splitInts[1], splitInts[2]);


             StreamReader srrr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\dgv_forecolor");
             string dgv_forecolor_name = srrr.ReadLine();
             var splitString2 = dgv_forecolor_name.Split(',');
            var splitInts2 = splitString2.Select(item => int.Parse(item)).ToArray();

            //takes each element of the array of 3 and passes it in to the correct slot
             dgv_fore_clr = System.Drawing.Color.FromArgb(splitInts2[0], splitInts2[1], splitInts2[2]);


            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + "\\label_color");
            string label_color_name = srr.ReadLine();

            var splitString1 = label_color_name.Split(',');
            var splitInts1 = splitString1.Select(item => int.Parse(item)).ToArray();

            //takes each element of the array of 3 and passes it in to the correct slot
             label_clr = System.Drawing.Color.FromArgb(splitInts1[0], splitInts1[1], splitInts1[2]);
            



           
        }

        private void reb7_old()
        {
            string date_from_txt = "01/05/2023";

            DateTime date_from = DateTime.ParseExact(date_from_txt, "dd/MM/yyyy", null);

            ListBox _ids = new ListBox();
            DateTime date_to=new DateTime(2023,07,27);
            sales_tableTableAdapter1.FillBy_Fatra(dataSet11.sales_table,date_from.ToShortDateString(), date_to.ToShortDateString(), far3txt.Text);

           // sales_tableTableAdapter1.Fill(dataSet11.sales_table);
           // MessageBox.Show("cc"+ dataSet11.sales_table.Rows.Count.ToString());
            foreach (DataRow dr in dataSet11.sales_table.Rows)
            {
                if (_ids.Items.Contains(dr["sales_id"].ToString()))
                {

                }
                else
                {
                    _ids.Items.Add(dr["sales_id"].ToString());
                }
            }

            //MessageBox.Show(_ids.Items.Count.ToString());
            foreach (var item in _ids.Items)
            {
               
                   // MessageBox.Show("start "+item.ToString());

                    decimal total_taklefa = 0;
                    decimal total_price_for_sell = 0;
                    decimal profit = 0;
                    decimal total_price = 0;
                    sales_tableTableAdapter1.FillBy_ID_stock(dataSet11.sales_table, Convert.ToInt32(item),far3txt.Text);
                    foreach (DataRow dr in dataSet11.sales_table.Rows)
                    {
                        //try
                        //{
                           
                            // purchases_tableTableAdapter1.FillBy_pro_id_fatra(dataSet11.Purchases_table, dr["sales_product_ID"].ToString(), Convert.ToDateTime("1/1/2000").ToShortDateString(), Convert.ToDateTime(dr["sales_date"]).ToShortDateString(),far3txt.Text);
                            //if (dataSet11.Purchases_table.Rows.Count <= 0)
                            //{
                            //    purchases_tableTableAdapter1.FillBy_pro_name_fatra(dataSet11.Purchases_table, dr["sales_product_name"].ToString(), Convert.ToDateTime("1/1/2000").ToShortDateString(), Convert.ToDateTime(dr["sales_date"]).ToShortDateString(),far3txt.Text);

                            //}
                            //if (dataSet11.Purchases_table.Rows.Count > 0)
                            //{
                            //    total_taklefa += Convert.ToDecimal(dataSet11.Purchases_table.Rows[0]["Purchases_unit_price"]) * Convert.ToDecimal(dr["sales_product_count"].ToString());
                            //    total_price_for_sell += Convert.ToDecimal(dr["sales_price_for_sell"]);

                            //}
                            //else 
                            //{
                                try
                                {
                                    products_tableTableAdapter1.FillBy_int_code_and_far3(dataSet11.products_table, dr["sales_product_ID"].ToString(), dr["sales_pro_stock"].ToString());
                                    if (dataSet11.products_table.Rows.Count > 0)
                                    {
                                        total_taklefa += Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]) * Convert.ToDecimal(dr["sales_product_count"].ToString());
                                        total_price_for_sell += Convert.ToDecimal(dr["sales_price_for_sell"]);
                                    }
                                    else 
                                    {
                                        total_taklefa += Convert.ToDecimal(dr["sales_price_for_sell"]) - 5;
                                        total_price_for_sell += Convert.ToDecimal(dr["sales_price_for_sell"]);
                                        //continue;
                                    }
                                }
                                catch 
                                {
                                  
                                }
                          //  }
                            // decimal basic_profit = Convert.ToDecimal(dataSet11.products_table.Rows[0]["nesba_saydaly"]) * Convert.ToDecimal(dgr.Cells[3].Value);
                          //  MessageBox.Show(dataSet11.Purchases_table.Rows.Count.ToString());
                            
                            
                        //}
                        //catch (Exception ex)
                        //{
                           
                        //}
                    }

                
                     profit = total_price_for_sell - total_taklefa - Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_discount"]);

                     total_price = total_price_for_sell - Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_discount"]);


                     if (item.ToString() == "273")
                     {
                         MessageBox.Show("taklefa " + total_taklefa.ToString());
                         MessageBox.Show("total_price_for_sell " + total_price_for_sell.ToString());

                         MessageBox.Show("profit " + profit.ToString());

                         MessageBox.Show("total price " + total_price.ToString());
                     }


                    sales_tableTableAdapter1.Update_profit_by_sales_id(profit, Convert.ToInt32(item),far3txt.Text);


                    try
                    {
                        string arba7_details = "ربح فاتورة بيع رقم " + item.ToString();// +" بعد المرتجع";

                        arba7_tableTableAdapter1.Update_By_Fatora_id_AND_Source_AND_stock(dataSet11.sales_table.Rows[0]["sales_date"].ToString(), arba7_details, profit, usertxt.Text, total_price, total_taklefa, Convert.ToInt32(item.ToString()), "مبيعات",far3txt.Text);
                       //MessageBox.Show("end " + item.ToString());

                    }
                    catch { continue; }

                
            }

           // MessageBox.Show("done");
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.freq_table' table. You can move, or remove it, as needed.


          //  check_space_in_backup();

           // ادارةالانتاجToolStripMenuItem.Visible = false;

            //FormTranslator.LocalizeForm(this);
            //SubscribeToLoadEvent(this);
            //ApplyFormStyling(this);


        }

        public void upload_file_local(string file_name, string extension, DateTime date, string file_original_path, string user, string file_form, string notes, string warehouse_, string type)
        {
            if (file_original_path != "")
            {
               // MessageBox.Show("44444444444");
                string directoryPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "files");

                if (!Directory.Exists(directoryPath))
                {

                    try
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    catch { }
                }
                try
                {
                    string file_new_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\files\\" + file_name + "." + extension;
                    System.IO.File.Copy(file_original_path, file_new_path, true);
                    uploaded_files_tableTableAdapter1.Insert(file_name, extension, date, file_new_path, user, file_form, notes, warehouse_, type);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void user_prev_excute()
        {
            this.user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, usertxt.Text);
            if (dataSet11.user_previliges.Rows.Count > 0)
            {
                if (usertxt.Text != "admin")
                {
                    ListBox l = new ListBox();
                    foreach (DataRow dr in dataSet11.user_previliges.Rows)
                    {
                        l.Items.Add(dr["user_previliges"].ToString());
                    }

                    foreach (ToolStripMenuItem s in menuStrip1.Items)
                    {
                        foreach (ToolStripDropDownItem sub in s.DropDownItems)
                        {
                            if (l.Items.Contains(sub.Text))
                            {
                                //MessageBox.Show(sub.OwnerItem.Name.ToString());
                                sub.Visible = true;
                            }
                            else
                                sub.Visible = false;
                        }

                    }

                    foreach (ToolStripMenuItem s in menuStrip1.Items)
                    {
                        if (s.HasDropDownItems)
                        {
                            s.Visible = true;
                        }
                        else { s.Visible = false; }
                    }
                    foreach (var g in this.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (var c in g.Controls.OfType<Button>())
                        {
                            try
                            {
                                if (l.Items.Contains(c.Text))
                                {
                                    c.Visible = true;
                                }
                                else { c.Visible = false; }
                            }
                            catch { }
                        }
                    }
                    far3txt.Text = dataSet11.user_previliges.Rows[0]["user_far3"].ToString();

                    purchases_tableTableAdapter1.Update_stock_for_new(far3txt.Text);
                    arba7_tableTableAdapter1.Update_stock_for_new(far3txt.Text);
                    arba7_cat_tableTableAdapter1.Update_stock_for_new(far3txt.Text);
                    numbers_tableTableAdapter1.Update_stock_for_new(far3txt.Text);
                    ras_mal_productsTableAdapter1.Update_far3_if_null(far3txt.Text);

                    // }
                }


            }


            stock_tableTableAdapter1.Fill(dataSet11.stock_table);
            if (dataSet11.stock_table.Rows.Count == 1)
            {
                ادارةالتحويلاتToolStripMenuItem.Visible = false;
            }
            toolStripStatusLabel1.Text = "مرحبا بك  /  " + usertxt.Text;
            toolStripStatusLabel2.Text = "فرع  /  " + far3txt.Text;
            button17.Visible = true;

            تواصلمعناToolStripMenuItem.Visible = true;
            if (toolStripStatusLabel2.Text == "فرع  /  " + "far3txt") 
            {
                Application.Restart();
            }
        }
        public void refresh_categories()
        {
            try
            {
                category_list_items.Items.Clear();
                categoryTableAdapter1.Fill(dataSet11.Category);
                foreach (DataRow dr in dataSet11.Category.Rows)
                {
                    if (dr["Category_name"].ToString() != "خامات")
                    {
                        category_list_items.Items.Add(dr["Category_name"].ToString());
                    }
                }
            }
            catch { }
        }

        private void RefreshCategoriesAsync()
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    // Use a separate table to avoid cross-thread issues with the main dataset
                    DataSet1.CategoryDataTable temp = new DataSet1.CategoryDataTable();
                    categoryTableAdapter1.Fill(temp);

                    var names = new List<string>();
                    foreach (DataRow dr in temp.Rows)
                    {
                        if (dr["Category_name"].ToString() != "خامات")
                        {
                            names.Add(dr["Category_name"].ToString());
                        }
                    }

                    Action update = () =>
                    {
                        // Update main dataset
                        dataSet11.Category.Clear();
                        dataSet11.Category.Merge(temp);

                        category_list_items.Items.Clear();
                        foreach (string n in names)
                        {
                            category_list_items.Items.Add(n);
                        }
                    };

                    if (category_list_items.InvokeRequired)
                    {
                        category_list_items.BeginInvoke(update);
                    }
                    else
                    {
                        update();
                    }
                }
                catch
                {
                }
            });
        }
        public void ras_mal_method()
        {
            decimal sum_madeen = 0;
            decimal sum_products = 0;
            decimal sum_safe = 0;


            //madeenen
            try
            {
                madeen_small_reportTableAdapter1.FillBy_TOTAL_MADEEN(dataSet11.madeen_small_report);
               sum_madeen= Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["TOTAL_MADEEN"]);
                //for (int i = 0; i < dataSet11.madeen_small_report.Rows.Count; ++i)
                //{
                //    sum_madeen += Convert.ToDecimal(dataSet11.madeen_small_report.Rows[i]["madeen_small_ba2y"]);
                //}
            }
            catch { }


            ListBox list = new ListBox();
            stock_tableTableAdapter1.Fill(dataSet11.stock_table);
            foreach (DataRow dr in dataSet11.stock_table.Rows)
            {
                list.Items.Add(dr["stock_name"].ToString());
            }
            //products
            foreach (var item in list.Items)
            {
                sum_products = 0;
                try
                {
                    //stock_tableTableAdapter1.Fill(dataSet11.stock_table);
                    //foreach (DataRow dr in dataSet11.stock_table.Rows)
                    //{
                    this.products_tableTableAdapter1.FillBy_TOTAL_PRODUCTS_stock(this.dataSet11.products_table, item.ToString());
                    sum_products = Convert.ToDecimal(dataSet11.products_table.Rows[0]["TOTAL_PRODUCTS"]);
                   
                    //this.products_tableTableAdapter1.FillBy_stock(this.dataSet11.products_table, item.ToString());
                    //for (int i = 0; i < dataSet11.products_table.Rows.Count; ++i)
                    //{
                    //    decimal price = Convert.ToDecimal(dataSet11.products_table.Rows[i]["pro_count"]) * Convert.ToDecimal(dataSet11.products_table.Rows[i]["pro_cost_price"]);
                    //    sum_products += price;

                    //}
                    //}
                }
                catch { }

                //safe
                //safe_current
                //try
                //{
                //    this.safeTableAdapter1.Fill(this.dataSet11.safe);
                //    sum_safe = Convert.ToDecimal(dataSet11.safe.Rows[0]["safe_count"]);
                //}
                //catch { }
                try
                {
                    income_tableTableAdapter1.FillBy_income_total_by_far3(dataSet11.income_table, item.ToString());
                    decimal total_income = Convert.ToDecimal(dataSet11.income_table.Rows[0]["income_total"]);

                    outcome_tableTableAdapter1.FillBy_outcome_total_by_far3(dataSet11.outcome_table, item.ToString());
                    decimal total_outcome = Convert.ToDecimal(dataSet11.outcome_table.Rows[0]["outcome_total"]);

                    sum_safe = total_income - total_outcome;
                }
                catch { }

                ras_mal_productsTableAdapter1.FillBy_date_far3(dataSet11.ras_mal_products, DateTime.Today.ToShortDateString(), item.ToString());

                if (dataSet11.ras_mal_products.Rows.Count > 0)
                {
                    ras_mal_productsTableAdapter1.Update_by_date_and_far3(sum_products, sum_madeen, sum_safe, DateTime.Today.ToShortDateString(), item.ToString());
                }
                else
                {
                    ras_mal_productsTableAdapter1.Insert(Convert.ToDateTime(DateTime.Today.ToShortDateString()), sum_products, sum_madeen, sum_safe, item.ToString());
                }

              //  MessageBox.Show(sum_products.ToString);
            }
            //MessageBox.Show("ras mal updated");

            //MessageBox.Show("madeen " + sum_madeen.ToString() + "/ pro" + sum_products.ToString() + "/ safe " + sum_safe.ToString());

        }
        private void قائمةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales s = new sales();
            s.Text = "تقارير المبيعات";
            s.far3_txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);

        }

        private void فاتورةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string buy_type_txt = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt").First();
            if (buy_type_txt == "نسبة")
            {
                buy_nesba b = new buy_nesba();
                b.Text = "فاتورة شراء";
                b.stock_txt.Text = far3txt.Text;
                b.usertxt.Text = usertxt.Text;
                SubscribeToLoadEvent(b);
                ApplyFormStyling(b);
                b.Show();            Control_Clicks_for_label(sender, e);
            }
            else
            {

                buy b = new buy();
                b.Text = "فاتورة شراء";
                b.stock_txt.Text = far3txt.Text;
                b.usertxt.Text = usertxt.Text;
                SubscribeToLoadEvent(b);
                ApplyFormStyling(b);
                b.Show();            Control_Clicks_for_label(sender, e);
            }
        }

        private void قائمةالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchases s = new purchases();
            s.Text = "تقارير المشتريات";
            s.far3_txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Program.StopTimer();

            
            this.ras_mal_productsTableAdapter1.Fill(dataSet11.ras_mal_products);
            get_partition();

            ras_mal_method();

            try
            {
                string un = "";
                string pw = "";
                string ip = "";
                string db_name = "";
                string db_port = "";
                string db_v = "";

                try
                {
                    un = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                }
                catch
                {
                    un = "";
                }
                try
                {
                    pw = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                }
                catch
                {
                    pw = "";
                }
                try
                {
                    ip = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
                }
                catch
                {
                    ip = "";
                }
                try
                {
                    db_port = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port").First();
                }
                catch
                {
                    db_port = "";
                }
                try
                {
                    db_v = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v").First();
                }
                catch
                {
                    db_v = "";
                }
                try
                {
                    db_name = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();
                }
                catch
                {
                    db_name = "";
                }

                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup (*.Bak)|*.bak";

                SqlConnection c = new SqlConnection();
                if (db_v == "ex")
                {
                    if (un == "")
                    {
                        c.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

                        db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";

                    }
                    else
                    {
                        c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                        //    db_name = "my_data";

                    }
                }
                else
                {
                    c.ConnectionString = @"Data Source=" + ip + "," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                    // db_name = "my_data";
                    // MessageBox.Show(c.ConnectionString);
                }

                // MessageBox.Show(backup_partition);

                Directory.CreateDirectory(backup_partition + @"\backup\" + DateTime.Today.Year.ToString() + "\\" + DateTime.Today.Month.ToString() + "\\" + DateTime.Today.Day.ToString() + "\\");

                string bb = backup_partition + @"\backup\" + DateTime.Today.Month.ToString();

                string backupname = backup_partition + @"\backup\" + DateTime.Today.Year.ToString() + "\\" + DateTime.Today.Month.ToString() + "\\" + DateTime.Today.Day.ToString() + "\\" + ph_name + " " + DateTime.Now.ToString("dd'-'MM'-'yyyy' IN 'HH';'mm' 'tt") + ".bak";

                // MessageBox.Show(backupname);
                // return;
                FileInfo path = new FileInfo(backupname);

                using (SqlConnection c = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("backup Database " + db_name + " To Disk='" + backupname + "'", c))
                {
                    c.Open();
                    cmd.ExecuteNonQuery();
                }

                 Compress(path);
                 if (System.IO.File.Exists(path.ToString()))
                 {
                     System.IO.File.Delete(path.ToString());
                 }

                // MessageBox.Show("تم انشاء نسخه احتياطية لقاعدة البيانات  بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message);
            }
           
            
            base.OnFormClosing(e);


            Environment.Exit(0);

           // Application.Exit();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            //pProcess.StartInfo.FileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup.exe";
            ////  pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
            //pProcess.Start();


            //ras_mal_method();
            //this.ras_mal_productsTableAdapter1.Fill(dataSet11.ras_mal_products);
            user_previligesTableAdapter1.Fill(dataSet11.user_previliges);

        }

        private void بياناتالصيدليةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مرتجعشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_mortaga3 sm = new sales_mortaga3();
            sm.Text = "مرتجع بيع";
            sm.far3txt.Text = far3txt.Text;
            sm.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(sm);
            ApplyFormStyling(sm);
            sm.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالمرتجعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mortaga3_sales s = new mortaga3_sales();
            s.Text = "تقارير مرتجعات البيع";
            // s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void مرتجعشراءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            purchases_mortaga3 s = new purchases_mortaga3();
            s.Text = "مرتجع شراء";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالمرتجعاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mortaga3_purchases_reports s = new mortaga3_purchases_reports();
            s.Text = "تقارير مرتجعات الشراء";
            // s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void إضافةمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user s = new add_user();
            s.Text = "إضافة مستخدم جديد";
            s.typeTXT.Text = "add";
            s.user_txt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void حذفمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_user d = new delete_user();
            d.Text = "حذف مستخدم";
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.Show();            Control_Clicks_for_label(sender, e);
        }

        private void عرضمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_users_2 s = new show_users_2();
            s.Text = "عرض مستخدم";
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }



        private void نسبةالصيدليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saydaly_nesba s = new saydaly_nesba();
            s.Text = "نسبة الصيدلي";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_customer ac = new add_customer();
            ac.usertxt.Text = usertxt.Text;
            ac.far3txt.Text = far3txt.Text;
            ac.Text = "إضافة عميل جديد";
            SubscribeToLoadEvent(ac);
            ApplyFormStyling(ac);
            ac.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customers_show c = new customers_show();
            c.Text = "قائمة العملاء";
            c.usertxt.Text = usertxt.Text;
            c.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(c);
            ApplyFormStyling(c);
            c.Show();            Control_Clicks_for_label(sender, e);
        }

        private void اضافةموردجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_mwared am = new add_mwared();
            am.Text = "اضافة مورد جديد";
            SubscribeToLoadEvent(am);
            ApplyFormStyling(am);
            am.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mwardeen_show m = new mwardeen_show();
            m.Text = "قائمة الموردين";
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تواصلمعناToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contact_US c = new contact_US();
            c.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(c);
            ApplyFormStyling(c);
            c.ShowDialog();          Control_Clicks_for_label(sender, e);
        }



        private void ينتهيقريباToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expiration_form ex = new expiration_form();
            ex.Text = "تاريخ الصلاحيه";
            SubscribeToLoadEvent(ex);
            ApplyFormStyling(ex);
            ex.Show();            Control_Clicks_for_label(sender, e);
        }


        private void الاقساطالمتأخرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void sell_btn_Click(object sender, EventArgs e)
        {
            string bee3_type_txt = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\bee3_type_txt").First();
            if (bee3_type_txt == "نسبة")
            {
                sell_nesba s = new sell_nesba();
                s.Text = "فاتورة بيع";
                s.far3txt.Text = far3txt.Text;
                // s.fatora_type.Text = "جمله";
                s.usertxt.Text = usertxt.Text;
                //foreach (var item in category_list.Items) 
                //{
                //    s.category_list.Items.Add(item.ToString());
                //}
                SubscribeToLoadEvent(s);
                ApplyFormStyling(s);
                s.Show();            Control_Clicks_for_label(sender, e);
            }
            else
            {
                sell s = new sell();
                s.Text = "فاتورة بيع";
                s.far3txt.Text = far3txt.Text;
                // s.fatora_type.Text = "جمله";
                s.usertxt.Text = usertxt.Text;
                //foreach (var item in category_list.Items) 
                //{
                //    s.category_list.Items.Add(item.ToString());
                //}
                SubscribeToLoadEvent(s);
                ApplyFormStyling(s);
                s.Show();            Control_Clicks_for_label(sender, e);
            }
          
           
        }

        private void تعديلفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Text = "تعديل فاتورة بيع";
            s.far3txt.Text = far3txt.Text;
            s.type_txt.Text = "تعديل";
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void حذفمستخدمToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            delete_user d = new delete_user();
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void تعديلفاتورةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buy b = new buy();
            b.Text = "تعديل فاتورة شراء";
            b.type_txt.Text = "تعديل";
            b.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(b);
            ApplyFormStyling(b);
            b.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sales_mortaga3 sm = new sales_mortaga3();
            sm.Text = "مرتجع بيع";
            sm.far3txt.Text = far3txt.Text;
            sm.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(sm);
            ApplyFormStyling(sm);
            sm.ShowDialog();                 Control_Clicks_for_label(sender, e);  
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            string buy_type_txt = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\buy_type_txt").First();
            if (buy_type_txt == "نسبة")
            {
                buy_nesba b = new buy_nesba();
                b.Text = "فاتورة شراء";
                b.stock_txt.Text = far3txt.Text;
                b.usertxt.Text = usertxt.Text;
                SubscribeToLoadEvent(b);
                ApplyFormStyling(b);
                b.Show();            Control_Clicks_for_label(sender, e);            Control_Clicks_for_label(sender, e);
            }
            else
            {

                buy b = new buy();
                b.Text = "فاتورة شراء";
                b.stock_txt.Text = far3txt.Text;
                b.usertxt.Text = usertxt.Text;
                SubscribeToLoadEvent(b);
                ApplyFormStyling(b);
                b.Show();            Control_Clicks_for_label(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchases_mortaga3 s = new purchases_mortaga3();
            s.Text = "مرتجع شراء";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sales s = new sales();
            s.Text = "تقارير المبيعات";
            s.usertxt.Text = usertxt.Text;
            s.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            purchases s = new purchases();
            s.Text = "تقارير المشتريات";
            s.far3_txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            product_list p = new product_list();
            p.Text = "قائمة الاصناف";
            p.far3_txt.Text = far3txt.Text;
            p.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            barcode_form b = new barcode_form();
            b.Text = "طباعة الباركود";
            b.stock_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(b);
            ApplyFormStyling(b);
            b.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sell_with_icons s = new sell_with_icons();
            s.Text = "فاتورة بيع";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            refresh_categories();
            foreach (var item in category_list_items.Items)
            {
                s.category_list_items.Items.Add(item.ToString());
            }
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ras_mal_method();
            this.ras_mal_productsTableAdapter1.Fill(dataSet11.ras_mal_products);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet11.madeen_small_report.Rows)
            {

                string madeen_name = dr["madeen_small_name"].ToString();

                madeen_tableTableAdapter1.FillBy_by_madeen(dataSet11.madeen_table, madeen_name);
                if (dataSet11.madeen_table.Rows.Count <= 0)
                {

                }

                decimal matloob = Convert.ToDecimal(dr["madeen_small_matloob"]);
                decimal madfoo3 = Convert.ToDecimal(dr["madeen_small_madfoo3"]);

                madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_name_insert_new(matloob, madfoo3, madeen_name);


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            madeen m = new madeen();
            m.Text = "جميع المدينين";
            m.far3txt.Text = far3txt.Text;
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mosta7kat_show md = new mosta7kat_show();

            md.usertxt.Text = usertxt.Text;
            md.Text = "تفاصيل حساب مدين";
            SubscribeToLoadEvent(md);
            ApplyFormStyling(md);
            // md.far3txt.Text = far3txt.Text;
            md.Show();            Control_Clicks_for_label(sender, e);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            da2n m = new da2n();
            m.Text = "جميع الدائنين";
            m.far3txt.Text = far3txt.Text;
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void طباعةالباركودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barcode_form b = new barcode_form();
            b.Text = "طباعة الباركود";
            b.stock_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(b);
            ApplyFormStyling(b);
            b.Show();            Control_Clicks_for_label(sender, e);
        }

        private void بياناتالمحلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
                         ListBox list = new ListBox();
                         string connString = @"Data Source=.\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=my_data;Integrated Security=false;User ID=me;Password=ahmed2010";
                         using (SqlConnection c = new SqlConnection(connString))
                         c.Open();
                         using (SqlCommand com = new SqlCommand("SELECT   TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG='my_data'", c))
                         {
                             DataTable t = c.GetSchema("Tables");
                             SqlDataAdapter adapter = new SqlDataAdapter(com);
                             adapter.Fill(t);
                             foreach (DataRow dr in t.Rows)
                             {
                                 list.Items.Add(dr[2].ToString());
                             }
                         }


                         //  string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss") + ".bak";
                         // MessageBox.Show(path);
                         foreach (var item in list.Items)
                         {
                             string query = "TRUNCATE TABLE " + item.ToString();
                             using (SqlCommand cmd = new SqlCommand(query, c))
                             {
                                 cmd.ExecuteNonQuery();
                             }
                         }
                         c.Close();
                         }
                         MessageBox.Show("تم مسح جميع البيانات ستتم اعادة تشغيل النظام");
                         Application.Restart();
           // //products_tableTableAdapter1.Delete_delete_all();
           // // user_previligesTableAdapter1.Delete_all();
           // madeen_small_reportTableAdapter1.Delete_all();
           // madeen_tableTableAdapter1.Delete_all();
           // ras_mal_productsTableAdapter1.Delete_all();
           // arba7_tableTableAdapter1.Delete_all();
           // // categoryTableAdapter1.Delete_all();
           //// customersTableAdapter1.Delete_all();
           // da2n_tableTableAdapter1.Delete_all();
           // da2n_small_reportsTableAdapter1.Delete_all();
           // income_tableTableAdapter1.Delete_all();
           // ma5zoon_movesTableAdapter1.Delete_all();
           // mortaga3_purchasesTableAdapter1.Delete_all();
           //// mwardeenTableAdapter1.Delete_all();
           // outcome_tableTableAdapter1.Delete_all();
           // purchases_tableTableAdapter1.Delete_all();
           // sales_mortaga3TableAdapter1.Delete_all();
           // sales_tableTableAdapter1.Delete_all();
            MessageBox.Show("done");
        }



        private void إضافةمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stocks s = new stocks();
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void فاتورةبيعقطاعيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Text = "فاتورة بيع ";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            //foreach (var item in category_list.Items)
            //{
            //    s.category_list.Items.Add(item.ToString());
            //}
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Text = "فاتورة بيع ";
            s.far3txt.Text = far3txt.Text;
            //s.fatora_type.Text = "قطاعي";
            s.usertxt.Text = usertxt.Text;
            //foreach (var item in category_list.Items)
            //{
            //    s.category_list.Items.Add(item.ToString());
            //}
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            mortaga3_sales s = new mortaga3_sales();
            s.Text = "تقارير مرتجعات البيع";
            // s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد الخروج من البرنامج بالكامل " + " ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                Program.StopTimer();
                Environment.Exit(0);
                //Application.Exit();
            }
            else if (re == DialogResult.No)
            {
                return;
            }
        }

         private string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }
        private void انشاءنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                string un = "";
                string pw = "";
                string ip = "";
                string db_name = "";
                string db_port = "";
                string db_v = "";

                try
                {
                    un = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                }
                catch
                {
                    un = "";
                }
                try
                {
                    pw = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                }
                catch
                {
                    pw = "";
                }
                try
                {
                    ip = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
                }
                catch
                {
                    ip = "";
                }
                try
                {
                    db_port = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port").First();
                }
                catch
                {
                    db_port = "";
                }
                try
                {
                    db_v = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v").First();
                }
                catch
                {
                    db_v = "";
                }
                try
                {
                    db_name = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();
                }
                catch
                {
                    db_name = "";
                }

                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup (*.Bak)|*.bak";

                SqlConnection c = new SqlConnection();
                if (db_v == "ex")
                {
                    if (un == "")
                    {
                        c.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

                        db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";

                    }
                    else
                    {
                        c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS," + db_port + ";Network Library=DBMSSOCN;Initial Catalog="+db_name+";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                    //    db_name = "my_data";

                    }
                }
                else 
                {
                    c.ConnectionString = @"Data Source=" + ip + "," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                   // db_name = "my_data";
                   // MessageBox.Show(c.ConnectionString);
                }
                SqlCommand cmd = new SqlCommand();
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    FileInfo path = new FileInfo(sf.FileName);
                    //    string query = "backup Database" + db_name + "To Disk=" + sf.FileName;
                    cmd = new SqlCommand("backup Database " + db_name + " To Disk='" + sf.FileName + "'", c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();

                    Compress(path);
                    path_for_google_drive_upload=path.FullName;
                   // MessageBox.Show(path.FullName);

                    DialogResult d = MessageBox.Show("تم انشاء نسخه احتياطية لقاعدة البيانات  بنجاح . هل تريد رفع نسخه على جوجل درايف ؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    {
                        // Your OAuth2 client secrets (replace with your actual credentials)
                        backgroundWorker1_google_drive.RunWorkerAsync();
                    }

                    //pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
                   
                    //string mail = "";
                    //string sender_mail = "";
                    //string sender_password = "";
                    //try
                    //{
                    //     mail = dataSet11.pharmacy_data.Rows[0]["pharmacy_mail"].ToString();
                    //    sender_mail = dataSet1.pharmacy_data.Rows[0]["pharmacy_sender_mail"].ToString();
                    //    sender_password= dataSet1.pharmacy_data.Rows[0]["pharmacy_sender_password"].ToString();
                    //}
                    //catch { }
                    //if (mail != ""&&sender_mail!=""&&sender_password!="")
                    //{
                    //    DialogResult d = MessageBox.Show("تم انشاء نسخه احتياطية لقاعدة البيانات  بنجاح . هل تريد ارسالها الي الميل ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    //    if (d == DialogResult.Yes)
                    //    {
                    //        try
                    //        {



                    //            MessageBox.Show("جاري ارسال النسخه الاحتياطيه برجاء الانتظار ");
                    //            try
                    //            {
                    //                //MailAddress addressFrom = sender_mail;// "midoahly9@outlook.com";
                    //                //MailAddress addressTo = mail;
                    //                //// MailAddress adressCC = "Shawn_Smithhh@outlook.com";

                    //                //MailMessage message = new MailMessage(addressFrom, addressTo);
                    //                //string title = "نسخة احتياطية " + dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString() + " " + DateTime.Now.ToShortDateString();
                    //                //message.Subject = title;
                    //                //message.BodyText = title;
                    //                //message.Date = DateTime.Now;

                    //                //message.Attachments.Add(new Attachment(sf.FileName + ".gz"));
                    //                //// message.Cc.Add(adressCC.Address);

                    //                //SmtpClient smtp = new SmtpClient();
                    //                //smtp.Host = "smtp.outlook.com";
                    //                //smtp.ConnectionProtocols = ConnectionProtocols.Ssl;
                    //                //smtp.Username = addressFrom.Address;
                    //                //smtp.Password = sender_password;// "ahmed2010";
                    //                //smtp.Port = 587;
                    //                ////  smtp.TimeOut = 60;

                    //                //smtp.SendOne(message);
                    //                //MessageBox.Show("تم ارسال النسخه الاحتياطيه بنجاح");
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //                MessageBox.Show(ex.Message);
                    //            }
                    //        }
                    //        catch { }
                    //    }
                    //}
                    //else 
                    //{
                    //    MessageBox.Show("تم انشاء نسخه احتياطية لقاعدة البيانات  بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }


        private void استردادنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                string un = "";
                string pw = "";
                string ip = "";
                string db_name = "";
                string db_port = "";
                string db_v = "";

                try
                {
                    un = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                }
                catch
                {
                    un = "";
                }
                try
                {
                    pw = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                }
                catch
                {
                    pw = "";
                }
                try
                {
                    ip = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
                }
                catch
                {
                    ip = "";
                }
                try
                {
                    db_port = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port").First();
                }
                catch
                {
                    db_port = "";
                }
                try
                {
                    db_v = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v").First();
                }
                catch
                {
                    db_v = "";
                }
                try
                {
                    db_name = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();
                }
                catch
                {
                    db_name = "";
                }
                SqlConnection c = new SqlConnection();

                if (db_v == "ex")
                {
                    if (un == "")
                    {
                        c.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;User Instance=True";
                        db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";
                    }
                    else
                    {
                        c.ConnectionString = @"Data Source=" + ip + "," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=Master;Integrated Security=false;User ID=" + un + ";Password=" + pw;
                        db_name = "my_data";

                    }
                }
                else 
                {
                    c.ConnectionString = @"Data Source=" + ip + "," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=Master;Integrated Security=false;User ID=" + un + ";Password=" + pw;
                 
                }

                SqlCommand command;

                
              
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Backup (*.Bak)|*.bak";

                if (op.ShowDialog() == DialogResult.OK)
                {



                    command = new SqlCommand("ALTER DATABASE " + db_name + " SET OFFLINE WITH ROLLBACK IMMEDIATE", c);
                    c.Open();
                    command.ExecuteNonQuery();
                    c.Close();

                    command = new SqlCommand("ALTER DATABASE " + db_name + " SET MULTI_USER", c);
                    c.Open();
                    command.ExecuteNonQuery();
                    c.Close();

                    //System.IO.File.Move(Application.StartupPath + "\test rent.mdf", "E:\\project\a5er 7aga");

                    //  cmd = new SqlCommand(" WITH MOVE 'test rent.mdf' TO 'C:\test rent.MDF';WITH MOVE 'test rent_log' TO 'C:\test rent_log.LDF'");
                    command = new SqlCommand("Restore Database " + db_name + " FROM Disk='" + op.FileName + "'", c);
                    c.Open();

                    command.ExecuteNonQuery();

                    c.Close();


                    command = new SqlCommand("alter database " + db_name + " set online", c);
                    c.Open();
                    command.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("تم استرداد نسخة قاعدة البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {
            }
        }

        private void عرضبياناتالمحلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pharmacy_data p = new pharmacy_data();
            p.Text = "بيانات المحل";
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.Show();            Control_Clicks_for_label(sender, e);

        }


        public static void Compress(FileInfo fi)
        {
            // Get the stream of the source file.
            using (FileStream inFile = fi.OpenRead())
            {
                // Prevent compressing hidden and already compressed files.
                if (((System.IO.File.GetAttributes(fi.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden)
                    && fi.Extension != ".gz")
                {
                    // Optionally check if the compressed file already exists.
                    string compressedFilePath = fi.FullName + ".gz";
                    if (System.IO.File.Exists(compressedFilePath))
                    {
                        // Handle the case as needed (e.g., delete, skip, or rename)
                        System.IO.File.Delete(compressedFilePath);
                    }

                    // Create the compressed file.
                    using (FileStream outFile = System.IO.File.Create(compressedFilePath))
                    {
                        using (GZipStream compressStream = new GZipStream(outFile, CompressionMode.Compress))
                        {
                            try
                            {
                                // Copy the source file into the compression stream.
                                inFile.CopyTo(compressStream);
                                //Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                                //    fi.Name, fi.Length, outFile.Length);
                            }
                            catch (Exception ex)
                            {
                              //  MessageBox.Show("Compression failed: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }


        private void button18_Click(object sender, EventArgs e)
        {
            print_last_fatora p = new print_last_fatora();
            p.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.ShowDialog();          Control_Clicks_for_label(sender, e);

        }


        private void مسحجميعبياناتالنظامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد مسح جميع بيانات النظام؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.Yes)
            {
                delete_all d = new delete_all();
                d.username_txt.Text = usertxt.Text;
                SubscribeToLoadEvent(d);
                ApplyFormStyling(d);
                d.ShowDialog();          Control_Clicks_for_label(sender, e);
            }
        }

        private void إضافةموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_employee a = new add_employee();
            a.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void حضورالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attending_emp a = new attending_emp();
            a.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void مراجعةحضورالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attending_show a = new attending_show();
            a.usertxt.Text = usertxt.Text;
            a.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void قائمةالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees_show ee = new employees_show();
            ee.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(ee);
            ApplyFormStyling(ee);
            ee.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void قسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_solaf s = new add_solaf();
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            s.Text = "عمل سلفه";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }
        
       
        private void button15_Click_1(object sender, EventArgs e)
        {
            mortaga3_purchases_reports s = new mortaga3_purchases_reports();
            s.Text = "تقارير مرتجعات الشراء";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            // s.usertxt.Text = usertxt.Text;
            s.Show();            Control_Clicks_for_label(sender, e);
        }
       
        private void button19_Click(object sender, EventArgs e)
        {
            add_solaf s = new add_solaf();
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            attending_emp a = new attending_emp();
            a.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void طباعةاخرفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_last_fatora p = new print_last_fatora();
            p.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void تقفيلالخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ta2feel t = new ta2feel();
            t.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(t);
            ApplyFormStyling(t);
            t.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void انشاءاذنصرفمبلغماليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ezn_create ee = new ezn_create();
            ee.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(ee);
            ApplyFormStyling(ee);
            ee.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void مراجعةاذوناتالصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ezn_show ee = new ezn_show();
            SubscribeToLoadEvent(ee);
            ApplyFormStyling(ee);
            ee.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void اضافيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_solaf s = new add_solaf();
            s.usertxt.Text = usertxt.Text;
            s.Text = "اضافي موظف";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }


        private void عملمكافأةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_solaf s = new add_solaf();
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            s.Text = "عمل مكافأة";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void عملخصمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_solaf s = new add_solaf();
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            s.Text = "عمل خصم";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void فاتورةصيانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syana_fatora s = new syana_fatora();
            s.Text = "فاتورة استلام صيانة";
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syana_reports s = new syana_reports();
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تسليمصيانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tasleem_syana t = new tasleem_syana();
            t.usertxt.Text = usertxt.Text;
            t.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(t);
            ApplyFormStyling(t);
            t.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
           
        }

        private void البحثفيالفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_in_far3 s = new search_in_far3();
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void مسحوباتالصيانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mas7obat_syana m = new mas7obat_syana();
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void عرضالارباحبالفئةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arba7_category a = new arba7_category();
            a.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void انصرافالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ensraf_form ee = new ensraf_form();
            SubscribeToLoadEvent(ee);
            ApplyFormStyling(ee);
            ee.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

       
        private void مراجعةالسيريالاتToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            serials_form s = new serials_form();
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void اضافةسيريالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_serial a = new add_serial();
            a.usertxt.Text=usertxt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

       

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_product ap = new add_product();
            ap.Text = "إضافة صنف";
            ap.usertxt.Text = usertxt.Text;
            ap.stock_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(ap);
            ApplyFormStyling(ap);
            ap.Show();            Control_Clicks_for_label(sender, e);
         
        }

        private void اعداداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings_form cc = new settings_form();
            
            SubscribeToLoadEvent(cc);
            ApplyFormStyling(cc);

            cc.ShowDialog();
            Control_Clicks_for_label(sender, e);
            colors();
        }

        private void backgroundWorker_nwa2es_DoWork(object sender, DoWorkEventArgs e)
        {
            //if (DateTime.Today <= Convert.ToDateTime("27/11/2021"))
            //{

            //   // reb7_old();
            //    //   MessageBox.Show("done");
            //}

            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            int i = 0;
            //MessageBox.Show("جرب من بره البرنامج");
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {

                try
                {
                    if (Convert.ToDecimal(dr["pro_count"]) <= Convert.ToDecimal(dr["pro_limit"]))
                    {

                        i += 1;
                    }
                }
                catch { }

            }

            //string n_icon = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icon.ico";
          
            notifyIcon1.Icon = Properties.Resources.icon;
            notifyIcon1.BalloonTipTitle = "تنبيه نواقص";
            notifyIcon1.BalloonTipText = "عدد الاصناف في النواقص " + i.ToString();
            notifyIcon1.ShowBalloonTip(6000);
            notifyIcon1.BalloonTipClicked += النواقصToolStripMenuItem_Click;
            notifyIcon1.Text = "تنبيه نواقص";
            
            madeen_small_reportTableAdapter1.Fill(dataSet11.madeen_small_report);
            string madeen_count = dataSet11.madeen_small_report.Rows.Count.ToString();
            notifyIcon2.Icon = Properties.Resources.icon;
            notifyIcon2.BalloonTipTitle = "تنبيه مدينين";
            notifyIcon2.BalloonTipText = "عدد المدينين  " + madeen_count;
            notifyIcon2.ShowBalloonTip(6000);
            notifyIcon2.BalloonTipClicked += قائمةالمدينينToolStripMenuItem_Click;
            notifyIcon2.Text = "تنبيه مدينين";
            

            try 
            {
                products_tableTableAdapter1.FillBy_stock(dataSet11.products_table, far3txt.Text);
                foreach (DataRow dr in dataSet11.products_table.Rows)
                {
                    string pro_id = dr["pro_ID"].ToString();
                    string pro_int_code = dr["pro_int_code"].ToString();
                    string pro_name = dr["pro_name"].ToString();
                    string pro_category = dr["pro_category"].ToString();

                    sales_tableTableAdapter1.Update_pro_id_by_old_id(pro_int_code,pro_name, pro_id,far3txt.Text);
                    purchases_tableTableAdapter1.Update_pro_id(pro_int_code, pro_name, pro_id,far3txt.Text);
                    ma5zoon_movesTableAdapter1.Update_pro_code(pro_int_code, pro_name, pro_id);
                   // mortaga3_purchasesTableAdapter1.Update_pro_id(Convert.ToInt32(pro_int_code), pro_name, Convert.ToInt32(pro_id));
                    sales_mortaga3TableAdapter1.Update_pro_id(pro_int_code, pro_name, pro_id);

                   categoryTableAdapter1.FillBy_name(dataSet11.Category, pro_category);
                    if (dataSet11.Category.Rows.Count <= 0)
                    {
                        categoryTableAdapter1.Insert(pro_category, 0, "", 0);
                    }
                }

                //try
                //{
                //    get_partition();
                //    CleanOldBackups(backup_partition + @"backup\");
                //}
                //catch { }

              //  MessageBox.Show("done");

                timer2.Start();
            }
            catch { }


            try
            {
                products_tableTableAdapter1.Update_int_code_if_null();
            }
            catch { }
            

          
        }

        private void تعديلفاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Text = "تعديل فاتورة بيع";
            s.type_txt.Text = "تعديل";
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void الأصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_assets a = new add_assets();
            a.usertxt.Text = usertxt.Text;
            a.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void حصصالشركاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partners_share p = new partners_share();
            p.usertxt.Text = usertxt.Text;
            p.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void حالةرأسالمالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ra2s_elmal_status r = new ra2s_elmal_status();
            r.Text = "حالة رأس المال";
            r.user_txt.Text = usertxt.Text;
            r.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(r);
            ApplyFormStyling(r);
            r.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void فاتورةبيعيدويToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell_with_icons s = new sell_with_icons();
            s.Text = "فاتورة بيع";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
           
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
          
            refresh_categories();

            foreach (var item in category_list_items.Items)
            {
                s.category_list_items.Items.Add(item.ToString());
            }
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshCategoriesAsync();

        }

        private void انشاءعرضسعرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nwa2s n = new nwa2s();
            n.Text = "عرض سعر";
            this.products_tableTableAdapter1.Fill(this.dataSet11.products_table);
            int i = 0;
            //MessageBox.Show("جرب من بره البرنامج");
            foreach (DataRow dr in dataSet11.products_table.Rows)
            {

                try
                {


                    i += 1;
                    // MessageBox.Show(i.ToString());
                    n.dataGridView1.Rows.Add(i.ToString(), dr["pro_ID"].ToString(), dr["pro_name"].ToString(), dr["pro_category"].ToString(), "", Convert.ToDecimal(dr["pro_bee3"]));
                    //  nwa2es_tableTableAdapter1.Insert_nwa2es(dr["pro_id_company"].ToString(), dr["pro_name"].ToString(), Convert.ToDecimal(dr["pro_count"]), 0);
                }
                catch { }

            }

            SubscribeToLoadEvent(n);
            ApplyFormStyling(n);
            n.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تعديلسعرفئةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_category_price ee = new edit_category_price();
            ee.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(ee);
            ApplyFormStyling(ee);
            ee.Show();            Control_Clicks_for_label(sender, e);
        }

        private void قائمةالمحذوفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            deleted_form d = new deleted_form();
            d.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.Show();            Control_Clicks_for_label(sender, e);
        }

        private void timer_for_deleting_temp_Tick(object sender, EventArgs e)
        {
            backgroundWorker_delete_temp.RunWorkerAsync();
        }

        private void backgroundWorker_delete_temp_DoWork(object sender, DoWorkEventArgs e)
        {
          //  arba7_tableTableAdapter1.update_arba7_differences();
            ListBox l=new ListBox();
            delete_temp(l);
         


        }

        private void CleanOldBackups(string backupRootDirectory)
        {
            try
            {
                DirectoryInfo rootDir = new DirectoryInfo(backupRootDirectory);
                var yearDirs = rootDir.GetDirectories().OrderBy(d => d.Name).ToList();
                
             
                // Get the current date
                DateTime currentDate = DateTime.Now;

                foreach (var yearDir in yearDirs)
                {
                    int year = int.Parse(yearDir.Name);
                    var monthDirs = yearDir.GetDirectories().OrderBy(d => d.Name).ToList();
                   // MessageBox.Show(year.ToString());
                    foreach (var monthDir in monthDirs)
                    {
                        int month = int.Parse(monthDir.Name);
                        DateTime monthDate = new DateTime(year, month, 1);

                        // Keep backups from the last 2 months as they are
                        if ((currentDate - monthDate).Days <= 10)
                            continue;

                        var dayDirs = monthDir.GetDirectories().OrderBy(d => d.Name).ToList();

                        foreach (var dayDir in dayDirs)
                        {
                            var backupFiles = dayDir.GetFiles("*.bak").OrderByDescending(f => f.CreationTime).ToList();

                            // Keep only the last backup file, delete the rest
                            if (backupFiles.Count > 1)
                            {
                                for (int i = 1; i < backupFiles.Count; i++)
                                {
                                  //  MessageBox.Show("Deleting file: " + backupFiles[i].FullName, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    backupFiles[i].Delete();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (logging, rethrowing, etc.)
                // Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Helper method to calculate the size of a directory
        private long GetDirectorySize(DirectoryInfo dir)
        {
            long size = 0;

            // Add file sizes
            FileInfo[] fis = dir.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }

            // Add subdirectory sizes
            DirectoryInfo[] dis = dir.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += GetDirectorySize(di);
            }
            return size;
        }

        private void delete_temp(ListBox l)
        {
            try
            {
                string tmpPath = Path.GetTempPath();

                var files = Directory.GetFiles(tmpPath, "*.*", SearchOption.AllDirectories);
                l.Items.AddRange(files);


                foreach (var item in l.Items)
                {
                    if (System.IO.File.Exists(item.ToString()))
                    {
                        try
                        {

                            System.IO.File.Delete(item.ToString());
                            // MessageBox.Show(item.ToString() + " deleted");
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(ex.Message + " not deleted");
                            continue;
                        }
                    }
                    // MessageBox.Show(item.ToString());
                }
            }
            catch { }

        }
       
        string backup_partition = "";
        private void get_partition()
        {
            //DriveInfo[] allDrives = DriveInfo.GetDrives();
            //ListBox p_list = new ListBox();

            //foreach (DriveInfo d in allDrives)
            //{

            //    if (d.Name != "C:\\" && d.IsReady == true && d.DriveType.ToString() == "Fixed")
            //    {
            //        p_list.Items.Add(d.Name);
            //         //MessageBox.Show(d.DriveType.ToString());
            //    }
            //}

            //backup_partition = p_list.Items[0].ToString();
        // MessageBox.Show(backup_partition);


            backup_partition = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\backup_path").First();
        }

        string ph_name;

        private void PerformBackup()
        {
            try
            {
                if (!backgroundWorker_backup.IsBusy)
                {
                    backgroundWorker_backup.RunWorkerAsync();
                }
            }
            catch { }

        }

        private void backgroundWorker_backup_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!backgroundWorker_backup.IsBusy)
                {
                    backgroundWorker_backup.RunWorkerAsync();
                }
            }
            catch { }

        }

        private void backgroundWorker_backup_DoWork(object sender, DoWorkEventArgs e)
        {
            get_partition();

            ras_mal_method();

            string un = "";
            string pw = "";
            string ip = "";
            string db_name = "";
            string db_port = "";
            string db_v = "";

            try
            {
                un = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
            }
            catch
            {
                un = "";
            }
            try
            {
                pw = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
            }
            catch
            {
                pw = "";
            }
            try
            {
                ip = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
            }
            catch
            {
                ip = "";
            }
            try
            {
                db_port = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port").First();
            }
            catch
            {
                db_port = "";
            }
            try
            {
                db_v = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v").First();
            }
            catch
            {
                db_v = "";
            }
            try
            {
                db_name = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();
            }
            catch
            {
                db_name = "";
            }

            try{
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup (*.Bak)|*.bak";

                SqlConnection c = new SqlConnection();
                if (db_v == "ex")
                {
                    if (un == "")
                    {
                        c.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

                        db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";

                    }
                    else
                    {
                        c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                        //    db_name = "my_data";

                    }
                }
                else
                {
                    c.ConnectionString = @"Data Source=" + ip + "," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                    // db_name = "my_data";

                }

               // MessageBox.Show(backup_partition);

                Directory.CreateDirectory(backup_partition + @"\backup\" + DateTime.Today.Year.ToString() + "\\" + DateTime.Today.Month.ToString() + "\\" + DateTime.Today.Day.ToString() + "\\");

                string bb = backup_partition + @"\backup\" + DateTime.Today.Month.ToString();

                string backupname = backup_partition + @"\backup\" + DateTime.Today.Year.ToString() + "\\" + DateTime.Today.Month.ToString() + "\\" + DateTime.Today.Day.ToString() + "\\" +ph_name+" "+ DateTime.Now.ToString("dd'-'MM'-'yyyy' IN 'HH';'mm' 'tt") + ".bak";

               // MessageBox.Show(backupname);
               // return;
                SqlCommand cmd = new SqlCommand();

                //string db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";
                FileInfo path = new FileInfo(backupname);
                //    string query = "backup Database" + db_name + "To Disk=" + sf.FileName;
                cmd = new SqlCommand("backup Database " + db_name + " To Disk='" + backupname + "'", c);
               // MessageBox.Show("backup Database " + db_name + " To Disk='" + backupname + "'");
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();

                 Compress(path);
               //  MessageBox.Show(path.ToString());
                // File.Delete();
                 if (System.IO.File.Exists(path.ToString()))
                 {
                     System.IO.File.Delete(path.ToString());
                 }


                // MessageBox.Show("تم انشاء نسخه احتياطية لقاعدة البيانات  بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message);
            }

        }

        private async void timer_backup_Tick(object sender, EventArgs e)
        {
            await Task.Run(() => PerformBackup());
            MessageBox.Show("Backup completed.");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            ListBox list_for_edit = new ListBox();
            ListBox list_for_skip = new ListBox();
            products_tableTableAdapter1.Fill(dataSet11.products_table);

            foreach (DataRow dr in dataSet11.products_table.Rows)
            {
                try
                {
                    string pro_name = dr["pro_name"].ToString();

                    purchases_tableTableAdapter1.FillBy_pro_stock_fatra_LAST_ONE(dataSet11.Purchases_table, pro_name, far3txt.Text, DateTime.Now.AddMonths(-3).ToShortDateString(), DateTime.Now.ToShortDateString());

                    if (dataSet11.Purchases_table.Rows.Count > 0)
                    {

                        list_for_skip.Items.Add(dataSet11.Purchases_table.Rows[0]["Purchases_product_name"].ToString());
                       // MessageBox.Show(dataSet11.Purchases_table.Rows[0]["Purchases_product_name"].ToString());
                    }
                    else 
                    {
                        list_for_edit.Items.Add(dr["pro_name"].ToString());
                    }
                }
                catch 
                {
                    list_for_edit.Items.Add(dr["pro_name"].ToString());
                }
            }

            //MessageBox.Show(list_for_edit.Items.Count.ToString());
            //MessageBox.Show(list_for_skip.Items.Count.ToString());

            foreach (var item in list_for_edit.Items) 
            {
                products_tableTableAdapter1.FillBy_name(dataSet11.products_table, item.ToString());
                decimal old_price = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_cost_price"]);
                decimal new_price = old_price + (old_price *Convert.ToDecimal(0.05));
                foreach (DataRow dr in dataSet11.products_table.Rows)
                {
                    int id = Convert.ToInt32(dr["pro_ID"]);
                    products_tableTableAdapter1.Update_cost_price_5_by_id(new_price,id);

                }
            }
            MessageBox.Show("done");

        }

        private void تغييرالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_all d = new delete_all();
            d.Text = "تغيير المستخدم";
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.ShowDialog();          Control_Clicks_for_label(sender, e);
            if (d.Result_user != "")
            {
                usertxt.Text = d.Result_user;
                user_prev_excute();
            }
        }

        private void تغييركلمةالسرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_password c = new change_password();
            c.username_txt.Text = usertxt.Text;
            SubscribeToLoadEvent(c);
            ApplyFormStyling(c);
            c.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void انشاءامرتحويلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ta7weel t = new ta7weel();
            t.Text = "انشاء امر تحويل";
            t.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(t);
            ApplyFormStyling(t);
            t.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void عرضاوامرالتحويلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ta7weelat_show tt = new ta7weelat_show();
            SubscribeToLoadEvent(tt);
            ApplyFormStyling(tt);
            tt.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void عرضالهالكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            halek_show h = new halek_show();
            h.Text = "قائمة الهالك";
            h.stock_txt.Text=far3txt.Text;
            SubscribeToLoadEvent(h);
            ApplyFormStyling(h);
            h.Show();            Control_Clicks_for_label(sender, e);
        }

        private void معادلةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mo3adalat_form m = new mo3adalat_form();
            m.Text = "معادلة انتاج جديدة";
            m.user_txt.Text = usertxt.Text;
            m.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void عرضمعادلاتالانتاجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mo3adalat_show mm = new mo3adalat_show();
            mm.Text = "عرض معادلات التصنيع";
            mm.usertxt.Text = usertxt.Text;
            mm.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(mm);
            ApplyFormStyling(mm);
            mm.Show();            Control_Clicks_for_label(sender, e);
        }

        private void فاتورةمسحوباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mas7obat_fatora m = new mas7obat_fatora();
            m.user_txt.Text = usertxt.Text;
            m.Text = "فاتورة مسحوبات";
            m.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تقاريرالمسحوباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mas7obat_list m = new mas7obat_list();
            m.user_txt.Text = usertxt.Text;
            m.Text = "تقارير المسحوبات";
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void امرشغلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amr_sho3l a = new amr_sho3l();
            a.Text = "امر شغل جديد";
            a.user_txt.Text = usertxt.Text;
            a.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.Show();            Control_Clicks_for_label(sender, e);
        }

        private void تقاريراوامرالشغلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amr_sho3l_list_2 a = new amr_sho3l_list_2();
            a.Text = "تقارير اوامر الشغل";
            SubscribeToLoadEvent(a);
            ApplyFormStyling(a);
            a.Show();            Control_Clicks_for_label(sender, e);
        }

        private void مصروفامرشغلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amr_masrof m = new amr_masrof();
            m.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.Show();            Control_Clicks_for_label(sender, e);
        }

        private void فاتورةتوريدمنالانتاجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tawreedat_fatora t = new tawreedat_fatora();
            t.Text = "فاتورة توريد من الانتاج";
            t.user_txt.Text = usertxt.Text;
            t.stock_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(t);
            ApplyFormStyling(t);
            t.Show();            Control_Clicks_for_label(sender, e);
        }

        

        private void تقاريرالتوريداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tawreedat_list t = new tawreedat_list();
            t.Text = "تقارير التوريدات";
            t.user_txt.Text = usertxt.Text;
            SubscribeToLoadEvent(t);
            ApplyFormStyling(t);
            t.Show();            Control_Clicks_for_label(sender, e);
        }

        private void فاتورةتسعيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell_for_tas3eer s = new sell_for_tas3eer();
            s.Text = "فاتورة تسعير";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            //foreach (var item in category_list.Items)
            //{
            //    s.category_list.Items.Add(item.ToString());
            //}
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();            Control_Clicks_for_label(sender, e);
        }

        private void عرضفواتيرالتسعيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_tas3eer ss = new show_tas3eer();
            ss.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(ss);
            ApplyFormStyling(ss);
            ss.ShowDialog();          Control_Clicks_for_label(sender, e);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void تعديلصلاحياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_users_2 s = new show_users_2();
            s.Text = "تعديل صلاحيات";
            s.type_txt.Text = "تعديل";
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog();            Control_Clicks_for_label(sender, e);
            user_prev_excute();
        }

        private void الجردبالباركودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gard_form g = new gard_form();
            g.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(g);
            ApplyFormStyling(g);
            g.Show();            Control_Clicks_for_label(sender, e);
        }

        private void إدارةالخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer_backup_to_mail_Tick(object sender, EventArgs e)
        {
            get_partition();
            try
            {
                backgroundWorker_backup_to_mail.RunWorkerAsync();
            }
            catch { }
        }

        private void backgroundWorker_backup_to_mail_DoWork(object sender, DoWorkEventArgs e)
        {
           
            ras_mal_method();

            try
            {
                string un = "";
                string pw = "";
                string ip = "";
                string db_name = "";
                string db_port = "";
                string db_v = "";

                try
                {
                    un = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                }
                catch
                {
                    un = "";
                }
                try
                {
                    pw = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                }
                catch
                {
                    pw = "";
                }
                try
                {
                    ip = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
                }
                catch
                {
                    ip = "";
                }
                try
                {
                    db_port = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port").First();
                }
                catch
                {
                    db_port = "";
                }
                try
                {
                    db_v = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v").First();
                }
                catch
                {
                    db_v = "";
                }
                try
                {
                    db_name = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();
                }
                catch
                {
                    db_name = "";
                }

                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup (*.Bak)|*.bak";

                string connString;
                if (un == "")
                {
                    connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                    db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";
                }
                else
                {
                    connString = @"Data Source=" + ip + "\\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=my_data;Integrated Security=false;User ID=" + un + ";Password=" + pw;
                    db_name = "my_data";
                }

                // MessageBox.Show(backup_partition);

                Directory.CreateDirectory(backup_partition + @"\backup\" + DateTime.Today.Year.ToString() + "\\" + DateTime.Today.Month.ToString() + "\\" + DateTime.Today.Day.ToString() + "\\");

                string bb = backup_partition + @"\backup\" + DateTime.Today.Month.ToString();

                string backupname = backup_partition + @"\backup\" + DateTime.Today.Year.ToString() + "\\" + DateTime.Today.Month.ToString() + "\\" + DateTime.Today.Day.ToString() + "\\" + ph_name + " " + DateTime.Now.ToString("dd'-'MM'-'yyyy' IN 'HH';'mm' 'tt") + ".bak";

                // MessageBox.Show(backupname);
                // return;
                FileInfo path = new FileInfo(backupname);

                using (SqlConnection c = new SqlConnection(connString))
                using (SqlCommand cmd = new SqlCommand("backup Database " + db_name + " To Disk='" + backupname + "'", c))
                {
                    c.Open();
                    cmd.ExecuteNonQuery();
                }

                Compress(path);
                //MessageBox.Show(path.ToString());
                // MessageBox.Show("تم انشاء نسخه احتياطية لقاعدة البيانات  بنجاح ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                //pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data); string mail = "";
                //string sender_mail = "";
                //string sender_password = "";
                //try
                //{
                //    mail = dataSet11.pharmacy_data.Rows[0]["pharmacy_mail"].ToString();
                //    sender_mail = dataSet1.pharmacy_data.Rows[0]["pharmacy_sender_mail"].ToString();
                //    sender_password = dataSet1.pharmacy_data.Rows[0]["pharmacy_sender_password"].ToString();
                //}
                //catch { }
                //if (mail != "" && sender_mail != "" && sender_password != "")
                //{

                //    try
                //    {
                //        //MailAddress addressFrom = sender_mail;// "midoahly9@outlook.com";
                //        //MailAddress addressTo = mail;
                //        //// MailAddress adressCC = "Shawn_Smithhh@outlook.com";

                //        //MailMessage message = new MailMessage(addressFrom, addressTo);
                //        //string title = "نسخة احتياطية " + dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString() + " " + DateTime.Now.ToShortDateString();
                //        //message.Subject = title;
                //        //message.BodyText = title;
                //        //message.Date = DateTime.Now;

                //        //message.Attachments.Add(new Attachment(path + ".gz"));
                //        //// message.Cc.Add(adressCC.Address);

                //        //SmtpClient smtp = new SmtpClient();
                //        //smtp.Host = "smtp.outlook.com";
                //        //smtp.ConnectionProtocols = ConnectionProtocols.Ssl;
                //        //smtp.Username = addressFrom.Address;
                //        //smtp.Password = sender_password;// "ahmed2010";
                //       // smtp.Port = 587;
                //        //  smtp.TimeOut = 60;

                //      //  smtp.SendOne(message);
                //      //  MessageBox.Show("تم ارسال النسخه الاحتياطيه بنجاح");
                //    }
                //    catch (Exception ex)
                //    {
                //        // MessageBox.Show(ex.Message);
                //    }


                
            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message);
            }
        }
        
        
        //// OAuth2 authentication and DriveService setup
        //private DriveService GetDriveService()
        //{
        //    UserCredential credential;

        //    // Load client secrets
        //    using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
        //    {
        //        // Specify the OAuth2 scopes you want
        //        string[] scopes = new[] { DriveService.Scope.DriveFile };
        //        string appName = "apm erp";

        //        // Authenticate
        //        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //            GoogleClientSecrets.Load(stream).Secrets,
        //            scopes,
        //            "user",
        //            CancellationToken.None).Result;
        //    }

        //    // Create Drive API service
        //    var service = new DriveService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = "apm erp",
        //    });

        //    return service;
        //}

        //private void UploadFileToGoogleDrive(string filePath)
        //{
        //    try
        //    {
        //        var driveService = GetDriveService();

        //        // Create a new file metadata object for Google Drive
        //        var fileMetadata = new Google.Apis.Drive.v2.Data.File()
        //        {
        //            Title = Path.GetFileName(filePath)
        //        };

        //        // Create the file stream
        //        using (var stream = new FileStream(filePath, FileMode.Open))
        //        {
        //            // Upload the file to Google Drive
        //            var request = driveService.Files.Insert(fileMetadata, stream, "application/octet-stream");
        //            request.Upload();
        //            MessageBox.Show("File uploaded successfully.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error uploading file: " + ex.Message);
        //    }
        //}


      //  private Dictionary<string, KeyValuePair<object, EventHandler>> controlDictionary = new Dictionary<string, KeyValuePair<object, EventHandler>>();
        private void Control_Clicks_for_label(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            ToolStripItem clickedMenuItem = sender as ToolStripItem;

            if (clickedControl != null)
            {
                // The clicked control is a Button or some other type of Control
                // Do something with the clicked control
                string controlName = clickedControl.Name;
                string controlText = clickedControl.Text;

                control_click(sender, e, "", controlName, controlText);
            }
            else if (clickedMenuItem != null)
            {
                // The clicked control is a ToolStripItem
                // Do something with the clicked ToolStripItem
                string menuItemName = clickedMenuItem.Name;
                string menuItemText = clickedMenuItem.Text;

                control_click(sender, e, "", menuItemName, menuItemText);
            }
        }
        protected void control_click(object sender, EventArgs e, object control,string controlName,string control_txt)
        {
            //string controlName = "";
            //string controlType = "";
            //string control_txt = "";

            if (control is Button)
            {
                controlName = ((Button)control).Name;
              //  controlType = "Button";
                control_txt = ((Button)control).Text;
            }
            else if (control is ToolStripItem)
            {
                controlName = ((ToolStripItem)control).Name;
             //   controlType = "ToolStripMenuItem";
                control_txt = ((ToolStripItem)control).Text;
            }

            //controlDictionary[controlName] = new KeyValuePair<object, EventHandler>(control, eventHandler);

            //string eventName = eventHandler.Method.Name;

            
            freq_tableTableAdapter1.FillBy_control_txt_and_user(dataSet11.freq_table, control_txt, usertxt.Text);
            if (dataSet11.freq_table.Rows.Count > 0)
            {
                freq_tableTableAdapter1.Update_count(control_txt, usertxt.Text);
            }
            else 
            {
                freq_tableTableAdapter1.Insert(controlName, "", "", 1, control_txt, usertxt.Text);
              
            }
            
            freq_tableTableAdapter1.FillBy_user(dataSet11.freq_table, usertxt.Text);
           // arrange_flowlayoutpanel(flowLayoutPanel3, dataGridView1);

        }
      private void arrange_flowlayoutpanel(FlowLayoutPanel flp, DataGridView dgv)
        {
            freq_tableTableAdapter1.FillBy_user(dataSet11.freq_table, usertxt.Text);

            int minSize = 100;
            int maxSize = 130;
            int minFontSize = 12;
            int maxFontSize = 15;
            Color[] colorPalette = new Color[]
{
    Color.FromArgb(47, 79, 79),
    Color.FromArgb(128, 0, 0),
    Color.FromArgb(165, 42, 42),
    Color.FromArgb(178, 34, 34),
    Color.FromArgb(139, 0, 0),
    Color.FromArgb(205, 92, 92),
    Color.FromArgb(255, 99, 71),
    Color.FromArgb(255, 69, 0),
    Color.FromArgb(255, 140, 0),
    Color.FromArgb(218, 165, 32),
    Color.FromArgb(255, 215, 0),
    Color.FromArgb(184, 134, 11),
    Color.FromArgb(218, 165, 32),
    Color.FromArgb(238, 232, 170),
    Color.FromArgb(189, 183, 107),
    Color.FromArgb(154, 205, 50),
    Color.FromArgb(0, 128, 0),
    Color.FromArgb(34, 139, 34),
    Color.FromArgb(60, 179, 113),
    Color.FromArgb(46, 139, 87),
    Color.FromArgb(0, 255, 127),
    Color.FromArgb(0, 206, 209),
    Color.FromArgb(72, 209, 204),
    Color.FromArgb(0, 191, 255),
    Color.FromArgb(30, 144, 255),
    Color.FromArgb(65, 105, 225),
    Color.FromArgb(72, 61, 139),
    Color.FromArgb(0, 0, 205),
    Color.FromArgb(138, 43, 226),
    Color.FromArgb(148, 0, 211)
};
            Random random = new Random();
            flp.Controls.Clear();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                try
                {
                    string controlName = row.Cells[0].Value.ToString();
                    string controlText = row.Cells[4].Value.ToString();
                    foreach (ToolStripMenuItem s in this.menuStrip1.Items)
                    {
                        Random rnd = new Random();
                        if (s.HasDropDownItems)
                        {
                            foreach (ToolStripDropDownItem sub in s.DropDownItems)
                            {
                                if (sub.Text == controlText)
                                {
                                    ToolStripDropDownItem currentSub = sub;
                                    Button button = new Button();
                                    button.Name = controlName;
                                    button.Text = controlText;
                                    int size = random.Next(minSize, maxSize + 1);
                                    button.Size = new Size(size, size);
                                    int fontSize = random.Next(minFontSize, maxFontSize + 1);
                                    button.Font = new Font(button.Font.FontFamily, fontSize, FontStyle.Regular);
                                    int colorIndex = random.Next(colorPalette.Length);
                                    Color color = colorPalette[colorIndex];
                                    button.BackColor = color;
                                    button.ForeColor = Color.Black;
                                    button.FlatStyle = FlatStyle.Flat;
                                    button.Cursor = Cursors.Hand;
                                    // button.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
                                    button.ForeColor = Color.White;
                                    button.FlatAppearance.BorderSize = 0;
                                    button.TextAlign = ContentAlignment.BottomCenter;
                                    button.Click += (sender, e) => currentSub.PerformClick();

                                    button.TextImageRelation = TextImageRelation.ImageAboveText;

                                    string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + s.Text + ".png";
                                    Image img = Image.FromFile(path);
                                    button.Image = new Bitmap(img, new Size(size / 4, size / 4)); // set the size of the image here
                                    button.ImageAlign = ContentAlignment.MiddleCenter;
                                    button.TextImageRelation = TextImageRelation.ImageAboveText;

                                    button.MouseEnter += (sender, e) =>
                                    {
                                        // Change the button's background color when the mouse enters
                                        Color hoverColor = ControlPaint.Dark(button.BackColor);
                                        button.BackColor = hoverColor;
                                        button.Size = new Size(size + 20, size + 20);
                                   

                                    };

                                    button.MouseLeave += (sender, e) =>
                                    {
                                        // Change the button's background color back to its original color when the mouse leaves
                                        button.BackColor = color;
                                        button.Size = new Size(size, size);
                                    };


                                    // button.ImageScaling = PictureBoxSizeMode.Zoom;
                                    flp.Controls.Add(button);
                                    // colorPalette = colorPalette.Where((c, i) => i != colorIndex).ToArray();
                                }
                            }
                        }
                    }
                }
                catch { }
            }
        }
    

        private void timer_freq_Tick(object sender, EventArgs e)
        {
           // MessageBox.Show("aaa");
            if (Form1.ActiveForm == this && this.TopMost)
            {
                arrange_flowlayoutpanel(flowLayoutPanel3, dataGridView1);
               // MessageBox.Show("aaa");
            }
        }

        private void فاتورةاستلامصيانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syana_fatora s = new syana_fatora();
            s.Text = "فاتورة استلام صيانة";
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();
        }

        private void تسليمصيانةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tasleem_syana t = new tasleem_syana();
            t.usertxt.Text = usertxt.Text;
            t.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(t);
            ApplyFormStyling(t);
            t.ShowDialog();
        }

        

        private void مسحوباتالصيانةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mas7obat_syana m = new mas7obat_syana();
            SubscribeToLoadEvent(m);
            ApplyFormStyling(m);
            m.ShowDialog();
        }

        private void تقاريرالصيانةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            syana_reports s = new syana_reports();
            s.usertxt.Text = usertxt.Text;
            s.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ////reb7_old();
            //MessageBox.Show("aaa");
            //DiscoverForms();
            //MessageBox.Show(allForms.Count.ToString());

            //richTextBox1.Clear();

            //// Extract control info from all forms and append to RichTextBox
            //foreach (Form form in allForms)
            //{
            //    ExtractControlInfo(form, richTextBox1);
            //}
        }
        private List<Form> allForms = new List<Form>();
        private void DiscoverForms()
        {
            try
            {
                IEnumerable<Form> forms = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(type => type.IsSubclassOf(typeof(Form)) && type.GetConstructor(Type.EmptyTypes) != null)
                    .Select(type => Activator.CreateInstance(type) as Form);

                allForms.AddRange(forms.Where(form => form != null));
            }
            catch (Exception ex)
            {
                // Handle or log the exception appropriately
                MessageBox.Show("Error discovering forms: " + ex.Message);
            }
        }

        private void ExtractControlInfo(Control container, RichTextBox richTextBox, int depth = 0, int maxDepth = 20)
        {
            //MessageBox.Show("eeeeee");
            if (depth >= maxDepth)
            {
                return; // Add a depth limit to prevent stack overflow
            }
            
            foreach (Control control in container.Controls)
            {
                MessageBox.Show(control.Text);
                // Append control name and text to RichTextBox
                if (!string.IsNullOrEmpty(control.Text))
                {
                    richTextBox.AppendText(control.Text + Environment.NewLine);
                }

                // If the control has child controls, recursively call the method
                if (control.HasChildren)
                {
                    ExtractControlInfo(control, richTextBox, depth + 1, maxDepth);
                }

                // If the control is a container (e.g., GroupBox), recursively call the method
                ContainerControl containerControl = control as ContainerControl;
                if (containerControl != null)
                {
                    ExtractControlInfo(containerControl, richTextBox, depth + 1, maxDepth);
                }

                // Check if the control is a MenuStrip
                if (control is MenuStrip)
                {
                    MenuStrip menuStrip = (MenuStrip)control;
                    richTextBox.AppendText(menuStrip.Name + Environment.NewLine);

                    foreach (ToolStripItem item in menuStrip.Items)
                    {
                        if (item is ToolStripMenuItem)
                        {
                            // Call ExtractToolStripMenuItemInfo if needed
                            // ExtractToolStripMenuItemInfo(toolStripMenuItem, richTextBox);
                        }
                    }
                }
            }
        }

        private void اضافةمسئولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_resp ar = new add_resp();
            ar.Text = "اضافة مسئول";
            ar.usertxt.Text = usertxt.Text;
            ar.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(ar);
            ApplyFormStyling(ar);
            ar.Show();
        }

        private void قائمةالمسئولينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resp_list rl = new resp_list();
            rl.Text = "قائمة المسئولين";
            rl.usertxt.Text = usertxt.Text;
            rl.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(rl);
            ApplyFormStyling(rl);
            rl.Show();
        }

        private void مستحقاتالمسئولينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DoSomethingAfterComponentsAreLoaded();

            backgroundWorker_delete_old_backup.RunWorkerAsync();
        }
        private void DoSomethingAfterComponentsAreLoaded()
        {

            string short_cuts_ = System.IO.File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\shorts.txt").First();
            if (short_cuts_.Contains("متغيرة"))
            {

                flowLayoutPanel3.Visible = true;
                flowLayoutPanel1.Visible = false;
                flowLayoutPanel2.Visible = false;
                pictureBox2.Visible = false;
                freq_tableTableAdapter1.FillBy_user(dataSet1.freq_table, usertxt.Text);

                arrange_flowlayoutpanel(flowLayoutPanel3, dataGridView1);

            }
            else
            {
                flowLayoutPanel3.Visible = false;
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel2.Visible = true;
                pictureBox2.Visible = true;
                buttons_colors();

                pictureBox2.Width = this.Width - flowLayoutPanel1.Width - flowLayoutPanel2.Width - 200;
                pictureBox2.Height = this.Height - menuStrip1.Height - pictureBox1.Height - statusStrip1.Height-200;
                int centerX = (this.Width - pictureBox2.Width+flowLayoutPanel1.Width-flowLayoutPanel2.Width) / 2;
                int centerY = flowLayoutPanel2.Location.Y+20;// (this.Height - pictureBox2.Height + menuStrip1.Height) / 2;

                pictureBox2.Location = new Point(centerX, centerY);
            }

            timer2.Stop();
            try
            {
                mas7obat_tableTableAdapter1.Update_where_unit_price_is_null();
            }
            catch { }
            //  check_pro_codes();

            foreach (ToolStripMenuItem t in menuStrip1.Items)
            {
                //
                try
                {
                    string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\" + t.Text + ".png";

                    t.Image = Image.FromFile(path);
                    // MessageBox.Show(t.Text);
                }
                catch { }
                t.TextImageRelation = TextImageRelation.ImageAboveText;
            }

            try
            {
                string home_pic = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\home_pic.png";

                pictureBox2.Image = Image.FromFile(home_pic);
            }
            catch
            {
                pictureBox2.Visible = false;
            }
            user_prev_excute();


            safeTableAdapter1.Fill(dataSet11.safe);
            if (dataSet11.safe.Rows.Count <= 0)
            {
                safeTableAdapter1.Insert(0, DateTime.Today, 0);
            }

            numbers_tableTableAdapter1.Fill(dataSet11.Numbers_table);
            if (dataSet11.Numbers_table.Rows.Count <= 0)
            {
                stock_tableTableAdapter1.Fill(dataSet11.stock_table);
                if (dataSet11.stock_table.Rows.Count == 1)
                {
                    ادارةالتحويلاتToolStripMenuItem.Visible = false;
                }

            }
            numbers_tableTableAdapter1.FillBy_stock(dataSet11.Numbers_table, far3txt.Text);
            if (dataSet11.Numbers_table.Rows.Count <= 0)
            {
                numbers_tableTableAdapter1.Insert(1, 1, 1, 1, far3txt.Text, 1, 1, 1, 1);
            }
            else
            {
                int sales_id; int purchases_ID; int syana_ID; int mas7obat_ID; int amr_sh3l_id; int tawreedat_ID; int tas3eer_ID;
                try
                {
                    sales_id = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["sales_ID"]);
                }
                catch
                {
                    sales_id = 1;
                }
                try
                {
                    purchases_ID = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["purchases_ID"]);
                }
                catch
                {
                    purchases_ID = 1;
                }
                try
                {
                    syana_ID = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["syana_ID"]);
                }
                catch
                {
                    syana_ID = 1;
                }
                try
                {
                    mas7obat_ID = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["mas7obat_ID"]);
                }
                catch
                {
                    mas7obat_ID = 1;
                }
                try
                {
                    amr_sh3l_id = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["amr_sh3l_id"]);
                }
                catch
                {
                    amr_sh3l_id = 1;
                }

                try
                {
                    tawreedat_ID = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["tawreedat_ID"]);
                }
                catch
                {
                    tawreedat_ID = 1;
                }
                try
                {
                    tas3eer_ID = Convert.ToInt32(dataSet11.Numbers_table.Rows[0]["tas3eer_ID"]);
                }
                catch
                {
                    tas3eer_ID = 1;
                }
                numbers_tableTableAdapter1.Update_numbers_in_case_by_stock(sales_id, purchases_ID, syana_ID, mas7obat_ID, amr_sh3l_id, tawreedat_ID, tas3eer_ID, far3txt.Text);
            }

            ta2feel_tableTableAdapter1.Fill(dataSet11.ta2feel_table);
            if (dataSet11.ta2feel_table.Rows.Count <= 0)
            {
                ta2feel_tableTableAdapter1.Insert(Convert.ToDateTime("1-1-2000"), 0);
            }

            pharmacy_dataTableAdapter1.Fill(dataSet11.pharmacy_data);
            if (dataSet11.pharmacy_data.Rows.Count <= 0)
            {
                System.IO.MemoryStream defaultImageStream = new System.IO.MemoryStream();
                Bitmap img = new Bitmap(Properties.Resources.blank_white);
                Image b = (Image)img;
                b.Save(defaultImageStream, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] defaultImageData = new byte[defaultImageStream.Length];
                //assign byte array the content of image
                defaultImageData = defaultImageStream.ToArray();
                pharmacy_dataTableAdapter1.Insert("", "", "", "", "", "", defaultImageData, "", "", "", "");
            }
            //    MessageBox.Show("ss");
            try
            {
                ph_name = dataSet11.pharmacy_data.Rows[0]["pharmacy_name"].ToString();
            }
            catch { }


            points_definition_tableTableAdapter1.Fill(dataSet11.points_definition_table);
            if (dataSet11.points_definition_table.Rows.Count <= 0) 
            {
                points_definition_tableTableAdapter1.InsertQuery(0, 0, 0, 0, "");
            }

            ras_mal_method();
            this.ras_mal_productsTableAdapter1.Fill(dataSet11.ras_mal_products);
            RefreshCategoriesAsync();
            //try
            //{
            stock_tableTableAdapter1.Fill(dataSet11.stock_table);
            // MessageBox.Show(dataSet11.stock_table.Rows.Count.ToString());
            if (dataSet11.stock_table.Rows.Count == 1)
            {
                products_tableTableAdapter1.Update_stock_for_all(dataSet11.stock_table.Rows[0]["stock_name"].ToString());
            }
            //}
            //catch { }


            backgroundWorker_nwa2es.RunWorkerAsync();
        }

        private void عرضالملفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_files s = new show_files();

           

            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);


            s.ShowDialog();
        }

      

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void بيانحالةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loan_aksat_show l = new loan_aksat_show();

            SubscribeToLoadEvent(l);
            ApplyFormStyling(l);
            l.user_txt.Text = usertxt.Text;
            l.far3_txt.Text = far3txt.Text;
            l.Text = "بيان حالة عميل";
            l.Show(); Control_Clicks_for_label(sender, e);
        }

        private void العملياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loans_under_revision lu = new loans_under_revision();
            SubscribeToLoadEvent(lu);
            ApplyFormStyling(lu);
            lu.Text = "طلبات تقسيط تم الصرف";
            lu.user_txt.Text = usertxt.Text;
            lu.far3_txt.Text = far3txt.Text;
            lu.title_txt.Text = "تم الصرف";
            lu.Show(); Control_Clicks_for_label(sender, e);
        }

        private void سدادقسطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pay_kest p = new pay_kest();
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.user_txt.Text = usertxt.Text;
            p.far3_txt.Text = far3txt.Text;
            p.Show(); Control_Clicks_for_label(sender, e);
        }

        private void حذفقسطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_kest d = new delete_kest();
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.user_txt.Text = usertxt.Text;
            d.far3_txt.Text = far3txt.Text;
            d.Show();
        }

        private void الأقساطالمتأخرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delayed_aksat_form d = new delayed_aksat_form();
            d.user_txt.Text = usertxt.Text;
            d.far3txt.Text = far3txt.Text;
            d.Text = "الاقساط المتأخرة";
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.Show(); Control_Clicks_for_label(sender, e);
        }

        private void نموذجمعرفةالاقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_loan_request cc = new create_loan_request();
            cc.Text = "نموذج معرفة الاقساط";
            cc.user_txt.Text = usertxt.Text;
            //cc.cst_name_txt.Text = cst_nameTXT.Text;
            //cc.cst_code_txt.Text = cst_code.Text;
            cc.far3_txt.Text = far3txt.Text;
            //   cc.requested_amount_txt.Text = (Convert.ToDecimal(matloobTXT.Text) - Convert.ToDecimal(madfoo3TXT.Text)).ToString();
            SubscribeToLoadEvent(cc);
            ApplyFormStyling(cc);
            cc.Show();
            Control_Clicks_for_label(sender, e);
        }

        private void الأقساطالمسددةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delayed_aksat_form d = new delayed_aksat_form();
            d.user_txt.Text = usertxt.Text;
            d.Text = "الاقساط المسددة";
            d.far3txt.Text = far3txt.Text;
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.Show(); Control_Clicks_for_label(sender, e);
        }

        private void سدادمبكرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sadad_mo3agal s = new sadad_mo3agal();
            s.user_txt.Text = usertxt.Text;
            s.far3_txt.Text = far3txt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.Show(); Control_Clicks_for_label(sender, e);
        }

        private void العملياتالمنتهيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loans_under_revision lu = new loans_under_revision();
            SubscribeToLoadEvent(lu);
            ApplyFormStyling(lu);
            lu.Text = "طلبات تقسيط منتهية";
            lu.user_txt.Text = usertxt.Text;
            lu.far3_txt.Text = far3txt.Text;
            lu.title_txt.Text = "متسرب";
            lu.Show(); Control_Clicks_for_label(sender, e);
        }

        private void إضافةعرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
           add_promotion a = new add_promotion();
           a.Text = "إضافة عرض";
           SubscribeToLoadEvent(a);
           ApplyFormStyling(a);
           a.Show(); Control_Clicks_for_label(sender, e);
        }

        private void قائمةالعروضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            promotions_list p = new promotions_list();
            p.Text = "قائمة العروض";
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.Show(); Control_Clicks_for_label(sender, e);
            
        }

        private void تعريفالنقاطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points_def_formcs p = new points_def_formcs();
            p.Text = "تعريف النقاط";
            SubscribeToLoadEvent(p);
            ApplyFormStyling(p);
            p.ShowDialog(); Control_Clicks_for_label(sender, e);

        }

        private void نقاطالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customers_points cp = new customers_points();
            cp.Text = "نقاط العملاء";
            SubscribeToLoadEvent(cp);
            ApplyFormStyling(cp);
            cp.ShowDialog(); Control_Clicks_for_label(sender, e);

        }

        private void صرفنسبةادارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sarf_nesba_edara s = new sarf_nesba_edara();
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            SubscribeToLoadEvent(s);
            ApplyFormStyling(s);
            s.ShowDialog(); Control_Clicks_for_label(sender, e);
        }

        private void backgroundWorker_delete_old_backup_DoWork(object sender, DoWorkEventArgs e)
        {
            get_partition();
            CleanOldBackups(backup_partition + @"\backup\");
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.U)
            {
                تغييرالمستخدمToolStripMenuItem.PerformClick();
                e.SuppressKeyPress = true; // Optional: prevent further handling
            }

        }

        private void إحصائياتالأقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aksat_summary_form d = new aksat_summary_form();
            d.user_txt.Text = usertxt.Text;
            d.far3txt.Text = far3txt.Text;
            d.Text = "إحصائيات الأقساط";
            SubscribeToLoadEvent(d);
            ApplyFormStyling(d);
            d.Show(); Control_Clicks_for_label(sender, e);
        }

        private void طباعةالجردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            products_print p = new products_print();
            p.Text = "طباعة الجرد";
            p.froo3_txt.Text = far3txt.Text;
            p.ShowDialog();
        }

        string path_for_google_drive_upload;
        string uploadedUserEmail = "";

       private void backgroundWorker1_google_drive_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Show and reset progress bar
                progressBar1.Invoke(new Action(() => {
                    progressBar1.Value   = 0;
                    progressBar1.Visible = true;
                }));

                var clientSecrets = new ClientSecrets
                {
                    ClientId     = "86632382867-r5mh7onqja6mgd05cfp0cpb8i390955k.apps.googleusercontent.com",
                    ClientSecret = "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"
                };

                string credentialPath = Path.Combine(Application.StartupPath, "google_token");
                var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    new[] { DriveService.Scope.DriveFile },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credentialPath, true)
                ).Result;

                // Create Drive service
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName       = "Google Drive File Upload"
                });

                // Get the actual Gmail address
                var about = service.About.Get().Execute();
                string email = about.User.EmailAddress;

                // Prepare upload
                var fileMetadata = new Google.Apis.Drive.v2.Data.File()
                {
                    Title = Path.GetFileName(path_for_google_drive_upload)
                };

                FilesResource.InsertMediaUpload request;
                using (var stream = new FileStream(path_for_google_drive_upload, FileMode.Open, FileAccess.Read))
                {
                    request = service.Files.Insert(fileMetadata, stream, GetMimeType(path_for_google_drive_upload));

                    // Progress handler
                    request.ProgressChanged += prog =>
                    {
                        if (prog.Status == UploadStatus.Uploading)
                        {
                            int percent = (int)((prog.BytesSent * 100L) / stream.Length);
                            if (percent < 0)   percent = 0;
                            if (percent > 100) percent = 100;

                            progressBar1.Invoke(new Action(() =>
                            {
                                progressBar1.Value = percent;
                                using (Graphics g = progressBar1.CreateGraphics())
                                {
                                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                    string text = @"{email} - {percent}%";
                                    var font = new Font("Segoe UI", 8, FontStyle.Regular);
                                    var size = g.MeasureString(text, font);
                                    var x = (progressBar1.Width  - size.Width ) / 2;
                                    var y = (progressBar1.Height - size.Height) / 2;
                                    g.Clear(this.BackColor);
                                    g.FillRectangle(Brushes.LightGreen, 0, 0, progressBar1.Width * percent / 100, progressBar1.Height);
                                    g.DrawString(text, font, Brushes.Black, x, y);
                                }
                            }));
                        }
                    };

                    // Perform upload
                    var status = request.Upload();

                    // Ensure bar reaches 100%
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Value = progressBar1.Maximum;
                    }));

                    // Success or failure
                    if (status.Status == UploadStatus.Completed)
                        MessageBox.Show("تم رفع النسخه الاحتياطيه لجوجل درايف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("فشل رفع الملف: " + status.Exception.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Hide progress bar when done
                progressBar1.Invoke(new Action(() => progressBar1.Visible = false));
            }
        }


       

        
       
    }
}
