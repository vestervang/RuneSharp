namespace RuneSharp.Core.Hiscore.Stat
{
    public interface IStat
    {
        Skill.Skill Skill { get; }

        int Level { get; }

        int Rank { get; }

        long Experience { get; }
    }
}