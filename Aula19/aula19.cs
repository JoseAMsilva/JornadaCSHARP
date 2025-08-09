using System;

public class Principal
{
    static void Main()
    {
        int[] num = new int[7];
        int icont, fim;

        for (icont = 0; icont < num.Length; icont++)
        {
            num[icont] = icont;
        }

        for (icont = 0; icont < num.Length; icont++)
        {
            fim = 7 - 1;
            if (icont < fim)
            {
                Console.Write("{0}, ", num[icont]);
            }
            else
            {
                Console.Write("{0}. ", num[icont]);
            }
        }
    }
}