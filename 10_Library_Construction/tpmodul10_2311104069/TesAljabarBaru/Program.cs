using System;
using AljabarLibraries;

namespace TesAljabarBaru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menghitung hasil kuadrat dari (2x - 3)^2
            double[] kuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil Kuadrat:");
            Console.WriteLine(string.Join(", ", kuadrat));

            // Mencari akar-akar dari persamaan kuadrat x^2 - 3x - 10 = 0
            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar-akar Persamaan Kuadrat:");
            Console.WriteLine(string.Join(", ", akar));

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}