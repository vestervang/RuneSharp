using System;

namespace RuneSharp.Core.Hiscore.Stat
{
    using Skill;
    public class Stat : IStat
    {
        private Stat(Skill activity, int rank, int level, long experience)
        {
            Skill = activity;
            Level = level;
            Rank = rank;
            Experience = experience;
        }

        public Skill Skill { get; }
        public int Level { get; }
        public int Rank { get; }
        public long Experience { get; }
        
        private static Stat ParseData(string data, Skill skill)
        {
            var splitData = data.Split(",");

            var rank = int.Parse(splitData[0]);
            var level = int.Parse(splitData[1]);
            var xp = long.Parse(splitData[2]);

            return new Stat(skill, rank, level, xp);
        }

        public static bool TryParseData(string data, Skill skill, out Stat stat)
        {
            try
            {
                stat = ParseData(data, skill);
                return true;
            }
            catch (ArgumentException)
            {
                stat = null;
                return false;
            }
        }
    }
}