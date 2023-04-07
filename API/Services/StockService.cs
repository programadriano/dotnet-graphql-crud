using API.Entities;

namespace API.Services
{
    public class StockService : IStockService
    {
        private readonly List<Stock> _stocks = new List<Stock>();

        public Stock Create(Stock stock)
        {
            stock.Id = _stocks.Count > 0 ? _stocks.Max(a => a.Id) + 1 : 1;
            _stocks.Add(stock);
            return stock;
        }

        public void Delete(int id)
        {
            var existingAtivo = _stocks.FirstOrDefault(a => a.Id == id);
            if (existingAtivo != null)
            {
                _stocks.Remove(existingAtivo);
            }
        }

        public List<Stock> GetAll() => _stocks.ToList();

        public Stock GetById(int id) => _stocks.FirstOrDefault(a => a.Id == id);

        public Stock Update(int id, Stock stock)
        {
            var existingAtivo = _stocks.FirstOrDefault(a => a.Id == id);

            if (existingAtivo == null)
                return null;


            existingAtivo.Ticker = stock.Ticker;
            existingAtivo.Nome = stock.Nome;
            existingAtivo.PrecoAtual = stock.PrecoAtual;
            existingAtivo.VolumeNegociado = stock.VolumeNegociado;
            existingAtivo.DataUltimaAtualizacao = stock.DataUltimaAtualizacao;

            return existingAtivo;
        }
    }
}
