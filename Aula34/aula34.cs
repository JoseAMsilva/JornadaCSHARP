using System;

public class Aula33
{
    public class Veiculo
    {
        public int Rodas;
        public string MaxVelocidade;
        public bool Ligado;
        public void Desligar()
        {
            Ligado = false;
        }
        public void Ligar()
        {
            Ligado = true;
        }
    }
    public class Carro : Veiculo
    {
        public string Nome;
        public string Cor;
        public Carro(string nome, string cor)
        {
            Nome = nome;
            Cor = cor;
            Rodas = 4;
            MaxVelocidade = "200 km/h";
            Ligado = false;
        }
        public string GetLigado()
        {
            if (Ligado)
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }
        
    }
    static void Main()
    {
        Carro carro = new Carro("Fusca", "Azul");

        Console.WriteLine("Nome:.......{0}", carro.Nome);
        Console.WriteLine("Cor:........{0}", carro.Cor);
        Console.WriteLine("Rodas:......{0}", carro.Rodas);
        Console.WriteLine("Velocidade: {0}", carro.MaxVelocidade);
        Console.WriteLine("Ligado:.....{0}", carro.GetLigado());
        
        
    }
}