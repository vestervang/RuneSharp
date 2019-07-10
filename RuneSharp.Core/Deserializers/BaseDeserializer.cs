using System;
using System.Net.Http;
using Newtonsoft.Json;
using RestEase;
using RuneSharp.Core.Extensions;
using RuneSharp.Core.GrandExchange;
using RuneSharp.Core.Hiscore;

namespace RuneSharp.Core.Deserializers
{
    public abstract class BaseDeserializer : IResponseDeserializer
    {
        internal JsonSerializerSettings JsonSerializerSettings { get; set; }

        protected abstract T DeserializeCharacter<T>(string content, Uri requestUri);

//        protected abstract T DeserializeItem<T>(string content, Uri requestUri);

        protected T DeserializeItem<T>(string content, Uri requestUri)
        {
            var model = JsonConvert.DeserializeObject<ItemResponse>(content);
            return ChangeType<T>(model.Item);
        }

        protected T DeserializeItems<T>(string content, Uri requestUri)
        {
            var model = JsonConvert.DeserializeObject<ItemsResponse>(content);
            return ChangeType<T>(model.Items);
        }

        protected T DeserializeAlphaList<T>(string content, Uri requestUri)
        {
            var model = JsonConvert.DeserializeObject<AlphaList>(content);
            return ChangeType<T>(model);
        }
        
        public virtual T Deserialize<T>(string content, HttpResponseMessage response)
        {
            if (typeof(T) == typeof(AlphaList))
            {
                return DeserializeAlphaList<T>(content, response.RequestMessage.RequestUri);
            }
            
            if (typeof(T) == typeof(Item))
            {
                return DeserializeItem<T>(content, response.RequestMessage.RequestUri);
            }
            
            if (typeof(T) == typeof(Item[]))
            {
//                return DeserializeCharacter<T>(content, response.RequestMessage.RequestUri);
                return DeserializeItems<T>(content, response.RequestMessage.RequestUri);
            }
            
            if (typeof(T) == typeof(Player))
            {
                return DeserializeCharacter<T>(content, response.RequestMessage.RequestUri);
            }
            
            try
            {
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"{typeof(T).Name} is not a supported deserializable type.", e);
            }
        }

        protected static string GetUsername(Uri requestUri)
        {
            var username = requestUri.GetParameter("player");
            return username.Replace('+', ' ');
        }

        protected T ChangeType<T>(object obj) => (T) Convert.ChangeType(obj, typeof(T));
    }
}