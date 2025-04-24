using System;

public class SayaTubeVideo
{
    // Properties
    public int id { get; private set; }
    public string title { get; private set; }
    public int playCount { get; private set; }

    // Constructor
    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
        {
            throw new ArgumentException("Judul video tidak boleh null atau lebih dari 200 karakter.");
        }

        this.title = title;
        this.id = new Random().Next(10000, 99999); // Generate ID acak 5 digit
        this.playCount = 0;
    }

    // Method untuk meningkatkan play count
    public void IncreasePlayCount(int count)
    {
        if (count < 0)
        {
            throw new ArgumentException("Play count tidak boleh negatif.");
        }

        if (count > 25000000)
        {
            throw new ArgumentException("Jumlah play count maksimal adalah 25.000.000.");
        }

        try
        {
            checked // untuk menangani overflow
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow error! Play count tidak dapat melebihi batas integer.");
        }
    }

    // Method untuk mencetak detail video
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {this.id}");
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Play Count: {this.playCount}");
    }
}
