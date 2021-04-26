using System;
using System.Linq;
using System.Reflection;

namespace TailBlazor.RadioButton
{
    public static class StringExtensions
    {
        /// <summary>
        /// Check if the string is null or empty.
        /// </summary>
        /// <param name="s">the string</param>
        /// <returns>a ture/false depending of if string is empty</returns>
        public static bool IsEmpty(this string s) => string.IsNullOrEmpty(s);
    }

    public static class EnumExtensions
    {
        /// <summary>
        /// Return the class attribute for an enum.
        /// </summary>
        /// <param name="enumValue">the enum</param>
        /// <returns>a string based on the class attribute</returns>
        public static string GetClass(this Enum enumValue) => 
            enumValue
            .GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<ClassAttribute>().Value;
    }
}
