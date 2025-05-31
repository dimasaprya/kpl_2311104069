using System;

class Program
{
    static void Main(string[] args)
    {
        // A & B
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // C: Tambahkan data nama anggota dan asisten
        data1.AddSebuahData("Fahmi Hasan Asagaf");
        data1.AddSebuahData("Laila");
        data1.AddSebuahData("Faishal");
        data1.AddSebuahData("Rizky Naufal Alghifari"); // asisten

        // D: Print semua data dari data2
        Console.WriteLine("\nData dari data2 (sebelum hapus):");
        data2.PrintSemuaData();

        // E: Hapus nama asisten dari data2
        data2.HapusSebuahData(3); // index ke-3 adalah nama asisten

        // F: Print ulang dari data1
        Console.WriteLine("\nData dari data1 (setelah hapus):");
        data1.PrintSemuaData();

        // G: Cetak jumlah data
        Console.WriteLine($"\nJumlah elemen di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah elemen di data2: {data2.GetSemuaData().Count}");
    }
}
