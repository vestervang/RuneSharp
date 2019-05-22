using RuneSharp.RuneScape3.Hiscore.Skills;
using CoreStatsRepository = RuneSharp.Core.Hiscore.Stat.StatRepository;

namespace RuneSharp.RuneScape3.Hiscore.Stats
{
    public class StatsRepository : CoreStatsRepository
    {
        public StatsRepository(string apiFeed) : base(apiFeed, new SkillRepository())
        {
        }
    }
}