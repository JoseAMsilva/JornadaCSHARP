using System;

public class Principal
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        int icont, jcont;

        Console.Clear();

        for (icont = 0; icont < 3; icont++)
        {
            for (jcont = 0; jcont < 3; jcont++)
            {
                Console.WriteLine("Insira o valor da posição [{0}][{1}]", icont, jcont);
                matriz[icont, jcont] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }

        for (icont = 0; icont < 3; icont++)
        {
            for (jcont = 0; jcont < 3; jcont++)
            {
                Console.Write(" {0} ", matriz[icont, jcont]);
            }
            Console.WriteLine("\n");
        }
    }
}