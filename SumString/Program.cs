using System;

namespace SumString
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi1 = "110000000000000000000000000000000100000000000000000000000000000000";
            var sayi2 = "1100000000000000000000000000000001000000000000000000000000000000099999999999999999999999";

            var MaxVal = sayi1.Length >= sayi2.Length ? sayi1 : sayi2;
            var MinVal = "";
            var Sum = "";
            var Elde = 0;

            if (MaxVal == sayi1)
            {
                MinVal = sayi2;

            }
            else
            {
                MinVal = sayi1;

            }
            var count = MinVal.Length - 1;

            for (int i = MaxVal.Length - 1; i >= 0; i--)
            {
                var sayiMaxConvert = Convert.ToInt32(MaxVal[i].ToString());
                if (count >= 0 && MinVal[count].ToString() != null)
                {
                    sayiMaxConvert += Elde;
                    var sayiMinConvert = Convert.ToInt32(MinVal[count].ToString());
                    var toplam = sayiMaxConvert + sayiMinConvert;
                    var kalan = toplam % 10;
                    Elde = toplam / 10;
                    toplam = 0;
                    count--;
                    Sum += kalan.ToString();
                }
                else
                {
                    Sum += sayiMaxConvert;

                }

            }
            char[] metindizi = Sum.ToCharArray();
            Array.Reverse(metindizi);
            string donenmetin = new string(metindizi);
            Console.WriteLine(donenmetin);

            Console.ReadKey();
        }
    }
}
