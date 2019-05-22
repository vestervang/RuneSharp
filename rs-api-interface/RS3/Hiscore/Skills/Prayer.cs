namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public sealed class Prayer : Skill
    {
        public Prayer()
        {
            Id = 6;
            Name = "prayer";
            MaximumExperience = 200000000;
            MaximumLevel = 99;
            IsCombat = true;
            IsMembers = false;
        }
    }
}