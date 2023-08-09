// Mocha implements the CondimentDecorater
using DecoratorPattern;

public class Mocha : CondimentDecorator
{
    // Condiment decorator has-a Beverage (recursion!)
    private Beverage m_beverage;
    private new BeverageSize m_size;

    // Constructor binds the object passed to member var
    public Mocha(Beverage beverage)
    {
        this.m_beverage = beverage;
        m_size = m_beverage.GetSize();
    }

    // getter implements abstract class Description
    public override string Description
    {
        get
        {
            return m_beverage.Description + ", Mocha";
        }
    }

    // get the Cost of the condiment plus the base-cost
    // of the original beverage
    public override double Cost()               
    {
        if (m_size == DecoratorPattern.BeverageSize.Venti)
        {
            return 0.40 + m_beverage.Cost();
        }
        else if (m_size == DecoratorPattern.BeverageSize.Grande)
        {
            return 0.30 + m_beverage.Cost();
        }
        else
        {
            return 0.20 + m_beverage.Cost();
        }
    }
}