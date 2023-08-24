using System;
namespace FactoryPattern
{
    public class ReggianoCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "Reggiano";
        }
    }
}
