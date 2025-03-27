using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTypeCastHelper
{
    public static class DoubleExtensions
    {
        public static uint ToUInt(this double value) => Convert.ToUInt32(value);

        public static uint? ToUInt(this double? value, uint? defaultValue = null) => value.HasValue ? (uint?)Convert.ToUInt32(value.Value) : defaultValue;

        public static ushort ToUShort(this double value) => Convert.ToUInt16(value);

        public static ushort? ToUShort(this double? value, ushort? defaultValue = null) => value.HasValue ? (ushort?)Convert.ToUInt16(value.Value) : defaultValue;

        public static short ToShort(this double value) => Convert.ToInt16(value);

        public static short? ToShort(this double? value, short? defaultValue = null) => value.HasValue ? (short?)Convert.ToInt16(value.Value) : defaultValue;

        public static ulong ToULong(this double value) => Convert.ToUInt64(value);

        public static ulong? ToULong(this double? value, ulong? defaultValue = null) => value.HasValue ? (ulong?)Convert.ToUInt64(value.Value) : defaultValue;

        public static int ToInt(this double value) => Convert.ToInt32(value);

        public static int? ToInt(this double? value, int? defaultValue = null) => value.HasValue ? (int?)Convert.ToInt32(value.Value) : defaultValue;

        public static long ToLong(this double value) => Convert.ToInt64(value);

        public static long? ToLong(this double? value, long? defaultValue = null) => value.HasValue ? (long?)Convert.ToInt64(value.Value) : defaultValue;

        public static float ToFloat(this double value) => Convert.ToSingle(value);

        public static float? ToFloat(this double? value, float? defaultValue = null) => value.HasValue ? (float?)Convert.ToSingle(value.Value) : defaultValue;

        public static decimal ToDecimal(this double value) => Convert.ToDecimal(value);

        public static decimal? ToDecimal(this double? value, decimal? defaultValue = null) => value.HasValue ? (decimal?)Convert.ToDecimal(value.Value) : defaultValue;

        public static TimeSpan ToTimeSpanFromSeconds(this double value) => TimeSpan.FromSeconds(value);

        public static TimeSpan? ToTimeSpanFromSeconds(this double? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromSeconds(value.Value) : defaultValue;

        public static TimeSpan ToTimeSpanFromMinutes(this double value) => TimeSpan.FromMinutes(value);

        public static TimeSpan? ToTimeSpanFromMinutes(this double? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromMinutes(value.Value) : defaultValue;

        public static TimeSpan ToTimeSpanFromHours(this double value) => TimeSpan.FromHours(value);

        public static TimeSpan? ToTimeSpanFromHours(this double? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromHours(value.Value) : defaultValue;

        public static TimeSpan ToTimeSpanFromDays(this double value) => TimeSpan.FromDays(value);

        public static TimeSpan? ToTimeSpanFromDays(this double? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromDays(value.Value) : defaultValue;
    
        public static TimeSpan ToTimeSpanFromMilliseconds(this double value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan? ToTimeSpanFromMilliseconds(this double? value, TimeSpan? defaultValue = null) => value.HasValue ? TimeSpan.FromMilliseconds(value.Value) : defaultValue;
       
        public static DateTime ToDateTimeFromUnixTimestamp(this double value)
        {
            return DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(value)).DateTime;
        }

        public static DateTime? ToDateTimeFromUnixTimestamp(this double? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(value.Value)).DateTime : defaultValue;
        }

        public static DateTime ToDateTimeFromUnixTimestampMilliseconds(this double value)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(value)).DateTime;
        }

        public static DateTime? ToDateTimeFromUnixTimestampMilliseconds(this double? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(value.Value)).DateTime : defaultValue;
        }

        public static DateTime ToDateTimeFromUnixTimestampSeconds(this double value)
        {
            return DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(value)).DateTime;
        }

        public static DateTime? ToDateTimeFromUnixTimestampSeconds(this double? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(value.Value)).DateTime : defaultValue;
        }

        public static DateTime ToDateTimeFromTicks(this double value)
        {
            return new DateTime(Convert.ToInt64(value));
        }

        public static DateTime? ToDateTimeFromTicks(this double? value, DateTime? defaultValue = null)
        {
            return value.HasValue ? new DateTime(Convert.ToInt64(value.Value)) : defaultValue;
        } 

    }
}
