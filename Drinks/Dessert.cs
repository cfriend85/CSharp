using System;

namespace Drinks
{
    public class Dessert : Drink
    {
        public bool hasCream;
        public string flavor;
        public bool isVegan;

        public override void sip()
        {
            base.sip(); //you can turn this off and just use the new message but if you wanted to include the base message this is here for that.
            Console.WriteLine("Sweet!");
        }

        public void addCream()
        {
            hasCream = true;
        }

        public Dessert(string n, bool hot, string clr, int cals, bool cream, string f, bool v) : base(n, hot, clr, cals)
        {
            hasCream = cream;
            flavor = f;
            isVegan = v;
        }
    }
}