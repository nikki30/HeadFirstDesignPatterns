using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso(BeverageSize.Tall);
            Console.WriteLine(espresso.Cost());

            Beverage beverage2 = new HouseBlend(BeverageSize.Grande);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.Cost());
            Console.WriteLine(beverage2.Description);
        }
    }
}
