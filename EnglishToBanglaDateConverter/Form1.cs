using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishToBanglaDateConverter
{   
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            //Author: Mohammad Kamrul Hasan
            //        Software Developer
            //        Bangladesh
            // email: sumon.rhythm@outlook.com
            //  Date: 28/12/2016
            //ConvertDate()--- This function return bangla date in english font e.g 13/07/1423
            //ConvertDate().ToBangla() -- This Extension method return Bangla-Date in Bangla Unicode font. e.g  ১৩/০৭/১৪২৩
            //ConvertDate().ToLongDate() -- This Extension method returns Bangla-Date in Bangla unicode font as Long format . e.g ১ লা বৈশাখ ১৪২৩ বঙ্গাব্দ

            string dateEN = dateTimePicker1.Value.ConvertDate().ToBangla();
            string shortDate = dateTimePicker1.Value.ConvertDate().ToBangla();
            string longDate = dateTimePicker1.Value.ConvertDate().ToLongDate();

            label1.Text = dateEN;
            label2.Text = shortDate;
            label3.Text = longDate;


        }

     
    }
    
    public static class Test
    {
        
        public static string ConvertDate(this DateTime datetime)
        {   

            int _yearBN, _monthBN = 0, _dateBN = 0;

            int date = Convert.ToInt32(datetime.ToString("dd"));
            int month = Convert.ToInt32(datetime.ToString("MM"));
            int year = Convert.ToInt32(datetime.ToString("yyyy"));
            if (month >= 04 && month <= 12)
            {   
                if(month == 4 && date < 14)
                {
                    _yearBN = year - 594;
                }
                else {

                    _yearBN = year - 593;
                }
                
            }
            else
            {
                _yearBN = year - 594;
            }

            switch (month)
            {

                case 4:

                    if (date < 14)
                    {
                        _monthBN = 12;
                        _dateBN = date + 14 + 3;
                    }
                    else if (date >= 14)
                    {
                        _monthBN = 1;
                        _dateBN = date - 14 + 1;
                    }
                    break;

                case 5:

                    if (date < 15)
                    {
                        _monthBN = 1;
                        _dateBN = date + 15 + 2;
                    }
                    else if (date >= 15)
                    {
                        _monthBN = 2;
                        _dateBN = date - 15 + 1;
                    }
                    break;

                case 6:

                    if (date < 15)
                    {
                        _monthBN = 2;
                        _dateBN = date + 15 + 2;
                    }
                    else if (date >= 15)
                    {
                        _monthBN = 3;
                        _dateBN = date - 15 + 1;
                    }
                    break;

                case 7:

                    if (date < 16)
                    {
                        month = 3;
                        _dateBN = date + 16;
                    }
                    else if (date >= 16)
                    {
                        _monthBN = 4;
                        _dateBN = date - 16 + 1;
                    }

                    break;

                case 8:

                    if (date < 16)
                    {
                        _monthBN = 4;
                        _dateBN = date + 16;
                    }

                    else if (date >= 16)
                    {
                        _monthBN = 5;
                        _dateBN = date - 16 + 1;
                    }

                    break;

                case 9:

                    if (date < 16)
                    {
                        _monthBN = 5;
                        _dateBN = date + 16;
                    }

                    else if (date >= 16)
                    {
                        _monthBN = 6;
                        _dateBN = date + 16;
                    }

                    break;

                case 10:

                    if (date < 16)
                    {
                        _monthBN = 6;
                        _dateBN = date + 15;

                    }

                    else if (date >= 16)
                    {
                        _monthBN = 7;
                        _dateBN = date - 16 + 1;
                    }

                    break;

                case 11:

                    if (date < 15)
                    {
                        _monthBN = 7;
                        _dateBN = date + 15 + 1;
                    }

                    else if (date >= 15)
                    {
                        _monthBN = 8;
                        _dateBN = date - 15 + 1;
                    }

                    break;

                case 12:

                    if (date < 15)
                    {
                        _monthBN = 8;
                        _dateBN = date + 15 + 1;

                    }

                    else if (date >= 15)
                    {
                        _monthBN = 9;
                        _dateBN = date - 15 + 1;
                    }

                    break;

                case 1:

                    if (date < 14)
                    {
                        _monthBN = 9;
                        _dateBN = date + 14 + 3;
                    }
                    else if (date >= 14)
                    {
                        _monthBN = 10;
                        _dateBN = date - 14 + 1;
                    }
                    break;

                case 2:
                    if (date < 13)
                    {
                        _monthBN = 10;
                        _dateBN = date + 13 + 5;
                    }

                    else if (date >= 13)
                    {
                        _monthBN = 11;
                        _dateBN = date - 13 + 1;
                    }
                    break;

                case 3:

                    if (date < 15)
                    {
                        _monthBN = 11;
                        _dateBN = date + 15 + 2;
                    }

                    else if (date >= 15)
                    {
                        _monthBN = 12;
                        _dateBN = date - 15 + 1;
                    }

                    break;
            }

            return _dateBN + " / " + _monthBN + " / " + _yearBN;

        }

        public static string ToBangla(this string Date)
        {

            return ConvertDigitsToBangla(Date);


        }

        public static string ToLongDate(this string Date)
        {
            string[] dates = Date.Split('/');
            int date = Convert.ToInt32(dates[0]);
            int month = Convert.ToInt32(dates[1]);
            int year = Convert.ToInt32(dates[2]);
            string _date = "", _month = "", _year="";
            switch (month)
            {
                case 1:
                    _month = "বৈশাখ";
                    break;
                case 2:
                    _month = "জ্যৈষ্ঠ";
                    break;
                case 3:
                    _month = "আষাঢ়";
                    break;
                case 4:
                    _month = "শ্রাবণ";
                    break;
                case 5:
                    _month = "ভাদ্র";
                    break;
                case 6:
                    _month = "আশ্বিন";
                    break;
                case 7:
                    _month = "কার্তিক";
                    break;
                case 8:
                    _month = "অগ্রহায়ণ";
                    break;
                case 9:
                    _month = "পৌষ";
                    break;
                case 10:
                    _month = "মাঘ";
                    break;
                case 11:
                    _month = "ফাল্গুন";
                    break;
                case 12:
                    _month = "চৈত্র";
                    break;


            }

            // _date = date.ConvertDigitsToBangla();
            string ddExt="";

            if (date == 1) ddExt = "লা";
            else if (date == 2 || date == 3) ddExt = "রা";
            else if (date >= 3 && date <= 20) ddExt = "ই";
            else if (date >= 21 && date <= 31) ddExt = "শে";


            string longDate = date.ToString().ConvertDigitsToBangla() + " " + ddExt + " " + _month + " " + year.ToString().ConvertDigitsToBangla() + " বঙ্গাব্দ";
            return longDate;
        }

        private static string ConvertDigitsToBangla(this string s)
        {
            return s
                .Replace("0", "০")
                .Replace("1", "১")
                .Replace("2", "২")
                .Replace("3", "৩")
                .Replace("4", "৪")
                .Replace("5", "৫")
                .Replace("6", "৬")
                .Replace("7", "৭")
                .Replace("8", "৮")
                .Replace("9", "৯");
        }


    }
    
}
