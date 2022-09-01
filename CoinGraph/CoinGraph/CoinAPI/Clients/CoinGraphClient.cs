using CoinGecko.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace CoinGecko.Clients
{
    public partial class CoinGraphClient : IDisposable, ICoinGeckoClient
    {
        private static readonly Lazy<CoinGraphClient> Lazy = new Lazy<CoinGraphClient>(() => new CoinGraphClient());

        #region Fields

        private readonly HttpClient _httpClient;
        private bool _isDisposed;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly string _apiKey;

        #endregion Fields

        #region Constructors

        public CoinGraphClient() : this((JsonSerializerSettings)null)
        {
        }

        public CoinGraphClient(string apiKey) : this((JsonSerializerSettings)null, apiKey)
        {
        }


        public CoinGraphClient(HttpClientHandler httpClientHandler) : this(httpClientHandler, serializerSettings: null)
        {
        }

        public CoinGraphClient(HttpClientHandler httpClientHandler, string apiKey) : this(httpClientHandler, null, apiKey)
        {
            _apiKey = apiKey;
        }

      

        public CoinGraphClient(JsonSerializerSettings serializerSettings) : this(new HttpClientHandler(), serializerSettings)
        {
        }

        public CoinGraphClient(JsonSerializerSettings serializerSettings, string apiKey) : this(new HttpClientHandler(), serializerSettings, apiKey)
        {
        }


        public CoinGraphClient(HttpClientHandler httpClientHandler, JsonSerializerSettings serializerSettings) : this(new HttpClient(httpClientHandler, true), serializerSettings)
        {
        }

        public CoinGraphClient(HttpClientHandler httpClientHandler, JsonSerializerSettings serializerSettings, string apiKey)
          : this(new HttpClient(httpClientHandler, true), serializerSettings, apiKey)
        {
        }


        public CoinGraphClient(HttpClient httpClient) : this(httpClient, serializerSettings: null)
        {
        }

        public CoinGraphClient(HttpClient httpClient, string apiKey) : this(httpClient, null, apiKey)
        {
        }


        public CoinGraphClient(HttpClient httpClient, JsonSerializerSettings serializerSettings)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
        }

        public CoinGraphClient(HttpClient httpClient, JsonSerializerSettings serializerSettings, string apiKey)
        {
            _httpClient = httpClient;
            _serializerSettings = serializerSettings;
            _apiKey = apiKey;
        }

        #endregion Constructors

        #region Properties

        public static CoinGraphClient Instance => Lazy.Value;

        public ISimpleClient SimpleClient => new SimpleClient(_httpClient, _serializerSettings, _apiKey);
        public IPingClient PingClient => new PingClient(_httpClient, _serializerSettings, _apiKey);
        public ICoinsClient CoinsClient => new CoinsClient(_httpClient, _serializerSettings, _apiKey);
        public IExchangesClient ExchangesClient => new ExchangesClient(_httpClient, _serializerSettings, _apiKey);
        public IEventsClient EventsClient => new EventsClient(_httpClient, _serializerSettings, _apiKey);
        public IExchangeRatesClient ExchangeRatesClient => new ExchangeRatesClient(_httpClient, _serializerSettings, _apiKey);
        public IGlobalClient GlobalClient => new GlobalClient(_httpClient, _serializerSettings, _apiKey);
        public IContractClient ContractClient => new ContractClient(_httpClient, _serializerSettings, _apiKey);
        public IFinancePlatformsClient FinancePlatformsClient => new FinancePlatformsClient(_httpClient, _serializerSettings, _apiKey);
        public IIndexesClient IndexesClient => new IndexesClient(_httpClient, _serializerSettings, _apiKey);
        public IDerivativesClient DerivativesClient => new DerivativesClient(_httpClient, _serializerSettings, _apiKey);
        public IStatusUpdatesClient StatusUpdatesClient => new StatusUpdateClient(_httpClient, _serializerSettings, _apiKey);
        public ISearchClient SearchClient => new SearchClient(_httpClient, _serializerSettings, _apiKey);

        #endregion Properties

        #region Methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }
            if (disposing)
            {
                _httpClient?.Dispose();
            }
            _isDisposed = true;
        }

        #endregion Methods
    }
}