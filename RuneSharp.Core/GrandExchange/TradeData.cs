using Newtonsoft.Json;

namespace RuneSharp.Core.GrandExchange
{
    public class TradeData
    {
        [JsonProperty("trend")]
        public PriceTrend Trend { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
        
        [JsonProperty("change")]
        public string Change { set; get; }
    }
}