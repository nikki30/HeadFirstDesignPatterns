using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public NYPizzaIngredientFactory()
        {
        }

        public IDough CreateDough()
        {
            Console.WriteLine("Adding NY style dough");
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            Console.WriteLine("Adding marinara sauce");
            return new MarinaraSauce();
        }

        public ICheese AddCheese()
        {
            Console.WriteLine("Adding reggiano cheese");
            return new ReggianoCheese();
        }

        public IVeggies[] GetVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom() };
            return veggies;
        }
    }
}
