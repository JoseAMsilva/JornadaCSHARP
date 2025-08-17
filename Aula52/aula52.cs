using System;

class Aula52
{
    static void Main(string[] args)
    {
        int n1, n2, res;
        res = n1 = n2 = 0;
        n1 = 10;
        try
        {
            res = n1 / n2;
            Console.WriteLine(res);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.GetType().Name);
        }
    }
}