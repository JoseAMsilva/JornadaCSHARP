using System;
using Dados;
using Settings;

public class Principal
{
    static void Main()
    {
        try
        {
            ExecutarProcessoDeVenda();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Erro de dados: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro de argumento: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Idade ou telefone inválido. Por favor, digite apenas números.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Fim do programa.");
        }
    }

    private static void ExecutarProcessoDeVenda()
    {
        TipoPassagem tipo = LerTipoPassagem();

        Passagem passagem = new Passagem(tipo);

        ColetarInformacoesDoPassageiro(passagem);

        passagem.SetPreco();

        ExibirResumo(passagem);
    }

    private static void ColetarInformacoesDoPassageiro(Passagem passagem)
    {
        Console.WriteLine("Digite o nome do passageiro:");
        passagem.Nome = Console.ReadLine() ?? string.Empty;

        passagem.Idade = LerInteiro("Digite a idade do passageiro:");
        passagem.Telefone = LerLong("Digite o telefone do passageiro (apenas números):");

        Console.WriteLine("Digite a partida do passageiro:");
        passagem.Partida = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o destino do passageiro:");
        passagem.Destino = Console.ReadLine() ?? string.Empty;
    }

    private static int LerInteiro(string prompt)
    {
        int valor;
        Console.WriteLine(prompt);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
            Console.WriteLine(prompt);
        }
        return valor;
    }

    private static long LerLong(string prompt)
    {
        long valor;
        Console.WriteLine(prompt);
        while (!long.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            Console.WriteLine(prompt);
        }
        return valor;
    }

    private static TipoPassagem LerTipoPassagem()
    {
        TipoPassagem tipo;
        string prompt = "Digite o tipo de passagem (Economica, Executiva, PrimeiraClasse):";

        Console.WriteLine(prompt);
        while (!Enum.TryParse<TipoPassagem>(Console.ReadLine(), true, out tipo))
        {
            Console.WriteLine("Tipo inválido. Por favor, escolha uma das opções válidas.");
            Console.WriteLine(prompt);
        }
        return tipo;
    }

    private static void ExibirResumo(Passagem passagem)
    {
        Console.Clear();
        Console.WriteLine("Informações da Passagem:");
        passagem.Info();
    }
}