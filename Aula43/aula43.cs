using System;

public interface Veiculo
{
    void Ligar();
    void Desligar();
    void Info();
}
public interface Combate
{
    void atirar();
}
public class Carro : Veiculo, Combate
{
    public bool ligado;
    private int municao;
    public int Municao
    {
        get { return municao; }
        set
        {
            if (value < 0)
            {
                municao = 0;
            }
            else if (value > 100)
            {
                municao = 100;
            }
            else
            {
                municao = value;
            }
        }
    }
    public Carro()
    {
        this.ligado = false;
        this.Municao = 100; // Usando o setter da propriedade no construtor
    }
    public void atirar()
    {
        if (ligado)
        {
            if (municao > 0)
            {
                municao--;
                Console.WriteLine("Tiro disparado! Munição restante: {0}", municao);
            }
            else
            {
                Console.WriteLine("Sem munição");
            }
        }
        else
        {
            Console.WriteLine("Carro desligado");
        }
    }

    public void Ligar()
    {
        this.ligado = true;
    }
    public void Desligar()
    {
        this.ligado = false;
    }
    public void Info()
    {
        Console.WriteLine("Carro ligado: {0}", ligado ? "Sim" : "Não");
    }
}
public class Aula43
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Ligar();
        carro.Info();
        carro.Municao = 50; // Atribuindo valor usando a propriedade
        Console.WriteLine("Munição definida para: " + carro.Municao); // Lendo o valor da propriedade
        carro.atirar();
        carro.atirar();
        carro.atirar();
        carro.Desligar();
        carro.atirar(); // Tentativa de atirar com o carro desligado
    }
}