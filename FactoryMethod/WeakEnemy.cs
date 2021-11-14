namespace FactoryMethod
{
    public class WeakEnemy : AbstractEnemy
    {
        public override string GetName()
        {
            return "A weak enemy";
        }

        public override int GetStrength()
        {
            return 1;
        }
    }
}