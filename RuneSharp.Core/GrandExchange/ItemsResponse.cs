using Newtonsoft.Json;

namespace RuneSharp.Core.GrandExchange
{
    public class ItemsResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }
}