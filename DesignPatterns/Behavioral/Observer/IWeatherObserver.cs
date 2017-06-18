using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IWeatherObserver
    {               
        // For push and pull notifications
        void Update(IWeatherObservable weatherData, object args);
    }
}
