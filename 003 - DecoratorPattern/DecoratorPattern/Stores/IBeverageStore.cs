using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;

namespace DecoratorPattern.Stores
{
    internal interface IBeverageStore
    {
        Beverage Order(BeverageType type, Size size = Size.TALL);
    }
}
