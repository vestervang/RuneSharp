namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public sealed class Herblore : Skill
    {
        public Herblore()
        {
            Id = 16;
            Name = "herblore";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = true;
        }
    }
}