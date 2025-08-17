using System;

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}
public class Dados
{
    private string nome;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new CustomException("Nome não pode ser vazio");
            }
            else
            {
                nome = value;
            }
        }
    }

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value <= 0)
            {
                throw new CustomException("Idade não pode ser 0 ou negativa");
            }
            else if (value > 120)
            {
                throw new CustomException("Idade não pode ser maior que 120");
            }
            else if (value < 18)
            {
                throw new CustomException("Passageiro deve ser maior de idade");
            }
            else
            {
                idade = value;
            }
        }
    }

    private long telefone;
    public long Telefone
    {
        get { return telefone; }
        set
        {
            if (value <= 0)
            {
                throw new CustomException("Telefone não pode ser 0 ou negativo");
            }
            else
            {
                telefone = value;
            }
        }
    }

    private string partida;
    public string Partida
    {
        get {return partida; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new CustomException("Partida não pode ser vazio");
            }
            else
            {
                partida = value;
            }
        }
    }

    private string destino;
    public string Destino
    {
        get {return destino; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new CustomException("Destino não pode ser vazio");
            }
            else
            {
                destino = value;
            }
        }
    }
}
public class Passagem : Dados
{
    public float Preco;
    public string Tipo;
    public Passagem(string tipo)
    {
        if (tipo != "economica" && tipo != "executiva" && tipo != "primeira classe")
        {
            throw new ArgumentException("Tipo de passagem inválido.");
        }
        else
        {
            this.Preco = 0.0f;
            this.Tipo = tipo;
        }
        
    }
    public void SetPreco()
    {
        if (Tipo == "economica")
        {
            Preco = 100.0f;
        }
        else if (Tipo == "executiva")
        {
            Preco = 200.0f;
        }
        else if (Tipo == "primeira classe")
        {
            Preco = 300.0f;
        }
        else
        {
            throw new ArgumentException("Tipo de passagem inválido.");
        }
    }
    public void InfoPassagem()
    {
        Console.WriteLine("Nome:.............{0}", Nome);
        Console.WriteLine("Idade:............{0}", Idade);
        Console.WriteLine("Telefone:.........{0}", Telefone);
        Console.WriteLine("Partida:..........{0}", Partida);
        Console.WriteLine("Destino:..........{0}", Destino);
        Console.WriteLine("Tipo de Passagem: {0}", Tipo);
        Console.WriteLine("Preço:............{0}", Preco);
    }
}
public class Pricipal
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Digite o tipo de passagem (Economica, Executiva, Primeira Classe):");
            string tipoPassagem = Console.ReadLine();
            tipoPassagem = tipoPassagem.ToLower();

            Passagem passagem = new Passagem(tipoPassagem);

            Console.WriteLine("Digite o nome do passageiro:");
            string nome = Console.ReadLine();
            passagem.Nome = nome;

            Console.WriteLine("Digite a idade do passageiro:");
            int idade = int.Parse(Console.ReadLine());
            passagem.Idade = idade;

            Console.WriteLine("Digite o telefone do passageiro:");
            long telefone = long.Parse(Console.ReadLine());
            passagem.Telefone = telefone;

            Console.WriteLine("Digite a partida do passageiro:");
            string partida = Console.ReadLine();
            passagem.Partida = partida;

            Console.WriteLine("Digite o destino do passageiro:");
            string destino = Console.ReadLine();
            passagem.Destino = destino;

            passagem.SetPreco();

            Console.Clear();
            Console.WriteLine("Informações da Passagem:");
            passagem.InfoPassagem();
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Erro de dados: {0}", ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro de argumento: {0}", ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Idade ou telefone inválido. Por favor, digite apenas números.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro inesperado: {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Fim do programa.");
        }
    }
}