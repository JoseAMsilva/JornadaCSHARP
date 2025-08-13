using System;

namespace Aprendizagem.Aula20
{
    class Program
    {
        static void Main()
        {

            string senha = "123";
            string senhaUser;
            int tentativas = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha:");
                senhaUser = Console.ReadLine();
                tentativas++;

            } while (senhaUser != senha);

            Console.Clear();
            Console.WriteLine("Senha correta!\nTentativas: {0}", tentativas);
        }
    }
}