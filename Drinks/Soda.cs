using System;

namespace Drinks
{
    // INHERITANCE
    public class Soda : Drink
    {
        public bool isCarbonated;
        public int sugar;

        public Soda(string n, string clr, int cals, int s) : base(n, false, clr, cals)
        {
            isCarbonated = true;
            sugar = s;
        }
    }
}