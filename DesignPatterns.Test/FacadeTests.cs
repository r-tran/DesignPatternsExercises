using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns.Test
{
    [TestClass]
    public class FacadeTests
    {
        // Demonstration of least knowledge principle, not a test
        [TestMethod]
        public void FacadeHomeTheater_SimplifiesInterface()
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Projector proj = new Projector();
            Screen screen = new Screen();
            TheaterLights light = new TheaterLights();
            PopcornPopper pop = new PopcornPopper(); 
            HomeTheaterFacade facade = new HomeTheaterFacade(amp, tuner, dvd, cd, proj, light, screen, pop);

            facade.WatchMovie("Inception");
            facade.endMovie();
        }
    }
}
