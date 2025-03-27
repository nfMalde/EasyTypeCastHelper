using System;
using Xunit;
using Shouldly;
using EasyTypeCastHelper;

namespace EasyTypeCastHelperTests
{
    public class LongExtensionsTests
    {
        [Theory]
        [InlineData(123L, 123U)]
        [InlineData(0L, 0U)]
        public void ToUInt_ShouldConvertLongToUInt(long value, uint expected)
        {
            value.ToUInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123U)]
        [InlineData(null, null)]
        public void ToUInt_Nullable_ShouldConvertNullableLongToNullableUInt(long? value, uint? expected)
        {
            value.ToUInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123UL)]
        [InlineData(0L, 0UL)]
        public void ToULong_ShouldConvertLongToULong(long value, ulong expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123UL)]
        [InlineData(null, null)]
        public void ToULong_Nullable_ShouldConvertNullableLongToNullableULong(long? value, ulong? expected)
        {
            value.ToULong().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, (short)123)]
        [InlineData(0L, (short)0)]
        public void ToShort_ShouldConvertLongToShort(long value, short expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, (short)123)]
        [InlineData(null, null)]
        public void ToShort_Nullable_ShouldConvertNullableLongToNullableShort(long? value, short? expected)
        {
            value.ToShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123)]
        [InlineData(0L, 0)]
        public void ToInt_ShouldConvertLongToInt(long value, int expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123)]
        [InlineData(null, null)]
        public void ToInt_Nullable_ShouldConvertNullableLongToNullableInt(long? value, int? expected)
        {
            value.ToInt().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123.0)]
        [InlineData(0L, 0.0)]
        public void ToDouble_ShouldConvertLongToDouble(long value, double expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123.0)]
        [InlineData(null, null)]
        public void ToDouble_Nullable_ShouldConvertNullableLongToNullableDouble(long? value, double? expected)
        {
            value.ToDouble().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123.0f)]
        [InlineData(0L, 0.0f)]
        public void ToFloat_ShouldConvertLongToFloat(long value, float expected)
        {
            value.ToFloat().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123.0f)]
        [InlineData(null, null)]
        public void ToFloat_Nullable_ShouldConvertNullableLongToNullableFloat(long? value, float? expected)
        {
            value.ToFloat().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123.0)]
        [InlineData(0L, 0.0)]
        public void ToDecimal_ShouldConvertLongToDecimal(long value, decimal expected)
        {
            value.ToDecimal().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, 123.0)]
        [InlineData(null, null)]
        public void ToDecimal_Nullable_ShouldConvertNullableLongToNullableDecimal(long? value, double? expected)
        {

            value.ToDecimal().ShouldBe(expected.HasValue ? Convert.ToDecimal(expected) : null);
        }

        [Theory]
        [InlineData(60L, 60)]
        public void ToTimeSpanFromSeconds_ShouldConvertLongToTimeSpanFromSeconds(long value, int expectedSeconds)
        {
            value.ToTimeSpanFromSeconds().TotalSeconds.ShouldBe(expectedSeconds);
        }

        [Theory]
        [InlineData(60L, 60)]
        [InlineData(null, null)]
        public void ToTimeSpanFromSeconds_Nullable_ShouldConvertNullableLongToNullableTimeSpanFromSeconds(long? value, int? expectedSeconds)
        {
            var result = value.ToTimeSpanFromSeconds();
            var seconds = result?.TotalSeconds;
            
            seconds.ShouldBe(expectedSeconds);
        }

        [Theory]
        [InlineData(60L, 60)]
        public void ToTimeSpanFromMinutes_ShouldConvertLongToTimeSpanFromMinutes(long value, int expectedMinutes)
        {
            value.ToTimeSpanFromMinutes().TotalMinutes.ShouldBe(expectedMinutes);
        }

        [Theory]
        [InlineData(60L, 60)]
        [InlineData(null, null)]
        public void ToTimeSpanFromMinutes_Nullable_ShouldConvertNullableLongToNullableTimeSpanFromMinutes(long? value, int? expectedMinutes)
        {
            var result = value.ToTimeSpanFromMinutes();
            var minutes = result?.TotalMinutes;
            minutes.ShouldBe(expectedMinutes);
        }

        [Theory]
        [InlineData(24L, 24)]
        public void ToTimeSpanFromHours_ShouldConvertLongToTimeSpanFromHours(long value, int expectedHours)
        {
            value.ToTimeSpanFromHours().TotalHours.ShouldBe(expectedHours);
        }

        [Theory]
        [InlineData(24L, 24)]
        [InlineData(null, null)]
        public void ToTimeSpanFromHours_Nullable_ShouldConvertNullableLongToNullableTimeSpanFromHours(long? value, int? expectedHours)
        {
            var result = value.ToTimeSpanFromHours();
            var hours = result?.TotalHours;
            hours.ShouldBe(expectedHours);
        }

        [Theory]
        [InlineData(7L, 7)]
        public void ToTimeSpanFromDays_ShouldConvertLongToTimeSpanFromDays(long value, int expectedDays)
        {
            value.ToTimeSpanFromDays().TotalDays.ShouldBe(expectedDays);
        }

        [Theory]
        [InlineData(7L, 7)]
        [InlineData(null, null)]
        public void ToTimeSpanFromDays_Nullable_ShouldConvertNullableLongToNullableTimeSpanFromDays(long? value, int? expectedDays)
        {
            var result = value.ToTimeSpanFromDays();
            var days = result?.TotalDays;
            days.ShouldBe(expectedDays);
        }

        [Theory]
        [InlineData(10000000L, 10000000)]
        public void ToTimeSpanFromTicks_ShouldConvertLongToTimeSpanFromTicks(long value, long expectedTicks)
        {
            value.ToTimeSpanFromTicks().Ticks.ShouldBe(expectedTicks);
        }

        [Theory]
        [InlineData(1609459200L, "2021-01-01T00:00:00Z")]
        public void ToDateTimeFromUnixTimestamp_ShouldConvertLongToDateTimeFromUnixTimestamp(long value, string expected)
        {
            value.ToDateTimeFromUnixTimestamp().ShouldBe(DateTime.Parse(expected).ToUniversalTime());
        }

        [Theory]
        [InlineData(1609459200L, "2021-01-01T00:00:00Z")]
        [InlineData(null, null)]
        public void ToDateTimeFromUnixTimestamp_Nullable_ShouldConvertNullableLongToNullableDateTimeFromUnixTimestamp(long? value, string? expected)
        {
            var result = value.ToDateTimeFromUnixTimestamp();
            result.ShouldBe(expected != null ? DateTime.Parse(expected).ToUniversalTime() : (DateTime?)null);
        }

        [Theory]
        [InlineData(1609459200000L, "2021-01-01T00:00:00Z")]
        public void ToDateTimeFromUnixTimestampMilliseconds_ShouldConvertLongToDateTimeFromUnixTimestampMilliseconds(long value, string expected)
        {
            value.ToDateTimeFromUnixTimestampMilliseconds().ShouldBe(DateTime.Parse(expected).ToUniversalTime());
        }

        [Theory]
        [InlineData(1609459200000L, "2021-01-01T00:00:00Z")]
        [InlineData(null, null)]
        public void ToDateTimeFromUnixTimestampMilliseconds_Nullable_ShouldConvertNullableLongToNullableDateTimeFromUnixTimestampMilliseconds(long? value, string? expected)
        {
            var result = value.ToDateTimeFromUnixTimestampMilliseconds();
            result.ShouldBe(expected != null ? DateTime.Parse(expected).ToUniversalTime() : (DateTime?)null);
        }

        [Theory]
        [InlineData(1609459200L, "2021-01-01T00:00:00Z")]
        public void ToDateTimeFromUnixTimestampSeconds_ShouldConvertLongToDateTimeFromUnixTimestampSeconds(long value, string expected)
        {
            value.ToDateTimeFromUnixTimestampSeconds().ShouldBe(DateTime.Parse(expected).ToUniversalTime());
        }

        [Theory]
        [InlineData(1609459200L, "2021-01-01T00:00:00Z")]
        [InlineData(null, null)]
        public void ToDateTimeFromUnixTimestampSeconds_Nullable_ShouldConvertNullableLongToNullableDateTimeFromUnixTimestampSeconds(long? value, string? expected)
        {
            var result = value.ToDateTimeFromUnixTimestampSeconds();
            result.ShouldBe(expected != null ? DateTime.Parse(expected).ToUniversalTime() : (DateTime?)null);
        }

        [Theory]
        [InlineData(637450560000000000L, "2021-01-01T00:00:00Z")]
        public void ToDateTimeFromTicks_ShouldConvertLongToDateTimeFromTicks(long value, string expected)
        {
            value.ToDateTimeFromTicks().ShouldBe(DateTime.Parse(expected).ToUniversalTime());
        }

        [Theory]
        [InlineData(637450560000000000L, "2021-01-01T00:00:00Z")]
        [InlineData(null, null)]
        public void ToDateTimeFromTicks_Nullable_ShouldConvertNullableLongToNullableDateTimeFromTicks(long? value, string? expected)
        {
            var result = value.ToDateTimeFromTicks();

            result.ShouldBe(expected != null ? DateTime.Parse(expected).ToUniversalTime() : (DateTime?)null);
        }


        [Theory]
        [InlineData(123L, (ushort)123)]
        [InlineData(0L, (ushort)0)]
        public void ToUShort_ShouldConvertLongToUShort(long value, ushort expected)
        {
            value.ToUShort().ShouldBe(expected);
        }

        [Theory]
        [InlineData(123L, (ushort)123)]
        [InlineData(null, null)]
        public void ToUShort_Nullable_ShouldConvertNullableLongToNullableUShort(long? value, ushort? expected)
        {
            value.ToUShort().ShouldBe(expected);
        }
    }
}

