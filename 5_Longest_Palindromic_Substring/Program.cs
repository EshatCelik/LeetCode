using System;

namespace _5_Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "clnazand", ters = "", aa = "", kelime = "", kelimeKopya = "";

            //char[] arrayChar = ss.ToCharArray();
            //Array.Reverse(arrayChar);
            //bb = new string(arrayChar);
            int indisİ = 0, indisJ = ss.Length - 1;
            for (int i = 0; i < ss.Length; i++)
            {
               
                for (int j = ss.Length - 1; j > 0; j--)
                {
                    if (ss[i] != ss[j])
                    {
                        kelime = "";
                       
                    }
                    else
                    {
                        indisJ = j;
                        try
                        {
                            var ini = ss.Substring(i, ss.Length-j).ToString();
                            var inj = ss.Substring(ss.Length-indisJ, ss.Length -i).ToString();
                            char[] arrayChar = inj.ToCharArray();
                            Array.Reverse(arrayChar);
                            inj = new string(arrayChar);

                            if (ini!=inj)
                            {
                                break;
                            }
                            else
                            {
                                kelime = ss.Substring(i, indisJ-1).ToString();
                            }
                           }
                        catch (Exception)
                        {

                        }
                        
                        if (kelime.Length >kelimeKopya.Length)
                        {

                            kelimeKopya = kelime;
                        }
                    }


                }

            }
            //char[] arrayChar = kelimeKopya.ToCharArray();
            //Array.Reverse(arrayChar);
            //var tersKelimeKopya = new string(arrayChar);
            var kk = kelimeKopya;
            Console.WriteLine($"kelime : {kk} \nboyut : {kk.Length}");




            Console.ReadLine();
        }


    }
}
