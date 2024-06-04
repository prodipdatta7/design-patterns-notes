using ObserverPattern.Interfaces;

namespace ObserverPattern.Subjects;

public class StockData : ISubject
{
    private readonly List<IObserver> _observers = new();
    private readonly Dictionary<string, float> _stockPrices = new();
    public Dictionary<string, float> StockPrices => _stockPrices;
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void SetPrice(string key, float price)
    {
        _stockPrices[key] = price;
        NotifyObservers();
    } 
}