using System;

public class Pricipal
{
    public class Dados
    {
        private string Nome;
        private int idade;
        private long telefone;
        private string partida;
        private string destino;

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetIdade(int idade)
        {
            if (idade < 0)
            {
                throw new ArgumentException("Idade não pode ser negativa.");
            }
            else if (idade > 120)
            {
                throw new ArgumentException("Idade não pode ser maior que 120.");
            }
            else if (idade < 18)
            {
                throw new ArgumentException("Idade não pode ser menor que 18.");
            }
            else
            {
                this.idade = idade;
            }
        }
        public int GetIdade()
        {
            return idade;
        }
        public void SetTelefone(long telefone)
        {
            this.telefone = telefone;
        }
        public long GetTelefone()
        {
            return telefone;
        }
        public void SetPartida(string partida)
        {
            this.partida = partida;
        }
        public string GetPartida()
        {
            return partida;
        }
        public void SetDestino(string destino)
        {
            this.destino = destino;
        }
        public string GetDestino()
        {
            return destino;
        }
    }
    public class Passagem : Dados
    {
        private float Preco;
        private string Tipo;
        public Passagem(string tipo)
        {
            this.Preco = 0.0f;
            this.Tipo = tipo;
        }

        public void SetPreco()
        {
            if (Tipo == "Economica")
            {
                Preco = 100.0f;
            }
            else if (Tipo == "Executiva")
            {
                Preco = 200.0f;
            }
            else if (Tipo == "Primeira Classe")
            {
                Preco = 300.0f;
            }
            else
            {
                throw new ArgumentException("Tipo de passagem inválido.");
            }
        }
        public void ExibirInfoPassagem()
        {
            Console.WriteLine("Nome:.............{0}", GetNome());
            Console.WriteLine("Idade:............{0}", GetIdade());
            Console.WriteLine("Telefone:.........{0}", GetTelefone());
            Console.WriteLine("Partida:..........{0}", GetPartida());
            Console.WriteLine("Destino:..........{0}", GetDestino());
            Console.WriteLine("Tipo de Passagem: {0}", Tipo);
            Console.WriteLine("Preço:............{0}", Preco);
        }
    }
    static void Main()
    {
        Console.WriteLine("Digite o nome do passageiro:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a idade do passageiro:");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o telefone do passageiro:");
        long telefone = long.Parse(Console.ReadLine());
        Console.WriteLine("Digite a partida do passageiro:");
        string partida = Console.ReadLine();
        Console.WriteLine("Digite o destino do passageiro:");
        string destino = Console.ReadLine();
        Console.WriteLine("Digite o tipo de passagem (Economica, Executiva, Primeira Classe):");
        string tipoPassagem = Console.ReadLine();
        if (tipoPassagem != "Economica" && tipoPassagem != "Executiva" && tipoPassagem != "Primeira Classe")
        {
            Console.Clear();
            Console.WriteLine("Tipo de passagem inválido. Por favor, escolha entre Economica, Executiva ou Primeira Classe.");
            return;
        }
        Passagem passagem = new Passagem(tipoPassagem);
        passagem.SetNome(nome);
        passagem.SetIdade(idade);
        passagem.SetTelefone(telefone);
        passagem.SetPartida(partida);
        passagem.SetDestino(destino);
        passagem.SetPreco();
        
        Console.Clear();
        Console.WriteLine("Informações da Passagem:");
        passagem.ExibirInfoPassagem();
    }
}