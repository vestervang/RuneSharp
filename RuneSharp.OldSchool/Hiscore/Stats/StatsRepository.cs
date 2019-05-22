using RuneSharp.Core.Hiscore.Stat;
using RuneSharp.OldSchool.Hiscore.Skills;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public class StatsRepository : StatRepository
    {
        public StatsRepository(string apiFeed) : base(apiFeed, new SkillRepository())
        {
        }
    }
}