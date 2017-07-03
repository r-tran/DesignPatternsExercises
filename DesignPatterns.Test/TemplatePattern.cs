using DesignPatterns.Behavioral.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Test
{
    [TestClass]
    public class TemplatePattern
    {
        // Not really a test, just an illustration of hooks
        [TestMethod]
        public void TemplateMethod_CanUseHooks()
        {
            CaffeineBeverageWithHook coffee = new CoffeWithHook();
            CaffeineBeverageWithHook tea = new TeaWithHook();
            System.Console.WriteLine("Making coffee....");
            coffee.PrepareRecipe();
            System.Console.WriteLine("Making tea.....");
            tea.PrepareRecipe();
        }
    }
}
