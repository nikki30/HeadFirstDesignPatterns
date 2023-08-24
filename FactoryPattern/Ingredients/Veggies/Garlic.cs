using System;
namespace FactoryPattern
{
    public class Garlic : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Garlic";
        }
    }
}
