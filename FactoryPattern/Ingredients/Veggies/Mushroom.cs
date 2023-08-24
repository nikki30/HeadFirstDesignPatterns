using System;
namespace FactoryPattern
{
    public class Mushroom : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Mushroom";
        }
    }
}
