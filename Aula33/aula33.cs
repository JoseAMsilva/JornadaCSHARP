using System;

public class Aula33
{
    public class Player
    {
        private string nome;
        private int energia;

        public Player(string nome)
        {
            this.nome = nome;
            this.energia = 100; // Energia inicial do jogador
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetEnergia()
        {
            return energia;
        }
        public void SetEnergia(int energia)
        {
            if (energia < 0)
            {
                if (this.energia + energia < 0)
                {
                    this.energia = 0;
                }
                else
                {
                    this.energia += energia;
                }
            }
            else
            {
                if (this.energia + energia > 100)
                {
                    this.energia = 100;
                }
                else
                {
                    this.energia += energia;
                }
                
            }
        }
    }
    static void Main()
    {
        Player jogador = new Player("Kratos");
        jogador.SetEnergia(-30);

        Console.WriteLine("Nome:....{0}", jogador.GetNome());
        Console.WriteLine("Energia: {0}", jogador.GetEnergia());
    
    }
}