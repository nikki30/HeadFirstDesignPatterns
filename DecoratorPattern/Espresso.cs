// Espresso coffee implements Beverage
using DecoratorPattern;

public class Espresso : Beverage
{
    // Constructor
    public Espresso(BeverageSize size)
    {
        m_description = "Espresso";
        m_size = size;
    }

    // calculate base cost of Espresso
    public override double Cost() { return 1.99; }
}