using API.Entities;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {

        private readonly ILogger<StockController> _logger;
        private readonly IStockService _stockService;

        public StockController(ILogger<StockController> logger, IStockService stockService)
        {
            _logger = logger;
            _stockService = stockService;
        }

        // GET: api/stock
        [HttpGet]
        public ActionResult<List<Stock>> GetAll()
        {
            return _stockService.GetAll();
        }

        // GET: api/stock/{id}
        [HttpGet("{id}")]
        public ActionResult<Stock> GetById(int id)
        {
            var stock = _stockService.GetById(id);
            if (stock == null)
            {
                return NotFound();
            }
            return stock;
        }

        // POST: api/stock
        [HttpPost]
        public ActionResult<Stock> Create(Stock stock)
        {
            _stockService.Create(stock);
            return CreatedAtAction(nameof(GetById), new { id = stock.Id }, stock);
        }

        // PUT: api/stock/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, Stock stock)
        {
            if (id != stock.Id)
            {
                return BadRequest();
            }

            var updatedStock = _stockService.Update(id, stock);
            if (updatedStock == null)
            {
                return NotFound();
            }

            return Ok(new { message = "Registro atualizado com sucesso" });
        }

        // DELETE: api/stock/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var stock = _stockService.GetById(id);
            if (stock == null)
            {
                return NotFound();
            }

            _stockService.Delete(id);
            return Ok(new { message = "Registro deletado com sucesso" });
        }
    }
}