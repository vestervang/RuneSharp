using System.Net.Http;
using rs_api_interface.RS3.Hiscore;
using rs_api_interface.RS3.Hiscore.Stats;

namespace rs_api_interface.RS3
{
    public class HiscoreClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        //        https://secure.runescape.com/m=hiscore/index_lite.ws?player=X
        //        https://secure.runescape.com/m=hiscore_ironman/index_lite.ws?player=X
        //        https://secure.runescape.com/m=hiscore_hardcore_ironman/index_lite.ws?player=X
        private const string _endpoint = "http://services.runescape.com/m=hiscore/index_lite.ws?player={0}";

        public static StatsRepository getStats(string username, GameMode gameMode = GameMode.Regular)
        {
            var hiscoreStream = getHiscoreStream(username, gameMode);
            return new StatsRepository(hiscoreStream);
        }

        private static string getHiscoreStream(string username, GameMode gameMode)
        {
            var endpoint = string.Format(_endpoint, username);

            var res = _httpClient.GetAsync(endpoint);

            return res.Result.Content.ReadAsStringAsync().Result;
        }
    }
}