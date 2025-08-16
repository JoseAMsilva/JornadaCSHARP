using System;

public class Galinha
{
    private string Nome;
    private int TotalOvos;
    public Galinha(string Nome)
    {
        this.Nome = Nome;
        this.TotalOvos = 0;
    }
    public Ovo Botar()
    {
        this.TotalOvos++;
        return new Ovo(this.TotalOvos, this.Nome);
    }
    public void Info()
    {
        Console.WriteLine("Nome da Galinha: {0}", this.Nome);
        Console.WriteLine("Total de Ovos: {0}", this.TotalOvos);
        Console.WriteLine("-------------------------");
    }
}
public class Ovo
{
    public int QntdeOvos;
    public string MinhaGalinha;
    public Ovo(int QntdeOvos, string MinhaGalinha)
    {
        this.QntdeOvos = QntdeOvos;
        this.MinhaGalinha = MinhaGalinha;
        Console.WriteLine("Ovo {0} da Galinha {1}", this.QntdeOvos, this.MinhaGalinha);
        Console.WriteLine("-------------------------");
    }
}
public class Aula46
{
    static void Main()
    {
        Galinha G1 = new Galinha("Clotilda");
        Galinha G2 = new Galinha("Margarida");
        Galinha G3 = new Galinha("Pintadinha");

        G1.Botar();
        G1.Botar();
        G2.Botar();
        G3.Botar();
        G3.Botar();
        G3.Botar();
        G1.Info();
        G2.Info();
        G3.Info();
    }
}
    