using CoinGraph.Models;
using Microsoft.EntityFrameworkCore;


namespace CoinGraph.CoinDbContext
{
    public class CoinContext : DbContext 
    {
        public DbSet<Coin> Coins { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-P68P09G6;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
        }
    }
}