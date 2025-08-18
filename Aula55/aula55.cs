using System;
using System.Collections.Generic;

class Aula55
{
    static void Main(string[] args)
    {
        Dictionary<int, string> veiculos = new Dictionary<int, string>();
        veiculos.Add(20, "Carro");
        veiculos.Add(10, "Moto");
        veiculos.Add(15, "Caminhão");
        veiculos.Add(25, "Patinete");
        //veiculos.Clear();
        Console.WriteLine("Tamanho do Dictionary: " + veiculos.Count);
        int key = 20;
        if (veiculos.ContainsKey(key))
        {
            Console.WriteLine("A chave " + key + " existe no Dictionary");
        }
        else
        {
            Console.WriteLine("A chave " + key + " não existe no Dictionary");
        }
        veiculos[25] = "Bicicleta";
        veiculos.Remove(10);
        string valor = "Bicicleta";
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine("O valor " + valor + " existe no Dictionary");
        }
        else
        {
            Console.WriteLine("O valor " + valor + " não existe no Dictionary");
        }
        Dictionary <int, string>.ValueCollection valores = veiculos.Values;
        foreach (string v in valores)
        {
            Console.WriteLine(v);
        }
    }
}