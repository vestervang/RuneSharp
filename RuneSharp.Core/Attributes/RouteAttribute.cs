using System;

namespace RuneSharp.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class RouteAttribute : Attribute
    {
        public string Route { get; }

        public RouteAttribute(string route)
        {
            Route = route;
        }
    }
}