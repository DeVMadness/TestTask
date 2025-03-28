using Integration.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration.Service.Implementation
{
    public class TaxRateService : ITaxRateService
    {

        public async Task<decimal> GetTaxRateByZipCodeAsync(string zipCode)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentNullException(nameof(zipCode), "Zip cannot be null or empty");

            using HttpClient client = new HttpClient();
            string? apikey = Environment.GetEnvironmentVariable("ApiKey");
            var response = await client.GetAsync($"https://www.taxrate.io/api/v1/rate/getratebyzip?api_key={apikey}&zip={zipCode}");

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error while getting tax rate: {response.StatusCode}");

            var taxRate = await response.Content.ReadAsStringAsync();
            var tax = JObject.Parse(taxRate)["rate_pct"]?.Value<decimal>() ?? 0m;

            return tax;
        }

    }
}
