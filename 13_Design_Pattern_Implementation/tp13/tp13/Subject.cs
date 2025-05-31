using System.Collections.Generic;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public class NewsAgency : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    public string News { get; set; }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(News);
        }
    }
}
