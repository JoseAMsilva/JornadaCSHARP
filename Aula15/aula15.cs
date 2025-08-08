using System;

public class Principal
{
    static void Main()
    {
        int tempo;
        char escolha = ' ';
        string veiculo = " ";
        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [o] Ônibus ");
        escolha = char.Parse(Console.ReadLine());
        escolha = char.ToUpper(escolha);

        switch (escolha)
        {
            case ('A'):
                veiculo = "Avião";
                tempo = 50;
                break;
            case ('C'):
                veiculo = "Carro";
                tempo = 480;
                break;
            case ('O'):
                veiculo = "Ônibus";
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponível");
        }
        else
        {
            Console.WriteLine("Para o transporte de {0} o tempo estimado é: {1} minutos", veiculo, tempo);
        }
    }
}