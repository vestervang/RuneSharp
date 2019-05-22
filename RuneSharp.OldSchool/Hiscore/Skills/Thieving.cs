using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.OldSchool.Hiscore.Stats
{
    public sealed class Thieving : Skill
    {
        public Thieving()
        {
            Id = 18;
            Name = "thieving";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = true;
        }
    }
}