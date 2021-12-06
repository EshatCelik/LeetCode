using System;

namespace TargetArray
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] dizi = new char[3, 3] {{'1','2','3'},
                                              {'4','5','6'},
                                              {'7','8','9'} };


            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var dd = dizi[i, j].ToString();
                }
            }
        }
    }
}
