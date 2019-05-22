namespace RuneSharp.Core.Hiscore.Skill
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