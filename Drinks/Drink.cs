using System;

namespace Drinks
{
    public abstract class Drink
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
        private int calories;
        
        
        // properties
        public int Calories
        {
            get { return calories; }
        }
        
        
        // functions (methods)
        public virtual void sip()
        {
            Console.WriteLine($"Taking a sip of {name}");
        }

        public void displayDrink()
        {
            string temp = isHot.ToString();
            if(temp == "True"){
                temp = "Hot";
            }
            else{
                temp = "Cold";
            }
            Console.WriteLine($"{name}, {temp}, {color}, {calories}");
        }

        
        public void addSugar(int amount)
        {
            calories += amount;
            Console.WriteLine($"You added sugar to your {name}, bringing the calorie count to {Calories}");
             //This alters the private version of calories. The public version still just returns the value of the private one.
        }
    }
}