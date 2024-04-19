namespace lab_6
{
    public class WeatherForecastApp : WeatherApp 
    {
        public WeatherForecastApp(string defaultLocation, string weather, string units) : base(defaultLocation, weather,
            units)
        {
            
        }

        public override string GetWeather(string location)
        {
            return Weather;
        }

        public override string GetUnits(string units)
        {
            return Units;
        }
    }
}