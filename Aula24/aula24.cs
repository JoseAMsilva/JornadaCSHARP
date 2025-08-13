using System;

public class Principal
{
    static void Main()
    {
        int v1, v2, res;
        Console.WriteLine("Digite o primeiro Valor:");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo Valor:");
        v2 = int.Parse(Console.ReadLine());

        res = soma(v1, v2);

        Console.WriteLine("A soma de {0} + {1} = {2}", v1, v2, res);
    }

    static int soma(int n1, int n2)
    {
        int resultado = n1 + n2;
        return resultado;
    }
}