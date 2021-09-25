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
            Coffee.displayDrink();
            Coffee.sip();
        }
    }
}
