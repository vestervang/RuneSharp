using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Magic : Skill
    {
        public Magic()
        {
            Id = 7;
            Name = "magic";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = true;
            IsMembers = false;
        }
    }
}