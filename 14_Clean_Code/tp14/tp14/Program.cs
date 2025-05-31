using System;

/// <summary>
/// Kelas utama untuk menjalankan program Observer Pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// Titik awal eksekusi program.
    /// </summary>
    public static void Main(string[] args)
    {
        // Membuat subject (publisher)
        NewsAgency agency = new NewsAgency();

        // Membuat observers
        NewsReader fahmi = new NewsReader("Fahmi");
        NewsReader laila = new NewsReader("Laila");
        NewsReader faishal = new NewsReader("Faishal");

        // Menambahkan observers ke subject
        agency.Attach(fahmi);
        agency.Attach(laila);
        agency.Attach(faishal);

        // Memberikan update berita pertama
        agency.News = "Berita terbaru: Design Pattern dipelajari!";
        agency.Notify();

        // Melepaskan salah satu observer
        agency.Detach(laila);

        // Memberikan update berita kedua
        agency.News = "Update: Observer Pattern sangat berguna!";
        agency.Notify();
    }
}
