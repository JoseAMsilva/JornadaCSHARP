using System;

public class Mat
{
    public static double Pi = 3.14159;
    public static double Dobro(double n)
    {
        return n * 2;
    }
}
public class Aula49
{
    static void Main()
    {
        double ValorPi;
        double DobroValor;
        double DobroPi;
        ValorPi = Mat.Pi;
        DobroValor = Mat.Dobro(10);
        DobroPi = Mat.Dobro(Mat.Pi);
        Console.WriteLine(ValorPi);
        Console.WriteLine(DobroValor);
        Console.WriteLine(DobroPi);
    }
}