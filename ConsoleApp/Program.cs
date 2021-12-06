using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> roma = new Dictionary<string, int>();
            roma.Add("I", 1);
            roma.Add("V", 5);
            roma.Add("X", 10);
            roma.Add("L", 50);
            roma.Add("C", 100);
            roma.Add("D",500);
            roma.Add("M",1000);

            //Console.Write("Roman Rakamı giriniz :");

            //string roman = Console.ReadLine();

            string roman = "MCMXCIV";
            int toplam = 0, deger1 = 0, deger2 = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (roma.TryGetValue(roman[i].ToString(), out deger1))
                {
                    try
                    {
                        if ( roma.TryGetValue(roman[i + 1].ToString(), out deger2))
                        {
                            if (deger1 < deger2)
                            {

                                toplam -= deger1;
                            }
                            else
                            {
                                toplam += deger1;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        toplam += deger1;
                    }

                }
            }
            Console.WriteLine(" sonuc :" + toplam);
        }
    }
}


