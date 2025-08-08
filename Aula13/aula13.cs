using System;

public class Principal
{
    enum OrdemNotas { Primeira, Segunda, Terceira, Quarta }
    static void Main()
    {
        int total = 0;
        int icont;
        string situacao;
        for (icont = 0; icont < 4; icont++)
        {
            OrdemNotas Ordem = (OrdemNotas)icont;
            Console.WriteLine("Insira o valor da {0} nota", Ordem);
            total += int.Parse(Console.ReadLine());
        }

        if (total < 40)
        {
            situacao = "Reprovado";
        }

        else if (total < 60)
        {
            situacao = "Recupraçao";
        }

        else
        {
            situacao = "Aprovado";
        }

        Console.WriteLine("Valor total: {0}\nSituação: {1}", total, situacao);
    }
}
