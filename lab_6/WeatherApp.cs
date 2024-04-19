using System.Collections.Generic;
namespace lab_6
{
    public abstract class WeatherApp : IWeatherApp
    {
        public readonly string defaultLocation;
        private IWeatherApp _weatherAppImplementation;
        public string Weather { get; protected set; }
        public string Units { get; protected set;}

        // Конструктор с init специфікатором
        protected WeatherApp(string defaultLocation, string weather, string units)
        {
            this.defaultLocation = defaultLocation;
            this.Weather = weather;
            this.Units = units;
        }

        public abstract string GetWeather(string location);
        public abstract string GetUnits(string units);
       
        public override string ToString()
        {
            return $"Розташування: {defaultLocation}, {Weather} , {Units} ";
        }
        
        public override bool Equals(object obj)
        {
            var other = obj as WeatherApp;

            if (other == null)
                return false;

            return this.defaultLocation == other.defaultLocation && this.Weather == other.Weather && this.Units == other.Units;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(defaultLocation, Weather, Units);
        }
    }
    public class HashCode
    {
        public static int Combine(string defaultLocation, string weather, string units)
        {
            throw new System.NotImplementedException();
        }
    }
}