using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IWeatherObservable
    {
        #region Properties

        float Temperature { get; set; }

        float Humidity { get; set; }

        float Pressure { get; set; }
        #endregion

        #region Methods

        void AddObserver(IWeatherObserver observer);

        void RemoveObserver(IWeatherObserver observer);

        void NotifyObservers(object args);        
        
        #endregion
    }
}
