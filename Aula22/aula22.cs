using System;

public class Principal
{
    public static void Main()
    {
        Console.Clear();
        int[] num = new int[5];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = 0;
        }

        foreach (int n in num)
        {
            Console.WriteLine("{0}", n);
        }
    }
}