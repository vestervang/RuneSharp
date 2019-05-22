namespace RunescapeApi.RuneScape3.Hiscore.Stats
{
    public interface IStat
    {
        dynamic Activity { get; }

        int Level { get; }

        int Rank { get; }

        long Experience { get; }
    }
}