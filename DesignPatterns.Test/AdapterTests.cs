using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns.Test
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void Adapter_TurkeyCanQuack()
        {
            ITurkey turkey = new WildTurkey();
            IDuck adaptedTurkey = new TurkeyAdapter(turkey);

            var quack = adaptedTurkey.Quack();
            Assert.AreEqual("Gobble gobble gobble!", quack);
        }                
    }
}
