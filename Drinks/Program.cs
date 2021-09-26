using System;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink Water = new Drink();
            Water.displayDrink();
            Drink Coffee = new Drink("Coffee", true, "Mud", 50);
            Drink Soda = new Drink("Pepsi", false, "Black", 150);
            Coffee.displayDrink();
            Soda.displayDrink();
            Coffee.sip();
            Console.WriteLine(Coffee.Calories);
            Coffee.name = "Super delicious Coffee";
            Coffee.addSugar(10);
        }
    }
}
