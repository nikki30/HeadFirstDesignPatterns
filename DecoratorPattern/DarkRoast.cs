// DarkRoast coffee implements Beverage
using DecoratorPattern;

public class DarkRoast : Beverage
{
    // Constructor
    public DarkRoast(BeverageSize size)
    {
        m_description = "Dark roast";
        m_size = size;
    }

    // calculate base cost of Dark Roast
    public override double Cost() { return 1.00; }
}