using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class WeatherPullData : IWeatherObservable
    {
        private List<IWeatherObserverPullNotify> _observers;

        public WeatherPullData()
        {
            _observers = new List<IWeatherObserverPullNotify>();
        }

        public void AddObserver(IWeatherObserverPushNotify observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(object args)
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(IWeatherObserverPushNotify observer)
        {
            throw new NotImplementedException();
        }
    }
}
