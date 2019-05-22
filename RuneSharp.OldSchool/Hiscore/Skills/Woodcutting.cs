using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Woodcutting : Skill
    {
        public Woodcutting()
        {
            Id = 9;
            Name = "woodcutting";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = false;
        }
    }
}