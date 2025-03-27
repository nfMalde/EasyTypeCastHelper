using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting <see cref="uint"/> and nullable <see cref="uint"/> values to various types.
    /// </summary>
    public static class UintExtensions
    {
        /// <summary>
        /// Converts the specified <see cref="uint"/> value to an <see cref="int"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="int"/> value.</returns>
        public static int ToInt(this uint value) => Convert.ToInt32(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="int"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="int"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static int? ToInt(this uint? value, int? defaultValue = null) => value.HasValue ? (int?)Convert.ToInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="short"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="short"/> value.</returns>
        public static short ToShort(this uint value) => Convert.ToInt16(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="short"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="short"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static short? ToShort(this uint? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="long"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="long"/> value.</returns>
        public static long ToLong(this uint value) => Convert.ToInt64(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="long"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="long"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static long? ToLong(this uint? value, long? defaultValue = null) => value.HasValue ? (long?)Convert.ToInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="double"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="double"/> value.</returns>
        public static double ToDouble(this uint value) => Convert.ToDouble(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="double"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="double"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static double? ToDouble(this uint? value, double? defaultValue = null) => value.HasValue ? (double?)Convert.ToDouble(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="decimal"/> value.</returns>
        public static decimal ToDecimal(this uint value) => Convert.ToDecimal(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="decimal"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static decimal? ToDecimal(this uint? value, decimal? defaultValue = null) => value.HasValue ? (decimal?)Convert.ToDecimal(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="ulong"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="ulong"/> value.</returns>
        public static ulong ToULong(this uint value) => Convert.ToUInt64(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="ulong"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="ulong"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static ulong? ToULong(this uint? value, ulong? defaultValue = null) => value.HasValue ? (ulong?)Convert.ToUInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="ushort"/> value.</returns>
        public static ushort ToUShort(this uint value) => Convert.ToUInt16(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="ushort"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static ushort? ToUShort(this uint? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="uint"/> value to a <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static bool ToBool(this uint value) => Convert.ToBoolean(value);

        /// <summary>
        /// Converts the specified nullable <see cref="uint"/> value to a nullable <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="uint"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="uint"/> is null.</param>
        /// <returns>The converted nullable <see cref="bool"/> value, or the default value if the nullable <see cref="uint"/> is null.</returns>
        public static bool? ToBool(this uint? value, bool? defaultValue = null) => value.HasValue ? (bool?)Convert.ToBoolean(value.Value) : defaultValue;
    }
}
