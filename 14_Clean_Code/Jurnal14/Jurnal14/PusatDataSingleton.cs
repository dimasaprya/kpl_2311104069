using System;
using System.Collections.Generic;

/// <summary>
/// Singleton class untuk menyimpan data global.
/// </summary>
public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    private List<string> _dataTersimpan;

    /// <summary>
    /// Konstruktor private untuk Singleton.
    /// </summary>
    private PusatDataSingleton()
    {
        _dataTersimpan = new List<string>();
    }

    /// <summary>
    /// Mengembalikan instance Singleton.
    /// </summary>
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    /// <summary>
    /// Mengambil semua data.
    /// </summary>
    public List<string> GetSemuaData()
    {
        return _dataTersimpan;
    }

    /// <summary>
    /// Mencetak semua data ke console.
    /// </summary>
    public void PrintSemuaData()
    {
        foreach (string data in _dataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    /// <summary>
    /// Menambahkan data baru ke list.
    /// </summary>
    public void AddSebuahData(string input)
    {
        _dataTersimpan.Add(input);
    }

    /// <summary>
    /// Menghapus data berdasarkan index.
    /// </summary>
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < _dataTersimpan.Count)
        {
            _dataTersimpan.RemoveAt(index);
        }
    }
}
