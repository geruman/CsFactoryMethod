using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractEnemy enemy1 = AbstractEnemy.CreateEnemy(EnemyTypes.WEAKENEMY);
            AbstractEnemy enemy2 = AbstractEnemy.CreateEnemy(EnemyTypes.STRONGENEMY);
            Console.WriteLine("Enemy 1");
            Console.WriteLine(enemy1.GetName());
            Console.WriteLine(enemy1.GetStrength());
            Console.WriteLine("Enemy 2");
            Console.WriteLine(enemy2.GetName());
            Console.WriteLine(enemy2.GetStrength());
            Console.ReadKey();
        }
    }
}
