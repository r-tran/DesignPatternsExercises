using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Behavioral.Observer;

namespace DesignPatterns.Test
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        public void WeatherData_CanSetMeasurements()
        {
            WeatherData weatherData = new WeatherData();
            float targetTemp = 40;
            float targetHumid = 50;
            float targetPress = 70;

            weatherData.SetMeasurements(targetTemp, targetHumid, targetPress);
            Assert.AreEqual(targetTemp, weatherData.Temperature);
            Assert.AreEqual(targetHumid, weatherData.Humidity);
            Assert.AreEqual(targetPress, weatherData.Pressure);
        }

        [TestMethod]
        public void WeatherData_CanAddObservers()
        {
            WeatherData weatherData = new WeatherData();

            IWeatherObserver statisticsDisplay = new StatisticsDisplay(weatherData);
            IWeatherObserver forecastDisplay = new ForecastDisplay(weatherData);
            IWeatherObserver conditionsDisplay = new CurrentConditionsDisplay(weatherData);

            Assert.AreEqual(3, weatherData.SubscriberCount);
        }

        [TestMethod]
        public void WeatherData_CanRemoveObservers()
        {
            WeatherData weatherData = new WeatherData();
            IWeatherObserver statisticsDisplay = new StatisticsDisplay(weatherData);
            IWeatherObserver forecastDisplay = new ForecastDisplay(weatherData);
            IWeatherObserver conditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.RemoveObserver(statisticsDisplay);
            Assert.AreEqual(2, weatherData.SubscriberCount);
        }

        // Console output, not a test
        [TestMethod]
        public void WeatherData_CanNotifyObservers()
        {
            WeatherData weatherData = new WeatherData();
            IWeatherObserver statisticsDisplay = new StatisticsDisplay(weatherData);
            IWeatherObserver forecastDisplay = new ForecastDisplay(weatherData);
            IWeatherObserver conditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(10, 20, 30);
            weatherData.RemoveObserver(statisticsDisplay);
            weatherData.SetMeasurements(40, 50, 60);
            weatherData.RemoveObserver(forecastDisplay);
            weatherData.SetMeasurements(70, 80, 90);
            weatherData.RemoveObserver(conditionsDisplay);
            weatherData.SetMeasurements(100, 810, 910);
        }

    }
}
