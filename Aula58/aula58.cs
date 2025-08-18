using System;
using System.Collections.Generic;

class Aula57
{
    static void Main(string[] args)
    {
        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>();

        carros.Capacity = 10;

        carros.Add("Vectra");
        carros.Add("Gol");
        carros.Add("Fox");
        carros.Add("Civic");

        carros2.AddRange(carros);
        Console.WriteLine("Imprimindo Carros2:");

        if (carros.Contains("Gol"))
        {
            Console.WriteLine("Existe");
        }
        else
        {
            Console.WriteLine("Não existe");
        }
        int posicao = carros.IndexOf("Gol");
        Console.WriteLine("Posição do Gol: " + carros.IndexOf("Gol"));

        carros.Insert(posicao, "Impala");

        carros.Reverse();
       
        carros.Sort();
        Console.WriteLine("Imprimindo Carros:");

        foreach (string c in carros)
        {
            Console.WriteLine(c);
        }
        
        int Tamanho = carros.Count;
        Console.WriteLine("Tamanho da lista: " + Tamanho);

    }
}