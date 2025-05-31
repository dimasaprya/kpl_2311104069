using System;
using System.Collections.Generic;

/// <summary>
/// Interface subject untuk mengatur observer.
/// </summary>
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

/// <summary>
/// Kelas concrete subject (publisher) yang mengirim berita ke observer.
/// </summary>
public class NewsAgency : ISubject
{
    private readonly List<IObserver> _observers;
    private string _news;

    /// <summary>
    /// Konstruktor NewsAgency, inisialisasi list observer.
    /// </summary>
    public NewsAgency()
    {
        _observers = new List<IObserver>();
    }

    /// <summary>
    /// Properti berita terbaru.
    /// </summary>
    public string News
    {
        get => _news;
        set => _news = value;
    }

    /// <summary>
    /// Menambahkan observer ke list.
    /// </summary>
    /// <param name="observer">Observer yang ingin ditambahkan.</param>
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    /// <summary>
    /// Menghapus observer dari list.
    /// </summary>
    /// <param name="observer">Observer yang ingin dihapus.</param>
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    /// <summary>
    /// Mengirim notifikasi ke semua observer.
    /// </summary>
    public void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_news);
        }
    }
}
