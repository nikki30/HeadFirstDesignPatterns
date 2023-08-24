using System;
namespace FactoryPattern
{
    public class ThickCrustDough : IDough
    {
        string IDough.ToString()
        {
            return "Thick Crust dough";
        }
    }
}
