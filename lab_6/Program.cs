using System;

namespace lab_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Створюємо наш перелік
            WeatherManager manager = new WeatherManager();

            // Додаємо місто
            manager.AddWeather(new WeatherForecastApp("Одеса", "18", "°C"));
            manager.AddWeather(new WeatherForecastApp("Київ", "10", "°C"));

            // Виводимо інформацію
            manager.DisplayWeathers();

            // Редагуємо погоду
            manager.EditWeather(0, new WeatherForecastApp("Одеса", "20", "°C"));
            manager.EditWeather(1, new WeatherForecastApp("Київ", "15", "°C"));

            // Виводимо оновлений список
            Console.WriteLine("\nПісля редагування:");
            manager.DisplayWeathers();

            // Видаляемо місто
            manager.RemoveWeather(new WeatherForecastApp("Київ", "15", "°C"));

            // Виводимо оновлений перелік
            Console.WriteLine("\nПерелік після видалення:");
            manager.DisplayWeathers();
        }
    }
}