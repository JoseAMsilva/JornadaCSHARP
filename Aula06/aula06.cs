using System;

class Aula06
{
    static void Main()
    {
        double valor_compra = 5.50;
        double valor_venda;
        double lucro = 0.1;
        string produto = "Pastel";

        valor_venda = valor_compra + (valor_compra * lucro);

        Console.WriteLine("Produto.......:{0,15}", produto);
        Console.WriteLine("Val.Compra....:{0,15:c}", valor_compra);
        Console.WriteLine("Lucro.........:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda.....:{0,15:c}", valor_venda);

    }
}