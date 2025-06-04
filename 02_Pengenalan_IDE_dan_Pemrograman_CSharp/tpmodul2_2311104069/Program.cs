using System;

class Program
{
    static void Main()
    {
        // Langkah 3A – Mengecek huruf vokal atau konsonan
        Console.WriteLine("Program dimulai...");

        Console.Write("Masukkan satu huruf kapital: ");
        char input = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Pindah baris

        if ("AIUEO".Contains(input))
        {
            Console.WriteLine($"Huruf {input} merupakan huruf vokal");
        }
        else if (char.IsLetter(input))
        {
            Console.WriteLine($"Huruf {input} merupakan huruf konsonan");
        }
        else
        {
            Console.WriteLine("Input bukan huruf.");
        }

        // Langkah 3B – Membuat array bilangan genap dari 2 sampai 10
        Console.WriteLine("\nArray bilangan genap:");
        int[] bilanganGenap = new int[5];
        int nilai = 2;
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            bilanganGenap[i] = nilai;
            nilai += 2;
        }

        // Cetak array bilangan genap
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap ke-{i + 1} : {bilanganGenap[i]}");
        }
    }
}
