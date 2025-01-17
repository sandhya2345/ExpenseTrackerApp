using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace m2.Services
{
    public class CurrencyService
    {
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://v6.exchangerate-api.com/v6/0fea5277f5d05d3cb5e8d1d5/";

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<ExchangeRateResponse>($"{ApiBaseUrl}latest/{fromCurrency}");
                if (response != null && response.ConversionRates != null && response.ConversionRates.ContainsKey(toCurrency))
                {
                    return response.ConversionRates[toCurrency];
                }
                return 1m; // Default to 1 if rates are unavailable
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching exchange rate: {ex.Message}");
                return 1m; // Default to 1 if an error occurs
            }
        }
    }

    public class ExchangeRateResponse
    {
        [JsonPropertyName("conversion_rates")]
        public Dictionary<string, decimal> ConversionRates { get; set; }
    }
}
