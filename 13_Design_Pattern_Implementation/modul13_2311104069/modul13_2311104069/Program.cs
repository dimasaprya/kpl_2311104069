using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    public List<string> DataTersimpan;

    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // A & B
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // C: Tambahkan data nama anggota dan asisten
        data1.AddSebuahData("Muhammad Daniel");
        data1.AddSebuahData("Reza");
        data1.AddSebuahData("Samosa");
        data1.AddSebuahData("Naufal"); // asisten

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
