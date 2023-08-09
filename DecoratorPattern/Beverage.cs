using System;
using DecoratorPattern;

public abstract class Beverage
{
    protected string m_description;
    protected BeverageSize m_size;

    // get a description of the beverage
    public virtual string Description { get { return m_description; } }

    // get a size of the beverage
    public virtual BeverageSize GetSize()
    {
        return m_size;
    }

    // set a size of the beverage
    public virtual void SetSize(BeverageSize size)
    {
        this.m_size = size;
    }

    // calculate cost of the beverage
    public abstract double Cost();
}