using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Summoning : Skill
    {
        public Summoning()
        {
            Id = 24;
            Name = "summoning";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = true;
            IsMembers = true;
        }
    }
}