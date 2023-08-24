using System;
namespace FactoryPattern
{
    public class Mozzarella : ICheese
    {
        string ICheese.ToString()
        {
            return "Mozzarella";
        }
    }
}
