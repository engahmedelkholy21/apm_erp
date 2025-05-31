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
    public partial class show_picture_form : Form
    {
        public show_picture_form()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SubscribeToLoadEvent(this);
            f1.ApplyFormStyling(this);
        }

        private void show_picture_form_Load(object sender, EventArgs e)
        {
           
                   
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = flipImage;
        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = flipImage;
        }

        private void show_picture_form_Shown(object sender, EventArgs e)
        {
             //try
            //{
            products_tableTableAdapter1.FillBy_name(dataSet11.products_table, name_txt.Text);
            //MessageBox.Show(dataSet11.products_table.Rows[0]["pro_mwared"].ToString() + dataSet11.products_table.Rows[0]["pro_mwared"].ToString().Length);
            try
            {
                pictureBox1.Image = Image.FromFile(dataSet11.products_table.Rows[0]["pro_mwared"].ToString());
            }
            catch { }
            right_btn.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\right.png";
            left_btn.ImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\icons\\left.png";

            //}
            //catch { }
        }
    }
}
