using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestAPP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksStockController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BooksStockController> _logger;

        public BooksStockController(ILogger<BooksStockController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/booksavailability/{id}")]
        public ActionResult<BookStockInfo> Get(int id)
        {

            switch (id)
            {
                case 1:
                    return new BookStockInfo { quantity = 23, id = id };
                case 2:
                    return new BookStockInfo { quantity = 43, id = id };
                case 3:
                    return new BookStockInfo { quantity = 13, id = id };
                default:
                    return new BookStockInfo { quantity = 0, id = id };
            }
        }
    }
}
