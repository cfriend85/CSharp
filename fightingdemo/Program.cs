using System;
using System.Collections.Generic;

namespace fightingdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are your Characters!! Please select a number corresponding to your character!!");
            List<Character> Players = new List<Character>(){
                new CloseRange("Ken"),
                new CloseRange("Ryu"),
                new LongRange("Dhalsim"),
                new LongRange("Bison"),

            };
            for(int i = 0; i < Players.Count; i++){
                Console.WriteLine($"Type {i} to select");
                Players[i].DisplayStats();
            }

            CloseRange Mario = new CloseRange("Mario");
            Mario.DisplayStats();
            CloseRange Bowser = new CloseRange("Bowser");
            Bowser.DisplayStats();
            Console.WriteLine(Bowser.StrongAttackAmount);

            LongRange Samus = new LongRange("Samus");
            Samus.DisplayStats();

            Mario.WeakAttack(Bowser);
            Bowser.StrongAttack(Mario);
            Samus.WeakAttack(Bowser);
            Samus.StrongAttack(Mario);
            Samus.StrongAttack(Mario);

            Console.WriteLine("Select your character!");
            string choice = Console.ReadLine();
            Character you = Players[Int32.Parse(choice)];
            Console.WriteLine($"You selected {you.Name} as your character!");
        }
    }
}
