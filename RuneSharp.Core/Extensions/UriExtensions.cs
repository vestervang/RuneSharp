using System;
using System.Linq;

namespace RuneSharp.Core.Extensions
{
    public static class UriExtensions
    {
        public static string GetParameter(this Uri uri, string parameterName)
        {
            var queries = uri.Query.TrimStart('?')
                .Split('&')
                .Select(x => x.Split('='))
                .ToDictionary(key => key[0], value => value[1]);

            if (!queries.TryGetValue("player", out var result))
            {
                throw new ArgumentNullException("Username was undefined.");
            }

            return result;
        }
    }
}