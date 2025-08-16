using System;

public class Calcular
{
    public int Somar(params int[] num)
    {
        int soma = 0;
        foreach (int n in num)
        {
            soma += n;
        }
        return soma;
    }
    public double Somar(params double[] num)
    {
        double soma = 0;
        foreach (double n in num)
        {
            soma += n;
        }
        return soma;
    }
}
public class Aula27
{
    static void Main()
    {
        double soma;
        Calcular calculo = new Calcular();
        soma = calculo.Somar(10, 20.54, 33.53, 47);
        Console.WriteLine(soma);
    }
}