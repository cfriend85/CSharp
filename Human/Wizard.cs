using System;

namespace Human
{
    public class Wizard : Human
    {
        private int health;
        public Wizard(string n) :base(n)
        {
            health = 50;
            intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int damage = intelligence * 5;
            target.takeDamage(damage);
            health += damage;
            Console.WriteLine($"{name} attacked {target.name} and stole {damage} of thier health!");
            Console.WriteLine(target.Health);
            return target.Health;
        }

        public int Heal(Human target)
        {
            int potion = intelligence * 10;
            target.takePotion(potion);
            return target.Health;
        }
    }
}