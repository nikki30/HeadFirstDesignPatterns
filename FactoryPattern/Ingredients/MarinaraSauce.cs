using System;
namespace FactoryPattern
{
    public class MarinaraSauce : ISauce
    {
        string ISauce.ToString()
        {
            return "Marinara sauce";
        }
    }
}
