using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;
using DecoratorPattern.Stores;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBeverageFactory factory = new BeverageFactory();
            IBeverageStore store = new DefaultBeverageStore(factory);

            // Espresso
            Beverage espresso = store.Order(BeverageType.Espresso, Size.GRANDE);
            PrintBeverage(espresso);

            // Doppio
            Beverage doppio = store.Order(BeverageType.Doppio, Size.GRANDE);
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = store.Order(BeverageType.Lungo, Size.TALL);
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = store.Order(BeverageType.Macchiato, Size.VENDI);
            PrintBeverage(macchiato);

            // Corretta
            Beverage corretta = store.Order(BeverageType.Corretta);
            PrintBeverage(corretta);

            // Con Panna
            Beverage conPanna = store.Order(BeverageType.ConPanna, Size.VENDI);
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = store.Order(BeverageType.Cappuccino, Size.GRANDE);
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = store.Order(BeverageType.Americano, Size.VENDI);
            PrintBeverage(americano);

            // Caffe Latte
            Beverage caffeLatte = store.Order(BeverageType.CaffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = store.Order(BeverageType.FlatWhite, Size.GRANDE);
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = store.Order(BeverageType.Romana, Size.VENDI);
            PrintBeverage(romana);

            // Marocchino
            Beverage marocchino = store.Order(BeverageType.Marocchino);
            PrintBeverage(marocchino);

            // Mocha
            Beverage mocha = store.Order(BeverageType.Mocha, Size.GRANDE);
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = store.Order(BeverageType.Bicerin, Size.VENDI);
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = store.Order(BeverageType.Breve);
            PrintBeverage(breve);

            // Raf coffee
            Beverage rafCoffee = store.Order(BeverageType.RafCoffee, Size.GRANDE);
            PrintBeverage(rafCoffee);

            // Mead raf
            Beverage meadRaf = store.Order(BeverageType.MeadRaf, Size.VENDI);
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = store.Order(BeverageType.Galao);
            PrintBeverage(galao);

            // Caffe affogato
            Beverage caffeAffogato = store.Order(BeverageType.CaffeAffogato, Size.GRANDE);
            PrintBeverage(caffeAffogato);

            // Vienna coffee
            Beverage viennaCoffee = store.Order(BeverageType.ViennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = store.Order(BeverageType.Glace, Size.GRANDE);
            PrintBeverage(glace);

            // Chocolate milk
            Beverage chocolateMilk = store.Order(BeverageType.ChocolateMilk, Size.VENDI);
            PrintBeverage(chocolateMilk);

            // Demi - creme
            Beverage demiCreme = store.Order(BeverageType.DemiCreme);
            PrintBeverage(demiCreme);

            // Latte macchiato
            Beverage latteMacchiato = store.Order(BeverageType.LatteMacchiato, Size.GRANDE);
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = store.Order(BeverageType.Freddo, Size.VENDI);
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = store.Order(BeverageType.Frappuccino, Size.GRANDE);
            PrintBeverage(frappuccino);

            // Caramel frappuccino
            Beverage caramelFrappuccino = store.Order(BeverageType.CaramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = store.Order(BeverageType.Frappe, Size.VENDI);
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = store.Order(BeverageType.IrishCoffee, Size.VENDI);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
