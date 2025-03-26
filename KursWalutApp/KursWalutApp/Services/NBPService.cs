using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using KursWalutApp.Models;

namespace KursWalutApp.Services

{
    public class NBPService
    {

        private readonly HttpClient _httpClient;

        public NBPService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ExchangeRateModel>> GetExchangeRates()
        {
            string url = "https://api.nbp.pl/api/exchangerates/tables/A/?format=json";
            var response = await _httpClient.GetStringAsync(url);
            Console.WriteLine("Dane z API: " + response);
            //var data = JsonSerializer.Deserialize<List<NBPResponse>>(response);
            var data = JsonSerializer.Deserialize<List<NBPResponse>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return data?[0].Rates ?? new List<ExchangeRateModel>();
        }

        public class NBPResponse
        {
            public List<ExchangeRateModel> Rates { get; set; }
        }
    }
}
