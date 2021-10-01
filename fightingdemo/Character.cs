using System;

namespace fightingdemo
{
    public class Character
    {
        public string Name;
        public int Damage;
        public bool isAlive;
        public string CombatStyle;
        public int WeakAttackAmount;
        public int StrongAttackAmount;

    public Character(string N, string CS, int WA, int SA)
    {
        Name = N;
        Damage = 0;
        isAlive = true;
        CombatStyle = CS;
        WeakAttackAmount = WA;
        StrongAttackAmount = SA;
    }

    public void DisplayStats()
    {
        Console.WriteLine("------------------");
        Console.WriteLine($"Name:         {Name}");
        Console.WriteLine($"Combat Style: {CombatStyle}");
        Console.WriteLine("------------------");
    }
    }
}