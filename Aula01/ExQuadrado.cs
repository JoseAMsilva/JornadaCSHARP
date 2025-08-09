using System;

public class Principal
{
    static void Main()
    {
        int LadoQuadrado;
        int SomaPerimetro, AreaQuadrado;

        Console.WriteLine("Insira o valor do Lado do Quadrado");
        LadoQuadrado = int.Parse(Console.ReadLine());

        SomaPerimetro = LadoQuadrado * 4;

        AreaQuadrado = LadoQuadrado * LadoQuadrado;

        Console.WriteLine("Area do Quadrado: {0}cm²\nPerimetro do Quadrado {1}cm", AreaQuadrado, SomaPerimetro);
    }
}