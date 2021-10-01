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

    public void WeakAttack(Character target)
    {
        target.Damage += WeakAttackAmount;
        Console.WriteLine($"{Name} weak attacked {target.Name} dealing {WeakAttackAmount} damage! Raising {target.Name}'s damage to {target.Damage}%!");
        target.CalculateKO();
    }

    public void StrongAttack(Character target)
    {
        target.Damage += StrongAttackAmount;
        Console.WriteLine($"{Name} strong attacked {target.Name} dealing {StrongAttackAmount} damage! Raising {target.Name}'s damage to {target.Damage}%!");
        target.CalculateKO();
    }

    public void CalculateKO()
    {
        Random rand = new Random();
        if(Damage > 300 && rand.Next(0,5) >= 1){
            Console.WriteLine($"{Name} has been knocked out!");
            isAlive = false;
            }
        else if(Damage > 200 && rand.Next(0,5) >= 3){
            Console.WriteLine($"{Name} has been knocked out!");
            isAlive = false;
            }
        else if(Damage > 100 && rand.Next(0,5) == 4){
            Console.WriteLine($"{Name} has been knocked out!");
            isAlive = false;
            }
        }
    }
    }