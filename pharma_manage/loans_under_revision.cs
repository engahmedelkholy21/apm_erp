using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace pharma_manage
{
    public partial class loans_under_revision : Form
    {
        public loans_under_revision()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

        }

        public void loans_under_revision_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.loans_requests_table' table. You can move, or remove it, as needed.
            if (title_txt.Text == "مراجعه")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_insert_date(dataSet11.loans_requests_table, "انتظار المراجعه",dateTimePicker1.Value.ToShortDateString(),dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
            }
            else if (title_txt.Text == "موافقه")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_revision_date(dataSet11.loans_requests_table, "تمت المراجعه في انتظار الموافقه",dateTimePicker1.Value.ToShortDateString(),dateTimePicker2.Value.ToShortDateString(),far3_txt.Text);
            }
            
            else if (title_txt.Text == "صرف")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تمت الموافقه في انتظار الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            }
            else if (title_txt.Text == "مرفوض")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تم رفض التقسيط", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            }
            else if (title_txt.Text == "تم الصرف")
            {
                //label1.Visible = true;
                //cst_name_txt.Visible = true;
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

                timer1.Stop();
                suggest_cst_name();

                dateTimePicker1_ValueChanged(sender, e);
            }
            else if (title_txt.Text == "متسرب")
            {
                //label1.Visible = true;
                //cst_name_txt.Visible = true;
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

                timer1.Stop();
                suggest_cst_name();

                dateTimePicker1_ValueChanged(sender, e);
            }
            
            



        }

        private void suggest_cst_name()
        {
            this.loans_requests_tableTableAdapter1.Fill(this.dataSet11.loans_requests_table);
            this.emp_tableTableAdapter1.Fill(this.dataSet11.employee_table);
            cst_code_text.AutoCompleteMode = AutoCompleteMode.Suggest;
            cst_code_text.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            foreach (DataRow dr in dataSet11.loans_requests_table.Rows)
            {
                DataCollection.Add(dr["loan_cst_name"].ToString());
            }
            foreach (DataRow dr in dataSet11.employee_table.Rows)
            {
                DataCollection.Add(dr["emp_name"].ToString());
            }

            cst_code_text.AutoCompleteCustomSource = DataCollection;

        }

        private void cancel_method(object sender, EventArgs e)
        {
            if (title_txt.Text == "موافقه")
            {

                DialogResult re = MessageBox.Show("هل انت متأكد من الغاء المراجعة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    loans_requests_tableTableAdapter1.Update_status_to_wait_to_revise(loan_code_txt);
                    MessageBox.Show("تم الغاء المراجعة");
                }
               
            }
            else if (title_txt.Text == "صرف")
            {
                DialogResult re = MessageBox.Show("هل انت متأكد من الغاء الموافقة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    loans_requests_tableTableAdapter1.Update_status_to_wait_to_accept(loan_code_txt);
                    MessageBox.Show("تم الغاء الموافقة");
                }
              
            }
        }
        private void delete_method(object sender, EventArgs e)
        {
            loan_delete ld= new loan_delete();
            ld.user_txt.Text = user_txt.Text;
            ld.far3_txt.Text = far3_txt.Text;
            ld.loan_name_txt.Text = loan_code;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(ld);
            f.ApplyFormStyling(ld);
            ld.ShowDialog();
            search_method();
        }


        private void byan_method(object sender, EventArgs e)
        {
            loan_aksat_show l = new loan_aksat_show();
            l.user_txt.Text = user_txt.Text;
            l.far3_txt.Text = far3_txt.Text;
            l.substringAutoCompleteTextBox1.TextBox_.Text = loan_code;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(l);
            f.ApplyFormStyling(l);
            l.ShowDialog();
        }

        private void edit_aksat_method(object sender, EventArgs e)
        {
            edit_aksat ed = new edit_aksat();
            ed.user_txt.Text = user_txt.Text;
            ed.far3_txt.Text = far3_txt.Text;
            ed.loan_code_txt.Text = loan_code;
            Form1 f = new Form1();
            f.SubscribeToLoadEvent(ed);
            f.ApplyFormStyling(ed);
            ed.ShowDialog();
        }
        private void revision_method(object sender, EventArgs e)
        {
            if (title_txt.Text == "مراجعه")
            {
               // cst_details c = new cst_details();
               // c.cst_code_txt.Text = cst_code;
               // c.damen_awel_code_txt.Text = damen_awel_code;
               // c.damen_tany_code_txt.Text = damen_tany_code;
               // c.final_amount.Text = final_amount;
               // c.extra_amount_txt.Text = extra_amont;
               // c.months_num_txt.Text = months_num;
               // c.requested_amount_txt.Text = requested_amount;
               // c.user_txt.Text = user_txt.Text;
               // c.title_txt.Text = title_info;
               // c.far3_txt.Text = far3_txt.Text;
               // c.nesba_txt.Text = nesba;
               // c.loan_code_txt.Text = loan_code_txt;
               //// c.far2_s3r_txt.Text = masareef;
               

               // try
               // {
               //     c.apply_date_txt.Text = Convert.ToDateTime(apply_date).ToShortDateString();
               // }
               // catch
               // {
               //     c.apply_date_txt.Text = "";
               // }
                

               // c.ShowDialog();
            }
            else if (title_txt.Text == "موافقه")
            {
                //cst_details c = new cst_details();
                //c.cst_code_txt.Text = cst_code;
                //c.damen_awel_code_txt.Text = damen_awel_code;
                //c.damen_tany_code_txt.Text = damen_tany_code;
                //c.final_amount.Text = final_amount;
                //c.extra_amount_txt.Text = extra_amont;
                //c.months_num_txt.Text = months_num;
                //c.requested_amount_txt.Text = requested_amount;
                //c.user_txt.Text = user_txt.Text;
                //c.title_txt.Text = title_info;
                //c.far3_txt.Text = far3_txt.Text;
                //c.nesba_txt.Text = nesba;
                //c.loan_code_txt.Text = loan_code_txt;

                //try
                //{
                //    c.apply_date_txt.Text = Convert.ToDateTime(apply_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.apply_date_txt.Text = "";
                //}
                //try
                //{
                //    c.revision_date_txt.Text = Convert.ToDateTime(revison_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.revision_date_txt.Text = "";
                //}
                

                //c.ShowDialog();
            }
            else if (title_txt.Text == "صرف")
            {
                //cst_details c = new cst_details();
                //c.cst_code_txt.Text = cst_code;
                //c.damen_awel_code_txt.Text = damen_awel_code;
                //c.damen_tany_code_txt.Text = damen_tany_code;
                //c.final_amount.Text = final_amount;
                //c.extra_amount_txt.Text = extra_amont;
                //c.months_num_txt.Text = months_num;
                //c.requested_amount_txt.Text = requested_amount;
                //c.user_txt.Text = user_txt.Text;
                //c.title_txt.Text = title_info;
                //c.far3_txt.Text = far3_txt.Text;
                //c.nesba_txt.Text = nesba;
                //c.loan_code_txt.Text = loan_code_txt;

                //try
                //{
                //    c.apply_date_txt.Text = Convert.ToDateTime(apply_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.apply_date_txt.Text = "";
                //}
                //try
                //{
                //    c.revision_date_txt.Text = Convert.ToDateTime(revison_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.revision_date_txt.Text = "";
                //}
                //try
                //{
                //    c.agreement_date_txt.Text = Convert.ToDateTime(agreement_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.agreement_date_txt.Text = "";
                //}

                

                //c.ShowDialog();
            }
            else if (title_txt.Text == "تم الصرف" || title_txt.Text == "متسرب")
            {

               

                if (fatora_num != "0")
                {
                    sales_fatora s = new sales_fatora();
                    s.Text = "مراجعة فاتورة مبيعات";
                    s.salesID_TXT.Text = fatora_num;
                    s.far3txt.Text = far3_txt.Text;
                    s.ShowDialog();
                }
                
                //cst_details c = new cst_details();
                //c.cst_code_txt.Text = cst_code;
                //c.damen_awel_code_txt.Text = damen_awel_code;
                //c.damen_tany_code_txt.Text = damen_tany_code;
                //c.final_amount.Text = final_amount;
                //c.extra_amount_txt.Text = extra_amont;
                //c.months_num_txt.Text = months_num;
                //c.requested_amount_txt.Text = requested_amount;
                //c.user_txt.Text = user_txt.Text;
                //c.title_txt.Text = title_info;
                //c.far3_txt.Text = far3_txt.Text;
                //c.nesba_txt.Text = nesba;
                //c.loan_code_txt.Text = loan_code_txt;
                //c.far2_s3r_txt.Text = masareef;
                //try
                //{
                //    c.apply_date_txt.Text = Convert.ToDateTime(apply_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.apply_date_txt.Text = "";
                //}
                //try
                //{
                //    c.revision_date_txt.Text = Convert.ToDateTime(revison_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.revision_date_txt.Text = "";
                //}
                //try
                //{
                //    c.agreement_date_txt.Text = Convert.ToDateTime(agreement_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.agreement_date_txt.Text = "";
                //}

                //try
                //{
                //    c.sarf_date_txt.Text = Convert.ToDateTime(sarf_date).ToShortDateString();
                //}
                //catch
                //{
                //    c.sarf_date_txt.Text = "";
                //}
                //c.ShowDialog();
            }
        }

        string loan_code;
        string cst_code;
        string damen_awel_code;
        string damen_tany_code;
        string final_amount;
        string extra_amont;
        string requested_amount;
        string months_num;
        string title_info;
        string apply_date;
        string revison_date;
        string sarf_date;
        string agreement_date;
        string nesba;
        string masareef;

        string loan_code_txt;
        string fatora_num;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (title_txt.Text == "مراجعه")
            {
                if (e.Button == MouseButtons.Right)
                {

                    int selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectedrowindex].Selected = true;


                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                   
                    
                    loan_code = selectedRow.Cells[0].Value.ToString();

                    // MessageBox.Show(pro_id_pub.ToString());
                    cst_code = selectedRow.Cells[2].Value.ToString();
                    loan_code_txt = selectedRow.Cells[0].Value.ToString();
                    damen_awel_code = selectedRow.Cells[7].Value.ToString();
                    damen_tany_code = selectedRow.Cells[9].Value.ToString();
                    final_amount = selectedRow.Cells[5].Value.ToString();
                    extra_amont = selectedRow.Cells[4].Value.ToString();
                    requested_amount = selectedRow.Cells[3].Value.ToString();
                    months_num = selectedRow.Cells[10].Value.ToString();
                    nesba = selectedRow.Cells[12].Value.ToString();
                    masareef = selectedRow.Cells[14].Value.ToString();
                    title_info = title_txt.Text;

                    apply_date = selectedRow.Cells[14].Value.ToString();
                    revison_date = selectedRow.Cells[15].Value.ToString();
                    sarf_date = selectedRow.Cells[17].Value.ToString();
                    agreement_date = selectedRow.Cells[16].Value.ToString();
                   // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();

                    var revise = new MenuItem("مراجعه");

                    m.MenuItems.Add(revise);

                    //  (mi);
                    // handle menu item click event here [as required]
                    //delete.Click += delete_product_Click;
                    //ma5zoon.Click += go_to_ma5zoon;
                    revise.Click += revision_method;

                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));

                }
            }
            else if (title_txt.Text == "موافقه")
            {
                if (e.Button == MouseButtons.Right)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    loan_code = selectedRow.Cells[0].Value.ToString();

                    // MessageBox.Show(pro_id_pub.ToString());
                    loan_code_txt = selectedRow.Cells[0].Value.ToString();
                    
                    cst_code = selectedRow.Cells[2].Value.ToString();
                    damen_awel_code = selectedRow.Cells[7].Value.ToString();
                    damen_tany_code = selectedRow.Cells[9].Value.ToString();
                    final_amount = selectedRow.Cells[5].Value.ToString();
                    extra_amont = selectedRow.Cells[4].Value.ToString();
                    requested_amount = selectedRow.Cells[3].Value.ToString();
                    months_num = selectedRow.Cells[10].Value.ToString();
                    title_info = title_txt.Text;
                    nesba = selectedRow.Cells[12].Value.ToString();
                    masareef = selectedRow.Cells[14].Value.ToString();
                   

                    apply_date = selectedRow.Cells[14].Value.ToString();
                    revison_date = selectedRow.Cells[15].Value.ToString();
                    sarf_date = selectedRow.Cells[17].Value.ToString();
                    agreement_date = selectedRow.Cells[16].Value.ToString();
                    // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();

                    var revise = new MenuItem("مراجعه للموافقه");
                    var cancel = new MenuItem("الغاء المراجعة");

                    m.MenuItems.Add(revise);
                    m.MenuItems.Add(cancel);
                    //  (mi);
                    // handle menu item click event here [as required]
                    //delete.Click += delete_product_Click;
                    //ma5zoon.Click += go_to_ma5zoon;
                    revise.Click += revision_method;
                    cancel.Click += cancel_method;


                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
            else if (title_txt.Text == "صرف")
            {
                if (e.Button == MouseButtons.Right)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    loan_code = selectedRow.Cells[0].Value.ToString();

                    // MessageBox.Show(pro_id_pub.ToString());
                    loan_code_txt = selectedRow.Cells[0].Value.ToString();
                    
                    cst_code = selectedRow.Cells[2].Value.ToString();
                    damen_awel_code = selectedRow.Cells[7].Value.ToString();
                    damen_tany_code = selectedRow.Cells[9].Value.ToString();
                    final_amount = selectedRow.Cells[5].Value.ToString();
                    extra_amont = selectedRow.Cells[4].Value.ToString();
                    requested_amount = selectedRow.Cells[3].Value.ToString();
                    months_num = selectedRow.Cells[10].Value.ToString();
                    nesba = selectedRow.Cells[12].Value.ToString();
                   
                    title_info = title_txt.Text;
                    masareef = selectedRow.Cells[14].Value.ToString();
                   
                    apply_date = selectedRow.Cells[14].Value.ToString();
                    revison_date = selectedRow.Cells[15].Value.ToString();
                    sarf_date = selectedRow.Cells[17].Value.ToString();
                    agreement_date = selectedRow.Cells[16].Value.ToString();
                    // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();

                    var revise = new MenuItem("صرف");
                    var cancel = new MenuItem("الغاء الموافقة");

                    m.MenuItems.Add(revise);
                    m.MenuItems.Add(cancel);

                    //  (mi);
                    // handle menu item click event here [as required]
                    //delete.Click += delete_product_Click;
                    //ma5zoon.Click += go_to_ma5zoon;
                    revise.Click += revision_method;
                    cancel.Click += cancel_method;

                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
            else if (title_txt.Text == "تم الصرف"||title_txt.Text=="متسرب")
            {
                if (e.Button == MouseButtons.Right)
                {
                    int selectedrowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[selectedrowindex].Selected = true;


                    //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    loan_code = selectedRow.Cells[0].Value.ToString();
                    fatora_num = selectedRow.Cells[13].Value.ToString();
                    // MessageBox.Show(pro_id_pub.ToString());
                    cst_code = selectedRow.Cells[2].Value.ToString();
                    damen_awel_code = selectedRow.Cells[7].Value.ToString();
                    damen_tany_code = selectedRow.Cells[9].Value.ToString();
                    final_amount = selectedRow.Cells[5].Value.ToString();
                    extra_amont = selectedRow.Cells[4].Value.ToString();
                    requested_amount = selectedRow.Cells[3].Value.ToString();
                    months_num = selectedRow.Cells[10].Value.ToString();
                    nesba = selectedRow.Cells[12].Value.ToString();
                    masareef = selectedRow.Cells[14].Value.ToString();
                   
                    title_info = title_txt.Text;

                    apply_date = selectedRow.Cells[14].Value.ToString();
                    revison_date = selectedRow.Cells[15].Value.ToString();
                    sarf_date = selectedRow.Cells[17].Value.ToString();
                    agreement_date = selectedRow.Cells[16].Value.ToString();
                    // MessageBox.Show(pro_name_pub.ToString());
                    var m = new ContextMenu();

                    var revise = new MenuItem("عرض الفاتورة");

                    m.MenuItems.Add(revise);

                    var byan = new MenuItem("عرض بيان حالة");


                    m.MenuItems.Add(byan);

                    var edit_aksat_ = new MenuItem("تعديل الاقساط");

                    m.MenuItems.Add(edit_aksat_);

                    var delete_ = new MenuItem("حذف");

                    m.MenuItems.Add(delete_);

                  

                    //  (mi);
                    // handle menu item click event here [as required]
                    //delete.Click += delete_product_Click;
                    //ma5zoon.Click += go_to_ma5zoon;
                    revise.Click += revision_method;
                    delete_.Click+= delete_method;
                    byan.Click += byan_method;
                    edit_aksat_.Click += edit_aksat_method;
                    int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (title_txt.Text == "مراجعه")
            {
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_insert_date(dataSet11.loans_requests_table, "انتظار المراجعه", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else { textBox1_TextChanged(sender, e); }
            }
            else if (title_txt.Text == "موافقه")
            {
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_revision_date(dataSet11.loans_requests_table, "تمت المراجعه في انتظار الموافقه", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else { search_method(); }
            }

            else if (title_txt.Text == "صرف")
            {
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تمت الموافقه في انتظار الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else { search_method(); }
            }
            else if (title_txt.Text == "مرفوض")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تم رفض التقسيط", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            }
            else if (title_txt.Text == "تم الصرف")
            {
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else { search_method(); }


                try
                {
                    decimal sum_ba2y = 0;

                    foreach (DataGridViewRow dgr in dataGridView1.Rows)
                    {
                        string loan_code = dgr.Cells[0].Value.ToString();
                        aksat_tableTableAdapter1.FillBy_not_paid_total(dataSet11.aksat_table, far3_txt.Text, loan_code);
                        
                        sum_ba2y += Convert.ToDecimal(dataSet11.aksat_table.Rows[0]["sum_kest_amount"]);
                    }

                    motbaky_txt.Text = sum_ba2y.ToString();
                }
                catch { }
            }
            else if (title_txt.Text == "متسرب")
            {
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else { search_method(); }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker1_ValueChanged(sender, e);
            //if (title_txt.Text == "مراجعه")
            //{
            //    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_insert_date(dataSet11.loans_requests_table, "انتظار المراجعه", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            //}
            //else if (title_txt.Text == "موافقه")
            //{
            //    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_revision_date(dataSet11.loans_requests_table, "تمت المراجعه في انتظار الموافقه", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            //}

            //else if (title_txt.Text == "صرف")
            //{
            //    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تمت الموافقه في انتظار الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            //}
            //else if (title_txt.Text == "مرفوض")
            //{
            //    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تم رفض التقسيط", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            //}
            //else if (title_txt.Text == "تم الصرف")
            //{
            //    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            //}
            //else if (title_txt.Text == "متسرب")
            //{
            //    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1_ValueChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.loans_requests_table' table. You can move, or remove it, as needed.
            if (title_txt.Text == "مراجعه")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_insert_date(dataSet11.loans_requests_table, "انتظار المراجعه", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

                try
                {
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                catch 
                {
                    Thread.Sleep(500);
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }

                string param = "الدفعة بتاريخ " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " إلى " + dateTimePicker2.Value.ToString("yyyy/MM/dd") + " في انتظار المراجعة ";

                loans_print1.SetParameterValue("title_param", param);

            }

            else if (title_txt.Text == "موافقه")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_revision_date(dataSet11.loans_requests_table, "تمت المراجعه في انتظار الموافقه", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

                try
                {
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                catch
                {
                    Thread.Sleep(500);
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }

                string param = "الدفعة بتاريخ " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " إلى " + dateTimePicker2.Value.ToString("yyyy/MM/dd") + " في انتظار الموافقة ";

                loans_print1.SetParameterValue("title_param", param);
            }

            else if (title_txt.Text == "صرف")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تمت الموافقه في انتظار الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

                try
                {
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                catch
                {
                    Thread.Sleep(500);
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }

                string param = "الدفعة بتاريخ " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " إلى " + dateTimePicker2.Value.ToString("yyyy/MM/dd") + " في انتظار الصرف ";

                loans_print1.SetParameterValue("title_param", param);
            }
            else if (title_txt.Text == "مرفوض")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_accepted_date(dataSet11.loans_requests_table, "تم رفض التقسيط", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);

                try
                {
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                catch
                {
                    Thread.Sleep(500);
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                string param = "التقسيطات المرفوضة من تاريخ " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " إلى " + dateTimePicker2.Value.ToString("yyyy/MM/dd");

                loans_print1.SetParameterValue("title_param", param);
            }
            else if (title_txt.Text == "تم الصرف")
            {
                string added_txt = "";
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_cst(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);
                    if (dataSet11.loans_requests_table.Rows.Count <= 0) 
                    {
                        added_txt = cst_code_text.Text;
                        loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_mandoob(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);
                   
                    }
                }

                try
                {
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                catch
                {
                    Thread.Sleep(500);
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }

                string param = "التقسيطات المنفذة من تاريخ " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " إلى " + dateTimePicker2.Value.ToString("yyyy/MM/dd")+added_txt;
                loans_print1.SetParameterValue("title_param", param);
                timer1.Stop();
               
            }

            else if (title_txt.Text == "متسرب")
            {
                string added_txt = "";
                if (cst_code_text.Text == "")
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text);
                }
                else
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_cst(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);
                    if (dataSet11.loans_requests_table.Rows.Count <= 0)
                    {
                        added_txt = cst_code_text.Text;
                        loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_mandoob(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                    }
                }

                try
                {
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }
                catch
                {
                    Thread.Sleep(500);
                    loans_print1.Refresh();
                    loans_print1.SetDataSource(dataSet11);
                }

                string param = "العملاء المتسربون من " + dateTimePicker1.Value.ToString("yyyy/MM/dd") + " إلى " + dateTimePicker2.Value.ToString("yyyy/MM/dd") + added_txt;
                loans_print1.SetParameterValue("title_param", param);
                timer1.Stop();

            }

            StreamReader srr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\printer_a4.txt");
            string printer_name = srr.ReadLine();


            loans_print1.PrintOptions.PrinterName = printer_name;
            loans_print1.PrintToPrinter(1, false, 0, 0);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                decimal asl = 0;
                decimal fayda = 0;
                decimal total = 0;
                decimal masareef = 0;
                




                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    asl += Convert.ToDecimal(dgr.Cells[3].Value);

                    fayda += Convert.ToDecimal(dgr.Cells[4].Value);

                    masareef += Convert.ToDecimal(dgr.Cells[14].Value);

                    total += Convert.ToDecimal(dgr.Cells[5].Value);
                }
                asl_txt.Text = asl.ToString();
                extra_txt.Text = fayda.ToString();
                total_txt.Text = total.ToString();
                masareef_txt.Text = masareef.ToString();
                count_txt.Text = dataGridView1.Rows.Count.ToString();

            }
            catch { }
        }

        private void search_method() 
        {
            //try
            //{

            if (title_txt.Text == "تم الصرف")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_cst(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);


                if (dataSet11.loans_requests_table.Rows.Count <= 0)
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_cst_name(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                }

                if (dataSet11.loans_requests_table.Rows.Count <= 0)
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_damen(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                }
                if (dataSet11.loans_requests_table.Rows.Count <= 0)
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_mandoob(dataSet11.loans_requests_table, "تم الصرف", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                }
            }
            else if (title_txt.Text == "متسرب")
            {
                loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_cst(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);
                if (dataSet11.loans_requests_table.Rows.Count <= 0)
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_cst_name(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                }
                if (dataSet11.loans_requests_table.Rows.Count <= 0)
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_damen(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                }
                if (dataSet11.loans_requests_table.Rows.Count <= 0)
                {
                    loans_requests_tableTableAdapter1.FillBy_agreed_or_not_and_sarf_date_and_mandoob(dataSet11.loans_requests_table, "متسرب", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), far3_txt.Text, cst_code_text.Text);

                }
            }
            //}
            //catch { }
        }
        private void cst_code_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                search_method();
            }
        }
    }
}
