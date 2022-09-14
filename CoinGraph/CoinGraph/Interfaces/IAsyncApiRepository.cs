using CoinGecko.Entities.Response.Coins;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinGecko.Interfaces
{
    public interface IAsyncApiRepository
    {
        /// <summary>
        ///     Sends an API request async using GET Method
        /// </summary>
        /// <param name="resourceUri">The resouce uri path</param>
        /// <returns>Asyncronous result turns by TApiResouce</returns>
        Task<T> GetAsync<T>(Uri resourceUri);
        Task<List<CoinMarkets>> GetCoinMarkets(string vsCurrency, string[] ids, string order, int? perPage, int? page, bool sparkline, string priceChangePercentage);
    }
}