using System;
namespace FactoryPattern
{
    public class Onion : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Onion";
        }
    }
}
