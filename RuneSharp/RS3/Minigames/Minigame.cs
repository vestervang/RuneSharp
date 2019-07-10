namespace RuneSharp.RS3.Minigames
{
    public class Minigame : IMinigame
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        
        public string ShortName { get; protected set; }
    }
}