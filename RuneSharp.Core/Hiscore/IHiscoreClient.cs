using System.Threading.Tasks;
using RestEase;

namespace RuneSharp.Core.Hiscore
{
    public interface IHiscoreClient : IRuneScapeApi
    {
        [Path("hiscoreRoute")]
        string HiscoreRoute { get; set; }
        [Path("gameMode")]
        string GameMode { get; set; }
        
        [Get("/m={hiscoreRoute}{gameMode}/index_lite.ws")]
        Task<Response<Player>> GetPlayerStatsAsync([Query("player")] string displayName);
    }
}