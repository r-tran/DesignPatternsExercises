using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier _amp;
        private Tuner _tuner;
        private DvdPlayer _dvd;
        private CdPlayer _cd;
        private Projector _projector;
        private TheaterLights _light;
        private Screen _screen;
        private PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, 
            Projector projector, TheaterLights light, Screen screen, PopcornPopper popper)
        {
            _amp = amp;
            _tuner = tuner;
            _dvd = dvd;
            _cd = cd;
            _projector = projector;
            _light = light;
            _screen = screen;
            _popper = popper;            
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            _popper.On();
            _popper.Pop();
            _light.Dim();
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(5);
            _dvd.On();
            _dvd.Play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down");
            _popper.Off();
            _light.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
