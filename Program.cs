using System;

namespace modul5_NIM
{
    class Program
    {
        static void Main()
        {
            // Sesuaikan tipe data input dengan digit akhir NIM
            int angka1 = 12, angka2 = 34, angka3 = 56;

            // Memanggil method static tanpa membuat objek
            int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

            Console.WriteLine($"Hasil Penjumlahan: {hasil}");

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
