using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class CurrentConditionDisplay : IObserver, IDisplay
{
    private float _temperature;
    private float _humidity;
    private float _pressure;

    private readonly WeatherData _weatherData;

    public CurrentConditionDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Update()
    {
        _temperature = _weatherData.Temperature;
        _humidity = _weatherData.Humidity;
        _pressure = _weatherData.Pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity and {2}atm pressure", _temperature, _humidity, _pressure);
    }

    public void Remove () => _weatherData.RemoveObserver(this);
}