using System;
using System.Collections.Generic;

class Aula55
{
    static void Main(string[] args)
    {
        LinkedList<string> veiculos = new LinkedList<string>();

        veiculos.AddFirst("Carro");
        veiculos.AddLast("Moto");
        veiculos.AddLast("Caminhão");

        foreach (string v in veiculos)
        {
            Console.WriteLine(v);
        }

        LinkedListNode<string> no = veiculos.Find("Moto");
        veiculos.AddAfter(no, "Patinete");
        Console.WriteLine("........................");
        foreach (string v in veiculos)
        {
            Console.WriteLine(v);
        }
        Console.WriteLine("........................");

        veiculos.Remove("Caminhão");

        if (veiculos.Find("Caminhão") == null)
        {
            Console.WriteLine("Não existe");
        }
        else
        {
            Console.WriteLine("Existe");
        }
        Console.WriteLine("........................");
        foreach (string v in veiculos)
        {
            Console.WriteLine(v);
        }
        Console.WriteLine("........................");

        if (veiculos.Find("Moto") == null)
        {
            Console.WriteLine("Não existe");
        }
        else
        {
            Console.WriteLine("Existe");
        }

        LinkedListNode<string> no2 = veiculos.FindLast("Moto").Next;
        veiculos.AddAfter(no2, "Avião");

        Console.WriteLine("........................");
        foreach (string v in veiculos)
        {
            Console.WriteLine(v);
        }
        Console.WriteLine("........................");
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Lista vazia");
        }
    }
}