using System;

class Program
{
    static void Main()
    {
        // 1. Menerima input nama
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        // 2. Membuat array tipe integer dengan 50 elemen
        int[] angkaArray = new int[50];
        for (int i = 0; i < angkaArray.Length; i++)
        {
            angkaArray[i] = i;
        }

        // Menampilkan angka sesuai aturan
        Console.WriteLine("\nArray dengan aturan khusus:");
        for (int i = 0; i < angkaArray.Length; i++)
        {
            string tambahan = "";
            if ((i + 1) % 2 == 0) tambahan += "##";
            if ((i + 1) % 3 == 0) tambahan += "$$";
            if ((i + 1) % 5 == 0) tambahan += "#$#$";
            
            Console.WriteLine($"{angkaArray[i]} {tambahan}");
        }

        // 3. Menerima input angka dan mengecek bilangan prima
        Console.Write("\nMasukkan angka (1-10000): ");
        string input = Console.ReadLine();
        int angka;
        
        if (int.TryParse(input, out angka) && angka >= 1 && angka <= 10000)
        {
            if (IsPrime(angka))
            {
                Console.WriteLine($"Angka {angka} merupakan bilangan prima.");
            }
            else
            {
                Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima.");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka antara 1-10000.");
        }
    }

    // Fungsi untuk mengecek bilangan prima
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
