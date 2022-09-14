using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoinGraph.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string CoinName { get; set; }
        public int Price { get; set; }
    }
}
