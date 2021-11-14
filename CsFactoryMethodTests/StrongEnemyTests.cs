using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Tests
{
    [TestClass()]
    public class StrongEnemyTests
    {
        private AbstractEnemy enemy;
        [TestInitialize()]
        public void Initialize()
        {
            enemy = new StrongEnemy();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            enemy = null;
        }
        [TestMethod()]
        public void GetNameTest()
        {
            Assert.AreEqual("A strong enemy",enemy.GetName());
        }

        [TestMethod()]
        public void GetStrengthTest()
        {
            Assert.AreEqual(10, enemy.GetStrength());
        }
    }
}