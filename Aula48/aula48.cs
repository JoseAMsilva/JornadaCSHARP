using System;

public class Calcular
{
    public double Somar(params double[] num)
    {
        double soma = 0;
        foreach (double n in num)
        {
            soma += n;
        }
        return soma;
    }
    public int Somar(params int[] num)
    {
        int soma = 0;
        foreach (int n in num)
        {
            soma += n;
        }
        return soma;
    }
    public int Fatorial(int n)
    {
        // 1. Caso Base (Condição de Parada)
        if (n <= 1)
        {
            return 1;
        }
        // 2. Passo Recursivo (Chamada a si mesmo com um problema menor)
        return n * Fatorial(n - 1);
    }
}
public class Aula48
{
    static void Main()
    {
        int fatorial;
        Calcular calcular = new Calcular();
        fatorial = calcular.Fatorial(5);
        Console.WriteLine(fatorial);
    }
}