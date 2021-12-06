using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36._Valid_Sudoku
{
    class Program
    {
        public static bool _validSudoku(char[,] dizi)
        {
            var deger = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    deger = Convert.ToInt32(dizi[i, j]);
                    //   var deger2 = Convert.ToInt32(dizi[i, 2].ToString());
                    if (deger != 46)
                    {
                        //sagdan kontrol
                        for (int a = j + 1; a < 9; a++)
                        {
                            if (dizi[i, a] == deger)
                            {
                                return true;
                            }
                        }
                        //soldan kontrol
                        for (int a = j - 1; a >= 0; a--)
                        {
                            if (dizi[i, a] == deger)
                            {
                                return true;
                            }
                        }
                        //yukari kontrol
                        for (int a = i - 1; a > 0; a--)
                        {
                            if (dizi[a, j] == deger)
                            {
                                return true;
                            }
                        }
                        //asagi kontrol
                        for (int a = i + 1; a < 9; a++)
                        {
                            if (dizi[a, j] == deger)
                            {
                                return true;
                            }
                        }
                        //// kare kontrol
                        int indisi = 0, indisj = 0;
                        if (i >= 0 && i <= 2 && j >= 0 && j <= 2)
                        {
                            indisi = 0;
                            indisj = 0;
                        }
                        else if (i >= 0 && i <= 2 && j >= 3 && j <= 5)
                        {
                            indisi = 0;
                            indisj = 3;
                        }
                        else if (i >= 0 && i <= 2 && j >= 6 && j <= 8)
                        {
                            indisi = 0;
                            indisj = 6;
                        }
                        else if (i >= 3 && i <= 5 && j >= 0 && j <= 2)
                        {
                            indisi = 3; indisj = 0;
                        }
                        else if (i >= 3 && i <= 5 && j >= 3 && j <= 5)
                        {
                            indisi = 3; indisj = 3;
                        }
                        else if (i >= 3 && i <= 5 && j >= 6 && j <= 8)
                        {
                            indisi = 3; indisj = 6;
                        }
                        else if (i >= 6 && i <= 8 && j >= 0 && j <= 2)
                        {
                            indisi = 6; indisj = 0;
                        }
                        else if (i >= 6 && i <= 8 && j >= 3 && j <= 5)
                        {
                            indisi = 6; indisj = 3;
                        }
                        else if (i >= 6 && i <= 8 && j >= 6 && j <= 8)
                        {
                            indisi = 6; indisj = 6;
                        }
                        for (int a = indisi; a < indisi + 3; a++)
                        {
                            for (int b = indisj; b < indisj + 3; b++)
                            {
                                var d = dizi[a, b];
                                if (d == deger && a != i && b != j)
                                {
                                    return true;
                                }
                            }

                        }

                    }

                }
            }



            return false;
        }

        static void Main(string[] args)
        {
          
            char[,] dizi = new char[9, 9]

              {// 0    1    2    3    4    5    6    7    8
                {'5', '3', '.', '.', '7', '.', '.', '.', '.' },  //0
                {'6', '.', '.', '1', '9', '5', '.', '.', '.'},   //1
                {'.', '9', '8', '.', '.', '.', '.', '6', '.'},   //2
                {'8', '.', '.', '.', '6', '.', '.', '.', '3'},   //3
                {'4', '.', '.', '8', '.', '3', '.', '.', '1'},   //4
                {'7', '.', '.', '.', '2', '.', '.', '.', '6'},   //5
                {'.', '6', '.', '.', '.', '.', '2', '8', '.'},   //6
                {'.', '.', '.', '4', '1', '9', '.', '.', '5' },  //7
                {'.', '.', '.', '5', '8', '.', '.', '7', '9' } };//8


            Console.WriteLine(_validSudoku(dizi));

            Console.ReadKey();

            //var deger = 0;

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        deger = Convert.ToInt32(dizi[i, j]);
            //        //   var deger2 = Convert.ToInt32(dizi[i, 2].ToString());
            //        if (deger != 46)
            //        {
            //            Kontrol(deger, i, j);
            //        }

            //    }
            //}
            //bool Kontrol(int deger, int i, int j)
            //{

            //    bool sagdan(int i, int j)
            //    {
            //        //sagdan kontrol
            //        for (int a = j + 1; a < 9; a++)
            //        {
            //            if (dizi[i, a] == deger)
            //            {
            //                return true;
            //            }
            //        }
            //        //soldan kontrol
            //        for (int a = i - 1; a > 0; a--)
            //        {
            //            if (dizi[i, a] == deger)
            //            {
            //                return true;
            //            }
            //        }
            //        //yukari kontrol
            //        for (int a = i - 1; a > 0; a--)
            //        {
            //            if (dizi[a, j] == deger)
            //            {
            //                return true;
            //            }
            //        }
            //        //asagi kontrol
            //        for (int a = i + 1; a < 9; a++)
            //        {
            //            if (dizi[a, j] == deger)
            //            {
            //                return true;
            //            }
            //        }
            //        //// kare kontrol
            //        //for (int i = 0; i < length; i++)
            //        //{

            //        //}
            //        return false;

            //    }
            //    return sagdan(i, j);
            //}
        }

    }
}
