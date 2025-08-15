using System;

public class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");//Primeiro a ser chamado
    }
    virtual public void Info(){}//Método virtual que pode ser sobrescrito
    

}
public class Derivada1 : Base
{
    public Derivada1() : base()
    {
        Console.WriteLine("Construtor da classe Derivada 1");//segundo a ser chamado
    }
    override public void Info()//Sobrescrevendo o método Info da classe Base
    {
        Console.WriteLine("Derivada 1");
    }

}

public class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");//terceiro a ser chamado
    }
    override public void Info()//Sobrescrevendo o método Info da classe Derivada1
    {
        Console.WriteLine("Derivada 2");
    }
}
public class Aula38
{
    static void Main()
    {
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Console.WriteLine();
        Derivada2 derivada2 = new Derivada2();
        Ref = derivada1;
        Ref.Info();//Chamando o método Info da classe Derivada1, usando o objeto de Referência, que sobrescreve o método Info da classe Base
        derivada2.Info();//Chamando o método Info da classe Derivada2, que sobrescreve o método da classe Base
    
    }
}