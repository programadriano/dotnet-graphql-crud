using API.Entities;

namespace API.Services
{
    public interface IStockService
    {
        List<Stock> GetAll();
        Stock GetById(int id);
        Stock Create(Stock stock);
        Stock Update(int id, Stock stock);
        void Delete(int id);
    }
}
