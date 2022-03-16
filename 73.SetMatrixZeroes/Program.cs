using System;

namespace _73.SetMatrixZeroes
{
    internal class Program
    {
        //      1 1 1  1 0 1  1 0 1
        //      1 0 1  1 0 1  0 0 0 
        //      1 1 1  1 0 1  1 0 1
        //
        //      1, 0, 1, 1   0 0 0 0
        //      1, 1, 0, 1   0 0 0 0
        //      1, 1, 1, 1   1 0 0 1
        //      1, 1, 1, 1   1 0 0 1
        static void Main(string[] args)
        {
            int[,] dizi = new int[,] { { 1, 0, 1, 1 }, { 1, 1, 0, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };

            int[,] yeniDizi = new int[dizi.GetLength(0), dizi.GetLength(1)];

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    int sayi = dizi[i, j];
                    yeniDizi[i, j] = sayi;
                }
            }

            int boyut = dizi[1, 1];
            int dd = dizi.GetLength(0);
            int dd1 = dizi.GetLength(1);
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    int sayi = yeniDizi[i, j];
                    if (sayi == 0)
                    {
                        //yukaridan aşağı
                        for (int k = 0; k < dizi.GetLength(0); k++)
                        {
                            dizi[k, j] = 0;
                        }
                        //sağdan sola
                        for (int k = 0; k < dizi.GetLength(1); k++)
                        {
                            dizi[i, k] = 0;
                        }

                    }
                }
            }
            string result = "[";
           
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                result += "[";
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    result += dizi[i, j] + ",";
                }
                result = result.Substring(0, result.Length - 1);
                result += "]";
            }
            result = result.Substring(0, result.Length - 1);
            result += "]";
            Console.WriteLine(result);
           
            Console.ReadKey();
        }
    }
}
