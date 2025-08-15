using System;

public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");//Primeiro a ser chamado
    }

}
public class Derivada1 : Base
{
    public Derivada1() : base()
    {
        Console.WriteLine("Construtor da classe Derivada 1");//segundo a ser chamado
    }
}

public class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");//terceiro a ser chamado
    }
}
public class Aula37
{
    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();//Sempre da classe base para a derivada mais específica
    }
}