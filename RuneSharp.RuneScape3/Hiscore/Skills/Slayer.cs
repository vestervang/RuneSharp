using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Slayer : Skill
    {
        public Slayer()
        {
            Id = 19;
            Name = "slayer";
            MaximumExperience = 200000000;
            MaximumLevel = 120;
            IsCombat = false;
            IsMembers = true;
        }
    }
}