using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.IO.Ports;
namespace pharma_manage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string un = "";
            string pw = "";
            string ip = "";
            string db_name;
            try
            {
                un = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\u").First();
                pw = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\p").First();
                ip = File.ReadLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\i").First();

            }
            catch
            {

            }



            SqlConnection c = new SqlConnection();
            if (un == "")
            {
                c.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\my_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

                db_name = "[" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\my_data.mdf " + "]";

            }
            else
            {
                c.ConnectionString = @"Data Source=" + ip + "\\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=my_data;Integrated Security=false;User ID=" + un + ";Password=" + pw;
                db_name = "my_data";

            }
            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand("CREATE TABLE [mo3adalat_tasnee3_table](mo3adalat_tasnee3_id] int IDENTITY(1,1) NOT NULL,[mo3adalat_tasnee3_pro_name] [varchar](150),[mo3adalat_tasnee3_material_name] [varchar](150),[mo3adalat_tasnee3_material_coun] [decimal](18, 2) ,[mo3adalat_tasnee3_notes] [varchar](150) ) ", c);

            c.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("added");
            c.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            // Get a list of all available COM ports on the system
            string[] ports = SerialPort.GetPortNames();

            // Populate the ComboBox with the list of port names
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            send_sms_class.send_sms_msg("الله لا إله إلا هو الحي القيوم لا تأخذه سنة ولا نوم له ما في السماوات وما في الأرض من ذا الذي يشفع عنده إلا بإذنه يعلم ما بين أيديهم وما خلفهم ولا يحيطون بشيء من علمه إلا بما شاء وسع كرسيه السماوات والأرض ولا يئوده حفظهما وهو العلي العظيم ", "01068637767");
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Sample financial data (replace this with actual data from your ERP app)
            decimal totalRevenue = 10000.0m;
            decimal costOfGoodsSold = 4000.0m;
            decimal operatingExpenses = 3000.0m;
            decimal nonOperatingIncome = 500.0m;
            decimal nonOperatingExpenses = 200.0m;

            // Calculate income statement components
            decimal grossProfit = totalRevenue - costOfGoodsSold;
            decimal operatingIncome = grossProfit - operatingExpenses;
            decimal netIncome = operatingIncome + (nonOperatingIncome - nonOperatingExpenses);

            // Create the income statement text
            StringBuilder incomeStatement = new StringBuilder();
            incomeStatement.AppendLine("Income Statement");
            incomeStatement.AppendLine("--------------------");
            incomeStatement.AppendLine(string.Format("Total Revenue: {0:C}", totalRevenue));
            incomeStatement.AppendLine(string.Format("- Cost of Goods Sold: {0:C}", costOfGoodsSold));
            incomeStatement.AppendLine(string.Format("Gross Profit: {0:C}", grossProfit));
            incomeStatement.AppendLine(string.Format("- Operating Expenses: {0:C}", operatingExpenses));
            incomeStatement.AppendLine(string.Format("Operating Income: {0:C}", operatingIncome));
            incomeStatement.AppendLine(string.Format("Non-Operating Income: {0:C}", nonOperatingIncome));
            incomeStatement.AppendLine(string.Format("- Non-Operating Expenses: {0:C}", nonOperatingExpenses));
            incomeStatement.AppendLine(string.Format("Net Income: {0:C}", netIncome));

            // Display the income statement in the text box
             MessageBox.Show(incomeStatement.ToString());
        }
        
    }
}
