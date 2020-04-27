using Demo.Core.CustomAttributes;
using System;
using System.Linq;
using System.Reflection;

namespace Demo.Core.CustomExtensions
{
    public static class EnumExtensions
    {
        public static string Text(this Enum value)
        {
            return value.GetAttribute<TextAttribute>().Text;
        }

        private static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<TAttribute>();
        }
    }
}
