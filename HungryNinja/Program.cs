using System;
using System.Collections.Generic;
namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Red = new Ninja();
            Buffet Pioneer = new Buffet();
            Red.Eat(Pioneer.Serve());
        }
    }
}
