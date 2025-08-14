using System;

public class Principal
{
    static void Main()
    {
         Soma(15, 20, 30, 40, 50);
    }
    static void Soma(params int[]num)
    {
        if (num.Length < 1)
        {
            Console.WriteLine("Nenhum valor foi informado");
        }
        if (num.Length < 2)
        {
            Console.WriteLine("Somente um valor foi informado: " + num[0]);
        }
        else
        {
            int soma = 0;
            foreach (int n in num)
            {
                soma += n;
            }
            
            Console.WriteLine("A soma dos valores informados é: " + soma);
        }
    }
}