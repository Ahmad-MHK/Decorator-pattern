using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Espresso
            Beverage espresso = new Espresso();
            espresso.Size = Size.GRANDE;
            PrintBeverage(espresso);

            // Doppio
            Beverage doppio = new Espresso();
            doppio = new Espresso(doppio);
            doppio.Size = Size.GRANDE;
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            lungo.Size = Size.TALL;
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            macchiato.Size = Size.VENDI;
            PrintBeverage(macchiato);

            // Corretta
            Beverage corretta = new Espresso();
            corretta = new Liqour(corretta); 
            PrintBeverage(corretta);

            // Con Panna
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            conPanna.Size = Size.VENDI;
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = new Espresso();
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            cappuccino.Size = Size.GRANDE;
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            macchiato.Size = Size.VENDI;
            PrintBeverage(americano);

            // Caffé Latte
            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite.Size = Size.GRANDE;
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            romana.Size = Size.VENDI;
            PrintBeverage(romana);

            // Marocchino
            Beverage marocchino = new Espresso();
            marocchino = new Chocolate(marocchino);
            marocchino = new MilkFoam(marocchino);
            PrintBeverage(marocchino);

            // Mocha
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            mocha.Size = Size.GRANDE;
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin); 
            bicerin = new WhiteChocolate(bicerin); 
            bicerin = new Whip(bicerin);
            bicerin.Size = Size.VENDI;
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve); 
            PrintBeverage(breve);

            // Raf coffee
            Beverage rafCoffee = new Espresso();
            rafCoffee = new VanillaSugar(rafCoffee); 
            rafCoffee = new Cream(rafCoffee); 
            rafCoffee.Size = Size.GRANDE;
            PrintBeverage(rafCoffee);

            // Mead raf
            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf); 
            meadRaf = new Cream(meadRaf);
            meadRaf.Size = Size.VENDI;
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            // Caffé affogato
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new IceCream(caffeAffogato); 
            caffeAffogato.Size = Size.GRANDE;
            PrintBeverage(caffeAffogato);

            // Vienna coffee
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            glace.Size = Size.GRANDE;
            PrintBeverage(glace);

            // Chocolate milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk.Size = Size.VENDI;
            PrintBeverage(chocolateMilk);

            // Demi – crème
            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // Latte macchiato
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            latteMacchiato.Size = Size.GRANDE;
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            freddo.Size = Size.VENDI;
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            frappuccino.Size = Size.GRANDE;
            PrintBeverage(frappuccino);

            // Caramel frappuccino
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Whip(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino); 
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            frappe.Size = Size.VENDI;
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = new Espresso();
            irishCoffee = new Whiskey(irishCoffee); 
            irishCoffee = new Whip(irishCoffee);
            irishCoffee.Size = Size.VENDI;
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ({beverage.Size}) ${beverage.cost():#.##}");
        }
    }
}