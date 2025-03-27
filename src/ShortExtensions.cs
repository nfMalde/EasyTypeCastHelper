using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTypeCastHelper
{
    /// <summary>
    /// Provides extension methods for converting <see cref="short"/> and <see cref="short?"/> values to various types.
    /// </summary>
    public static class ShortExtensions
    {
        /// <summary>
        /// Converts the specified <see cref="short"/> value to a <see cref="long"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="long"/> value.</returns>
        public static long ToLong(this short value) => Convert.ToInt64(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="long"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="long"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static long? ToLong(this short? value, long? defaultValue = null) => value.HasValue ? (long?)Convert.ToInt64(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="short"/> value to a <see cref="double"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="double"/> value.</returns>
        public static double ToDouble(this short value) => Convert.ToDouble(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="double"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="double"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static double? ToDouble(this short? value, double? defaultValue = null) => value.HasValue ? (double?)Convert.ToDouble(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="short"/> value to a <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="decimal"/> value.</returns>
        public static decimal ToDecimal(this short value) => Convert.ToDecimal(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="decimal"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static decimal? ToDecimal(this short? value, decimal? defaultValue = null) => value.HasValue ? (decimal?)Convert.ToDecimal(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="short"/> value to an <see cref="int"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="int"/> value.</returns>
        public static int ToInt(this short value) => Convert.ToInt32(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="int"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="int"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static int? ToInt(this short? value, int? defaultValue = null) => value.HasValue ? (int?)Convert.ToInt32(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="short"/> value to a <see cref="short"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="short"/> value.</returns>
        public static short ToShort(this short value) => Convert.ToInt16(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="short"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="short"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static short? ToShort(this short? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="short"/> value to a <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="ushort"/> value.</returns>
        public static ushort ToUShort(this short value) => Convert.ToUInt16(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="ushort"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static ushort? ToUShort(this short? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;

        /// <summary>
        /// Converts the specified <see cref="short"/> value to a <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The <see cref="short"/> value to convert.</param>
        /// <returns>The converted <see cref="bool"/> value.</returns>
        public static bool ToBool(this short value) => Convert.ToBoolean(value);

        /// <summary>
        /// Converts the specified nullable <see cref="short"/> value to a nullable <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The nullable <see cref="short"/> value to convert.</param>
        /// <param name="defaultValue">The default value to return if the nullable <see cref="short"/> value is null.</param>
        /// <returns>The converted nullable <see cref="bool"/> value, or the default value if the nullable <see cref="short"/> value is null.</returns>
        public static bool? ToBool(this short? value, bool? defaultValue = null) => value.HasValue ? (bool?)Convert.ToBoolean(value.Value) : defaultValue;
    }
}
