using System;
using System.Data;
using Newtonsoft.Json;

namespace RuneSharp.Core.Converters
{
    public class MillisecondsToSecondsConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            var test = reader.ReadAsString();
            var value = serializer.Deserialize<Tmp>(reader);
            bool b;
//            if (Boolean.TryParse(value, out b))
//            {
//                return b;
//            }


            throw new Exception("Cannot unmarshal type bool");
            
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (bool) untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
        }

        public static readonly MillisecondsToSecondsConverter Singleton = new MillisecondsToSecondsConverter();

        class Tmp
        {
            public string test;
            public string test2;
        }
    }
}