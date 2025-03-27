using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting decimal values to various types.
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Converts the specified decimal value to a boolean.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>A boolean representation of the decimal value.</returns>
        public static bool ToBool(this decimal value) => Convert.ToBoolean(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable boolean.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable boolean representation of the nullable decimal value.</returns>
        public static bool? ToNullableBool(this decimal? value, bool? defaultValue = null) => value.HasValue ? (bool?)Convert.ToBoolean(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to an unsigned integer.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>An unsigned integer representation of the decimal value.</returns>
        public static uint ToUInt(this decimal value) => Convert.ToUInt32(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable unsigned integer.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable unsigned integer representation of the nullable decimal value.</returns>
        public static uint? ToUInt(this decimal? value, uint? defaultValue = null) => value.HasValue ? (uint?)Convert.ToUInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to an unsigned short.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>An unsigned short representation of the decimal value.</returns>
        public static ushort ToUShort(this decimal value) => Convert.ToUInt16(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable unsigned short.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable unsigned short representation of the nullable decimal value.</returns>
        public static ushort? ToUShort(this decimal? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to a short.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>A short representation of the decimal value.</returns>
        public static short ToShort(this decimal value) => Convert.ToInt16(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable short.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable short representation of the nullable decimal value.</returns>
        public static short? ToShort(this decimal? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to an unsigned long.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>An unsigned long representation of the decimal value.</returns>
        public static ulong ToULong(this decimal value) => Convert.ToUInt64(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable unsigned long.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable unsigned long representation of the nullable decimal value.</returns>
        public static ulong? ToULong(this decimal? value, ulong? defaultValue = null) => value.HasValue ? (ulong?)Convert.ToUInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to an integer.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>An integer representation of the decimal value.</returns>
        public static int ToInt(this decimal value) => Convert.ToInt32(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable integer.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable integer representation of the nullable decimal value.</returns>
        public static int? ToInt(this decimal? value, int? defaultValue = null) => value.HasValue ? (int?)Convert.ToInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to a long.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>A long representation of the decimal value.</returns>
        public static long ToLong(this decimal value) => Convert.ToInt64(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable long.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable long representation of the nullable decimal value.</returns>
        public static long? ToLong(this decimal? value, long? defaultValue = null) => value.HasValue ? (long?)Convert.ToInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to a float.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>A float representation of the decimal value.</returns>
        public static float ToFloat(this decimal value) => Convert.ToSingle(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable float.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable float representation of the nullable decimal value.</returns>
        public static float? ToFloat(this decimal? value, float? defaultValue = null) => value.HasValue ? (float?)Convert.ToSingle(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified decimal value to a double.
        /// </summary>
        /// <param name="value">The decimal value to convert.</param>
        /// <returns>A double representation of the decimal value.</returns>
        public static double ToDouble(this decimal value) => Convert.ToDouble(value);

        /// <summary>
        /// Converts the specified nullable decimal value to a nullable double.
        /// </summary>
        /// <param name="value">The nullable decimal value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable decimal is null.</param>
        /// <returns>A nullable double representation of the nullable decimal value.</returns>
        public static double? ToDouble(this decimal? value, double? defaultValue = null) => value.HasValue ? (double?)Convert.ToDouble(value.Value) : defaultValue;
    }
}
