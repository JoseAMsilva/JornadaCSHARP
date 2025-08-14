using System;

public class Jogador
{
    public int energia = 100;
    public int vida = 100;
    public int forca = 10;
    public int defesa = 5;
    public bool vivo = true;
}
public class Principal
{
    static void Main()
    {
        Jogador jodador1 = new Jogador();
        Jogador jodador2 = new Jogador();
        Jogador jodador3 = new Jogador();

        jodador1.energia = 80;
        jodador2.vida = 00;
        jodador3.forca = 15;
        jodador1.defesa = 10;
        jodador2.vivo = false;
        jodador3.energia = 50;

        Console.WriteLine("Jogador 1 - Energia: " + jodador1.energia + ", Vida: " + jodador1.vida + ", Força: " + jodador1.forca + ", Defesa: " + jodador1.defesa + ", Vivo: " + jodador1.vivo);

        Console.WriteLine("Jogador 2 - Energia: " + jodador2.energia + ", Vida: " + jodador2.vida + ", Força: " + jodador2.forca + ", Defesa: " + jodador2.defesa + ", Vivo: " + jodador2.vivo);

        Console.WriteLine("Jogador 3 - Energia: " + jodador3.energia + ", Vida: " + jodador3.vida + ", Força: " + jodador3.forca + ", Defesa: " + jodador3.defesa + ", Vivo: " + jodador3.vivo);
    }   
}
