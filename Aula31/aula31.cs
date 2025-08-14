using System;

public class Aula30
{
    public class Player()
    {
        static public string Name;
        static public int Stamina;
        static public int Health;
        static public int Strength;
        static public void Play(string name)
        {
            Name = name;
            Stamina = 100;
            Health = 100;
            Strength = 50;
        }
        static public void Info()
        {
            Console.WriteLine("Player:...{0}", Name);
            Console.WriteLine("Stamina:..{0}", Stamina);
            Console.WriteLine("Health:...{0}", Health);
            Console.WriteLine("Strength:.{0}", Strength);
        }
    }

    public class Villain
    {
        public string Name;
        public static bool Alerted;

        public Info()
        {
            Console.WriteLine("Villain:...{0}", Name);
            Console.WriteLine("Alerted:..{0}", Alerted ? "Yes" : "No");
        }
    }
    static void Main()
    {
        Player.Play("Naruto");
        Player Enemy = new Villain("Madara");
        Enemy Warrior = new Enemy("Pain");
        Villain.Alerted = true;

        Enemy.Alerted = true;

        Player.Info();
        Console.WriteLine();
        Warrior.Info();
        Console.WriteLine();
        Villain.Info();
    }
}