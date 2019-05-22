using System.Collections.Generic;
using Newtonsoft.Json;

namespace RuneSharp.Core.GrandExchange
{
    public class AlphaList
    {
        [JsonProperty("types")]
        public List<object> Types { get; set; }

        [JsonProperty("alpha")]
        public List<Alpha> Alpha { get; set; }
    }
}