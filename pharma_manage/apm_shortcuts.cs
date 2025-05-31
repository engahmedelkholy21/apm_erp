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
    public partial class apm_shortcuts : UserControl
    {
        public apm_shortcuts()
        {
            InitializeComponent();
        }

        private Button bee3_btn;
        public Button BEE3_BTN
        {
            get
            {
                return bee3_btn = button1;
            }
            set
            {
                bee3_btn = button1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Text = "فاتورة بيع";
            s.far3txt.Text = far3txt.Text;
            s.usertxt.Text = usertxt.Text;
            //foreach (var item in category_list.Items)
            //{
            //    s.category_list.Items.Add(item.ToString());
            //}
            s.Show();
        }

        private void apm_shortcuts_Load(object sender, EventArgs e)
        {
            foreach (Panel fl in flowLayoutPanel_home.Controls.OfType<Panel>())
            {
                foreach (Button b in fl.Controls.OfType<Button>())
                {
                    //MessageBox.Show(b.Text);
                    b.Cursor = Cursors.Hand;
                    b.MouseEnter +=  Mouse_enter_method;
                    b.MouseLeave +=Mouse_leave_method;
                    if (b.Text == "فاتورة بيع")
                    {
                        b.Image = Properties.Resources.sell_stable;
                    }
                    else if (b.Text == "تقارير المبيعات")
                    {
                        b.Image = Properties.Resources.sales_stable;
                    }
                }

            }
        }

        


        private void Mouse_enter_method(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.Width += 10;
            b.Height += 10;
            b.FlatAppearance.BorderSize = 5;
            b.FlatAppearance.BorderColor = Color.White;
            if (b.Text == "فاتورة بيع")
            {
                b.Image = Properties.Resources.sell_gif;
            }
            else if (b.Text == "تقارير المبيعات")
            {
                b.Image = Properties.Resources.sales_gif;
            }
        }
       private void Mouse_leave_method(object sender, EventArgs e) 
        {
            Button b = sender as Button;
            b.Width -= 10;
            b.Height -= 10;
            b.FlatAppearance.BorderSize = 0; 
           if (b.Text == "فاتورة بيع")
            {
                b.Image = Properties.Resources.sell_stable;
            }
           else if (b.Text == "تقارير المبيعات")
           {
               b.Image = Properties.Resources.sales_stable;
           }
           // b.FlatAppearance.BorderColor = Color.AliceBlue;
        }

      
    }
}
