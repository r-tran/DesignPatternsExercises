using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class WeatherData : IWeatherObservable
    {
        private List<IWeatherObserver> _weatherObservers = new List<IWeatherObserver>();

        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public int SubscriberCount => _weatherObservers.Count;

        public void AddObserver(IWeatherObserver observer)
        {
            _weatherObservers.Add(observer);
        }

        public void NotifyObservers(object args = null)
        {
            foreach (var observer in _weatherObservers)
            {
                observer.Update(this, args);
            }
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            _weatherObservers.Remove(observer);
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
