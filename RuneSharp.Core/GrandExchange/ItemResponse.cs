using Newtonsoft.Json;

namespace RuneSharp.Core.GrandExchange
{
    public class ItemResponse
    {
        [JsonProperty("item")]
        public Item Item { get; set; }
    }
}