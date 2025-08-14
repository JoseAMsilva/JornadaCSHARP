using System;

public class Principal
{
    public class Player()
    {
        public string Name;
        public int Stamina;
        public int Health;
        public int Strength;
        public Player(string name, int stamina, int health, int strength)
        {
            Name = name;
            Stamina = stamina;
            Health = health;
            Strength = strength;
        }
        public void Info()
        {
            Console.WriteLine("Player:...{0}", Name);
            Console.WriteLine("Stamina:..{0}", Stamina);
            Console.WriteLine("Health:...{0}", Health);
            Console.WriteLine("Strength:.{0}", Strength);
        }
    }
    static void Main()
    {
        Player Hero = new Player("Hero", 100, 100, 50);
        Player Villain = new Player("Villain", 80, 120, 60);

        Hero.Info();
        Console.WriteLine();
        Villain.Info();
    }
}