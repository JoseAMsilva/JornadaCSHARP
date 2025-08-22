namespace Dados
{
    /// <summary>
    /// Classe base para armazenar informações de uma entidade, como um passageiro.
    /// </summary>
    public class Dados
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public long Telefone { get; set; }
        public string Partida { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
    }
}