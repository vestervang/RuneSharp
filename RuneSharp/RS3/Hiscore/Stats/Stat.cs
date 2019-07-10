

using RuneSharp.RS3.Hiscore.Skills;

namespace RunescapeApi.RuneScape3.Hiscore.Stats
{
    public class Stat : IStat
    {
        public Stat(Skill activity, int rank, int level, long experience)
        {
            Activity = activity;
            Level = level;
            Rank = rank;
            Experience = experience;
        }

        public dynamic Activity { get; }
        public int Level { get; }
        public int Rank { get; }
        public long Experience { get; }
    }
}