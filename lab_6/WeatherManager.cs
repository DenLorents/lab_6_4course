using System;
using System.Collections.Generic;

namespace lab_6
{
    public class WeatherManager
    {
        private List<IWeatherApp> weathers = new List<IWeatherApp>();

        public void AddWeather(IWeatherApp weather)
        {
            weathers.Add(weather);
        }
        
        public bool RemoveWeather(IWeatherApp weather)
        {
            return weathers.Remove(weather);
        }

        public void EditWeather(int index, IWeatherApp newWeather)
        {
            if (index >= 0 && index < weathers.Count)
            {
                weathers[index] = newWeather;
            }
            else
            {
                Console.WriteLine("Невірний індекс");
            }
        }

        public void DisplayWeathers()
        {
            foreach (var weather in weathers)
            {
                Console.WriteLine(weather.ToString());
            }
        }
    }
}