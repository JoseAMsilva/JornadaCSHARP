using System;

sealed public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base selada");
    }
}
public class Aula40
{
    static void Main()
    {
        Base baseObj = new Base();
        // Base não pode ser herdada, pois é sealed
        // class Derivada : Base {} // Isso causaria um erro de compilação
        Console.WriteLine("A classe Base foi instanciada.");
    }
}