using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 8, 9 };

            for (int i = dizi.Length-1; i >=0; i--)
            {
                if (dizi[i]<9)
                {
                    dizi[i]++;
                    return dizi;
                }

                dizi[i] = 0;
            }

            var dizi2 = new int[dizi.Length + 1];
            dizi2[0] = 1;
            return dizi2;


            ////123
            ////321
            //int elde = 0;
            //bool kucukMu = false;
            //for (int i = dizi.Length - 1; i >= 0; i--)
            //{
            //    dizi[i] += elde;
            //    if (dizi[dizi.Length - 1] == 9 && i == 0)
            //    {
            //        dizi[i] = 9;
            //    }
            //    else if (dizi[i] >= 9)
            //    {
            //        kucukMu = false;
            //        dizi[i] = 0;
            //        elde = 1;

            //        // dizi[i] += 1;
            //    }
            //    else
            //    {
            //        kucukMu = true;
            //        if (i == dizi.Length - 1)
            //        {
            //            dizi[i]++;
            //        }
            //        else
            //        {
            //            dizi[i] = dizi[i];

            //        }
            //    }

            //}
            //if (kucukMu == false)
            //{


            //    var diziNew = new int[dizi.Length + 1];
            //    diziNew[0] = 1;

            //    foreach (var item in diziNew)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
        }
    }
}
