using System;

/// <summary>
/// Interface observer untuk menerima update dari subject.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Method untuk menerima update pesan dari subject.
    /// </summary>
    /// <param name="message">Pesan update yang dikirim.</param>
    void Update(string message);
}

/// <summary>
/// Kelas observer yang mewakili pembaca berita.
/// </summary>
public class NewsReader : IObserver
{
    private string _name;

    /// <summary>
    /// Konstruktor untuk inisialisasi nama pembaca.
    /// </summary>
    /// <param name="name">Nama pembaca berita.</param>
    public NewsReader(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Method untuk menampilkan pesan ketika observer menerima update.
    /// </summary>
    /// <param name="message">Isi pesan update.</param>
    public void Update(string message)
    {
        Console.WriteLine($"{_name} menerima berita: {message}");
    }
}
