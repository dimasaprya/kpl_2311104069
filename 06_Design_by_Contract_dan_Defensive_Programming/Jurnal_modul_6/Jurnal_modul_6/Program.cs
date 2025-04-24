using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Membuat pengguna baru
            SayaTubeUser user = new SayaTubeUser("Fahmi");

            // Membuat beberapa video
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Inception oleh Fahmi");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film The Dark Knight oleh Fahmi");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Interstellar oleh Fahmi");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Fight Club oleh Fahmi");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film The Matrix oleh Fahmi");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Shutter Island oleh Fahmi");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film The Prestige oleh Fahmi");
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Gladiator oleh Fahmi");
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Lord of the Rings oleh Fahmi");
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Avatar oleh Fahmi");

            // Menambahkan video ke pengguna
            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);
            user.AddVideo(video8);
            user.AddVideo(video9); // Video ini tidak akan tercetak, karena maksimal 8
            user.AddVideo(video10); // Video ini juga tidak akan tercetak

            // Meningkatkan play count
            video1.IncreasePlayCount(5000);
            video2.IncreasePlayCount(10000);
            video3.IncreasePlayCount(15000);

            // Mencetak semua video dan play count
            user.PrintAllVideoPlaycount();

            // Mencetak total play count
            Console.WriteLine($"Total Play Count dari Semua Video: {user.GetTotalVideoPlayCount()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }
}
