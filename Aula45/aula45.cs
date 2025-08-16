using System;

struct Carro
{
    public string Marca;
    public string Modelo;
    public string Cor;
    public int Ano;
    public Carro(string marca, string modelo, string cor, int ano)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Cor = cor;
        this.Ano = ano;
    }
    public void Info()
    {
        Console.WriteLine("Marca.: {0}", this.Marca);
        Console.WriteLine("Modelo: {0}", this.Modelo);
        Console.WriteLine("Cor...: {0}", this.Cor);
        Console.WriteLine("Ano...: {0}", this.Ano);
        Console.WriteLine("-------------------------");
    }
}
public class Aula44
{
    static void Main()
    {
        Carro[] carros = new Carro[3];
        for (int i = 0; i < carros.Length; i++)
        {
            Console.Write("Digite a marca do carro {0}: ", i + 1);
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do carro {0}: ", i + 1);
            string modelo = Console.ReadLine();
            Console.Write("Digite a cor do carro {0}: ", i + 1);
            string cor = Console.ReadLine();
            Console.Write("Digite o ano do carro {0}: ", i + 1);
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // Cria um novo carro e adiciona ao array

            carros[i] = new Carro(marca, modelo, cor, ano);
        }
        foreach (Carro carro in carros)
        {
            carro.Info();
        }
    }
}