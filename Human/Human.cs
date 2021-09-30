using System;

namespace Human
{
    public class Human
    {
        public Human(string n)
        {
            name = n;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string n, int s, int i, int d, int h)
        {
            name = n;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }

        public void displayHuman()
        {
            Console.WriteLine($"{name} has {strength} strength, {intelligence} intelligence, {dexterity} dexterity and {health} health");
        }

        public virtual int Attack(Human target)
        {
            int damage = strength * 5;
            target.health -= damage;
            Console.WriteLine($"{name} attacked {target.name} and dealt {damage} damage! Leaving {target.name} with {target.health} health!");
            return target.health;
        }

        public int takeDamage(int damage)
        {
            health -= damage;
            return Health; 
        }

        public int takePotion(int potion)
        {
            health += potion;
            return Health;
        }
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        private int health;

        public int Health
        {
            get { return health; }
        }
    }
}