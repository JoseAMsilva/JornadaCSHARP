using System;
using Dados;
namespace Settings
{
    public class Passagem : Dados.Dados
    {
        public decimal Preco { get; private set; }
        public TipoPassagem Tipo { get; private set; }

        public Passagem(TipoPassagem tipo)
        {
            this.Tipo = tipo;
        }

        public void SetPreco()
        {
            switch (this.Tipo)
            {
                case TipoPassagem.Economica:
                    this.Preco = 100.00m;
                    break;
                case TipoPassagem.Executiva:
                    this.Preco = 200.00m;
                    break;
                case TipoPassagem.PrimeiraClasse:
                    this.Preco = 300.00m;
                    break;
            }
        }
        public void Info()
        {
            Console.WriteLine($"Nome:.............{this.Nome}");
            Console.WriteLine($"Idade:............{this.Idade}");
            Console.WriteLine($"Tipo de Passagem: {this.Tipo}");
            Console.WriteLine($"Preço:............{this.Preco:C}");
        }
    }
}
