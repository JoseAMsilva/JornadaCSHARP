using System;

public class Principal
{
    public class Veiculo
    {
        private int rodas;
        public int MaxVelocidade;
        public bool ligado;
        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }
        public void Desiligar()
        {
            ligado = false;
        }
        public void Ligar()
        {
            ligado = true;
        }
        public string GetLigado()
        {
            return (ligado) ? "Sim" : "Não";
        }
        public int GetRodas()
        {
            return rodas;
        }
        public void SetRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }
    public class Carro : Veiculo
    {
        public string Nome;
        public string Cor;
        public Carro(string nome, string cor) : base(4)
        {
            Desiligar();
            MaxVelocidade = 200;
            Nome = nome;
            Cor = cor;
        }
    }
    public class CarroCombate : Carro
    {
        public int Municao;
        public CarroCombate() : base("Carro de Combate", "Verde")
        {
            Municao = 100;
            SetRodas(6);
            MaxVelocidade = 100;
        }
    }
    static void Main()
    {
        Carro carro = new Carro("Fusca", "Azul");
        CarroCombate ccombate = new CarroCombate();
        ccombate.Desiligar();

        carro.Ligar();

        Console.WriteLine("Nome:.......{0}", carro.Nome);
        Console.WriteLine("Cor:........{0}", carro.Cor);
        Console.WriteLine("Rodas:......{0}", carro.GetRodas());
        Console.WriteLine("Velocidade: {0}", carro.MaxVelocidade);
        Console.WriteLine("Ligado:.....{0}", carro.GetLigado());
        Console.WriteLine("---------------------------");
        Console.WriteLine("Nome:.......{0}", ccombate.Nome);
        Console.WriteLine("Cor:........{0}", ccombate.Cor);
        Console.WriteLine("Rodas:......{0}", ccombate.GetRodas());
        Console.WriteLine("Velocidade: {0}", ccombate.MaxVelocidade);
        Console.WriteLine("Ligado:.....{0}", ccombate.GetLigado());
        Console.WriteLine("Municao:....{0}", ccombate.Municao);
    }
}