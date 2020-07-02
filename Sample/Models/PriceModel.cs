using Newtonsoft.Json;

namespace Sample.Models
{
    public class PriceModel
    {

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("exchange_of_rate")]
        public double ExchangeOfRate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}