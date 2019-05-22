using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Fletching : Skill
    {
        public Fletching()
        {
            Id = 10;
            Name = "fletching";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = false;
        }
    }
}