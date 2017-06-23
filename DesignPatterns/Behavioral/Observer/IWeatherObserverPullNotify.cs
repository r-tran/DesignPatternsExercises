using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IWeatherObserverPullNotify
    {
        void Update(IWeatherObservable weatherData, object args);        
    }
}
