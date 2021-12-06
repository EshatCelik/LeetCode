using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] {-1,-1, 0, 1, 2};
           
            Array.Sort(dizi);
            /*
             *
            -4,-1,-1       -1,-1,0       -1,0,1     0,1,2       |  -4,-1 -1,0            |  -4,-1 -1,0 1     |-4,-1 -1,0, 1 2
            -4,-1,0        -1,-1,1       -1,02                  |  -4,-1 -1 1            |  -4,-1 -1,0 2     |
            -4,-1,1        -1,-1,2                              |  -4,-1 -1 2            |                   |
            -4,-1,2        -1,0,1                               |                        |   -4,-1 -1,1 2    |
                                                                |  -4,-1 0 1             |                   |
            -4,-1,0        -1,0,2                               |  -4,-1 0 2             |                   |
            -4,1,1         -1,1,2                               |                        |                   |
            -4,-1,2                                             |  -4,-1 1 2             |                   |
                                                                |                        |
            -4,0,1                                              |                        |
            -4,0,2                                              |                        |
                                                                |                        |
            -4,1,2
            */
            var baseList = new List<IList<int>>();
            var altList = new List<int>();

            int indis1 = 0, indis2 = 1, indis3 = 2;
            int toplam = 0;
            for (int m = 0; m < dizi.Length - 2; m++)
            {
                for (int i = m; i < dizi.Length && (i + 2) < dizi.Length; i++)
                {

                    indis2 = i + 1;
                    indis1 = i;
                    indis3 = indis2 + 1;
                    for (int j = indis2; j < dizi.Length && (indis2 + 1) < dizi.Length; j++)
                    {
                        do
                        {
                            for (int k = m; k <= indis1; k++)
                            {
                                toplam += dizi[k];
                            }

                            toplam += dizi[indis2];
                            toplam += dizi[indis3];
                            if (toplam == 0)
                            {
                                for (int x = m; x <= indis1; x++)
                                {
                                    altList.Add(dizi[x]);
                                }
                                altList.Add(dizi[indis2]);
                                altList.Add(dizi[indis3]);
                                if (altList.Count == 4)
                                {
                                    var nonzeroList = new List<int>();
                                    for (int k = 0; k < altList.Count; k++)
                                    {
                                        if (altList[k] != 0)
                                        {
                                            nonzeroList.Add(altList[k]);
                                        }
                                    }
                                    altList = nonzeroList;
                                };

                                bool varmi = Exist(altList);
                                if (altList.Count != 0 && varmi == false && altList.Count == 3)
                                {
                                    baseList.Add(altList);

                                }
                            }
                            altList = new List<int>();

                            indis3++;
                            toplam = 0;
                        } while (indis3 != dizi.Length);
                        indis2++;
                        indis3 = indis2 + 1;
                    }
                }
            }
            bool Exist(List<int> gelenDizi)
            {
               
                
                bool varmi=false;   
                varmi=baseList.Contains(gelenDizi);
                for (int zz = 0; zz < baseList.Count; zz++)
                {
                    var ll = baseList[zz];
                    if (gelenDizi.Count == ll.Count)
                    {

                        for (int ff = 0; ff < ll.Count; ff++)
                        {
                            if (altList[ff] == ll[ff])
                            {
                                varmi = true;
                            }
                            else
                            {
                                varmi = false;
                                break;
                            }
                        }
                        if (varmi)
                            return true;
                    }
                }
                return varmi;
            }
            var list = baseList.Distinct().ToArray();
        }
    }
}
//if (altList.Count > 3)
//{
//    var nonzeroList = new List<int>();
//    for (int k = 0; k < altList.Count; k++)
//    {
//        if (altList[k] != 0)
//        {
//            nonzeroList.Add(altList[k]);
//        }
//    }
//    altList = nonzeroList;
//}
//if (baseList.IndexOf(altList) == -1)




//bool ciftMi = false;
//if (altList.Count % 2 == 0)
//{
//    for (int x = 0; x < altList.Count / 2; x++)
//    {
//        int boyut = altList.Count - x;
//        if (altList[x] + altList[boyut - 1] == 0)
//        {
//            ciftMi = true;
//        }
//        else
//        {
//            ciftMi = false;
//        }
//    }

//}
//if (ciftMi == false)
//{

//}  