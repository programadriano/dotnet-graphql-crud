using API.Entities;
using API.Services;

namespace API.Infra
{
    public class Mutation
    {
        private readonly IStockService _stockService;
        public Mutation(IStockService stockService)
        {
            _stockService = stockService;
        }

        public Stock AddStock(Stock input)
        {
            return _stockService.Create(input);
        }

        public bool DeleteStock(int id)
        {           
            _stockService.Delete(id);
            return true;
        }

        public Stock UpdateStock(int id, Stock input)
        {
            return _stockService.Update(id, input);
        }
    }
}
