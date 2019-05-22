using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using RuneSharp.Core.Attributes;

namespace RuneSharp.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetRoute(this Enum value) => GetAttribute<RouteAttribute>(value).Route;
        public static string GetHiscoreRoute(this Enum value) => GetAttribute<HiscoreRouteAttribute>(value).Route;
        public static string GetGERoute(this Enum value) => GetAttribute<GERouteAttribute>(value).Route;


        private static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            
            if (name == null)
            {
                return null;
            }

            var field = type.GetField(name);

            if (field == null)
            {
                return null;
            }

            var attr = Attribute.GetCustomAttribute(field, typeof(T)) as T;

            return attr;
        }
    }
}