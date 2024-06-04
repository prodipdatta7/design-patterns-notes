using ObserverPattern.Interfaces;

namespace ObserverPattern.Subjects;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private float _temperature;
    private float _humidity;
    private float _pressure;
    public float Temperature => _temperature;
    public float Humidity => _humidity;
    public float Pressure => _pressure;

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

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}