using System;

namespace fightingdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CloseRange Mario = new CloseRange("Mario");
            Mario.DisplayStats();
            CloseRange Bowser = new CloseRange("Bowser");
            Bowser.DisplayStats();
            Console.WriteLine(Bowser.StrongAttackAmount);
        }
    }
}
