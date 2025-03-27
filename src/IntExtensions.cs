using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting integers to various types.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Converts a long value to a uint.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted uint value.</returns>
        public static uint ToUInt(this int value) => Convert.ToUInt32(value);

        /// <summary>
        /// Converts a nullable long value to a nullable uint.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable uint value, or the default value if the input is null.</returns>
        public static uint? ToUInt(this int? value, uint? defaultValue = null) => value.HasValue ? (uint?)Convert.ToUInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a ulong.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted ulong value.</returns>
        public static ulong ToULong(this int value) => Convert.ToUInt64(value);

        /// <summary>
        /// Converts a nullable long value to a nullable ulong.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable ulong value, or the default value if the input is null.</returns>
        public static ulong? ToULong(this int? value, ulong? defaultValue = null) => value.HasValue ? (ulong?)Convert.ToUInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts a long value to a short.
        /// </summary>
        /// <param name="value">The long value to convert.</param>
        /// <returns>The converted short value.</returns>
        public static short ToShort(this int value) => Convert.ToInt16(value);

        /// <summary>
        /// Converts a nullable long value to a nullable short.
        /// </summary>
        /// <param name="value">The nullable long value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable long is null.</param>
        /// <returns>The converted nullable short value, or the default value if the input is null.</returns>
        public static short? ToShort(this int? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;


        public static ushort ToUShort(this int value) => Convert.ToUInt16(value);

        public static ushort? ToUShort(this int? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;



        /// <summary>
        /// Converts an integer to a long.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToLong(this int value)
        {
            return Convert.ToInt64(value);
        }

        /// <summary>
        /// Converts a nullable integer to a nullable long.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static long? ToLong(this int? value, long? defaultValue = null)
        {
            return value.HasValue ? Convert.ToInt64(value.Value) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a double.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted double value.</returns>
        public static double ToDouble(this int value)
        {
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Converts a nullable integer to a nullable double.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable double value, or the default value if the nullable integer is null.</returns>
        public static double? ToDouble(this int? value, double? defaultValue = null)
        {
            return value.HasValue ? Convert.ToDouble(value.Value) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a decimal.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted decimal value.</returns>
        public static decimal ToDecimal(this int value)
        {
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// Converts a nullable integer to a nullable decimal.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable decimal value, or the default value if the nullable integer is null.</returns>
        public static decimal? ToDecimal(this int? value, decimal? defaultValue = null)
        {
            return value.HasValue ? Convert.ToDecimal(value.Value) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a boolean.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>True if the integer is not zero, otherwise false.</returns>
        public static bool ToBool(this int value)
        {
            return value != 0;
        }

        /// <summary>
        /// Converts a nullable integer to a nullable boolean.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>True if the nullable integer is not zero, false if it is zero, or the default value if the nullable integer is null.</returns>
        public static bool? ToBool(this int? value, bool? defaultValue = null)
        {
            return value.HasValue ? value.Value != 0 : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a TimeSpan representing seconds.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromSeconds(this int value)
        {
            return TimeSpan.FromSeconds(value.ToLong());
        }

        /// <summary>
        /// Converts a nullable integer to a nullable TimeSpan representing seconds.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable integer is null.</returns>
        public static TimeSpan? ToTimeSpanFromSeconds(this int? value, TimeSpan? defaultValue = null)
        {
            return value.HasValue ? TimeSpan.FromSeconds(value.Value.ToLong()) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a TimeSpan representing minutes.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromMinutes(this int value)
        {
            return TimeSpan.FromMinutes(value.ToLong());
        }

        /// <summary>
        /// Converts a nullable integer to a nullable TimeSpan representing minutes.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable integer is null.</returns>
        public static TimeSpan? ToTimeSpanFromMinutes(this int? value, TimeSpan? defaultValue = null)
        {
            return value.HasValue ? TimeSpan.FromMinutes(value.Value.ToLong()) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a TimeSpan representing hours.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromHours(this int value)
        {
            return TimeSpan.FromHours(value.ToLong());
        }

        /// <summary>
        /// Converts a nullable integer to a nullable TimeSpan representing hours.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable integer is null.</returns>
        public static TimeSpan? ToTimeSpanFromHours(this int? value, TimeSpan? defaultValue = null)
        {
            return value.HasValue ? TimeSpan.FromHours(value.Value.ToLong()) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a TimeSpan representing days.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromDays(this int value)
        {
            return TimeSpan.FromDays(value.ToLong());
        }

        /// <summary>
        /// Converts a nullable integer to a nullable TimeSpan representing days.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable TimeSpan value, or the default value if the nullable integer is null.</returns>
        public static TimeSpan? ToTimeSpanFromDays(this int? value, TimeSpan? defaultValue = null)
        {
            return value.HasValue ? TimeSpan.FromDays(value.Value.ToLong()) : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a TimeSpan representing ticks.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted TimeSpan value.</returns>
        public static TimeSpan ToTimeSpanFromTicks(this int value)
        {
            return TimeSpan.FromTicks(value.ToLong());
        }

        /// <summary>
        /// Converts an integer to a DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromUnixTimestamp(this int value)
        {
            return DateTimeOffset.FromUnixTimeSeconds(value.ToLong()).DateTime;
        }

        /// <summary>
        /// Converts a nullable integer to a nullable DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable integer is null.</returns>
        public static DateTime? ToDateTimeFromUnixTimestamp(this int? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? DateTimeOffset.FromUnixTimeSeconds(value.Value.ToLong()).DateTime : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a DateTime from a Unix timestamp in milliseconds.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromUnixTimestampMilliseconds(this int value)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(value.ToLong()).DateTime;
        }

        /// <summary>
        /// Converts a nullable integer to a nullable DateTime from a Unix timestamp in milliseconds.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable integer is null.</returns>
        public static DateTime? ToDateTimeFromUnixTimestampMilliseconds(this int? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(value.Value.ToLong()).DateTime : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromUnixTimestampSeconds(this int value)
        {
            return DateTimeOffset.FromUnixTimeSeconds(value.ToLong()).DateTime;
        }

        /// <summary>
        /// Converts a nullable integer to a nullable DateTime from a Unix timestamp in seconds.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable integer is null.</returns>
        public static DateTime? ToDateTimeFromUnixTimestampSeconds(this int? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? DateTimeOffset.FromUnixTimeSeconds(value.Value.ToLong()).DateTime : defaultValue;
        }

        /// <summary>
        /// Converts an integer to a DateTime from ticks.
        /// </summary>
        /// <param name="value">The integer value to convert.</param>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTimeFromTicks(this int value)
        {
            return new DateTime(value.ToLong());
        }

        /// <summary>
        /// Converts a nullable integer to a nullable DateTime from ticks.
        /// </summary>
        /// <param name="value">The nullable integer value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable integer is null.</param>
        /// <returns>The converted nullable DateTime value, or the default value if the nullable integer is null.</returns>
        public static DateTime? ToDateTimeFromTicks(this int? value, DateTime? defaultValue = null)
        {
            long? v = value.ToLong(value);

            return v.HasValue ? new DateTime(v.Value) : defaultValue;
        }
    }
}
