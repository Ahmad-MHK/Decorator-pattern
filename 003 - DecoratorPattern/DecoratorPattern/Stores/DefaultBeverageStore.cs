using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;

namespace DecoratorPattern.Stores
{
    internal class DefaultBeverageStore : BeverageStore
    {
        private readonly IBeverageFactory _factory;

        public DefaultBeverageStore(IBeverageFactory factory)
        {
            _factory = factory;
        }

        protected override Beverage CreateBeverage(BeverageType type)
        {
            return _factory.CreateBeverage(type);
        }
    }
}
