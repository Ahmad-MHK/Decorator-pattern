using System;
using DecoratorPattern.Beverages;

namespace DecoratorPattern.Factories
{
    internal class BeverageFactory : IBeverageFactory
    {
        public Beverage CreateBeverage(BeverageType type, Beverage? baseBeverage = null)
        {
            return type switch
            {
                BeverageType.Espresso => new Espresso(baseBeverage!),
                BeverageType.Chocolate => new Chocolate(baseBeverage!),
                BeverageType.Water => new Water(baseBeverage!),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unsupported beverage type")
            };
        }
    }
}
