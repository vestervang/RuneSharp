namespace rs_api_interface.RS3.Minigames
{
    public interface IMinigame
    {
        int Id { get; }
        string Name { get; }
        
        string ShortName { get; }
    }
}