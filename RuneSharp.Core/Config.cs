using System.Reflection;

namespace RuneSharp.Core
{
    public class Config
    {
        public static string Version { get; } =
            Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute> ().InformationalVersion
            ?? "Unknown";
        
        public static string UserAgent { get; } = $"RS api interface v{Version}";
        public static readonly string baseAPIUrl = "http://services.runescape.com";
    }
}