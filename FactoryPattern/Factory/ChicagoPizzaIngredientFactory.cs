using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ChicagoPizzaIngredientFactory()
        {
        }

        public IDough CreateDough()
        {
            Console.WriteLine("Adding Chicago style dough");
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            Console.WriteLine("Adding Chicago marinara sauce");
            return new MarinaraSauce();
        }

        public ICheese AddCheese()
        {
            Console.WriteLine("Adding Chicago cheese");
            return new Mozzarella();
        }

        public IVeggies[] GetVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Mushroom() };
            return veggies;
        }
    }
}
