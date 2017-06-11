using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Test
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void LazyDoubleCheckedProduction_Singleton_EnsuresOneInstance()
        {
            var president1 = LazyDoubleCheckedLockingProduction.President.Instance;
            var president2 = LazyDoubleCheckedLockingProduction.President.Instance;
            var president3 = LazyDoubleCheckedLockingProduction.President.Instance;

            Assert.AreEqual(president1, president2);
            Assert.AreEqual(president2, president3);
        }

        [TestMethod]
        public void LazyImplementation_Singleton_EnsuresOneInstance()
        {
            var president1 = LazyImplementation.President.Instance;
            var president2 = LazyImplementation.President.Instance;
            var president3 = LazyImplementation.President.Instance;

            Assert.AreEqual(president1, president2);
            Assert.AreEqual(president2, president3);
        }

        [TestMethod]
        public void LazyImplementationUsingSyncLock_Singleton_EnsuresOneInstance()
        {
            var president1 = LazyImplementationUsingSyncLock.President.Instance;
            var president2 = LazyImplementationUsingSyncLock.President.Instance;
            var president3 = LazyImplementationUsingSyncLock.President.Instance;

            Assert.AreEqual(president1, president2);
            Assert.AreEqual(president2, president3);
        }

        [TestMethod]
        public void LazyImplementationUsingDoubleCheckedSyncLock_Singleton_EnsuresOneInstance()
        {
            var president1 = LazyImplementationUsingDoubleCheckedSyncLock.President.Instance;
            var president2 = LazyImplementationUsingDoubleCheckedSyncLock.President.Instance;
            var president3 = LazyImplementationUsingDoubleCheckedSyncLock.President.Instance;

            Assert.AreEqual(president1, president2);
            Assert.AreEqual(president2, president3);
        }
    }
}
