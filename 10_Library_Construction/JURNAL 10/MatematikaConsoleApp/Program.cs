using System;
using MatematikaLibraries;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FPB dari 60 dan 45 adalah: " + Matematika.FPB(60, 45));
        Console.WriteLine("KPK dari 12 dan 8 adalah: " + Matematika.KPK(12, 8));

        int[] persamaanTurunan = { 1, 4, -12, 9 };
        Console.WriteLine("Turunan dari x^3 + 4x^2 - 12x + 9 adalah: ");
        Console.WriteLine(Matematika.Turunan(persamaanTurunan));

        int[] persamaanIntegral = { 4, 6, -12, 9 };
        Console.WriteLine("Integral dari 4x^3 + 6x^2 -12x + 9 adalah: ");
        Console.WriteLine(Matematika.Integral(persamaanIntegral));
    }
}
