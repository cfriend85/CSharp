using System;

namespace HungryNinja
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool isSpicy;
        public bool isSweet;

        public Food(string n, int cals, bool spicy, bool sweet)
        {
            Name = n;
            Calories = cals;
            isSpicy = spicy;
            isSweet = sweet;
        }
    }
}