using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RuneSharp.Core.Converters;

namespace RuneSharp.Core.GrandExchange
{
    public class Item
    {
        [JsonProperty("icon")] 
        public Uri Icon { get; set; }

        [JsonProperty("icon_large")] 
        public Uri IconLarge { get; set; }

        [JsonProperty("id")] 
        public long Id { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(ParseItemCategory))]
        public ItemCategory Type { get; set; }

        [JsonProperty("typeIcon")] 
        public Uri TypeIcon { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }

        [JsonProperty("description")] 
        public string Description { get; set; }

        [JsonProperty("current")] 
        public TradeData Current { get; set; }

        [JsonProperty("today")] 
        public TradeData Today { get; set; }

        [JsonProperty("members")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Members { get; set; }

        [JsonProperty("day30")] 
        internal TradeData Day30 { get; set; }

        [JsonProperty("day90")] 
        internal TradeData Day90 { get; set; }

        [JsonProperty("day180")] 
        internal TradeData Day180 { get; set; }

        public Dictionary<HistoryPeriod, TradeData> TradeHistories => new Dictionary<HistoryPeriod, TradeData>
        {
            { HistoryPeriod.Days30, Day30 },
            { HistoryPeriod.Days90, Day90 },
            { HistoryPeriod.Days180, Day180 },
            { HistoryPeriod.Current, Current },
            { HistoryPeriod.Today, Today }
        };
    }
}