using System;

namespace Drinks
{
    public class Drink
    {
        // constructor
        public Drink()
        {
            name = "Water";
            isHot = false;
            color = "clear";
            calories = 0;

        }
        public Drink(string n, bool hot, string clr, int cals) //Param names cannot match attribute names
        {
            name = n;
            isHot = hot;
            color = clr;
            calories = cals;
        }
        
        
        // attributes (fields)
        public string name;
        public bool isHot;
        public string color;
        public int calories;
        
        
        // functions (methods)
        public void sip()
        {
            Console.WriteLine($"Taking a sip of {name}");
        }

        public void displayDrink()
        {
            Console.WriteLine($"{name}, {isHot}, {color}, {calories}");
        }
        // properties
    }
}