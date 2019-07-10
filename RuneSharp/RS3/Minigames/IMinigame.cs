namespace RuneSharp.RS3.Minigames
{
    public interface IMinigame
    {
        int Id { get; }
        string Name { get; }
        
        string ShortName { get; }
    }
}