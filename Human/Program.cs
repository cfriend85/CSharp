using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human oConner = new Human("O'Conner");
            oConner.displayHuman();
            Human Toretto = new Human("Toretto", 100, 1000, 50, 500);
            oConner.Attack(Toretto);
            Wizard Gandalf = new Wizard("Gandalf");
            Gandalf.Attack(Toretto);
            Gandalf.Heal(oConner);
            Ninja Raz = new Ninja("Raz");
            Raz.Attack(Toretto);
            Raz.Steal(Toretto);
            Samurai Ronin = new Samurai("Ronin");
            Console.WriteLine(Ronin.Meditate());
            Ronin.Attack(Toretto);
        }
    }
}
