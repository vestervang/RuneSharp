namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public sealed class Mining : Skill
    {
        public Mining()
        {
            Id = 15;
            Name = "mining";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = false;
            IsMembers = false;
        }
    }
}