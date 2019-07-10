namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public interface ISkill
    {
        int Id { get; }

        string Name { get; }

        long MaximumExperience { get; }

        int MaximumLevel { get; }

        bool IsCombat { get; }

        bool IsMembers { get; }
    }
}