using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace APICoin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinController : ControllerBase
    {
        private readonly ILogger<CoinController> _logger;
       
        public CoinController(ILogger<CoinController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Coin> Get()
        {

            return null;
        }

        [HttpPost]
        public ActionResult<Coin> Post(Coin coin)
        {
            if (coin == null)
            {
                return BadRequest();
            }

            return Ok(coin);
        }
    }
}
