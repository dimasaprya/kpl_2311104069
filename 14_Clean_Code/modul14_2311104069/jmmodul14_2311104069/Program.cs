using System;
using System.Collections.Generic;

// Interface untuk observer yang menerima update berita
public interface IObserver
{
    void Update(string message);
}

// Interface untuk subject yang mengelola observer
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

// Implementasi subject: NewsAgency
public class NewsAgency : ISubject
{
    // Daftar observer yang terdaftar
    private readonly List<IObserver> observers = new List<IObserver>();

    // Berita terbaru yang akan dikirim ke observer
    private string latestNews;

    public void Attach(IObserver observer)
    {
        if (observer == null) throw new ArgumentNullException(nameof(observer));
        if (!observers.Contains(observer))
            observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        if (observer == null) throw new ArgumentNullException(nameof(observer));
        observers.Remove(observer);
    }

    public void Notify()
    {
        // Jika tidak ada berita, tidak perlu notify
        if (string.IsNullOrEmpty(latestNews)) return;

        foreach (var observer in observers)
        {
            observer.Update(latestNews);
        }
    }

    // Menambahkan berita baru dan notify observer
    public void AddNews(string news)
    {
        if (string.IsNullOrEmpty(news)) return;

        latestNews = news;
        Notify();
    }
}

// Implementasi observer: Subscriber
public class Subscriber : IObserver
{
    private readonly string name;

    public Subscriber(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be empty", nameof(name));
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} menerima berita terbaru: {message}");
    }
}

// Program utama untuk menjalankan demo
class Program
{
    static void Main()
    {
        var agency = new NewsAgency();

        var sub1 = new Subscriber("Andi");
        var sub2 = new Subscriber("Budi");
        var sub3 = new Subscriber("Cici");

        agency.Attach(sub1);
        agency.Attach(sub2);
        agency.Attach(sub3);

        agency.AddNews("Berita Hari Ini: Cuaca Cerah!");

        agency.Detach(sub2);

        agency.AddNews("Update: Harga BBM Naik!");
    }
}
