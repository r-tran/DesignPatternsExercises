using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class ForecastDisplay : IWeatherObserver, IDisplay
    {
        #region Fields and Properties

        private IWeatherObservable _weatherData;

        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        #endregion


        public ForecastDisplay(IWeatherObservable weather)
        {
            _weatherData = weather;
            _weatherData?.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("This is a forecast display");
        }

        public void Update(IWeatherObservable weatherData, object args = null)
        {
            weatherData.Temperature = Temperature;
            weatherData.Humidity = Humidity;
            weatherData.Pressure = Pressure;
            Display();
        }
    }
}
