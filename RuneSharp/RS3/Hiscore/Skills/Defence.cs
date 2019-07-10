namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public sealed class Defence : Skill
    {
        public Defence()
        {
            Id = 2;
            Name = "defence";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = true;
            IsMembers = false;
        }
    }
}