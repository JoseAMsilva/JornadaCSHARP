using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zekinha");
            if(args.GetLength(0)>0)
            {
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}  