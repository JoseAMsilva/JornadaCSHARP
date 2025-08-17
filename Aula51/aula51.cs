using System;

class Aula51
{
    static void Main(string[] args)
    {
        int soma = 0;
        int Args = 0;
        if (args.Length > 0)
        {
            foreach (string s in args)
            {
                Args++;
                soma += Convert.ToInt32(s);
            }
        }
        else
        {
            Console.WriteLine("Nenhum argumento passado");
        }
        Console.WriteLine(soma);
        Console.WriteLine(Args);
    }
}