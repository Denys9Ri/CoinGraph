using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Models;
using System.Threading.Tasks;
using CoinGraph.Models;

namespace WebAPIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        CoinContext db;
        public ValuesController(CoinContext context)
        {
            
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CoinContext>>> Get()
        //{
        //}

       
        [HttpGet("{id}")]
        public async Task<ActionResult<CoinContext>> Get(int id)
        {
            Coin coin = await db.Coins.FirstOrDefaultAsync(x => x.Id == id);
            if (coin == null)
                return NotFound();
            return new ObjectResult(coin);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<CoinContext>> Post(Coin coin)
        {
            if (coin == null)
            {
                return BadRequest();
            }

            db.Coins.Add(coin);
            await db.SaveChangesAsync();
            return Ok(coin);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<CoinContext>> Put(Coin coin)
        {
            if (coin == null)
            {
                return BadRequest();
            }
            if (!db.Coins.Any(x => x.Id == coin.Id))
            {
                return NotFound();
            }

            db.Update(coin);
            await db.SaveChangesAsync();
            return Ok(coin);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CoinContext>> Delete(int id)
        {
            Coin coin = db.Coins.FirstOrDefault(x => x.Id == id);
            if (coin == null)
            {
                return NotFound();
            }
            db.Coins.Remove(coin);
            await db.SaveChangesAsync();
            return Ok(coin);
        }
    }
}