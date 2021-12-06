using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {

            string ss = "   fly me   to   the moon  ";

            ss = ss.Trim();
            int max = 0;
            var temp = ss.Split(" ");
            for (int i = 0; i < temp.Length; i++)
            {
                max = temp[i].Length;
            }

        }
    }
}
