using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace pharma_manage
{
    public partial class delete_all : Form
    {
        public delete_all()
        {
            InitializeComponent();
        }

        int count = 0;
       
        private void delete_all_Load(object sender, EventArgs e)
        {
            if (this.Text == "تغيير المستخدم")
            {
                username_txt.Visible = false;
                comboBox1.Visible = true;

                comboBox1.Focus();

                this.user_previligesTableAdapter1.Fill(this.dataSet11.user_previliges);

                foreach (DataRow dr in dataSet11.user_previliges.Rows)
                {
                    if (comboBox1.Items.Contains(dr["user_name"].ToString()))
                    {
                    }
                    else
                    {
                        comboBox1.Items.Add(dr["user_name"].ToString());
                    }
                }
                //comboBox1.Text = usertxt.Text;
                button1.Text = "تغيير المستخدم";
                button1.BackColor = Color.Green;
                Result_user = "";

            }
            else 
            {
                comboBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Text.Contains("مسح"))
            {
                count += 1;

                try
                {
                    user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, username_txt.Text);
                    string password = dataSet11.user_previliges.Rows[0]["password"].ToString();

                    if (password == password_txt.Text)
                    {
                        DialogResult re = MessageBox.Show("هل تريد مسح جميع بيانات النظام؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (re == DialogResult.Yes)
                        {
                            ListBox list = new ListBox();

                            string un = "";
                            string pw = "";
                            string ip = "";
                            string db_name = "";
                            string db_port = "";
                            string db_v = "";
                           
                                try
                                {
                                    un = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                                }
                                catch 
                                {
                                    un = "";
                                }
                                try
                                {
                                    pw = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                                }
                                catch
                                {
                                    pw = "";
                                }
                                try
                                {
                                    ip = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();
                                }
                                catch
                                {
                                    ip = "";
                                }
                                try
                                {
                                    db_port = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_port").First();
                                }
                                catch
                                {
                                    db_port = "";
                                }
                                try
                                {
                                    db_v = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_v").First();
                                }
                                catch
                                {
                                    db_v = "";
                                }
                                try
                                {
                                    db_name = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\db_n").First();
                                }
                                catch
                                {
                                    db_name = "";
                                }
                                
                                
                               

                            SqlConnection c = new SqlConnection();

                            if (db_v == "ex")
                            {
                               // MessageBox.Show("ddddd");
                                if (string.IsNullOrEmpty(un))
                                {
                                    c.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

                                    db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";
                                  //  MessageBox.Show(c.ConnectionString);
                                }
                                else
                                {
                                    c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                                }
                            }
                            else 
                            {
                                c.ConnectionString = @"Data Source=" + ip + "," + db_port + ";Network Library=DBMSSOCN;Initial Catalog=" + db_name + ";Integrated Security=false;User ID=" + un + ";Password=" + pw;
                
                            }
                            try
                            {
                          //  MessageBox.Show(c.ConnectionString);
                                c.Open();

                                // Retrieve the list of tables
                                SqlCommand com = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", c);
                                DataTable t = new DataTable();
                                SqlDataAdapter adapter = new SqlDataAdapter(com);
                                adapter.Fill(t);

                                foreach (DataRow dr in t.Rows)
                                {
                                    string tableName = dr["TABLE_NAME"].ToString();

                                    //if (tableName == "user_previliges" || tableName == "customers" || tableName == "mwardeen")
                                    //    continue; // Skip these table names

                                   // MessageBox.Show(tableName);
                                    list.Items.Add(tableName);
                                }
                                // Truncate all tables
                                foreach (var item in list.Items)
                                {
                                    string tableName = item.ToString();
                                    string query = "TRUNCATE TABLE [" + tableName + "]";
                                    SqlCommand cmd = new SqlCommand(query, c);
                                    cmd.ExecuteNonQuery();
                                }

                                // Shrink the database and log file after truncation
                                string shrinkDbQuery = @"
                DECLARE @DatabaseName NVARCHAR(128);
                DECLARE @LogFileName NVARCHAR(128);

                -- Get the current database name
                SET @DatabaseName = DB_NAME();

                -- Get the log file name for the current database
                SELECT @LogFileName = name
                FROM sys.master_files
                WHERE type = 1 AND database_id = DB_ID(@DatabaseName);

                -- Backup the transaction log if needed
                IF (SELECT recovery_model_desc FROM sys.databases WHERE name = @DatabaseName) != 'SIMPLE'
                BEGIN
                    DECLARE @BackupLogCommand NVARCHAR(MAX);
                    SET @BackupLogCommand = 'BACKUP LOG [' + @DatabaseName + '] TO DISK = ''C:\\Backup\\' + @DatabaseName + '_LogBackup.trn'';';
                    EXEC sp_executesql @BackupLogCommand;
                END

                -- Shrink the database to the smallest possible size
                DBCC SHRINKDATABASE (@DatabaseName);

                -- Shrink the log file to the smallest possible size
                DBCC SHRINKFILE (@LogFileName);
            ";

                                SqlCommand shrinkCmd = new SqlCommand(shrinkDbQuery, c);
                                shrinkCmd.ExecuteNonQuery();

                                // Insert initial data
                                numbers_tableTableAdapter1.Insert(1, 1, 1, 1, "الرئيسي", 1, 1, 1, 1);
                                stock_tableTableAdapter1.Insert("الرئيسي", "");

                                MessageBox.Show("تم مسح جميع البيانات ستتم اعادة تشغيل النظام");
                                Application.Restart();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                            finally
                            {
                                if (c.State == ConnectionState.Open)
                                {
                                    c.Close();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    if (count == 3)
                    {
                        MessageBox.Show("لقد استنفذت محاولاتك سيتم الخروج من النظام");

                        Application.Exit();

                    }
                    else
                    {
                        MessageBox.Show("ادخل البيانات بطريقة صحيحة . باقي " + (3 - count).ToString() + " محاوله");
                    }
                }
            }
            else if (this.Text == "تغيير المستخدم") 
            {
                user_previligesTableAdapter1.FillBy_name(dataSet11.user_previliges, comboBox1.Text);
               
                if (password_txt.Text == Convert.ToString(dataSet11.user_previliges.Rows[0]["password"]))// && textBox3.Text == "aassdd")
                {
                    Result_user = comboBox1.Text;
                    this.Close();
                }
                else 
                {
                    Result_user = "";
                }



            }
        }
        public string Result_user;
    }
}
