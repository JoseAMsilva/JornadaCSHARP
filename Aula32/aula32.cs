using System;

public class Aula32
{
    public class Calcular
    {
        public int v1;
        public int v2;
        public Calcular(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public int Somar()
        {
            return v1 + v2;
        }
    }
    public static void Main()
    {
        Calcular num = new Calcular(10, 2);

        Console.WriteLine("A soma é: {0}", num.Somar());
    }
}