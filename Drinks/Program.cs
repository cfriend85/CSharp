using System;
using System.Collections.Generic;

namespace Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ABSTRACT CLASS no longer allows basic instances of the Drink class.

            // YOU MUST BE SPECIFIC!! Like on line 25 how it says Soda Pepsi = new Soda() that is explicitly telling it that it is a Soda.
            
            // Drink Water = new Drink();
            // Water.displayDrink();
            // Drink Coffee = new Drink("Coffee", true, "Mud", 50);
            // Drink Juice = new Drink("Orange Juice", false, "Yellow", 39);
            // Coffee.displayDrink();
            // Juice.displayDrink();
            // Coffee.sip();
            // Console.WriteLine(Coffee.Calories);
            // Coffee.name = "Super delicious Coffee";
            // Coffee.addSugar(10);

            Soda Pepsi = new Soda("Pepsi", "Black", 150, 40);
            Pepsi.displayDrink();
            Pepsi.sip();

            Dessert chocoShake = new Dessert("Chocolate Shake", false, "Brown", 300, true, "Chocolate", false);
            chocoShake.displayDrink();
            chocoShake.sip();
            
            
            Pepsi.addAlcohol(0.1);


        // IENUMERABLE - This allows you to build a list of mulitiple types by building the list with it's Parent elements (Drink).
        // You can only do things with each that all of them have in common. i.e Drink class does not contain the IAlcoholic interface therefore
        // you cannot run d.addAlcohol().
            List<Drink> DrinkMenu = new List<Drink>();
            DrinkMenu.Add(Pepsi);
            DrinkMenu.Add(chocoShake);

            foreach(Drink d in DrinkMenu)
            {
                d.displayDrink();
                d.sip();
            }
        }
    }
}
