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
    public partial class show_users_2 : Form
    {
        public show_users_2()
        {
            InitializeComponent();
        }

        private void usernameTXT_TextChanged(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            ListBox l = new ListBox();
            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            {

                if (s.HasDropDownItems)
                {
                    foreach (ToolStripDropDownItem sub in s.DropDownItems)
                    {
                        l.Items.Add(sub.Name);
                    }
                }
            }
           // try
            //{
            //    user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, usernameTXT.Text);
            //    foreach (DataRow dr in dataSet11.user_previliges.Rows)
            //    {
            //        if (l.Items.Contains(dr["user_previliges"].ToString()))
            //        {
            //            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            //            {

            //                if (s.HasDropDownItems)
            //                {
            //                    foreach (ToolStripDropDownItem sub in s.DropDownItems)
            //                    {
            //                        if (sub.Name == dr["user_previliges"].ToString())
            //                        {
            //                            dataGridView1.Rows.Add(sub.Text);
            //                        }
            //                    }

            //                }
            //            }
            //        }
            //    }
            //}
            //catch { }
        }
        string user_name;
        string password;
        string far3;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (FlowLayoutPanel f in flowPanel_subItems.Controls)
            {
                foreach (CheckBox c in f.Controls)
                {
                    c.Checked = false;
                }
            }
             user_name = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            usernameTXT.Text = user_name;
            user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, user_name);
            password = dataSet11.user_previliges.Rows[0]["password"].ToString();
            far3 = dataSet11.user_previliges.Rows[0]["user_far3"].ToString();
            foreach (DataRow dr in dataSet11.user_previliges.Rows)
            {
                foreach (FlowLayoutPanel f in flowPanel_subItems.Controls)
                {
                    foreach (CheckBox c in f.Controls)
                    {
                       // c.Enabled = false;
                        if (c.Text == dr["user_previliges"].ToString())
                        {
                            c.Checked = true;
                        }
                    }
                }
            }


            //Form1 f = new Form1();
            //ListBox l = new ListBox();
            //foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            //{

            //    if (s.HasDropDownItems)
            //    {
            //        foreach (ToolStripDropDownItem sub in s.DropDownItems)
            //        {
            //            l.Items.Add(sub.Name);
            //        }
            //    }
            //}
            //try
            //{
            //    user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, user_name);
            //    dataGridView1.Rows.Clear();
            //    foreach (DataRow dr in dataSet11.user_previliges.Rows)
            //    {
            //        if (l.Items.Contains(dr["user_previliges"].ToString()))
            //        {
            //            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            //            {

            //                if (s.HasDropDownItems)
            //                {
            //                    foreach (ToolStripDropDownItem sub in s.DropDownItems)
            //                    {
            //                        if (sub.Name == dr["user_previliges"].ToString())
            //                        {
            //                            dataGridView1.Rows.Add(sub.Text);
            //                        }
            //                    }

            //                }
            //            }
            //        }
            //    }
            //}
            //catch { }
        }

        private void show_users_Load(object sender, EventArgs e)
        {
            if (type_txt.Text == "تعديل")
            {
                add_btn.Visible = true;
            }
            else 
            {
                add_btn.Visible = false;
            }
            this.user_previligesTableAdapter1.Fill(this.dataSet1.user_previliges);
            ListBox l = new ListBox();
            foreach (DataRow dr in dataSet1.user_previliges.Rows)
            {
                if (l.Items.Contains(dr["user_name"].ToString()))
                {

                }
                else
                {
                    l.Items.Add(dr["user_name"].ToString());
                }
            }

            foreach (var item in l.Items)
            {
                dataGridView2.Rows.Add(item.ToString());
            }
            suggest_un();



            ///////////////
            Form1 f = new Form1();
            foreach (ToolStripMenuItem s in f.menuStrip1.Items)
            {
                Random rnd = new Random();

                if (s.HasDropDownItems)
                {
                    FlowLayoutPanel g = new FlowLayoutPanel();
                    g.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    g.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    //  g.AutoSize = true;
                    g.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    g.Text = s.Text;
                    //g.Width = 1300;
                    //g.Height = 40;
                    g.AutoSize = true;
                    g.FlowDirection = FlowDirection.TopDown;
                    g.Font = new Font(g.Font.FontFamily, 12);
                    //FlowLayoutPanel ff = new FlowLayoutPanel();
                    CheckBox check_all = new CheckBox();
                    check_all.AutoSize = true;
                    check_all.ForeColor = Color.White;
                    check_all.Name = "all_check";
                    //check_all.CheckedChanged += new System.EventHandler(check_all_changed);
                    check_all.Text = "الكل";
                    Color randomColor = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));


                    g.BackColor = randomColor;

                  //  g.Controls.Add(check_all);
                    foreach (ToolStripDropDownItem sub in s.DropDownItems)
                    {
                        CheckBox cc = new CheckBox();
                        cc.Name = sub.Name;
                        cc.Text = sub.Text;

                        cc.Appearance = System.Windows.Forms.Appearance.Button;
                        
                        cc.AutoSize = true;
                      
                        cc.BackColor = System.Drawing.Color.Red;
                        cc.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        cc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
                        cc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        cc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
                        cc.Cursor = Cursors.Hand;

                       
                        // cc.Size = new System.Drawing.Size(120, 40);


                        cc.UseVisualStyleBackColor = false;



                      
                       
                        cc.ForeColor = Color.White;

                        cc.Font = new Font("Arial", 13, FontStyle.Bold);
                        g.Controls.Add(cc);


                    }

                    flowPanel_subItems.Controls.Add(g);
                    FlowLayoutPanel btn = new FlowLayoutPanel();
                    btn.BackColor = Color.Transparent;
                    btn.Width = 30;
                    btn.Height = 10;

                    flowPanel_subItems.Controls.Add(btn);

                }

                

            }
            ///////////

        }
        private void suggest_un()
        {
            this.user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);
            usernameTXT.AutoCompleteMode = AutoCompleteMode.Suggest;
            usernameTXT.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.user_previliges.Rows)
            {
                DataCollection.Add(dr["user_name"].ToString());
            }

            usernameTXT.AutoCompleteCustomSource = DataCollection;

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            user_previligesTableAdapter1.Delete_by_name(user_name);
            foreach (FlowLayoutPanel f in flowPanel_subItems.Controls)
            {
                foreach (CheckBox c in f.Controls)
                {
                    if (c.Checked == true)
                    {
                       // listBox1.Items.Add(c.Name);
                        // usernameTXT.Text+=", "+c.Name;

                        user_previligesTableAdapter1.Insert(user_name, password, c.Text, usertxt.Text, far3);
                    }
                }
            }
            MessageBox.Show("تم التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
