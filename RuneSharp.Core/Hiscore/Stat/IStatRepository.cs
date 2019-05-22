namespace RuneSharp.Core.Hiscore.Stat
{
    public interface IStatRepository
    {
        Stat Stat(string skillName);

        Stat Stat(int skillId);
    }
}