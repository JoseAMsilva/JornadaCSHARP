using System;

public class Principal
{

    static void Main()
    {
        int AlturaQuadrado, BaseQuadrado;
        int SomaPerimetro;

        Console.WriteLine("Insira o valor da Base do quadrado");
        BaseQuadrado = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor da Altura do quadrado");
        AlturaQuadrado = int.Parse(Console.ReadLine());

        SomaPerimetro = BaseQuadrado*2 + AlturaQuadrado*2;

        Console.WriteLine("Perimetro do Quadrado: {0}cm", SomaPerimetro);
        
    }
}