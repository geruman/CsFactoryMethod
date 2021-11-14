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
    public class AbstractEnemyTests
    {
        [TestMethod()]
        public void CreateEnemyTest()
        {
            AbstractEnemy enemy = AbstractEnemy.CreateEnemy(EnemyTypes.WEAKENEMY);
            Assert.IsTrue(enemy is WeakEnemy);
            enemy = AbstractEnemy.CreateEnemy(EnemyTypes.STRONGENEMY);
            Assert.IsTrue(enemy is StrongEnemy);
        }
    }
}