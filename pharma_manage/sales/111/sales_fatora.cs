using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.CrystalReports;

namespace pharma_manage
{
    public partial class sales_fatora : Form
    {
        public sales_fatora()
        {
            InitializeComponent();
        }


        List<CurrencyInfo> currencies = new List<CurrencyInfo>();


        private void sales_fatora_Load(object sender, EventArgs e)
        {
            try
            {
                sales_tableTableAdapter1.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(salesID_TXT.Text));

                cst_nameTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_name"].ToString();
                cst_phoneTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_phone"].ToString();
                cst_addressTXT.Text = dataSet11.sales_table.Rows[0]["sales_cst_address"].ToString();

                dateTimePicker1.Value = Convert.ToDateTime(dataSet11.sales_table.Rows[0]["sales_date"]);

                discountTXT.Text = dataSet11.sales_table.Rows[0]["sales_discount"].ToString();
                reb7TXT.Text = dataSet11.sales_table.Rows[0]["sales_profit"].ToString();
                hesab_sab2TXT.Text = dataSet11.sales_table.Rows[0]["sales_7esab_sabe2"].ToString();
                ba2y_el7esabTXT.Text = dataSet11.sales_table.Rows[0]["sales_ba2y_el7esab"].ToString();

                madfoo3TXT.Text = dataSet11.sales_table.Rows[0]["sales_madfoo3"].ToString();

                mwazafTXT.Text = dataSet11.sales_table.Rows[0]["sales_user"].ToString();

                notesTXT.Text = dataSet11.sales_table.Rows[0]["sales_notes"].ToString();
                fatora_type.Text = dataSet11.sales_table.Rows[0]["sales_fatora_type"].ToString();

                egmaly_kest_txt.Text = dataSet11.sales_table.Rows[0]["sales_egmaly_kest_cost"].ToString();
                mandoob_txt.Text = dataSet11.sales_table.Rows[0]["sales_mandoob"].ToString();
                foreach (DataRow dr in dataSet11.sales_table.Rows)
                {
                    dataGridView1.Rows.Add(dr["sales_product_ID"].ToString(), dr["sales_product_name"].ToString(), dr["sales_product_count"].ToString(), dr["sales_unit_price"].ToString(), dr["sales_price_for_sell"].ToString(), dr["sales_pro_stock"].ToString());
                }

                
               
            }
            catch
            {
                this.Hide();
                MessageBox.Show("تأكد من رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }

            try
            {
              
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Egypt));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.USA));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));

                
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("هل تريد حذف الفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                delete_sales();
                MessageBox.Show("تم الحذف بنجاح ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void delete_sales()
        {
            try
            {
                //update ma5zoon
               // ma5zoon_movesTableAdapter1.Delete_by_fatora_ID(Convert.ToInt32(salesID_TXT.Text));

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    

                        products_tableTableAdapter1.FillBy_name(dataSet11.products_table, dgr.Cells[1].Value.ToString());
                        string pro_code = dataSet11.products_table.Rows[0]["pro_int_code"].ToString();
                        string unit_price = dataSet11.products_table.Rows[0]["pro_bee3"].ToString();
                        decimal pro_count = Convert.ToDecimal(dataSet11.products_table.Rows[0]["pro_count"]);
                        decimal pro_count_after = pro_count + Convert.ToDecimal(dgr.Cells[2].Value);
                        ma5zoon_movesTableAdapter1.Insert_ma5zoon_moves_all(DateTime.Today.ToShortDateString(),pro_code, dgr.Cells[1].Value.ToString(), Convert.ToDecimal(dgr.Cells[2].Value),
                            Convert.ToDecimal(dgr.Cells[4].Value), pro_count, pro_count_after, "حذف فاتورة بيع", Convert.ToInt32(salesID_TXT.Text), cst_nameTXT.Text, usertxt.Text, dgr.Cells[5].Value.ToString());

                   
                }

                //update products
                sales_tableTableAdapter1.FillBy_ID(dataSet11.sales_table, Convert.ToInt32(salesID_TXT.Text));
                foreach (DataRow dgr in dataSet11.sales_table.Rows)
                {

                    products_tableTableAdapter1.Update_count_BY_name_buy(Convert.ToDecimal(dgr["sales_product_count"]), Convert.ToDecimal(dgr["sales_product_count"]), dgr["sales_product_name"].ToString(), dgr["sales_pro_stock"].ToString());
                   
                }

                decimal income_cost = 0;
                if (Convert.ToDecimal(madfoo3TXT.Text) < Convert.ToDecimal(egmaly_elfatoraTXT.Text))
                {
                    income_cost = Convert.ToDecimal(madfoo3TXT.Text);
                }
                else
                {
                    income_cost = Convert.ToDecimal(egmaly_elfatoraTXT.Text);
                }

                ////safe current
                //safeTableAdapter1.Update_sarf_from_safe(Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_madfoo3"]));


                ////safe status daily
                //decimal tarh = Convert.ToDecimal(dataSet11.sales_table.Rows[0]["sales_madfoo3"]) * -1;
                //safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), tarh);



                madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                decimal old_7esab = 0;
                decimal ba2y_el7esab = 0;

                try
                {
                    //if madeen exist
                    old_7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);


                    //madeen small report update
                    madeen_small_reportTableAdapter1.Update_matloob_AND_madfoo3_by_name(-Convert.ToDecimal(egmaly_elfatoraTXT.Text), -Convert.ToDecimal(madfoo3TXT.Text), cst_nameTXT.Text);
                    madeen_small_reportTableAdapter1.FillBy_madeen_small_name(dataSet11.madeen_small_report, cst_nameTXT.Text);
                    decimal new_matloob = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_matloob"]);
                    decimal new_madfoo3 = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_madfoo3"]);

                    ba2y_el7esab = Convert.ToDecimal(dataSet11.madeen_small_report.Rows[0]["madeen_small_ba2y"]);

                    //madeen details insert
                    string madeen_byan = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;
                    madeen_tableTableAdapter1.Delete_by_details(madeen_byan);
                    string madeen_byan2 = "مبلغ ناتج عن عملية مرتجع بيع لفاتورة رقم  " + salesID_TXT.Text;

                    madeen_tableTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
                    //madeen details update matlob and madfo93
                    madeen_tableTableAdapter1.Update_matloob_and_madfoo3_by_madeen_name(-Convert.ToDecimal(egmaly_elfatoraTXT.Text),- Convert.ToDecimal(madfoo3TXT.Text), cst_nameTXT.Text);

                }
                catch { }

                //delete sales
                sales_tableTableAdapter1.Delete_by_ID(Convert.ToInt32(salesID_TXT.Text));



                //delete from tarkebat

                //delete from arba7
                arba7_tableTableAdapter1.Delete_fatora_id(Convert.ToInt32(salesID_TXT.Text));
                arba7_cat_tableTableAdapter1.Delete_fatora_id(Convert.ToInt32(salesID_TXT.Text));



                //delete from income
                string income_details = "مبلغ من فاتورة بيع رقم " + salesID_TXT.Text;
                decimal all_income=0;
                income_tableTableAdapter1.FillBy_fatora_id(dataSet11.income_table, Convert.ToInt32(salesID_TXT.Text));
                foreach (DataRow dr in dataSet11.income_table.Rows) 
                {
                    all_income += Convert.ToDecimal(dr["income_cost"]);
                }
               
                sales_mortaga3TableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));
                income_tableTableAdapter1.Delete_by_fatora(Convert.ToInt32(salesID_TXT.Text));
                saydaly_nesbaTableAdapter1.Delete_by_fatora_id(Convert.ToInt32(salesID_TXT.Text));

                safeTableAdapter1.Update_sarf_from_safe(all_income);
                safeTableAdapter1.Insert_safe(dateTimePicker1.Value.ToShortDateString(), -all_income);
            }
            catch
            {
                MessageBox.Show("تأكد من ادخال البيانات بطريقة صحيحه");
                return;
            }

        }

        string cost_in_words_txt="";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pharmacy_dataTableAdapter.Fill(this.DataSet1.pharmacy_data);

            ListBox l = new ListBox();
            foreach (DataGridViewRow dgr in dataGridView1.Rows)
            {
                if (dgr.Cells[5].Value.ToString() != "0")
                {
                    try
                    {
                        if (l.Items.Contains(dgr.Cells[5].Value.ToString()))
                        {
                        }
                        else
                        {
                            l.Items.Add(dgr.Cells[5].Value.ToString());
                        }
                    }
                    catch { }
                }
            }

            l.Items.Remove("0.00");
            select_printer s = new select_printer();
            foreach (var item in l.Items)
            {
                s.listBox1.Items.Add(item);
            }
            s.sales_num.Text = salesID_TXT.Text;
            s.cst_name_txt.Text = cst_nameTXT.Text;
            s.ShowDialog();

           
            
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal sum = 0;
                //decimal sum_dariba = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                   // dataGridView1.Rows[i].Cells[4].Value = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                   // sum_dariba += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);

                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                   
                }

                decimal egmaly_after = sum+Convert.ToDecimal(egmaly_kest_txt.Text);
                egmaly_se3r_txt.Text = sum.ToString();
                //egmaly_dariba_txt.Text = sum_dariba.ToString();
                egmaly_elfatoraTXT.Text = Convert.ToString(egmaly_after);
            }
            catch { }
        }


        public class ToWord
        {
            /// Group Levels: 987,654,321.234
            /// 234 : Group Level -1
            /// 321 : Group Level 0
            /// 654 : Group Level 1
            /// 987 : Group Level 2

            #region Varaibles & Properties

            /// <summary>
            /// integer part
            /// </summary>
            private long _intergerValue;

            /// <summary>
            /// Decimal Part
            /// </summary>
            private int _decimalValue;

            /// <summary>
            /// Number to be converted
            /// </summary>
            public Decimal Number { get; set; }

            /// <summary>
            /// Currency to use
            /// </summary>
            public CurrencyInfo Currency { get; set; }

            /// <summary>
            /// English text to be placed before the generated text
            /// </summary>
            public String EnglishPrefixText { get; set; }

            /// <summary>
            /// English text to be placed after the generated text
            /// </summary>
            public String EnglishSuffixText { get; set; }

            /// <summary>
            /// Arabic text to be placed before the generated text
            /// </summary>
            public String ArabicPrefixText { get; set; }

            /// <summary>
            /// Arabic text to be placed after the generated text
            /// </summary>
            public String ArabicSuffixText { get; set; }
            #endregion

            #region General

            /// <summary>
            /// Constructor: short version
            /// </summary>
            /// <param name="number">Number to be converted</param>
            /// <param name="currency">Currency to use</param>
            public ToWord(Decimal number, CurrencyInfo currency)
            {
                InitializeClass(number, currency, String.Empty, "only.", "فقط", "لا غير.");
            }

            /// <summary>
            /// Constructor: Full Version
            /// </summary>
            /// <param name="number">Number to be converted</param>
            /// <param name="currency">Currency to use</param>
            /// <param name="englishPrefixText">English text to be placed before the generated text</param>
            /// <param name="englishSuffixText">English text to be placed after the generated text</param>
            /// <param name="arabicPrefixText">Arabic text to be placed before the generated text</param>
            /// <param name="arabicSuffixText">Arabic text to be placed after the generated text</param>
            public ToWord(Decimal number, CurrencyInfo currency, String englishPrefixText, String englishSuffixText, String arabicPrefixText, String arabicSuffixText)
            {
                InitializeClass(number, currency, englishPrefixText, englishSuffixText, arabicPrefixText, arabicSuffixText);
            }

            /// <summary>
            /// Initialize Class Varaibles
            /// </summary>
            /// <param name="number">Number to be converted</param>
            /// <param name="currency">Currency to use</param>
            /// <param name="englishPrefixText">English text to be placed before the generated text</param>
            /// <param name="englishSuffixText">English text to be placed after the generated text</param>
            /// <param name="arabicPrefixText">Arabic text to be placed before the generated text</param>
            /// <param name="arabicSuffixText">Arabic text to be placed after the generated text</param>
            private void InitializeClass(Decimal number, CurrencyInfo currency, String englishPrefixText, String englishSuffixText, String arabicPrefixText, String arabicSuffixText)
            {
                Number = number;
                Currency = currency;
                EnglishPrefixText = englishPrefixText;
                EnglishSuffixText = englishSuffixText;
                ArabicPrefixText = arabicPrefixText;
                ArabicSuffixText = arabicSuffixText;

                ExtractIntegerAndDecimalParts();
            }

            /// <summary>
            /// Get Proper Decimal Value
            /// </summary>
            /// <param name="decimalPart">Decimal Part as a String</param>
            /// <returns></returns>
            private string GetDecimalValue(string decimalPart)
            {
                string result = String.Empty;

                if (Currency.PartPrecision != decimalPart.Length)
                {
                    int decimalPartLength = decimalPart.Length;

                    for (int i = 0; i < Currency.PartPrecision - decimalPartLength; i++)
                    {
                        decimalPart += "0"; //Fix for 1 number after decimal ( 10.5 , 1442.2 , 375.4 ) 
                    }

                    result = String.Format("{0}.{1}", decimalPart.Substring(0, Currency.PartPrecision), decimalPart.Substring(Currency.PartPrecision, decimalPart.Length - Currency.PartPrecision));

                    result = (Math.Round(Convert.ToDecimal(result))).ToString();
                }
                else
                    result = decimalPart;

                for (int i = 0; i < Currency.PartPrecision - result.Length; i++)
                {
                    result += "0";
                }

                return result;
            }

            /// <summary>
            /// Eextract Interger and Decimal parts
            /// </summary>
            private void ExtractIntegerAndDecimalParts()
            {
                String[] splits = Number.ToString().Split('.');

                _intergerValue = Convert.ToInt32(splits[0]);

                if (splits.Length > 1)
                    _decimalValue = Convert.ToInt32(GetDecimalValue(splits[1]));
            }
            #endregion

            #region English Number To Word

            #region Varaibles

            private static string[] englishOnes =
               new string[] {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

            private static string[] englishTens =
                new string[] {
            "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

            private static string[] englishGroup =
                new string[] {
            "Hundred", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillian",
            "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion",
            "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septendecillion", "Octodecillion", "Novemdecillion",
            "Vigintillion", "Unvigintillion", "Duovigintillion", "10^72", "10^75", "10^78", "10^81", "10^84", "10^87",
            "Vigintinonillion", "10^93", "10^96", "Duotrigintillion", "Trestrigintillion"
        };
            #endregion

            /// <summary>
            /// Process a group of 3 digits
            /// </summary>
            /// <param name="groupNumber">The group number to process</param>
            /// <returns></returns>
            private string ProcessGroup(int groupNumber)
            {
                int tens = groupNumber % 100;

                int hundreds = groupNumber / 100;

                string retVal = String.Empty;

                if (hundreds > 0)
                {
                    retVal = String.Format("{0} {1}", englishOnes[hundreds], englishGroup[0]);
                }
                if (tens > 0)
                {
                    if (tens < 20)
                    {
                        retVal += ((retVal != String.Empty) ? " " : String.Empty) + englishOnes[tens];
                    }
                    else
                    {
                        int ones = tens % 10;

                        tens = (tens / 10) - 2; // 20's offset

                        retVal += ((retVal != String.Empty) ? " " : String.Empty) + englishTens[tens];

                        if (ones > 0)
                        {
                            retVal += ((retVal != String.Empty) ? " " : String.Empty) + englishOnes[ones];
                        }
                    }
                }

                return retVal;
            }

            /// <summary>
            /// Convert stored number to words using selected currency
            /// </summary>
            /// <returns></returns>
            public string ConvertToEnglish()
            {
                Decimal tempNumber = Number;

                if (tempNumber == 0)
                    return "Zero";

                string decimalString = ProcessGroup(_decimalValue);

                string retVal = String.Empty;

                int group = 0;

                if (tempNumber < 1)
                {
                    retVal = englishOnes[0];
                }
                else
                {
                    while (tempNumber >= 1)
                    {
                        int numberToProcess = (int)(tempNumber % 1000);

                        tempNumber = tempNumber / 1000;

                        string groupDescription = ProcessGroup(numberToProcess);

                        if (groupDescription != String.Empty)
                        {
                            if (group > 0)
                            {
                                retVal = String.Format("{0} {1}", englishGroup[group], retVal);
                            }

                            retVal = String.Format("{0} {1}", groupDescription, retVal);
                        }

                        group++;
                    }
                }

                String formattedNumber = String.Empty;
                formattedNumber += (EnglishPrefixText != String.Empty) ? String.Format("{0} ", EnglishPrefixText) : String.Empty;
                formattedNumber += (retVal != String.Empty) ? retVal : String.Empty;
                formattedNumber += (retVal != String.Empty) ? (_intergerValue == 1 ? Currency.EnglishCurrencyName : Currency.EnglishPluralCurrencyName) : String.Empty;
                formattedNumber += (decimalString != String.Empty) ? " and " : String.Empty;
                formattedNumber += (decimalString != String.Empty) ? decimalString : String.Empty;
                formattedNumber += (decimalString != String.Empty) ? " " + (_decimalValue == 1 ? Currency.EnglishCurrencyPartName : Currency.EnglishPluralCurrencyPartName) : String.Empty;
                formattedNumber += (EnglishSuffixText != String.Empty) ? String.Format(" {0}", EnglishSuffixText) : String.Empty;

                return formattedNumber;
            }

            #endregion

            #region Arabic Number To Word

            #region Varaibles

            private static string[] arabicOnes =
               new string[] {
            String.Empty, "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة",
            "عشرة", "أحد عشر", "اثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر"
        };

            private static string[] arabicFeminineOnes =
               new string[] {
            String.Empty, "إحدى", "اثنتان", "ثلاث", "أربع", "خمس", "ست", "سبع", "ثمان", "تسع",
            "عشر", "إحدى عشرة", "اثنتا عشرة", "ثلاث عشرة", "أربع عشرة", "خمس عشرة", "ست عشرة", "سبع عشرة", "ثماني عشرة", "تسع عشرة"
        };

            private static string[] arabicTens =
                new string[] {
            "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون"
        };

            private static string[] arabicHundreds =
                new string[] {
            "", "مائة", "مئتان", "ثلاثمائة", "أربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة","تسعمائة"
        };

            private static string[] arabicAppendedTwos =
                new string[] {
            "مئتا", "ألفا", "مليونا", "مليارا", "تريليونا", "كوادريليونا", "كوينتليونا", "سكستيليونا"
        };

            private static string[] arabicTwos =
                new string[] {
            "مئتان", "ألفان", "مليونان", "ملياران", "تريليونان", "كوادريليونان", "كوينتليونان", "سكستيليونان"
        };

            private static string[] arabicGroup =
                new string[] {
            "مائة", "ألف", "مليون", "مليار", "تريليون", "كوادريليون", "كوينتليون", "سكستيليون"
        };

            private static string[] arabicAppendedGroup =
                new string[] {
            "", "ألفاً", "مليوناً", "ملياراً", "تريليوناً", "كوادريليوناً", "كوينتليوناً", "سكستيليوناً"
        };

            private static string[] arabicPluralGroups =
                new string[] {
            "", "آلاف", "ملايين", "مليارات", "تريليونات", "كوادريليونات", "كوينتليونات", "سكستيليونات"
        };
            #endregion

            /// <summary>
            /// Get Feminine Status of one digit
            /// </summary>
            /// <param name="digit">The Digit to check its Feminine status</param>
            /// <param name="groupLevel">Group Level</param>
            /// <returns></returns>
            private string GetDigitFeminineStatus(int digit, int groupLevel)
            {
                if (groupLevel == -1)
                { // if it is in the decimal part
                    if (Currency.IsCurrencyPartNameFeminine)
                        return arabicFeminineOnes[digit]; // use feminine field
                    else
                        return arabicOnes[digit];
                }
                else
                    if (groupLevel == 0)
                    {
                        if (Currency.IsCurrencyNameFeminine)
                            return arabicFeminineOnes[digit];// use feminine field
                        else
                            return arabicOnes[digit];
                    }
                    else
                        return arabicOnes[digit];
            }

            /// <summary>
            /// Process a group of 3 digits
            /// </summary>
            /// <param name="groupNumber">The group number to process</param>
            /// <returns></returns>
            private string ProcessArabicGroup(int groupNumber, int groupLevel, Decimal remainingNumber)
            {
                int tens = groupNumber % 100;

                int hundreds = groupNumber / 100;

                string retVal = String.Empty;

                if (hundreds > 0)
                {
                    if (tens == 0 && hundreds == 2) // حالة المضاف
                        retVal = String.Format("{0}", arabicAppendedTwos[0]);
                    else //  الحالة العادية
                        retVal = String.Format("{0}", arabicHundreds[hundreds]);
                }

                if (tens > 0)
                {
                    if (tens < 20)
                    { // if we are processing under 20 numbers
                        if (tens == 2 && hundreds == 0 && groupLevel > 0)
                        { // This is special case for number 2 when it comes alone in the group
                            if (_intergerValue == 2000 || _intergerValue == 2000000 || _intergerValue == 2000000000 || _intergerValue == 2000000000000 || _intergerValue == 2000000000000000 || _intergerValue == 2000000000000000000)
                                retVal = String.Format("{0}", arabicAppendedTwos[groupLevel]); // في حالة الاضافة
                            else
                                retVal = String.Format("{0}", arabicTwos[groupLevel]);//  في حالة الافراد
                        }
                        else
                        { // General case
                            if (retVal != String.Empty)
                                retVal += " و ";

                            if (tens == 1 && groupLevel > 0 && hundreds == 0)
                                retVal += " ";
                            else
                                if ((tens == 1 || tens == 2) && (groupLevel == 0 || groupLevel == -1) && hundreds == 0 && remainingNumber == 0)
                                    retVal += String.Empty; // Special case for 1 and 2 numbers like: ليرة سورية و ليرتان سوريتان
                                else
                                    retVal += GetDigitFeminineStatus(tens, groupLevel);// Get Feminine status for this digit
                        }
                    }
                    else
                    {
                        int ones = tens % 10;
                        tens = (tens / 10) - 2; // 20's offset

                        if (ones > 0)
                        {
                            if (retVal != String.Empty)
                                retVal += " و ";

                            // Get Feminine status for this digit
                            retVal += GetDigitFeminineStatus(ones, groupLevel);
                        }

                        if (retVal != String.Empty)
                            retVal += " و ";

                        // Get Tens text
                        retVal += arabicTens[tens];
                    }
                }

                return retVal;
            }

            /// <summary>
            /// Convert stored number to words using selected currency
            /// </summary>
            /// <returns></returns>
            public string ConvertToArabic()
            {
                Decimal tempNumber = Number;

                if (tempNumber == 0)
                    return "صفر";

                // Get Text for the decimal part
                string decimalString = ProcessArabicGroup(_decimalValue, -1, 0);

                string retVal = String.Empty;
                Byte group = 0;
                while (tempNumber >= 1)
                {
                    // seperate number into groups
                    int numberToProcess = (int)(tempNumber % 1000);

                    tempNumber = tempNumber / 1000;

                    // convert group into its text
                    string groupDescription = ProcessArabicGroup(numberToProcess, group, Math.Floor(tempNumber));

                    if (groupDescription != String.Empty)
                    { // here we add the new converted group to the previous concatenated text
                        if (group > 0)
                        {
                            if (retVal != String.Empty)
                                retVal = String.Format("{0} {1}", "و", retVal);

                            if (numberToProcess != 2)
                            {
                                if (numberToProcess % 100 != 1)
                                {
                                    if (numberToProcess >= 3 && numberToProcess <= 10) // for numbers between 3 and 9 we use plural name
                                        retVal = String.Format("{0} {1}", arabicPluralGroups[group], retVal);
                                    else
                                    {
                                        if (retVal != String.Empty) // use appending case
                                            retVal = String.Format("{0} {1}", arabicAppendedGroup[group], retVal);
                                        else
                                            retVal = String.Format("{0} {1}", arabicGroup[group], retVal); // use normal case
                                    }
                                }
                                else
                                {
                                    retVal = String.Format("{0} {1}", arabicGroup[group], retVal); // use normal case
                                }
                            }
                        }

                        retVal = String.Format("{0} {1}", groupDescription, retVal);
                    }

                    group++;
                }

                String formattedNumber = String.Empty;
                formattedNumber += (ArabicPrefixText != String.Empty) ? String.Format("{0} ", ArabicPrefixText) : String.Empty;
                formattedNumber += (retVal != String.Empty) ? retVal : String.Empty;
                if (_intergerValue != 0)
                { // here we add currency name depending on _intergerValue : 1 ,2 , 3--->10 , 11--->99
                    int remaining100 = (int)(_intergerValue % 100);

                    if (remaining100 == 0)
                        formattedNumber += Currency.Arabic1CurrencyName;
                    else
                        if (remaining100 == 1)
                            formattedNumber += Currency.Arabic1CurrencyName;
                        else
                            if (remaining100 == 2)
                            {
                                if (_intergerValue == 2)
                                    formattedNumber += Currency.Arabic2CurrencyName;
                                else
                                    formattedNumber += Currency.Arabic1CurrencyName;
                            }
                            else
                                if (remaining100 >= 3 && remaining100 <= 10)
                                    formattedNumber += Currency.Arabic310CurrencyName;
                                else
                                    if (remaining100 >= 11 && remaining100 <= 99)
                                        formattedNumber += Currency.Arabic1199CurrencyName;
                }
                formattedNumber += (_decimalValue != 0) ? " و " : String.Empty;
                formattedNumber += (_decimalValue != 0) ? decimalString : String.Empty;
                if (_decimalValue != 0)
                { // here we add currency part name depending on _intergerValue : 1 ,2 , 3--->10 , 11--->99
                    formattedNumber += " ";

                    int remaining100 = (int)(_decimalValue % 100);

                    if (remaining100 == 0)
                        formattedNumber += Currency.Arabic1CurrencyPartName;
                    else
                        if (remaining100 == 1)
                            formattedNumber += Currency.Arabic1CurrencyPartName;
                        else
                            if (remaining100 == 2)
                                formattedNumber += Currency.Arabic2CurrencyPartName;
                            else
                                if (remaining100 >= 3 && remaining100 <= 10)
                                    formattedNumber += Currency.Arabic310CurrencyPartName;
                                else
                                    if (remaining100 >= 11 && remaining100 <= 99)
                                        formattedNumber += Currency.Arabic1199CurrencyPartName;
                }
                formattedNumber += (ArabicSuffixText != String.Empty) ? String.Format(" {0}", ArabicSuffixText) : String.Empty;

                return formattedNumber;
            }
            #endregion
        }

        public class CurrencyInfo
        {
            public enum Currencies { Egypt = 0, USA, SaudiArabia, Gold };

            #region Constructors

            public CurrencyInfo(Currencies currency)
            {
                switch (currency)
                {
                    case Currencies.Egypt:
                        CurrencyID = 0;
                        CurrencyCode = "EGP";
                        IsCurrencyNameFeminine = true;
                        EnglishCurrencyName = "Egyptian Pound";
                        EnglishPluralCurrencyName = "Egyptian Pounds";
                        EnglishCurrencyPartName = "Piaster";
                        EnglishPluralCurrencyPartName = "Piasteres";
                        Arabic1CurrencyName = "جنيها";
                        Arabic2CurrencyName = "جنيهان";
                        Arabic310CurrencyName = "جنيهات";
                        Arabic1199CurrencyName = "جنيه";
                        Arabic1CurrencyPartName = "قرش";
                        Arabic2CurrencyPartName = "قرشان";
                        Arabic310CurrencyPartName = "قروش";
                        Arabic1199CurrencyPartName = "قرشاً";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = false;
                        break;

                    case Currencies.USA:
                        CurrencyID = 1;
                        CurrencyCode = "Dollar";
                        IsCurrencyNameFeminine = false;
                        EnglishCurrencyName = "Dollor";
                        EnglishPluralCurrencyName = "Dollor";
                        EnglishCurrencyPartName = "Cent";
                        EnglishPluralCurrencyPartName = "Cents";
                        Arabic1CurrencyName = "دولار امريكي";
                        Arabic2CurrencyName = "دولاران امريكيان";
                        Arabic310CurrencyName = "دولارات امريكيه";
                        Arabic1199CurrencyName = "دولارا امريكيا";
                        Arabic1CurrencyPartName = "سنت";
                        Arabic2CurrencyPartName = "سنتان";
                        Arabic310CurrencyPartName = "سنت";
                        Arabic1199CurrencyPartName = "سنتا";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = false;
                        break;

                    case Currencies.SaudiArabia:
                        CurrencyID = 2;
                        CurrencyCode = "SAR";
                        IsCurrencyNameFeminine = false;
                        EnglishCurrencyName = "Saudi Riyal";
                        EnglishPluralCurrencyName = "Saudi Riyals";
                        EnglishCurrencyPartName = "Halala";
                        EnglishPluralCurrencyPartName = "Halalas";
                        Arabic1CurrencyName = "ريال سعودي";
                        Arabic2CurrencyName = "ريالان سعوديان";
                        Arabic310CurrencyName = "ريالات سعودية";
                        Arabic1199CurrencyName = "ريالاً سعودياً";
                        Arabic1CurrencyPartName = "هللة";
                        Arabic2CurrencyPartName = "هللتان";
                        Arabic310CurrencyPartName = "هللات";
                        Arabic1199CurrencyPartName = "هللة";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = true;
                        break;


                    case Currencies.Gold:
                        CurrencyID = 4;
                        CurrencyCode = "XAU";
                        IsCurrencyNameFeminine = false;
                        EnglishCurrencyName = "Gram";
                        EnglishPluralCurrencyName = "Grams";
                        EnglishCurrencyPartName = "Milligram";
                        EnglishPluralCurrencyPartName = "Milligrams";
                        Arabic1CurrencyName = "جرام";
                        Arabic2CurrencyName = "جرامان";
                        Arabic310CurrencyName = "جرامات";
                        Arabic1199CurrencyName = "جراماً";
                        Arabic1CurrencyPartName = "ملجرام";
                        Arabic2CurrencyPartName = "ملجرامان";
                        Arabic310CurrencyPartName = "ملجرامات";
                        Arabic1199CurrencyPartName = "ملجراماً";
                        PartPrecision = 2;
                        IsCurrencyPartNameFeminine = false;
                        break;

                }
            }

            #endregion

            #region Properties

            /// <summary>
            /// Currency ID
            /// </summary>
            public int CurrencyID { get; set; }

            /// <summary>
            /// Standard Code
            /// Syrian Pound: SYP
            /// UAE Dirham: AED
            /// </summary>
            public string CurrencyCode { get; set; }

            /// <summary>
            /// Is the currency name feminine ( Mua'anath مؤنث)
            /// ليرة سورية : مؤنث = true
            /// درهم : مذكر = false
            /// </summary>
            public Boolean IsCurrencyNameFeminine { get; set; }

            /// <summary>
            /// English Currency Name for single use
            /// Syrian Pound
            /// UAE Dirham
            /// </summary>
            public string EnglishCurrencyName { get; set; }

            /// <summary>
            /// English Plural Currency Name for Numbers over 1
            /// Syrian Pounds
            /// UAE Dirhams
            /// </summary>
            public string EnglishPluralCurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 1 unit only
            /// ليرة سورية
            /// درهم إماراتي
            /// </summary>
            public string Arabic1CurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 2 units only
            /// ليرتان سوريتان
            /// درهمان إماراتيان
            /// </summary>
            public string Arabic2CurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 3 to 10 units
            /// خمس ليرات سورية
            /// خمسة دراهم إماراتية
            /// </summary>
            public string Arabic310CurrencyName { get; set; }

            /// <summary>
            /// Arabic Currency Name for 11 to 99 units
            /// خمس و سبعون ليرةً سوريةً
            /// خمسة و سبعون درهماً إماراتياً
            /// </summary>
            public string Arabic1199CurrencyName { get; set; }

            /// <summary>
            /// Decimal Part Precision
            /// for Syrian Pounds: 2 ( 1 SP = 100 parts)
            /// for Tunisian Dinars: 3 ( 1 TND = 1000 parts)
            /// </summary>
            public Byte PartPrecision { get; set; }

            /// <summary>
            /// Is the currency part name feminine ( Mua'anath مؤنث)
            /// هللة : مؤنث = true
            /// قرش : مذكر = false
            /// </summary>
            public Boolean IsCurrencyPartNameFeminine { get; set; }

            /// <summary>
            /// English Currency Part Name for single use
            /// Piaster
            /// Fils
            /// </summary>
            public string EnglishCurrencyPartName { get; set; }

            /// <summary>
            /// English Currency Part Name for Plural
            /// Piasters
            /// Fils
            /// </summary>
            public string EnglishPluralCurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 1 unit only
            /// قرش
            /// هللة
            /// </summary>
            public string Arabic1CurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 2 unit only
            /// قرشان
            /// هللتان
            /// </summary>
            public string Arabic2CurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 3 to 10 units
            /// قروش
            /// هللات
            /// </summary>
            public string Arabic310CurrencyPartName { get; set; }

            /// <summary>
            /// Arabic Currency Part Name for 11 to 99 units
            /// قرشاً
            /// هللةً
            /// </summary>
            public string Arabic1199CurrencyPartName { get; set; }
            #endregion
        }

       

        

    }
}
