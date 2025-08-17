using System;


delegate int Operacao(params int[] num);
class Mat
{
    public static int Somar(params int[] num)
    {
        int soma = 0;
        foreach (int n in num)
        {
            soma += n;
        }
        return soma;
    }
    public static int Multiplicar(params int[] num)
    {
        int mult = 1;
        foreach (int n in num)
        {
            mult *= n;
        }
        return mult;
    }
}
class Aula50
{
    static void Main()
    {
        int soma, multiplicacao;
        Operacao D1 = new Operacao(Mat.Somar);
        soma = D1(1, 2, 3, 4, 5);
        Console.WriteLine(soma);

        D1 = new Operacao(Mat.Multiplicar);
        multiplicacao = D1(1, 2, 3, 4, 5);
        Console.WriteLine(multiplicacao);
    }
}