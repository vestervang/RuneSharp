using System;

namespace RuneSharp.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class HiscoreRouteAttribute : Attribute
    {
        public string Route { get; }

        public HiscoreRouteAttribute(string route)
        {
            Route = route;
        }
    }
}