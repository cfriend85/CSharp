using System;

namespace Drinks
{
    // INHERITANCE
    public class Soda : Drink, IAlcoholic
    {
        public bool isCarbonated;
        public int sugar;
        public double abv {get;set;}

        public void addAlcohol(double amount)
        {
            abv += amount;
            Console.WriteLine($"You added some alcohol to your drink, making it {abv}%!");
        }

        public Soda(string n, string clr, int cals, int s) : base(n, false, clr, cals)
        {
            isCarbonated = true;
            sugar = s;
            abv = 0.0;
        }
    }
}