using System;

public class Principal
{
    static void Main()
    {
        float LadoQuadrado;
        float SomaPerimetro, AreaQuadrado;

        Console.WriteLine("Insira o valor do Lado do Quadrado");
        LadoQuadrado = float.Parse(Console.ReadLine());

        SomaPerimetro = LadoQuadrado * 4;

        AreaQuadrado = Math.Pow(LadoQuadrado);

        Console.WriteLine("Area do Quadrado: {0:F2}cm²\nPerimetro do Quadrado {1:F2}cm", AreaQuadrado, SomaPerimetro);
    }
}