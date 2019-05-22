using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Total : Skill
    {
        public Total()
        {
            Id = 0;
            Name = "total";
            MaximumExperience = 5400000000;
            MaximumLevel = 2736;
            IsCombat = false;
            IsMembers = false;
        }
    }
}