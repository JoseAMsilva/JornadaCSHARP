using System;

public class Principal
{

    static void Main()
    {
        float AlturaRetangulo, BaseRetangulo;
        float SomaPerimetro, AreaRetangulo;

        Console.WriteLine("Insira o valor da Base do Retangulo");
        BaseRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor da Altura do Retangulo");
        AlturaRetangulo = float.Parse(Console.ReadLine());

        AreaRetangulo = BaseRetangulo * AlturaRetangulo;
        SomaPerimetro = BaseRetangulo * 2 + AlturaRetangulo * 2;

        Console.WriteLine("Área do Retangulo: {0:F2}cm²\nPerimetro do Retangulo: {1:F2}cm", AreaRetangulo, SomaPerimetro);
        
    }
}