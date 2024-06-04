using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class StatisticsDisplay : IObserver, IDisplay
{
    private static int _count = 0;
    private readonly WeatherData _weatherData;
    private static float _totalTemperature = 0;
    private static float _totalHumidity = 0;
    private static float _totalPressure = 0;
    private static float _maxTemperate = float.MinValue;
    private static float _minTemperature = float.MaxValue;
    private static float _maxHumidity = float.MinValue;
    private static float _minHumidity = float.MaxValue;
    private static float _maxPressure = float.MinValue;
    private static float _minPressure = float.MaxValue;


    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        _count++;
        _totalTemperature += temperature;
        _totalHumidity += humidity;
        _totalPressure += pressure;
        _maxTemperate = Math.Max(_maxTemperate, temperature);
        _minTemperature = Math.Min(_minTemperature, temperature);
        _maxHumidity = Math.Max(_maxHumidity, humidity);
        _minHumidity = Math.Min(_minHumidity, humidity);
        _maxPressure = Math.Max(_maxPressure, pressure);
        _minPressure = Math.Min(_minPressure, pressure);
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", _totalTemperature / _count, _maxTemperate, _minTemperature);
        Console.WriteLine("Avg/Max/Min humidity = {0}/{1}/{2}", _totalHumidity / _count, _maxHumidity, _minHumidity);
        Console.WriteLine("Avg/Max/Min pressure = {0}/{1}/{2}", _totalPressure / _count, _maxPressure, _minPressure);
    }
    public void Remove() => _weatherData.RemoveObserver(this);
}