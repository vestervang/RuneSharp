using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Total : Skill
    {
        public Total()
        {
            Id = 0;
            Name = "total";
            MaximumExperience = 4600000000;
            MaximumLevel = 2277;
            IsCombat = false;
            IsMembers = false;
        }
    }
}