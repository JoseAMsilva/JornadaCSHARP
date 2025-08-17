using System;
using Calculo1;

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}

namespace Calculo1
{
    public class Area//area de um retangulo
    {
        public static double AreaRet(double b, double a )
        {
            if (b <= 0 || a <= 0)
            {
                throw new CustomException("Valor inválido");
            }
            else
            {
                 return (b * a);
            }
        }
    }
}
namespace Calculo2
{
    public class Area
    {
        public static double AreaParap(double a, double b, double c)//area de um paralelepipedo
        {
            double area;
            if (b <= 0 || a <= 0 || c <= 0)
            {
                throw new CustomException("Valor inválido");
            }
            else
            {
                area = 2 * (a * b + a * c + b * c);
                return (area);
            }

        }
    }
}
public class Aula54
{
    static void Main(string[] args)
    {
        double AreaRetangulo, AreaParalelepipedo;
        try
        {
            AreaRetangulo = Calculo1.Area.AreaRet(10.5, 20.5);
            AreaParalelepipedo = Calculo2.Area.AreaParap(10.5, 20.5, 30.5);
            Console.WriteLine("Area do retangulo: " + AreaRetangulo);
            Console.WriteLine("Area do paralelepipedo: " + AreaParalelepipedo);
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}