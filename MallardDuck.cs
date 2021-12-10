namespace DuckCode
{
    using System;

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehaviour = new Quack();
            FlyBehaviour = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a mallard duck");
        }
    }
}
