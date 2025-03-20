// See https://aka.ms/new-console-template for more information

public class PemrosesData
{
    
    public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic max = 0;
        dynamic x1 = a;
        dynamic x2 = b;
        dynamic x3 = c;
        if (x1 > x2 && x1 > x3)
        {
            max = x1;
        }
        else if (x2 > x1 && x2 > x3)
        { 
            max = x2;
        }
        else if (x3 > x1 && x3 > x2)
        {
            max = x3;
        }
        Console.WriteLine("Nilai terbesar: " + max);
    }
}
class program
{
static void Main()
    {
        PemrosesData proses = new PemrosesData();
        proses.DapatkanNilaiTerbesar(10, 30, 22);
    }
}


