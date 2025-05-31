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
    public partial class close_form : Form
    {
        public close_form()
        {
            InitializeComponent();
        }

        private void close_form_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
