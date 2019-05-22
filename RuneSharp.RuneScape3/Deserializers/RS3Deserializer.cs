using RuneSharp.Core.Deserializers;
using RuneSharp.Core.Hiscore;
using System;
using Newtonsoft.Json;
using RuneSharp.Core.GrandExchange;
using RuneSharp.RuneScape3.Hiscore.Stats;

namespace RuneSharp.RuneScape3.Deserializers
{
    public class RS3Deserializer : BaseDeserializer
    {
        protected override T DeserializeCharacter<T>(string content, Uri requestUri)
        {
            var username = GetUsername(requestUri);
            var model = new Player(username, new StatsRepository(content));

            return ChangeType<T>(model);
        }
    }
}