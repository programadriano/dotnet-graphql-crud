using API.Entities;
using API.Services;

namespace API.Infra
{
    public class Query
    {
        private readonly IStockService _stockService;
        public Query(IStockService stockService)
        {
            _stockService = stockService;
        }

        public Stock GetById(int id) => _stockService.GetById(id);

        public IEnumerable<Stock> Stocks => _stockService.GetAll();
    }
}
