using System;

public class Principal
{
    static void Main()
    {
        int divisor, dividendo, resto;
        divisor = 10;
        dividendo = 3;

        int quociente = Dividir(divisor, dividendo, out resto);

        Console.WriteLine("O quociente de {0} / {1} é {2} e o resto é {3}", divisor, dividendo, quociente, resto);

    }

    static int Dividir(int n1, int n2, out int r)
    {
        int quoc = n1 / n2;
        r = n1 % n2;
        return quoc;
    }
    
}