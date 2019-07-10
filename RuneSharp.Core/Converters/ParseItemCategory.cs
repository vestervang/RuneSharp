using System;
using System.Globalization;
using System.Threading;
using Newtonsoft.Json;
using RuneSharp.Core.GrandExchange;

namespace RuneSharp.Core.Converters
{
    internal class ParseItemCategory : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(string);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            
            var value = serializer.Deserialize<string>(reader);
            
            CultureInfo cultureInfo   = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            value = textInfo.ToTitleCase(value);

            value = value.Replace(" ", string.Empty);
            value = value.Replace("-", string.Empty);
            
            return (ItemCategory)Enum.Parse(typeof(ItemCategory), value);
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}