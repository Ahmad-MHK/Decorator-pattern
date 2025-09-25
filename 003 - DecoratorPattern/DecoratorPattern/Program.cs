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
            Beverage doppio = factory.CreateBeverage(BeverageType.Doppio);
            doppio.Size = Size.GRANDE;
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = factory.CreateBeverage(BeverageType.Lungo);
            lungo.Size = Size.TALL;
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = factory.CreateBeverage(BeverageType.Macchiato);
            macchiato.Size = Size.VENDI;
            PrintBeverage(macchiato);

            // Corretta
            Beverage corretta = factory.CreateBeverage(BeverageType.Corretta);
            PrintBeverage(corretta);

            // Con Panna
            Beverage conPanna = factory.CreateBeverage(BeverageType.ConPanna);
            conPanna.Size = Size.VENDI;
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = factory.CreateBeverage(BeverageType.Cappuccino);
            cappuccino.Size = Size.GRANDE;
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = factory.CreateBeverage(BeverageType.Americano);
            americano.Size = Size.VENDI;
            PrintBeverage(americano);

            // Caffe Latte
            Beverage caffeLatte = factory.CreateBeverage(BeverageType.CaffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = factory.CreateBeverage(BeverageType.FlatWhite);
            flatWhite.Size = Size.GRANDE;
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = factory.CreateBeverage(BeverageType.Romana);
            romana.Size = Size.VENDI;
            PrintBeverage(romana);

            // Marocchino
            Beverage marocchino = factory.CreateBeverage(BeverageType.Marocchino);
            PrintBeverage(marocchino);

            // Mocha
            Beverage mocha = factory.CreateBeverage(BeverageType.Mocha);
            mocha.Size = Size.GRANDE;
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = factory.CreateBeverage(BeverageType.Bicerin);
            bicerin.Size = Size.VENDI;
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = factory.CreateBeverage(BeverageType.Breve);
            PrintBeverage(breve);

            // Raf coffee
            Beverage rafCoffee = factory.CreateBeverage(BeverageType.RafCoffee);
            rafCoffee.Size = Size.GRANDE;
            PrintBeverage(rafCoffee);

            // Mead raf
            Beverage meadRaf = factory.CreateBeverage(BeverageType.MeadRaf);
            meadRaf.Size = Size.VENDI;
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = factory.CreateBeverage(BeverageType.Galao);
            PrintBeverage(galao);

            // Caffe affogato
            Beverage caffeAffogato = factory.CreateBeverage(BeverageType.CaffeAffogato);
            caffeAffogato.Size = Size.GRANDE;
            PrintBeverage(caffeAffogato);

            // Vienna coffee
            Beverage viennaCoffee = factory.CreateBeverage(BeverageType.ViennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = factory.CreateBeverage(BeverageType.Glace);
            glace.Size = Size.GRANDE;
            PrintBeverage(glace);

            // Chocolate milk
            Beverage chocolateMilk = factory.CreateBeverage(BeverageType.ChocolateMilk);
            chocolateMilk.Size = Size.VENDI;
            PrintBeverage(chocolateMilk);

            // Demi - creme
            Beverage demiCreme = factory.CreateBeverage(BeverageType.DemiCreme);
            PrintBeverage(demiCreme);

            // Latte macchiato
            Beverage latteMacchiato = factory.CreateBeverage(BeverageType.LatteMacchiato);
            latteMacchiato.Size = Size.GRANDE;
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = factory.CreateBeverage(BeverageType.Freddo);
            freddo.Size = Size.VENDI;
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = factory.CreateBeverage(BeverageType.Frappuccino);
            frappuccino.Size = Size.GRANDE;
            PrintBeverage(frappuccino);

            // Caramel frappuccino
            Beverage caramelFrappuccino = factory.CreateBeverage(BeverageType.CaramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = factory.CreateBeverage(BeverageType.Frappe);
            frappe.Size = Size.VENDI;
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = factory.CreateBeverage(BeverageType.IrishCoffee);
            irishCoffee.Size = Size.VENDI;
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}
