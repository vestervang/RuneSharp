using System.Collections.Generic;
using Newtonsoft.Json;
using RuneSharp.Core.Converters;

namespace RuneSharp.Core.GrandExchange
{
    public class ItemGraphData
    {
        [JsonProperty("daily")]
        public Dictionary<string, long> Daily { get; set; }

        [JsonProperty("average")]
        public Dictionary<string, long> Average { get; set; }
    }
}