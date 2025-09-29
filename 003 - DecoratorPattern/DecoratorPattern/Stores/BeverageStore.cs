using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;

namespace DecoratorPattern.Stores
{
    internal abstract class BeverageStore : IBeverageStore
    {
        public Beverage Order(BeverageType type, Size size = Size.TALL)
        {
            var beverage = CreateBeverage(type); 
            beverage.Size = size;                
            return beverage;
        }

        // Factory Method to be implemented by concrete stores
        protected abstract Beverage CreateBeverage(BeverageType type);
    }
}
