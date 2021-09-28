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
            Drink Juice = new Drink("Orange Juice", false, "Yellow", 39);
            Coffee.displayDrink();
            Juice.displayDrink();
            Coffee.sip();
            Console.WriteLine(Coffee.Calories);
            Coffee.name = "Super delicious Coffee";
            Coffee.addSugar(10);

            Soda Pepsi = new Soda("Pepsi", "Black", 150, 40);
            Pepsi.displayDrink();
            Pepsi.sip();

            Dessert chocoShake = new Dessert("Chocolate Shake", false, "Brown", 300, true, "Chocolate", false);
            chocoShake.displayDrink();
            chocoShake.sip();
        }
    }
}
