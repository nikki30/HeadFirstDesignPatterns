using System;
namespace FactoryPattern
{
    public class ThinCrustDough : IDough
    {
        string IDough.ToString()
        {
            return "Thin Crust dough";
        }
    }
}
