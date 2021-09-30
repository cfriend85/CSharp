using System;

namespace Human
{
    public class Samurai : Human
    {
        private int health;
        public Samurai(string n) :base(n)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.Health < 50){
                target.takeDamage(target.Health);
            }
            return target.Health;
        }

        public string Meditate()
        {
            health = 200;
            return $"Mediation complete, health restored to {health}";
        }
    }
}