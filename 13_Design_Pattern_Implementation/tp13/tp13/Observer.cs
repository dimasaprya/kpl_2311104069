using System;

public interface IObserver
{
    void Update(string message);
}

public class NewsReader : IObserver
{
    private string name;

    public NewsReader(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} menerima berita: {message}");
    }
}
