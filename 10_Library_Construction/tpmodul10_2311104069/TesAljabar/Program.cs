using System;
using AljabarLibraries;

class Program
{
    static void Main()
    {
        double[] kuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine("Hasil Kuadrat:");
        Console.WriteLine(string.Join(", ", kuadrat));

        double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine("Akar-akar Persamaan Kuadrat:");
        Console.WriteLine(string.Join(", ", akar));
    }
}