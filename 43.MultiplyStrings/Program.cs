

string num1 = "99999999999";
string num2 = "99999999999";
string max = "", min = "";

if (num2.Length > num1.Length)
{
    max = num2;
    min = num1;
}
else
{
    max = num1;
    min = num2;

}



int toplam = 0,carpim=0;
int sayac = 0;

for (int i = min.Length - 1; i >= 0; i--)
{
    var n2 = Convert.ToInt32(min[i].ToString());

    for (int j = 0; j < max.Length; j++)
    {
        var n1 = Convert.ToInt32(max[j].ToString());

        for (int k = 0; k < sayac; k +)
        {
            n2 *= 10;
        }
        carpim = n1 * n2;

        sayac++;
    }

}
Console.WriteLine(toplam);
Console.ReadKey();
