using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AirboxDemo.Resources.Text;

namespace AirboxDemo.Services
{
    internal static class EnumHelper
    {
        /// <summary>
        /// Get a translated list of enum values from their description attributes
        /// </summary>
        /// <typeparam name="T">Enum</typeparam>
        /// <returns>Collection of translations</returns>
        public static IEnumerable<string?> GetListOfTranslations<T>() where T : struct, Enum
        {
            return Enum.GetValues<T>().Select(x => x.GetTranslation());
        }

        /// <summary>
        /// Get an enum from its translated value
        /// </summary>
        /// <typeparam name="T">Enum</typeparam>
        /// <param name="translation">Translated value</param>
        /// <returns>Enum value</returns>
        public static T GetEnumFromTranslation<T>(string translation) where T : struct, Enum
        {
            return Enum.GetValues<T>().Where(x => x.GetTranslation() == translation).First();
        }

        /// <summary>
        /// Get the translation of an enum
        /// </summary>
        /// <param name="value">Enum to translate</param>
        /// <returns>Translation if it exists or null otherwise</returns>
        public static string? GetTranslation(this Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name == null)
                return null;

            var field = type.GetField(name);
            return field != null && Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr
                ? GetTranslatedString(attr.Description)
                : null;
        }

        /// <summary>
        /// Get the translation for a string value
        /// </summary>
        /// <param name="stringName">String resource name</param>
        /// <returns>Translation if it exists or null</returns>
        private static string? GetTranslatedString(string stringName)
        {
            if (stringName == null) 
                return null;

            try
            {
                var propertyInfo = typeof(AppText).GetProperty(
                    stringName,
                    BindingFlags.NonPublic | BindingFlags.Static);

                var translatedDescription = propertyInfo?.GetValue(null)?.ToString();
                return string.IsNullOrEmpty(translatedDescription) ? stringName : translatedDescription;
            }
            catch
            {
                return null;
            }
        }
    }
}
