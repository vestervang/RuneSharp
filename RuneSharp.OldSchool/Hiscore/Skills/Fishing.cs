using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Fishing : Skill
    {
        public Fishing()
        {
            Id = 11;
            Name = "fishing";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = false;
        }
    }
}