using RuneSharp.Core.Attributes;
using System;

namespace RuneSharp.RuneScape3
{
    [Flags]
    public enum GameMode
    {
        [Route("")]
        Regular = 1,
        [Route("_ironman")]
        Ironman = 2,
        [Route("_hardcore_ironman")]
        HardcoreIronman = 4,
    }
}