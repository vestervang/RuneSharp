using Newtonsoft.Json;

namespace RuneSharp.Core.GrandExchange
{
    public class Alpha
    {
        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("items")]
        public long Items { get; set; }
    }
}