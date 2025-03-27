using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting ulong and nullable ulong values to various types.
    /// </summary>
    public static class ULongExtensions
    {
        /// <summary>
        /// Converts the specified ulong value to a long.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted long value.</returns>
        public static long ToLong(this ulong value) => Convert.ToInt64(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable long.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable long value, or the default value if the nullable ulong value is null.</returns>
        public static long? ToLong(this ulong? value, long? defaultValue = null) => value.HasValue ? (long?)Convert.ToInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to a double.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted double value.</returns>
        public static double ToDouble(this ulong value) => Convert.ToDouble(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable double.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable double value, or the default value if the nullable ulong value is null.</returns>
        public static double? ToDouble(this ulong? value, double? defaultValue = null) => value.HasValue ? (double?)Convert.ToDouble(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to a decimal.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted decimal value.</returns>
        public static decimal ToDecimal(this ulong value) => Convert.ToDecimal(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable decimal.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable decimal value, or the default value if the nullable ulong value is null.</returns>
        public static decimal? ToDecimal(this ulong? value, decimal? defaultValue = null) => value.HasValue ? (decimal?)Convert.ToDecimal(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to an int.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted int value.</returns>
        public static int ToInt(this ulong value) => Convert.ToInt32(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable int.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable int value, or the default value if the nullable ulong value is null.</returns>
        public static int? ToInt(this ulong? value, int? defaultValue = null) => value.HasValue ? (int?)Convert.ToInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to a short.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted short value.</returns>
        public static short ToShort(this ulong value) => Convert.ToInt16(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable short.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable short value, or the default value if the nullable ulong value is null.</returns>
        public static short? ToShort(this ulong? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to a ulong.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted ulong value.</returns>
        public static ulong ToULong(this ulong value) => Convert.ToUInt64(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable ulong.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable ulong value, or the default value if the nullable ulong value is null.</returns>
        public static ulong? ToULong(this ulong? value, ulong? defaultValue = null) => value.HasValue ? (ulong?)Convert.ToUInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to a ushort.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted ushort value.</returns>
        public static ushort ToUShort(this ulong value) => Convert.ToUInt16(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable ushort.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable ushort value, or the default value if the nullable ulong value is null.</returns>
        public static ushort? ToUShort(this ulong? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified ulong value to a bool.
        /// </summary>
        /// <param name="value">The ulong value to convert.</param>
        /// <returns>The converted bool value.</returns>
        public static bool ToBool(this ulong value) => Convert.ToBoolean(value);

        /// <summary>
        /// Converts the specified nullable ulong value to a nullable bool.
        /// </summary>
        /// <param name="value">The nullable ulong value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable ulong value is null.</param>
        /// <returns>The converted nullable bool value, or the default value if the nullable ulong value is null.</returns>
        public static bool? ToBool(this ulong? value, bool? defaultValue = null) => value.HasValue ? (bool?)Convert.ToBoolean(value.Value) : defaultValue;
    }
}
