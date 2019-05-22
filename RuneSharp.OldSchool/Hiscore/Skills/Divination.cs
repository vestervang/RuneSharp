using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Divination : Skill
    {
        public Divination()
        {
            Id = 26;
            Name = "divination";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = true;
        }
    }
}