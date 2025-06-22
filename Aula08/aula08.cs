using System;

class Aula08
{
    static void Main()
    {
        int valor1, valor2, soma;

        Console.Write("Primero valor: \n");
        valor1 = int.Parse(Console.ReadLine());

        Console.Write("Segundo valor: \n");
        valor2 = Convert.ToInt32(Console.ReadLine());

        soma = valor1 + valor2;

        Console.WriteLine("\nA soma de {0} com {1} é {2}\n", valor1, valor2, soma);
    }
}