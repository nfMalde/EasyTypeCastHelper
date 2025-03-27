using System;
namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting long and nullable long values to various types.
    /// </summary>
    public static class LongExtensions
    {
        /// <summary>
        /// Converts a long value to a uint.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted uint value.</returns>
        public static uint ToUInt(this long value) => Convert.ToUInt32(value);

        /// <summary>
        /// Converts a nullable long value to a nullable uint.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable uint value, or the default value if the input is null.</returns>
        public static uint? ToUInt(this long? value, uint? defaultValue = null) => value.HasValue ? (uint?)Convert.ToUInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a ulong.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted ulong value.</returns>
        public static ulong ToULong(this long value) => Convert.ToUInt64(value);

        /// <summary>
        /// Converts a nullable long value to a nullable ulong.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable ulong value, or the default value if the input is null.</returns>
        public static ulong? ToULong(this long? value, ulong? defaultValue = null) => value.HasValue ? (ulong?)Convert.ToUInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a short.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted short value.</returns>
        public static short ToShort(this long value) => Convert.ToInt16(value);

        /// <summary>
        /// Converts a nullable long value to a nullable short.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable short value, or the default value if the input is null.</returns>
        public static short? ToShort(this long? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a ushort.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted ushort value.</returns>
        public static ushort ToUShort(this long value) => Convert.ToUInt16(value);

        /// <summary>
        /// Converts a nullable long value to a nullable ushort.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable ushort value, or the default value if the input is null.</returns>
        public static ushort? ToUShort(this long? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to an int.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted int value.</returns>
        public static int ToInt(this long value) => Convert.ToInt32(value);

        /// <summary>
        /// Converts a nullable long value to a nullable int.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable int value, or the default value if the input is null.</returns>
        public static int? ToInt(this long? value, int? defaultValue = null) => value.HasValue ? (int?)Convert.ToInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a double.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted double value.</returns>
        public static double ToDouble(this long value) => Convert.ToDouble(value);

        /// <summary>
        /// Converts a nullable long value to a nullable double.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable double value, or the default value if the input is null.</returns>
        public static double? ToDouble(this long? value, double? defaultValue = null) => value.HasValue ? (double?)Convert.ToDouble(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a float.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted float value.</returns>
        public static float ToFloat(this long value) => Convert.ToSingle(value);

        /// <summary>
        /// Converts a nullable long value to a nullable float.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable float value, or the default value if the input is null.</returns>
        public static float? ToFloat(this long? value, float? defaultValue = null) => value.HasValue ? (float?)Convert.ToSingle(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a decimal.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted decimal value.</returns>
        public static decimal ToDecimal(this long value) => Convert.ToDecimal(value);

        /// <summary>
        /// Converts a nullable long value to a nullable decimal.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable decimal value, or the default value if the input is null.</returns>
        public static decimal? ToDecimal(this long? value, decimal? defaultValue = null) => value.HasValue ? (decimal?)Convert.ToDecimal(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a TimeSpan representing seconds.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromSeconds(this long value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Converts a nullable long value to a nullable TimeSpan representing seconds.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable long is null.</returns>
        public static TimeSpan? ToTimeSpanFromSeconds(this long? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromSeconds(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a TimeSpan representing minutes.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromMinutes(this long value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Converts a nullable long value to a nullable TimeSpan representing minutes.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable long is null.</returns>
        public static TimeSpan? ToTimeSpanFromMinutes(this long? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromMinutes(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a TimeSpan representing hours.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromHours(this long value) => TimeSpan.FromHours(value);

        /// <summary>
        /// Converts a nullable long value to a nullable TimeSpan representing hours.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable long is null.</returns>
        public static TimeSpan? ToTimeSpanFromHours(this long? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromHours(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a TimeSpan representing days.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromDays(this long value) => TimeSpan.FromDays(value);

        /// <summary>
        /// Converts a nullable long value to a nullable TimeSpan representing days.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable long is null.</returns>
        public static TimeSpan? ToTimeSpanFromDays(this long? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromDays(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a TimeSpan representing ticks.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromTicks(this long value) => TimeSpan.FromTicks(value);

        /// <summary>
        /// Converts a long value to a DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromUnixTimestamp(this long value) => DateTimeOffset.FromUnixTimeSeconds(value).DateTime;

        /// <summary>
        /// Converts a nullable long value to a nullable DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable long is null.</returns>
        public static DateTime? ToDateTimeFromUnixTimestamp(this long? value, DateTime? defaultValue = null) => value.HasValue ? DateTimeOffset.FromUnixTimeSeconds(value.Value).DateTime : defaultValue;

        /// <summary>
        /// Converts a long value to a DateTime from a Unix timestamp in milliseconds.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromUnixTimestampMilliseconds(this long value) => DateTimeOffset.FromUnixTimeMilliseconds(value).DateTime;

        /// <summary>
        /// Converts a nullable long value to a nullable DateTime from a Unix timestamp in milliseconds.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable long is null.</returns>
        public static DateTime? ToDateTimeFromUnixTimestampMilliseconds(this long? value, DateTime? defaultValue = null) => value.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(value.Value).DateTime : defaultValue;

        /// <summary>
        /// Converts a long value to a DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromUnixTimestampSeconds(this long value) => DateTimeOffset.FromUnixTimeSeconds(value).DateTime;

        /// <summary>
        /// Converts a nullable long value to a nullable DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable long is null.</returns>
        public static DateTime? ToDateTimeFromUnixTimestampSeconds(this long? value, DateTime? defaultValue = null) => value.HasValue ? DateTimeOffset.FromUnixTimeSeconds(value.Value).DateTime : defaultValue;

        /// <summary>
        /// Converts a long value to a DateTime from ticks.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromTicks(this long value) => new DateTime(value);

        /// <summary>
        /// Converts a nullable long value to a nullable DateTime from ticks.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable long is null.</returns>
        public static DateTime? ToDateTimeFromTicks(this long? value, DateTime? defaultValue = null) => value.HasValue ? new DateTime(value.Value) : defaultValue;
    }
}
