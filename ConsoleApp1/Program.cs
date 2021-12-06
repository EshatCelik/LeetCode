using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hay = "hello", need = "ll";
            int sayac = 0;
            for (int i = 0; i < need.Length; i++)
            {
                for (int j = sayac; j < hay.Length; j++)
                {
                    if (need[i]==hay[j])
                    {
                        sayac = j+1;
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
