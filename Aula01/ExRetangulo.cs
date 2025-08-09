using System;

public class Principal
{

    static void Main()
    {
        int AlturaRetangulo, BaseRetangulo;
        int SomaPerimetro, AreaRetangulo;

        Console.WriteLine("Insira o valor da Base do Retangulo");
        BaseRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor da Altura do Retangulo");
        AlturaRetangulo = int.Parse(Console.ReadLine());

        AreaRetangulo = BaseRetangulo * AlturaRetangulo;
        SomaPerimetro = BaseRetangulo * 2 + AlturaRetangulo * 2;

        Console.WriteLine("Área do Retangulo: {0}cm²\nPerimetro do Retangulo: {1}cm", AreaRetangulo, SomaPerimetro);
        
    }
}