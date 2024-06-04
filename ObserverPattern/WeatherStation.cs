﻿using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    public class WeatherStation
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
