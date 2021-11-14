using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class AbstractEnemy
    {
        public abstract int GetStrength();
        public abstract string GetName();
        public static AbstractEnemy CreateEnemy(EnemyTypes type)
        {
            switch (type)
            {
                case EnemyTypes.WEAKENEMY:
                    return new WeakEnemy();
                case EnemyTypes.STRONGENEMY:
                    return new StrongEnemy();
                default:
                    return null;
            }
        }
    }
}
