class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Fahmi hasan asagaf");

        for (int i = 0; i < 100000; i++)
        {
            video.IncreasePlayCount(100000); // Uji overflow
        }

        video.PrintVideoDetails();
    }
}
