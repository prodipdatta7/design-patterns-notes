using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class StatisticsDisplay : IObserver, IDisplay
{
    private static int _count;
    private readonly WeatherData _weatherData;
    private static float _totalTemperature;
    private static float _totalHumidity;
    private static float _totalPressure;
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

    public void Update()
    {
        _count++;
        _totalTemperature += _weatherData.Temperature;
        _totalHumidity += _weatherData.Humidity;
        _totalPressure += _weatherData.Pressure;
        _maxTemperate = Math.Max(_maxTemperate, _weatherData.Temperature);
        _minTemperature = Math.Min(_minTemperature, _weatherData.Temperature);
        _maxHumidity = Math.Max(_maxHumidity, _weatherData.Humidity);
        _minHumidity = Math.Min(_minHumidity, _weatherData.Humidity);
        _maxPressure = Math.Max(_maxPressure, _weatherData.Pressure);
        _minPressure = Math.Min(_minPressure, _weatherData.Pressure);
        
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