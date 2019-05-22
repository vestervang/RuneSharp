using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public sealed class Crafting : Skill
    {
        public Crafting()
        {
            Id = 13;
            Name = "crafting";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = false;
        }
    }
}