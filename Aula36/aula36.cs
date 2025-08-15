using System;

public class Veiculo
{
    public int VelAtual;
    private int VelMax;
    protected bool Ligado;
    public Veiculo(int velmax)
    {
        VelAtual = 0;
        VelMax = velmax;
        Ligado = false;
    }
    public int GetVelMax()//método para obter a velocidade máxima
    {
        return VelMax;
    }
}
public class Carro : Veiculo
{
    public string Nome;
    public Carro(string Nome, int Vm) : base(Vm)
    {
        this.Nome = Nome;
        Ligado = true;//protected pode ser acessado por classes derivadas
    }
    public void GetInfo()
    {
        Console.WriteLine("Nome:..............{0}", Nome);
        Console.WriteLine("Velocidade:........{0}", VelAtual);
        Console.WriteLine("Velocidade Máxima: {0}", GetVelMax());//private não pode ser acessado por classes derivadas
        Console.WriteLine("Ligado:............{0}", Ligado ? "Sim" : "Não");
    }
}
public class Aula36
{
    static void Main()
    {
        Carro carro = new Carro("Batmóvel", 300);

        carro.GetInfo();
    }

        
}