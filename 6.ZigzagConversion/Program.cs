using System.Text;
using System.Threading.Tasks;

namespace _6._ZigzagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dizi = "ESHATÇELİK";
            string dizi = "enrxihcsanbtgxdcttnujvfscrwqtyuynmxwvbqxorquowzhpmdzjlrlcncyoywbmvzhxpenhvi" +
                "vthfivkhfxbqaquyetwifthnsxrggoqbhxiqsvzzscqutmszfqjnmtaeqtmykcbrzkjuhltznluiyokfhvstou" +
                "zgqmeaogrqsdmzohydtuotjyysttlknmqdyvdpbxftatuqastvphoahpsdifnxrfbqaghdfoyhhsxhntdcctcm" +
            "iupqzeqsjrkmzrphfoooioyvjdxnwbzhvqzwuprgibsitjpazfritpfesfsqgrxekxcgmtmvvgfqqwspdjxzadd" +
            "ukvlqpkuzjzhwsutpcafsyaibjhammegwbtpqelrnkbldxguzgcseccinlizyogwqzlifxcthdgmanjztltanvi" +
            "ajschhkdxlrfrohmxmsmmhvodihdvfnxofbxmlclxvrojacjpwxbeurhcbmzgzwwgyvtlzeivxygaappzosdikk" +
            "mlwltxirdioytnfeieepehgvgvqjfavsntfiqnbvxputczznfdcmkkhshxdnzyhormwjcxfbobwrcvehbitnsd" +
            "gacjpeiysbmrnoqssfvoyxkeglmaygfgihqznazgdmzqcpiuudjucvyjimlivqpdzhfnhe" +
            "vksudvjlrgrcavxzehlrqgjhmjqtyzztjsnopyagetjfqiexqroiayrojhjhgiarcpgrniysdhztpfqhwhpyf" +
            "ioopxxvgxniovabdatgjszazsiwzzweiluxirvqqkzefbhiddqmxrmxjwtiwrogckdldadtkczpfhzikpujhjgqfbbbt";
            var baseList = new List<IList<string>>();
            var altList = new List<string>();
            var ssccd = dizi.Length;
            int target = 375;
            int countdizi = 0;
            while (countdizi < dizi.Length)
            {
                altList = new List<string>();
                for (int j = countdizi; j < target + countdizi && j < dizi.Length; j++)
                {
                    altList.Add(dizi[j].ToString());
                }
                baseList.Add(altList);
                altList = new List<string>();                                                            //E   T   İ
                countdizi += target;                                                                     //S A Ç L K
                if (countdizi < dizi.Length)                                                             //H   E
                {                                                                                        //
                    for (int x = target - 2, z = 0; x > 0 && countdizi < dizi.Length; z++, x--)          //E 0  0  E
                    {                                                                                    //S 0  Ç  L
                                                                                                         //H T  0  İ
                        for (int j = 0; j < x; j++)                                                      //A 0  0  K
                        {                                                                                //
                            altList.Add(" ");                                                            //
                        }                                                                                //
                        altList.Add(dizi[countdizi].ToString());
                        for (int y = 0; y <= z; y++)
                        {
                            altList.Add(" ");
                        }
                        baseList.Add(altList);


                        altList = new List<string>();
                        countdizi++;
                    }
                    //countdizi++;
                }
            }
            var sss = "";
            for (int i = 0; i < target; i++)
            {

                for (int j = 0; j < baseList.Count; j++)
                {

                    try
                    {

                        if (baseList[j][i] != " ")
                        {


                            sss += baseList[j][i];

                        }

                    }
                    catch (Exception)
                    {
                    }
                }
            }





            Console.WriteLine(sss);
            Console.ReadKey();
        }

    }
}
