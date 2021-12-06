using System;
using System.Collections.Generic;

namespace _21_MergeTwoSortedLists
{
    class Program
    {


        /*
        *         1
        *        1  1
        *       1 2  1
        *      1 3  3  1
        *     1 4  6  4  1
        *    1 5 10  10 5 1
        *    
        */



        static void Main(string[] args)
        {

            GetRow(2);
            Console.ReadLine();
        }

        public static IList<int>GetRow(int numRows)
        {
            var baseList = new List<List<int>>();
            var altList = new List<int>();
            if (numRows == 0)
            {
                altList.Add(1);
                baseList.Add(altList);
                return baseList[0];
            }
            if (numRows == 1)
            {
                altList.Add(1);
                baseList.Add(altList);
                altList = new List<int>();

                altList.Add(1);
                altList.Add(1);
                baseList.Add(altList);
                return baseList[1];
            }
            altList.Add(1);
            baseList.Add(altList);
            altList = new List<int>();
            altList.Add(1);
            altList.Add(1);
            baseList.Add(altList);
            for (int i = 1; i < numRows; i++)
            {
                altList = new List<int>();
                altList.Add(1);
                for (int j = 1; j <= i; j++)
                {
                    int sayi = baseList[i][j - 1] + baseList[i][j];

                    altList.Add(sayi);

                }
                altList.Add(1);
                baseList.Add(altList);


            }
            return baseList[numRows-1];
        }
    }
}
