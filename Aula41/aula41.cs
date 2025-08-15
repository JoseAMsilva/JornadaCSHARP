using System;

public class Veiculo
{
    private int VelMax;
    public int Vm
    {
        get
        {
            return VelMax;
        }
        set
        {
            if (value < 0)
            {
                VelMax = 0;
            }
            else if (value > 200)
            {
                VelMax = 200;
            }
            else
            {
                VelMax = value;
            }
        }
    }
        public Veiculo()
    {
        VelMax = 120;// Valor padrão de velocidade máxima
    }
    public class Aula40
    {
        static void Main()
        {
            Veiculo carro = new Veiculo();
            carro.Vm = 110; // Setando a velocidade máxima para 110
            Console.WriteLine("Velocidade Máxima: " + carro.Vm);// Exibe a velocidade máxima definida com Get
        }
    }
}
    
