using CoinGraph.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPIApp.Models
{
    public class CoinContext : DbContext
    {
        public DbSet<Coin> Coins { get; set; }
        public CoinContext(DbContextOptions<CoinContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}