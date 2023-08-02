namespace DuckCode
{
    using System;

    public abstract class Duck
    {
        public FlyBehaviour FlyBehaviour;
        public QuackBehaviour QuackBehaviour;

        public Duck()
        {
        }

        public abstract void display();

        public void PerformFly()
        {
            FlyBehaviour.fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.quack();
        }

        public void setQuackBehaviour(QuackBehaviour qb)
        {
            QuackBehaviour = qb;
        }

        // implementation should not be tied here - then we can't change the behaviour at run time
        public void setFlyBehaviour(FlyBehaviour fb)
        {
            FlyBehaviour = fb;
        }

        public void swim()
        {
            Console.WriteLine("All ducks float");
        }
    }
}
