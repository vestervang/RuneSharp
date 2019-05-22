using System;

namespace RuneSharp.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GERouteAttribute : Attribute
    {
        public string Route { get; }

        public GERouteAttribute(string route)
        {
            Route = route;
        }
    }
}