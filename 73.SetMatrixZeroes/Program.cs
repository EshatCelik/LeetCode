using System;

namespace _73.SetMatrixZeroes
{
    internal class Program
    {
        //      1 1 1  1 0 1
        //      1 0 1  0 0 0
        //      1 1 1  1 0 1
        //
        //      0 1 1  0 0 0
        //      1 0 1  0 0 0
        //      1 1 1  0 0 1
        static void Main(string[] args)
        {
            int deger=-1;
            int[,] dizi = new int[,] { { 0, 1, 2, 0 }, { 3, 4, 5, 2 }, { 1, 3, 1, 5 } };
            int[,] yenidizi = new int[,] { { -1, -1, -1 }, { -1, -1, -1 }, { -1, -1, -1 } };
            int en = dizi.Length;

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    deger= dizi[i, j];
                    if (deger == 0)
                    {
                        //yukarı sıfırla
                        for (int k = 0; k < dizi.GetLength(0); k++)
                        {
                            yenidizi[k, j] = 0;
                        }
                        //aşagıyı sıfırla
                        for (int k = 0; k < dizi.GetLength(1); k++)
                        {
                            yenidizi[i, k] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < yenidizi.GetLength(0); i++)
            {
                for (int j = 0; j < yenidizi.GetLength(1); j++)
                {
                    int dd=yenidizi[i,j];
                    if (dd!=0)
                    {
                        yenidizi[i, j] = dizi[i, j];

                    }
                }

            }
        }
    }
}
