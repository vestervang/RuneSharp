using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Strength : Skill
    {
        public Strength()
        {
            Id = 3;
            Name = "strength";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = true;
            IsMembers = false;
        }
    }
}