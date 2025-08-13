using System;

public class Principal
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[,] { { 11, 22, 00, 44, 55}, { 66, 77, 88, 99, 00 } };

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Vetor 1:");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(".............................................");

        //int BinarySerach(int[] arr, int key)
        Console.WriteLine("Binary Search:");
        int key = 33;
        int ndx = Array.BinarySearch(vetor1, key);
        Console.WriteLine("Valor {0} está na posição {1} do vetor", key, ndx);
        Console.WriteLine(".............................................");

        // public static void Copy(int[] sourceArray, int[] destinationArray, int length)
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(".............................................");

        // Public void CopyTo(Array array, int index)
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(".............................................");

        // public long GetLongLength(int dimension)
        Console.WriteLine("GetLongLength");
        long length = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", length);
        Console.WriteLine(".............................................");

        // public int GetLowerBound(int dimension)
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor1 = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vetor 1 {0}", MenorIndiceVetor1);
        Console.WriteLine("Menor índice da matriz {0}", MenorIndiceMatriz);
        Console.WriteLine(".............................................");

        // public int GetUpperBound(int dimension)
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor1 = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor 1 {0}", MaiorIndiceVetor1);
        Console.WriteLine("Maior índice da matriz {0}", MaiorIndiceMatriz);
        Console.WriteLine(".............................................");

        // public object GetValue(int index)
        Console.WriteLine("GetValue");
        int valor1 = Convert.ToInt32(vetor1.GetValue(3));
        int valor2 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor do vetor 1 na posição 3 {0}", valor1);
        Console.WriteLine("Valor da matriz na posição [1, 3] {0}", valor2);
        Console.WriteLine(".............................................");

        // public static int IndexOf(int[] array, int value)
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3 no vetor 1 {0}", indice1);
        Console.WriteLine(".............................................");

        // public int LastIndexOf(int[] array, int value)
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do último valor 3 no vetor 1 {0}", indice2);
        Console.WriteLine(".............................................");

        // public static void Reverse(int[] array)
        Console.WriteLine("Reverse");
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(".............................................");

        // public static void SetValue(object value, int index)
        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2 após SetValue:");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine(".............................................");

        // public static void Sort(int[] array)
        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor 1 ordenado:");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 2 ordenado:");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor 3 ordenado:");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
    }
}