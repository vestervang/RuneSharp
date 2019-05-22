using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Constitution : Skill
    {
        public Constitution()
        {
            Id = 4;
            Name = "constitution";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = true;
            IsMembers = false;
        }
    }
}