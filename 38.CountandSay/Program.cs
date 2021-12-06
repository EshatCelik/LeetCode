

int temp = 0;
int sayac = 0;
string sayi = "11", tempSayi = "";
int n = 5;
bool ayni = true;
int indis=0;

for (int i = 0; i < n-2; i++)
{indis = 0;

    for (int j = 0; j < sayi.Length; j++)
    {
        temp = Convert.ToInt32(sayi[j].ToString());
        
        try
        {


            while (ayni == true)
            {
                int ss = Convert.ToInt32(sayi[indis].ToString());
                if (temp != ss)
                {
                    ayni = false;
                    indis++;
                }
                else
                {
                    sayac++;
                    indis++;
                    j++;
                }

            }



        }
        catch (Exception)
        {
        }
        tempSayi += sayac.ToString() + temp;
        j--;
        ayni = true;
        if (sayac == sayi.Length)
        {
            sayac= 0;
            break;

        }
        sayac = 0;
        indis--;
    }


    sayi = tempSayi;
    tempSayi = "";
    ayni = true;
    sayac=0;

}

Console.WriteLine(sayi);



