namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public sealed class Dungeoneering : Skill
    {
        public Dungeoneering()
        {
            Id = 25;
            Name = "dungeoneering";
            MaximumExperience = 200000000;
            MaximumLevel = 120;
            IsCombat = false;
            IsMembers = true;
        }
    }
}