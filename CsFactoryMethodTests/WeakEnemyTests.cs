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
    public class WeakEnemyTests
    {
        private AbstractEnemy enemy;
        [TestInitialize()]
        public void Initialize()
        {
            enemy = new WeakEnemy();
        }
        [TestMethod()]
        public void GetNameTest()
        {
            Assert.AreEqual("A weak enemy", enemy.GetName());
        }

        [TestMethod()]
        public void GetStrengthTest()
        {
            Assert.AreEqual(1, enemy.GetStrength());
        }
    }
}