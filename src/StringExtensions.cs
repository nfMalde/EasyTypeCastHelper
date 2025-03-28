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
        /// Converts the string to a nullable integer. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted nullable integer, or the default value if the conversion fails.</returns>
        public static int? ToNullableInt(this string? value, int? defaultValue = null)
        {
            return int.TryParse(value, out int result) ? (int?)result : defaultValue;
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
        /// Converts the string to a nullable double. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <param name="numberStyles">The number styles to use for the conversion.</param>
        /// <param name="cultureInfo">The culture info to use for the conversion.</param>
        /// <returns>The converted nullable double, or the default value if the conversion fails.</returns>
        public static double? ToNullableDouble(this string? value, double? defaultValue = null, NumberStyles numberStyles = NumberStyles.Any, CultureInfo? cultureInfo = null)
        {
            return double.TryParse(value, numberStyles, cultureInfo ?? CultureInfo.InvariantCulture, out double result) ? (double?)result : defaultValue;
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
        /// Converts the string to a nullable boolean. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted nullable boolean, or the default value if the conversion fails.</returns>
        public static bool? ToNullableBool(this string? value, bool? defaultValue = null)
        {
            return bool.TryParse(value, out bool result) ? (bool?)result : defaultValue;
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
        /// Converts the string to a nullable DateTime. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <param name="dateTimeStyles">The date time styles to use for the conversion.</param>
        /// <param name="cultureInfo">The culture info to use for the conversion.</param>
        /// <returns>The converted nullable DateTime, or the default value if the conversion fails.</returns>
        public static DateTime? ToNullableDateTime(this string? value, DateTime? defaultValue = null, DateTimeStyles dateTimeStyles = DateTimeStyles.None, CultureInfo? cultureInfo = null)
        {
            return DateTime.TryParse(value, cultureInfo ?? CultureInfo.InvariantCulture, dateTimeStyles, out DateTime result) ? (DateTime?)result : defaultValue;
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
        /// Converts the string to a nullable Guid. Returns the default value if the conversion fails.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted nullable Guid, or the default value if the conversion fails.</returns>
        public static Guid? ToNullableGuid(this string? value, Guid? defaultValue = null)
        {
            return Guid.TryParse(value, out Guid result) ? (Guid?)result : defaultValue;
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
        /// Converts the string to a nullable enum of type T. Returns the default value if the conversion fails.
        /// </summary>
        /// <typeparam name="T">The type of the enum.</typeparam>
        /// <param name="value">The string to convert.</param>
        /// <param name="defaultValue">The default value to return if the conversion fails.</param>
        /// <returns>The converted nullable enum of type T, or the default value if the conversion fails.</returns>
        public static T? ToNullableEnum<T>(this string? value, T? defaultValue = null) where T : struct
        {
            return Enum.TryParse(value, true, out T result) ? (T?)result : defaultValue;
        }

        /// <summary>
        /// Deserializes the JSON string to an object of type T.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize.</typeparam>
        /// <param name="value">The JSON string to deserialize.</param>
        /// <param name="options">The options to use for deserialization.</param>
        /// <returns>The deserialized object of type T.</returns>
        public static T? DeserializeFromJson<T>(this string value, System.Text.Json.JsonSerializerOptions? options = null)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(value, options);
        }

        /// <summary>
        /// Deserializes the JSON string to a nullable object of type T. Returns the default value if the string is null.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize.</typeparam>
        /// <param name="value">The JSON string to deserialize.</param>
        /// <param name="defaultValue">The default value to return if the string is null.</param>
        /// <param name="options">The options to use for deserialization.</param>
        /// <returns>The deserialized nullable object of type T, or the default value if the string is null.</returns>
        public static T? DeserializeFromNullableJson<T>(this string? value, T? defaultValue = default, System.Text.Json.JsonSerializerOptions? options = null)
        {
            if (value == null)
            {
                return defaultValue;
            }

            return System.Text.Json.JsonSerializer.Deserialize<T>(value, options);
        }
    }
}
