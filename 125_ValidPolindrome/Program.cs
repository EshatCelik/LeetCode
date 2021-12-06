using System;

namespace _125_ValidPolindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPolindrome("A m@n, a plan, a canal: Panama"))
            {
                Console.WriteLine("true");

            }else
            Console.WriteLine("false");

            Console.ReadLine();
        }

        public static bool IsPolindrome(string s)
        {
            string ss = s.Trim().ToUpper(),sk="";

            string[] _split = ss.Split(' ', ',', ':', '.');
            s = "";

            for (int i = 0; i < _split.Length; i++)
            {
                s += _split[i];
            }
            s = s.Replace("@", "a");
            s = s.ToUpper();
            for (int i = s.Length; i >0; i--)
            {
                sk += s[i-1];
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]!=sk[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
