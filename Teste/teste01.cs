using System;

class Principal
{
    static void Main()
    {
        string nome, endereco;
        int idade;
        long numero_de_telefone;
        string destino;
        double valor_passagem = 150.00;
        double taxa = 0.1;
        double valor_total;

        Console.Write("Insira seu nome:\n");
        nome = Console.ReadLine();

        Console.Write("insira a sua idade:\n");
        idade = int.Parse(Console.ReadLine());
        bool maioridade = (idade >= 18);

        Console.Write("Insira a sua ciade:\n");
        endereco = Console.ReadLine();

        if (maioridade)
        {
            Console.Write("insira seu numero de telefone:\n");
            numero_de_telefone = long.Parse(Console.ReadLine());

            Console.Write("Insira o seu destino:\n");
            destino = Console.ReadLine();

            Console.WriteLine("\nValor da Viagem {0:0,0.00}\nPorém nós cobramos uma taxa de {1:P} para viagens com este destino\n",valor_passagem, taxa);

            valor_total = valor_passagem + (valor_passagem * taxa);

            Console.WriteLine("Confira seus dados\n....................................\n");
            Console.WriteLine("\nValor da Viagem {0:0,0.00}\nPorém nós cobramos uma taxa de {1:P} para viagens com este destino\n",valor_passagem, taxa);
            Console.WriteLine("Seu nome...............{0, 5}\n", nome);
            Console.WriteLine("Origem.................{0, 5}\n", endereco);
            Console.WriteLine("Destino................{0, 5}\n", destino);
            Console.WriteLine("Sua idade..............{0, 5}\n", idade);
            Console.WriteLine("Numero de telefone.....{0, 5}\n", numero_de_telefone);
            Console.WriteLine("Valor da viagem........{0, 5:c}\n", valor_total);

            Console.WriteLine("....................................\n");
        }
        else
        {
            Console.WriteLine("Desculpe {0} mas você precisa ser maior de idade para comprar uma passagem\n", nome);
        }

    }
}