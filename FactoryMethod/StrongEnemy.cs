namespace FactoryMethod
{
    public class StrongEnemy : AbstractEnemy
    {
        public override string GetName()
        {
            return "A strong enemy";
        }

        public override int GetStrength()
        {
            return 10;
        }
    }
}