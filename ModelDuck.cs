namespace DuckCode
{
    using System;

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
