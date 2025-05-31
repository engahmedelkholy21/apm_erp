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
    public partial class points_def_formcs : Form
    {
        public points_def_formcs()
        {
            InitializeComponent();
        }

        private void points_def_formcs_Load(object sender, EventArgs e)
        {
            id_txt.Text = "1";
            points_definition_tableTableAdapter1.FillBy_id(this.dataSet11.points_definition_table, Convert.ToInt32(id_txt.Text));
            if (dataSet11.points_definition_table.Rows.Count > 0)
            {
                point_value_txt.Text = dataSet11.points_definition_table.Rows[0]["points_def_point_value"].ToString();
                min_txt.Text = dataSet11.points_definition_table.Rows[0]["points_def_minimum_to_redeem"].ToString();
                notes_txt.Text = dataSet11.points_definition_table.Rows[0]["points_def_notes"].ToString();
                point_cost_in_fatora_txt.Text = dataSet11.points_definition_table.Rows[0]["points_def_point_cost_in_fatora"].ToString();
            }
            else 
            {
                points_definition_tableTableAdapter1.InsertQuery(0, 0, 0, 0,"");
                points_def_formcs_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                points_definition_tableTableAdapter1.Update_points_by_id_1(Convert.ToDecimal(point_value_txt.Text), 0, Convert.ToInt32(min_txt.Text), notes_txt.Text, Convert.ToDecimal(point_cost_in_fatora_txt.Text));
                MessageBox.Show("تم التعديل", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.points_definition_tableTableAdapter1.FillBy_id(this.dataSet11.points_definition_table,Convert.ToInt32(id_txt.Text));
            }
            catch { }
        }

        private void point_cost_in_fatora_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (point_cost_in_fatora_txt.Text != "")
                {

                    decimal points = 1000 / Convert.ToDecimal(point_cost_in_fatora_txt.Text);
                    example_txt.Text = "اذا اشترى العميل فاتورة بمبلغ 1000 فانه يحصل على " + points.ToString() + " نقطة";
                }
            }
            catch { }
        }

       
       
    }
}
