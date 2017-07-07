using System.Configuration;
using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Structural.Proxy;

namespace DesignPatterns.Test
{
    [TestClass]
    public class ProxyTests    
    {
        // Not really a test
        [TestMethod]
        public void Proxy_TestProtection()
        {            
            SecurityDoor security = new SecurityDoor(new LabDoor());            
            security.SetPassword("Hello");
            security.OpenDoor();
            security.SetPassword("S3cR3T!");
            security.OpenDoor();
            security.CloseDoor();
        }
    }
}
