namespace DuckCode
{
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.setFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();
            model.PerformQuack();
            return;
        }
    }
}
