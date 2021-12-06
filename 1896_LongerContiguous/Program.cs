using System;

namespace _1896_LongerContiguous
{
    class Program
    {
        static void Main(string[] args)
        {
            int boyut = 10;

            for (int i = 0; i < boyut; i++)
            {
                for (int j = boyut; j >=i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("  * ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
