using System;

public class Jogador
{
    public int energia;
    public int vida;
    public int forca;
    public int defesa;
    public bool vivo;
    public string nome;
    public Jogador(string n)
    {
        nome = n;
        energia = 100;
        vida = 100;
        forca = 10;
        defesa = 5;
        vivo = true;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador " + nome + " foi destruído.");
    }
}
public class Principal
{
    static void Main()
    {
        Jogador jogador1 = new Jogador("Mario");
        Jogador jogador2 = new Jogador("Guardião");
        Jogador jogador3 = new Jogador("Guerreiro");

        jogador1.energia = 80;
        jogador2.vida = 0;
        jogador3.forca = 15;
        jogador1.defesa = 10;
        jogador2.vivo = false;
        jogador3.energia = 50;

        Console.WriteLine(jogador1.nome + " - Energia: " + jogador1.energia + ", Vida: " + jogador1.vida + ", Força: " + jogador1.forca + ", Defesa: " + jogador1.defesa + ", Vivo: " + jogador1.vivo);
        Console.WriteLine(jogador2.nome + " - Energia: " + jogador2.energia + ", Vida: " + jogador2.vida + ", Força: " + jogador2.forca + ", Defesa: " + jogador2.defesa + ", Vivo: " + jogador2.vivo);
        Console.WriteLine(jogador3.nome + " - Energia: " + jogador3.energia + ", Vida: " + jogador3.vida + ", Força: " + jogador3.forca + ", Defesa: " + jogador3.defesa + ", Vivo: " + jogador3.vivo);
    }   
}