using System.ComponentModel.Design.Serialization;

string c;
string[] d;
string[] d2;
Console.WriteLine("Cümle Giriniz:");
c = Console.ReadLine();
d = c.Split(" ");
d2 = c.Split(" ");
Console.WriteLine("Toplam karakter sayısı: " + c.Length);
Console.WriteLine("Toplam kelime sayısı: "+d.Length);
for(int i=0; i<d.Length; i++)
{
    int s = 1;
    for(int j=0; j<d.Length; j++)
    {
        if(i!=j && d[i] == d2[j])
        {
            s++;            
            d2[j] = "";                                                         
        }       
        else if (i==j && d[i] == d2[j])
        {
            d2[j] = "";
        }
    }
    if (s>=2)
    {
        Console.WriteLine("Tekrar eden kelime: " + d[i] + "   Tekrar sayısı: " + s);
    }
    s = 1;
}
        
