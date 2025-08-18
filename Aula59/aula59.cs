using System;
using System.Collections.Generic;

class Aula58
{
    static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();
        int tamanho = fila.Count;
        fila.Enqueue("Ana");
        fila.Enqueue("Maria");
        fila.Enqueue("João");
        fila.Enqueue("Pedro");
        foreach (string n in fila)
        {
            Console.WriteLine(n);
        }
        string pessoa = fila.Dequeue();
        Console.WriteLine("Pessoa atendida: " + pessoa);
        Console.WriteLine("Proxima pessoa na fila: " + fila.Peek());
        Console.WriteLine("Tamanho da fila: " + fila.Count);
    }
}