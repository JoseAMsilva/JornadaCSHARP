using System;

namespace Aprendizagem.Aula20
{
    class Program
    {
        static void Main()
        {
            int[] num = new int[10];

            int i = 0;

            while (i < num.Length)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                num[i] = int.Parse(Console.ReadLine());
                i++;
            }
            
            Console.Clear();
            Console.WriteLine("Você digitou os seguintes números:");

            i = 0;

            while (i < num.Length)
            {
                Console.WriteLine("O {0}º número é: {1}", i + 1, num[i]);
                i++;
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            Console.Clear(); Console.WriteLine("Fim do programa.");
            Console.WriteLine("Obrigado por usar nosso programa!");
            Console.WriteLine("Até a próxima!");  
        }
    }
}