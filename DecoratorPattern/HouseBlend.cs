// HouseBlend coffee implements Beverage
using DecoratorPattern;

public class HouseBlend : Beverage
{
    // Constructor
    public HouseBlend(BeverageSize size)
    {
        m_description = "House blend";
        m_size = size;
    }

    // calculate base cost of House Blend
    public override double Cost()
    {
        return 0.89;
    }
}
