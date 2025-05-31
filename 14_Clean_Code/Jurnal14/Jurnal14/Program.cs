using System;

class Program
{
    static void Main(string[] args)
    {
        // Ambil instance singleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Tambah data ke data1
        data1.AddSebuahData("Fahmi Hasan Asagaf");
        data1.AddSebuahData("Laila");
        data1.AddSebuahData("Faishal");
        data1.AddSebuahData("Rizky Naufal Alghifari");

        // Print dari data2 (refleksi dari data1)
        Console.WriteLine("Data sebelum penghapusan:");
        data2.PrintSemuaData();

        // Hapus asisten dari data2
        data2.HapusSebuahData(3);

        // Print ulang dari data1
        Console.WriteLine("\nData setelah penghapusan:");
        data1.PrintSemuaData();
    }
}
