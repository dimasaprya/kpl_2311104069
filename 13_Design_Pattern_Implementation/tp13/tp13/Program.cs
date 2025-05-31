using System;

class Program
{
    static void Main(string[] args)
    {
        NewsAgency agency = new NewsAgency();

        NewsReader fahmi = new NewsReader("Fahmi");
        NewsReader laila = new NewsReader("Laila");
        NewsReader faishal = new NewsReader("Faishal");

        agency.Attach(fahmi);
        agency.Attach(laila);
        agency.Attach(faishal);

        agency.News = "Berita terbaru: Design Pattern dipelajari!";
        agency.Notify();

        agency.Detach(laila);

        agency.News = "Update: Observer Pattern sangat berguna!";
        agency.Notify();
    }
}
