using System;

public class Principal
{
    static void Main()
    {
        double pi = 3.1415;
        float raio;
        float TotalPerimetro, AreaCircunferencia;

        Console.WriteLine("Insira o valor do raio");
        raio = float.Parse(Console.ReadLine());

        AreaCircunferencia = (float)pi * (raio * raio);
        TotalPerimetro = 2 * (float)pi * raio;

        Console.WriteLine("Area da circunferência: {0:F2}cm²\nPerimetro da circunferência: {1:F2}cm", AreaCircunferencia, TotalPerimetro);
    }
}