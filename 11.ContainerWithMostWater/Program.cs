




int[] dizi = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
// II.Yol

int sol=0;
int sag = dizi.Length - 1;
int temp=0;
int max=0,min=0;

while (sol<sag)
{
    if (dizi[sol]<dizi[sag])
    {
        temp = dizi[sol] * (sag - sol);
        if (temp>max)
        {
            max = temp;
        }
        sol++;
    }
    else
    {
        temp = dizi[sag] * (sag - sol);
        if (temp>max)
        {
            max = temp;
        }
        sag--;
    }
}

//int indisİlk = 0,indisSon=0,toplam=0;

//// I.Yol
//    for (int i = 0; i < dizi.Length; i++)
//    {
//        indisİlk=dizi[i];
//        for (int j =i+1; j < dizi.Length; j++)
//        {
//            indisSon = dizi[j];
//            if (indisİlk>indisSon)
//            {
//                min = indisSon;
//            }
//            else
//            {
//                min = indisİlk;
//            }
//            toplam = min * (j - i);
//            if (max< toplam)
//            {
//                max = toplam;
//            }
         

//        }

//    }

Console.WriteLine(max);
Console.ReadKey();
