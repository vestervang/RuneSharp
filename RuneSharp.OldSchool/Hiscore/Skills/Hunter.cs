using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Hunter : Skill
    {
        public Hunter()
        {
            Id = 22;
            Name = "hunter";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = true;
        }
    }
}