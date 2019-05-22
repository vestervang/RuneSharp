using RuneSharp.Core.Deserializers;
using RuneSharp.Core.Hiscore;
using System;
using RuneSharp.OldSchool.Hiscore.Stats;

namespace RuneSharp.OldSchool.Deserializers
{
    public class OSRSDeserializer : BaseDeserializer
    {
        protected override T DeserializeCharacter<T>(string content, Uri requestUri)
        {
            var username = GetUsername(requestUri);
            var model = new Player(username, new StatsRepository(content));

            return ChangeType<T>(model);
        }
    }
}