using RuneSharp.OldSchool.Deserializers;
using RuneSharp.Core.Extensions;
using System.Threading.Tasks;
using RuneSharp.Core.Hiscore;
using RuneSharp.Core;
using RestEase;
using RuneSharp.Core.GrandExchange;

namespace RunescapeApi.OldSchool
{
    public class ApiClient
    {
        internal IApi API { get; }

        public ApiClient()
        {
            API = new RestClient(Config.baseAPIUrl) {ResponseDeserializer = new OSRSDeserializer()}
                .For<IApi>();

            API.GrandExchangeRoute = Game.OldSchool.GetGERoute();
            API.HiscoreRoute = Game.OldSchool.GetHiscoreRoute();
            API.GameMode = GameMode.Regular.GetRoute();
        }

        public async Task<Player> GetPlayerStats(string displayName, GameMode? gameMode = null)
        {
            if (gameMode != null)
            {
                API.GameMode = gameMode.GetRoute();
            }

            try
            {
                var response = await API.GetPlayerStatsAsync(displayName);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }
        
        public async Task<Item> GetItem(int id)
        {
            try
            {
                var response = await API.GetItemAsync(id);
                return response.GetContent();
            }
            catch
            {
                return null;
            }
        }
    }
}