using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.IntegerToRoman
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //(1, "I");
            //(5, "V");
            //(10, "X");
            //(50, "L");
            //(100, "C");
            //(500, "D");
            //(1000, "M");
            int num = 1994;
            string ss = string.Empty;
            while (num >= 1000)
            {
                ss += "M";
                num -= 1000;
            }

            if (num >= 900)
            {
                ss += "CM";
                num -= 900;
            }

            if (num >= 500)
            {
                ss += "D";
                num -= 500;
            }
            if (num >= 400)
            {
                ss += "CD";
                num -= 400;
            }
            while (num >= 100)
            {
                ss += "C";
                num -= 100;
            }
            if (num >= 90)
            {
                ss += "XC";
                num -= 90;
            }
            if (num >= 50)
            {
                ss += "L";
                num -= 50;
            }
            if (num>=40)
            {
                ss += "XL";
                num -= 40;
            }
            while (num>=10)
            {
                ss += "X";
                num -= 10;
            }
            if (num>=9)
            {
                ss += "IX";
                num -= 9;
            }
            if (num>=5)
            {
                ss += "V";
                num -= 5;
            }
            if (num>=4)
            {
                ss += "IV";
                num -= 4;
            }

            while (num>=1)
            {
                ss += "I";
                num -= 1;
            }

            Console.WriteLine(ss);






















            //var sb = new StringBuilder();

            //while (num >= 1000)
            //{
            //    sb.Append("M");
            //    num -= 1000;
            //}

            //// -- less than thousand
            //if (num >= 900)
            //{
            //    sb.Append("CM");
            //    num -= 900;
            //}
            //else if (num >= 500)
            //{
            //    sb.Append("D");
            //    num -= 500;
            //}
            //else if (num >= 400)
            //{
            //    sb.Append("CD");
            //    num -= 400;
            //}
            //sb.Append(new string('C', num / 100));
            //num %= 100;

            //// -- less than hundred
            //if (num >= 90)
            //{
            //    sb.Append("XC");
            //    num -= 90;
            //}
            //else if (num >= 50)
            //{
            //    sb.Append("L");
            //    num -= 50;
            //}
            //else if (num >= 40)
            //{
            //    sb.Append("XL");
            //    num -= 40;
            //}
            //sb.Append(new string('X', num / 10));
            //num %= 10;

            //// -- less than ten
            //if (num == 9)
            //{
            //    sb.Append("IX");
            //    num -= 9;
            //}
            //else if (num >= 5)
            //{
            //    sb.Append("V");
            //    num -= 5;
            //}
            //else if (num >= 4)
            //{
            //    sb.Append("IV");
            //    num -= 4;
            //}
            //sb.Append(new string('I', num));



            //Dictionary<int, string> liste = new Dictionary<int, string>();

            //var sayi = 1973;
            //string yazi = sayi.ToString();
            //string yaziİle = "";
            //for (int i = yazi.Length; i > 0; i--)
            //{
            //    var rakam = Convert.ToInt32(yazi[i]);
            //    if (rakam < Convert.ToInt32(yazi[i + 1]))
            //    {

            //    }
            //}
            Console.ReadKey();
        }
    }
}
