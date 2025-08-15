using System;

abstract public class Veiculo
{
    protected int VelMax;
    protected int VelAtual;
    protected bool Ligado;
    public Veiculo()
    {
        VelAtual = 0;
        Ligado = false;
    }
    public void SetLigar(bool Ligar)
    {
        Ligado = Ligar;
    }
    public int GetVelAtual()
    {
        return VelAtual;
    }
    abstract public void Acelerar(int mult);
    virtual public void Info(){}
}
public class Carro : Veiculo
{
    public Carro()
    {
        VelMax = 200;
        SetLigar(true);
    }
    public override void Acelerar(int mult)
    {
        VelAtual += 10 * mult;
        if (VelAtual > VelMax)
        {
            VelAtual = VelMax;
        }
    }
    override public void Info()
    {
        if (Ligado)
        {
            Console.WriteLine("Ligado");
        }
        else
        {
            Console.WriteLine("Desligado");
        }
        Console.WriteLine("Carro: {0}/{1} ", VelAtual, VelMax);
    }
}
public class Aula39
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Acelerar(10);
        carro.Info();
    }
}