using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Invention : Skill
    {
        public Invention()
        {
            Id = 27;
            Name = "invention";
            MaximumExperience = 200000000;
            MaximumLevel = 120;
            IsCombat = false;
            IsMembers = true;
        }
    }
}