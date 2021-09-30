using System;

namespace Human
{
    public class Ninja : Human
    {
        private int health;
        public Ninja(string n) :base(n)
        {
            dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int damage = dexterity * 5;
            target.takeDamage(damage);
            Random rand = new Random();
            int moreDamage = rand.Next(0,11);
            if(moreDamage <= 2){
                Console.WriteLine("Bonus damage!");
                target.takeDamage(moreDamage);
            }
            return target.Health;
        }

        public void Steal(Human target)
        {
            target.takeDamage(5);
            health += 5;
            Console.WriteLine($"{name} stole 5 health from {target.name} and added it to their health!");
        }
    }
}