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
        Carro carro = new Carro("Ford", "Mustang", "Vermelho", 2021);
        carro.Info();
        Carro carro2 = new Carro("Chevrolet", "Camaro", "Amarelo", 2020);
        carro2.Info();
    }
}