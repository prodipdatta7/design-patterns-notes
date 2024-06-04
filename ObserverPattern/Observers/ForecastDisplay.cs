using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class ForecastDisplay : IObserver, IDisplay
{
    private readonly WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Improving weather on the way!");
    }

    public void Update()
    {
        Display();
    }
    public void Remove() => _weatherData.RemoveObserver(this);
}