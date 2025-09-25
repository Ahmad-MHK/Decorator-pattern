using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBeverageFactory factory = new BeverageFactory();

            // Espresso
            Beverage espresso = factory.CreateBeverage(BeverageType.Espresso);
            espresso.Size = Size.GRANDE;
            PrintBeverage(espresso);

            // Doppio
            Beverage doppio = factory.CreateBeverage(BeverageType.Espresso);
            doppio.Size = Size.GRANDE;
            doppio = factory.CreateBeverage(BeverageType.Espresso, doppio);
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = factory.CreateBeverage(BeverageType.Espresso);
            lungo = factory.CreateBeverage(BeverageType.Water, lungo);
            lungo.Size = Size.TALL;
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = factory.CreateBeverage(BeverageType.Espresso);
            macchiato.Size = Size.VENDI;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            // Corretta
            Beverage corretta = factory.CreateBeverage(BeverageType.Espresso);
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            // Con Panna
            Beverage conPanna = factory.CreateBeverage(BeverageType.Espresso);
            conPanna.Size = Size.VENDI;
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = factory.CreateBeverage(BeverageType.Espresso);
            cappuccino.Size = Size.GRANDE;
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = factory.CreateBeverage(BeverageType.Espresso);
            americano.Size = Size.VENDI;
            americano = factory.CreateBeverage(BeverageType.Water, americano);
            americano = factory.CreateBeverage(BeverageType.Water, americano);
            PrintBeverage(americano);

            // Caffe Latte
            Beverage caffeLatte = factory.CreateBeverage(BeverageType.Espresso);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = factory.CreateBeverage(BeverageType.Espresso);
            flatWhite.Size = Size.GRANDE;
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = factory.CreateBeverage(BeverageType.Espresso);
            romana.Size = Size.VENDI;
            romana = new Lemon(romana);
            PrintBeverage(romana);

            // Marocchino
            Beverage marocchino = factory.CreateBeverage(BeverageType.Espresso);
            marocchino = factory.CreateBeverage(BeverageType.Chocolate, marocchino);
            marocchino = new MilkFoam(marocchino);
            PrintBeverage(marocchino);

            // Mocha
            Beverage mocha = factory.CreateBeverage(BeverageType.Espresso);
            mocha.Size = Size.GRANDE;
            mocha = factory.CreateBeverage(BeverageType.Chocolate, mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = factory.CreateBeverage(BeverageType.Espresso);
            bicerin.Size = Size.VENDI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = factory.CreateBeverage(BeverageType.Espresso);
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            // Raf coffee
            Beverage rafCoffee = factory.CreateBeverage(BeverageType.Espresso);
            rafCoffee.Size = Size.GRANDE;
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            // Mead raf
            Beverage meadRaf = factory.CreateBeverage(BeverageType.Espresso);
            meadRaf.Size = Size.VENDI;
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = factory.CreateBeverage(BeverageType.Espresso);
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            // Caffe affogato
            Beverage caffeAffogato = factory.CreateBeverage(BeverageType.Espresso);
            caffeAffogato.Size = Size.GRANDE;
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            // Vienna coffee
            Beverage viennaCoffee = factory.CreateBeverage(BeverageType.Espresso);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = factory.CreateBeverage(BeverageType.Espresso);
            glace.Size = Size.GRANDE;
            glace = new IceCream(glace);
            PrintBeverage(glace);

            // Chocolate milk
            Beverage chocolateMilk = factory.CreateBeverage(BeverageType.Chocolate);
            chocolateMilk.Size = Size.VENDI;
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // Demi - creme
            Beverage demiCreme = factory.CreateBeverage(BeverageType.Espresso);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // Latte macchiato
            Beverage latteMacchiato = factory.CreateBeverage(BeverageType.Espresso);
            latteMacchiato.Size = Size.GRANDE;
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = factory.CreateBeverage(BeverageType.Espresso);
            freddo.Size = Size.VENDI;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = factory.CreateBeverage(BeverageType.Espresso);
            frappuccino.Size = Size.GRANDE;
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // Caramel frappuccino
            Beverage caramelFrappuccino = factory.CreateBeverage(BeverageType.Espresso);
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Whip(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = factory.CreateBeverage(BeverageType.Espresso);
            frappe.Size = Size.VENDI;
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = factory.CreateBeverage(BeverageType.Espresso);
            irishCoffee.Size = Size.VENDI;
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
