using RuneSharp.Core.Attributes;
using System;

namespace RunescapeApi.OldSchool
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
        
        [Route("_ultimate")]
        Ultimate = 8,
        
        [Route("_deadman")]
        Deadman = 16,
        
        [Route("_seasonal")]
        Seasonal = 32,
        
        [Route("_tournament")]
        Tournament = 64,
    }
}