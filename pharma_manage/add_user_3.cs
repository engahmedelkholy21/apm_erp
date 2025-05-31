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
    public partial class add_user_3 : Form
    {
        public add_user_3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void add_user_Load(object sender, EventArgs e)
        {
            this.stock_tableTableAdapter.Fill(this.dataSet11.stock_table);
            Form1 f = new Form1();
            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            {
                if (s.HasDropDownItems)
                {
                    TableLayoutPanel g = new TableLayoutPanel();
                    g.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    g.ColumnCount = 1;
                    g.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    g.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    g.AutoSize = true;
                    g.Font = new Font(g.Font.FontFamily, 12);

                    CheckBox check_all = new CheckBox();
                    check_all.AutoSize = true;
                    check_all.ForeColor = Color.White;
                    check_all.Name = s.Text;
                    check_all.Text = s.Text;
                    check_all.Appearance = System.Windows.Forms.Appearance.Button;
                    check_all.FlatStyle = FlatStyle.Flat;
                    check_all.FlatAppearance.BorderSize = 0;
                    check_all.BackColor = Color.FromArgb(64, 64, 64);
                    check_all.FlatAppearance.CheckedBackColor = Color.Green;
                    check_all.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                    check_all.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);

                    g.Controls.Add(check_all, 0, 0);
                    g.SetColumnSpan(check_all, 2);

                    int row = 1;
                    foreach (ToolStripDropDownItem sub in s.DropDownItems)
                    {
                        CheckBox cc = new CheckBox();
                        cc.AutoSize = true;
                        cc.ForeColor = Color.White;
                        cc.Name = sub.Name;
                        cc.Text = sub.Text;
                        cc.Font = new Font("Arial", 13, FontStyle.Bold);
                        cc.Appearance = System.Windows.Forms.Appearance.Button;
                        cc.FlatStyle = FlatStyle.Flat;
                        cc.FlatAppearance.BorderSize = 0;
                        cc.BackColor = Color.FromArgb(64, 64, 64);
                        cc.FlatAppearance.CheckedBackColor = Color.Green;
                        cc.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
                        cc.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);

                        g.Controls.Add(cc, 0, row);

                        row++;
                    }

                    g.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    for (int i = 0; i < row; i++)
                    {
                        g.RowStyles.Add(new RowStyle(SizeType.AutoSize));
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

