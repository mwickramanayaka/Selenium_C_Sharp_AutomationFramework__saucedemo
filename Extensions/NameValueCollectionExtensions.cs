using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace Test.Framework.Extensions
{
    public static class NameValueCollectionExtensions
    {

        public static string GetSettingValue(this NameValueCollection settings, string key, string defaultValue = null, bool required = false)
        {
            try
            {
                return required ? settings.GetRequiredValue(key) : settings.GetValueOrDefault(key, defaultValue);
            }
            catch (Exception exception)
            {
                throw new ConfigurationErrorsException($"Error loading value for item {key}", exception);
            }
        }


        public static T GetSettingValue<T>(this NameValueCollection settings, string key, Func<string, T> conversion, T defaultValue) where T : struct
        {
            return settings.GetSettingValue(key, conversion, defaultValue.ToString());

        }


        public static T GetSettingValue<T>(this NameValueCollection settings, string key, Func<string, T> conversion, string defaultValue = null, bool isRequired = false) where T : struct
        {
            try
            {
                return conversion(isRequired ? settings.GetRequiredValue(key) : settings.GetValueOrDefault(key, defaultValue));
            }
            catch (Exception ex)
            {
                throw new ConfigurationErrorsException($"Error loading value for item {key}", ex);
            }

        }


        public static string GetRequiredValue(this NameValueCollection values, string key)
        {

            if (values.AllKeys.FirstOrDefault(k => k.Equals(key, StringComparison.InvariantCultureIgnoreCase)) == null)
            {
                throw new IndexOutOfRangeException($"{key} is not set.");
            }

            var value = values[key];

            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException($"{key} value is empty.");
            }

            return value;
        }


        public static string GetValueOrDefault(this NameValueCollection values, string key, string defaultValue = null)
        {
            string value = values.AllKeys.Contains(key, StringComparer.InvariantCultureIgnoreCase) ? values[key] : null;

            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }
}
