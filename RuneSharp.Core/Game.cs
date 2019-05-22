using RuneSharp.Core.Attributes;

namespace RuneSharp.Core
{
    public enum Game
    {
        [GERoute("itemdb_oldschool"), HiscoreRoute("hiscore_oldschool")]
        OldSchool,
        [GERoute("itemdb_rs"), HiscoreRoute("hiscore")]
        RuneScape3
    }
}