namespace API.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Nome { get; set; }
        public decimal PrecoAtual { get; set; }
        public decimal VolumeNegociado { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
    }

}
