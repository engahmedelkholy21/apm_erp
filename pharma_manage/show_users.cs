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
    public partial class show_users : Form
    {
        public show_users()
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
            try
            {
                user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, usernameTXT.Text);
                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {
                    if (l.Items.Contains(dr["user_previliges"].ToString()))
                    {
                        foreach (ToolStripMenuItem s in f.menuStrip1.Items)
                        {

                            if (s.HasDropDownItems)
                            {
                                foreach (ToolStripDropDownItem sub in s.DropDownItems)
                                {
                                    if (sub.Name == dr["user_previliges"].ToString())
                                    {
                                        dataGridView1.Rows.Add(sub.Text);
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string user_name = dataGridView2.CurrentRow.Cells[0].Value.ToString();

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
            try
            {
                user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, user_name);
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {
                    if (l.Items.Contains(dr["user_previliges"].ToString()))
                    {
                        foreach (ToolStripMenuItem s in f.menuStrip1.Items)
                        {

                            if (s.HasDropDownItems)
                            {
                                foreach (ToolStripDropDownItem sub in s.DropDownItems)
                                {
                                    if (sub.Name == dr["user_previliges"].ToString())
                                    {
                                        dataGridView1.Rows.Add(sub.Text);
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void show_users_Load(object sender, EventArgs e)
        {
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
    }
}
