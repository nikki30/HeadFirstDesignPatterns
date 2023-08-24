using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public interface IPizzaIngredientFactory
    {        
        public IDough CreateDough();

        public ISauce CreateSauce();

        public ICheese AddCheese();

        public IVeggies[] GetVeggies();
    }
}
