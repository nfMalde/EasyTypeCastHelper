using System;
using System.Globalization;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting strings to various types.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the string to an integer. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted integer, or the default value if the conversion fails.</returns>
        public static int ToInt(this string? value, int defaultValue = 0)
        {
            return int.TryParse(value, out int result) ? result : defaultValue;
        }

        /// <summary>
        /// Converts the string to a nullable integer. Returns null if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>The converted nullable integer, or null if the conversion fails.</returns>
        public static int? ToNullableInt(this string? value)
        {
            return int.TryParse(value, out int result) ? (int?)result : null;
        }

        /// <summary>
        /// Converts the string to a double. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <param name="numberStyles">The number styles to use for the conversion.</param>
        /// <param name="cultureInfo">The culture info to use for the conversion.</param>
        /// <returns>The converted double, or the default value if the conversion fails.</returns>
        public static double ToDouble(this string? value, double defaultValue = 0.0, NumberStyles numberStyles = NumberStyles.Any, CultureInfo? cultureInfo = null)
        {
            return double.TryParse(value, numberStyles, cultureInfo ?? CultureInfo.InvariantCulture, out double result) ? result : defaultValue;
        }

        /// <summary>
        /// Converts the string to a nullable double. Returns null if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="numberStyles">The number styles to use for the conversion.</param>
        /// <param name="cultureInfo">The culture info to use for the conversion.</param>
        /// <returns>The converted nullable double, or null if the conversion fails.</returns>
        public static double? ToNullableDouble(this string? value, NumberStyles numberStyles = NumberStyles.Any, CultureInfo? cultureInfo = null)
        {
            return double.TryParse(value, numberStyles, cultureInfo ?? CultureInfo.InvariantCulture, out double result) ? (double?)result : null;
        }

        /// <summary>
        /// Converts the string to a boolean. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted boolean, or the default value if the conversion fails.</returns>
        public static bool ToBool(this string? value, bool defaultValue = false)
        {
            return bool.TryParse(value, out bool result) ? result : defaultValue;
        }

        /// <summary>
        /// Converts the string to a nullable boolean. Returns null if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>The converted nullable boolean, or null if the conversion fails.</returns>
        public static bool? ToNullableBool(this string? value)
        {
            return bool.TryParse(value, out bool result) ? (bool?)result : null;
        }

        /// <summary>
        /// Converts the string to a DateTime. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <param name="dateTimeStyles">The date time styles to use for the conversion.</param>
        /// <param name="cultureInfo">The culture info to use for the conversion.</param>
        /// <returns>The converted DateTime, or the default value if the conversion fails.</returns>
        public static DateTime ToDateTime(this string? value, DateTime defaultValue, DateTimeStyles dateTimeStyles = DateTimeStyles.None, CultureInfo? cultureInfo = null)
        {
            return DateTime.TryParse(value, cultureInfo ?? CultureInfo.InvariantCulture, dateTimeStyles, out DateTime result) ? result : defaultValue;
        }

        /// <summary>
        /// Converts the string to a nullable DateTime. Returns null if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="dateTimeStyles">The date time styles to use for the conversion.</param>
        /// <param name="cultureInfo">The culture info to use for the conversion.</param>
        /// <returns>The converted nullable DateTime, or null if the conversion fails.</returns>
        public static DateTime? ToNullableDateTime(this string? value, DateTimeStyles dateTimeStyles = DateTimeStyles.None, CultureInfo? cultureInfo = null)
        {
            return DateTime.TryParse(value, cultureInfo ?? CultureInfo.InvariantCulture, dateTimeStyles, out DateTime result) ? (DateTime?)result : null;
        }

        /// <summary>
        /// Converts the string to a Guid. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted Guid, or the default value if the conversion fails.</returns>
        public static Guid ToGuid(this string? value, Guid defaultValue)
        {
            return Guid.TryParse(value, out Guid result) ? result : defaultValue;
        }

        /// <summary>
        /// Converts the string to a nullable Guid. Returns null if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>The converted nullable Guid, or null if the conversion fails.</returns>
        public static Guid? ToNullableGuid(this string? value)
        {
            return Guid.TryParse(value, out Guid result) ? (Guid?)result : null;
        }

        /// <summary>
        /// Converts the string to an enum of type T. Returns the default value if the conversion fails.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted enum of type T, or the default value if the conversion fails.</returns>
        public static T ToEnum<T>(this string? value, T defaultValue) where T : struct
        {
            return Enum.TryParse(value, true, out T result) ? result : defaultValue;
        }

        /// <summary>
        /// Converts the string to a nullable enum of type T. Returns null if the conversion fails.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="value">The string to convert.</param>
        /// <returns>The converted nullable enum of type T, or null if the conversion fails.</returns>
        public static T? ToNullableEnum<T>(this string? value) where T : struct
        {
            return Enum.TryParse(value, true, out T result) ? (T?)result : null;
        }

        public static T? DeserializeFromJson<T>(this string value, System.Text.Json.JsonSerializerOptions? options = null)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(value, options);
        }

        public static T? DeserializeFromNullableJson<T>(this string? value, System.Text.Json.JsonSerializerOptions? options = null)
        {

            if (value == null)
            {
                return default;
            }

            return System.Text.Json.JsonSerializer.Deserialize<T>(value, options);
        }
    }
}
