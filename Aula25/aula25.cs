using System;

public class Principal
{
    static void Main()
    {
        int num = 10;

        Dobrar(ref num);

        Console.WriteLine("O valor dobrado é {0}", num);
    }

    static void Dobrar(ref int n1)
    {
        n1 *= 2;

    }
}