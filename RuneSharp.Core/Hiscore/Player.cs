using RuneSharp.Core.Hiscore.Stat;

namespace RuneSharp.Core.Hiscore
{
    public class Player
    {
        protected IStatRepository stats;
        protected string displayName;

        public Player(string username, IStatRepository statRepository)
        {
            displayName = username;
            stats = statRepository;
        }
    }
}