using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Cooking : Skill
    {
        public Cooking()
        {
            Id = 8;
            Name = "cooking";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = false;
        }
    }
}