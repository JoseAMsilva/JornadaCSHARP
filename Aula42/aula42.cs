using System;

public class Veiculo
{
    private int[] VelMax = new int[5] {80, 120, 160, 240, 300};
    public int this[int index]
    {
        get
        {
            return VelMax[index];
        }
        set
        {
            if (value < 0)
            {
                VelMax[index] = 0;
            }
            else if (value > 300)
            {
                VelMax[index] = 300;
            }
            else
            {
                VelMax[index] = value;
            }
        }
    }
    public class Aula40
    {
        static void Main()
        {
            Veiculo carro = new Veiculo();
            carro[4] = 110;//alterando a velocidade com um indexador
            Console.WriteLine("Velocidade Máxima: " + carro[4]);// Exibe a velocidade máxima definida com um idexador e o Get
        }
    }
}
    
