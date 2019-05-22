using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Construction : Skill
    {
        public Construction()
        {
            Id = 23;
            Name = "construction";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = true;
        }
    }
}