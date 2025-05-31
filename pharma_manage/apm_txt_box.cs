using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pharma_manage
{
    public partial class apm_txt_box : UserControl
    {
        public apm_txt_box()
        {
            InitializeComponent();
        }
        private TextBox txt_box;
        public TextBox TXT_BOX
        {
            get
            {
                return txt_box = textBox1;
            }
            set
            {
                txt_box = textBox1;
            }
        }

        private ListBox lst_box;
        public ListBox LST_BOX
        {
            get
            {
                return lst_box = listBox1;
            }
            set
            {
                lst_box = listBox1;
            }
        }

        private void apm_txt_box_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                listBox1.Visible = false;
            }
            else 
            {
                listBox1.Visible = true;
            }
        }

        ListBox src_listbox = new ListBox();

        private ListBox src_list;
        public ListBox SRC_LIST
        {
            get
            {
                return src_list = src_listbox;
            }
            set
            {
                src_list = src_listbox;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Focused == true)
            {
                listBox1.Items.Clear();
                foreach (var item in src_list.Items)
                {
                    if (item.ToString().Contains(textBox1.Text))
                    {
                        // m.MenuItems.Add(item.ToString());
                        listBox1.Items.Add(item.ToString());

                        //MenuItem mi = new MenuItem();
                        //mi.Text = item.ToString();
                        //mi.Name = item.ToString();
                        //mi.Click += new EventHandler(delegate(object ss, EventArgs ee) { btn_click(sender, e, textBox2, mi); });

                        //m.MenuItems.Add(mi);


                    }

                }

                if (textBox1.Text == "")
                {
                    listBox1.Visible = false;
                }
                else
                {
                    listBox1.Visible = true;
                    //  this.Height = listBox1.Items.Count * listBox1.ItemHeight;
                }
                the_last_selected_item = 0;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
              
                if (this.listBox1.Items.Count > 0)
                {
                    
                    if (the_last_selected_item == 0)
                    {
                        this.listBox1.SelectedIndex = 0;
                        the_last_selected_item = 0;
                        textBox1.Text = listBox1.Items[0].ToString();
                    }
                    else 
                    {
                        this.listBox1.SelectedIndex = the_last_selected_item;
                    }
                }
            }
        }
       int the_last_selected_item;
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                //try
                //{
                    this.listBox1.SelectedIndex = the_last_selected_item;
                    textBox1.Text = listBox1.Items[listBox1.SelectedIndex + 1].ToString(); //listBox1.SelectedItem.ToString();

                   the_last_selected_item = listBox1.SelectedIndex + 1;

                  
                //}
                //catch { }
            }
            else if (e.KeyCode == Keys.Up)
            {
                //listBox1.Focus();
                
                textBox1.Text = listBox1.Items[listBox1.SelectedIndex - 1].ToString(); //

                the_last_selected_item = listBox1.SelectedIndex - 1;

            }
            else if((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z))//|| (e.KeyCode <= Keys.))
            {
                textBox1.Text = textBox1.Text + " ";
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;

                //MessageBox.Show(e.KeyValue.ToString());
                //SendKeys.Send(e.KeyValue.ToString());
            }

            else if ((e.KeyCode >= Keys.Back))//|| (e.KeyCode <= Keys.))
            {
                textBox1.Text = textBox1.Text + " ";
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;

                //MessageBox.Show(e.KeyValue.ToString());
                //SendKeys.Send(e.KeyValue.ToString());
            }
        }

    }
}
