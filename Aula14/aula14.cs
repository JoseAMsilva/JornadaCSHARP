using System;

public class Principal
{
    enum OrdemNotas { Primeira, Segunda, Terceira, Quarta }
    static void Main()
    {
        int total = 0;
        int icont;
        string resultado;

        for (icont = 0; icont < 4; icont++)
        {
            OrdemNotas ordem = (OrdemNotas)icont;
            Console.WriteLine("Digite o valor da {0} nota", ordem);
            total += int.Parse(Console.ReadLine());
        }
        if (total >= 60)
        {
            if (total >= 90)
            {
                resultado = "Aprovado com louvor";
            }
            else
            {
                resultado = "Aprovado";
            }
        }
        else
        {
            if (total >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Recuperação";
            }
        }
        Console.WriteLine("Nota Final: {0}\nSituação: {1}", total, resultado);
    }
    
}