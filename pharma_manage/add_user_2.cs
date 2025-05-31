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
    public partial class add_user_2 : Form
    {
        public add_user_2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void add_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.stock_table' table. You can move, or remove it, as needed.
            this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
            Form1 f = new Form1();
            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            {

                if (s.HasDropDownItems)
                {
                    FlowLayoutPanel g = new FlowLayoutPanel();
                    g.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    g.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    //  g.AutoSize = true;
                    g.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    g.Text = s.Text;
                    g.Width = 1300;
                    g.Height = 40;
                   // g.AutoSize = true;
                    g.Font = new Font(g.Font.FontFamily, 12);
                    //FlowLayoutPanel ff = new FlowLayoutPanel();
                    CheckBox check_all = new CheckBox();
                    check_all.AutoSize = true;
                    check_all.ForeColor = Color.White;
                    check_all.Name = "all_check";
                    //check_all.CheckedChanged += new System.EventHandler(check_all_changed);
                    check_all.Text = "الكل";

                    g.Controls.Add(check_all);
                    foreach (ToolStripDropDownItem sub in s.DropDownItems)
                    {
                        CheckBox cc = new CheckBox();
                        cc.AutoSize = true;
                        cc.ForeColor = Color.White;
                        cc.Name = sub.Name;
                        cc.Text = sub.Text;
                        cc.Font = new Font("Arial", 13, FontStyle.Bold);
                        g.Controls.Add(cc);
                    }

                    flowPanel_subItems.Controls.Add(g);

                }

                if (typeTXT.Text == "add")
                {
                    add_btn.Text = "إضافة المستخدم";
                }
                else if (typeTXT.Text == "edit")
                {
                    add_btn.Text = "تعديل المستخدم";
                }
               
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (FlowLayoutPanel g in flowPanel_subItems.Controls)
                {
                    foreach (CheckBox c in g.Controls)
                    {
                        if (c.Text == "الكل")
                        {
                            if (c.Checked == true)
                            {
                                foreach (CheckBox ch in g.Controls)
                                {
                                    ch.Checked = true;
                                }
                            }
                        }
                    }
                    g.BackColor = Color.CornflowerBlue;
                }
            }
            catch { }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            
            //check if user exist
            if (passwordTXT.Text == ""||confirm_password_TXT.Text=="") 
            {
                MessageBox.Show("ادخل كلمة السر وتأكيدها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                passwordTXT.Select();
                return;
            }
            this.user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);
            for (int n = 0; n < dataSet11.user_previliges.Rows.Count; ++n)
            {
                if (dataSet11.user_previliges.Rows[n]["user_name"].ToString() == usernameTXT.Text)
                {
                    MessageBox.Show("إسم المستخدم موجود بالفعل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usernameTXT.Focus();
                    return;
                }
            }


            //password and confirm password
            if (passwordTXT.Text != confirm_password_TXT.Text) 
            {
                MessageBox.Show("كلمة السر غير متطابقة . حاول مره اخري", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBox1.Items.Clear();
                  
            //foreach (CheckBox c in flowPanel_items.Controls) 
            //{
            //    if (c.Checked == true) 
            //    {
            //        listBox1.Items.Add(c.Name);
            //       // usernameTXT.Text+=", "+c.Name;

            //         user_previligesTableAdapter1.Insert(usernameTXT.Text,passwordTXT.Text,c.Name,usertxt.Text);
            //    }
            //}
            foreach (FlowLayoutPanel f in flowPanel_subItems.Controls)
            {
                foreach (CheckBox c in f.Controls)
                {
                    if (c.Checked == true)
                    {
                        listBox1.Items.Add(c.Name);
                        // usernameTXT.Text+=", "+c.Name;

                        user_previligesTableAdapter1.Insert(usernameTXT.Text, passwordTXT.Text, c.Text, user_txt.Text,stock_txt.Text);
                    }
                }
            }
            //user_previligesTableAdapter1.Insert(usernameTXT.Text, passwordTXT.Text, "safe_manage",usertxt.Text);
            MessageBox.Show("تم الاضافة بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);




            foreach (FlowLayoutPanel f in flowPanel_subItems.Controls)
            {
                foreach (CheckBox c in f.Controls)
                {
                    c.Checked = false;
                    
                }
            }
            checkBox1.Checked = false;
            usernameTXT.Clear(); passwordTXT.Clear(); confirm_password_TXT.Clear();

            //

        }

        private void add_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                foreach (var g in flowPanel_subItems.Controls.OfType<FlowLayoutPanel>())
                {

                    foreach (var c in g.Controls.OfType<CheckBox>())
                    {
                        c.Checked = true;
                    }
                }
            }
            else
            {
                foreach (var g in flowPanel_subItems.Controls.OfType<FlowLayoutPanel>())
                {

                    foreach (var c in g.Controls.OfType<CheckBox>())
                    {
                        c.Checked = false;
                    }
                }
            }
        }

        }
    }

