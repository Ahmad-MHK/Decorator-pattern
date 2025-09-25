using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factories
{
    internal interface IBeverageFactory
    {
        Beverage CreateBeverage(BeverageType type, Beverage? baseBeverage = null);
    }
}
