using System;

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}
public class Perfil
{
    public string Nome;
    public int Idade;
    public Perfil(string nome, int idade)
    {
        if (nome == " ")
        {
            throw new CustomException("Nome não pode ser vazio");
        }
        if (idade <= 0)
        {
            throw new CustomException("Idade não pode ser 0 ou negativa");
        }
        else
        {
            Nome = nome;
            Idade = idade;
        }
    }
    public void Info()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
    }
}
class Aula53
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        try
        {
            Perfil perfil = new Perfil(nome, idade);
            perfil.Info();
        }
        catch (CustomException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do programa");
        }
    }
}